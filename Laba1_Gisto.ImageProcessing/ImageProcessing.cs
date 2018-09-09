using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;

namespace Laba2_Klaster.ImageProcessing
{
    public class ImageProcessing
    {
        public IList<IDictionary<byte, int>> Calculate(Bitmap image)
        {
            var rGisto = new Dictionary<byte, int>();
            var gGisto = new Dictionary<byte, int>();
            var bGisto = new Dictionary<byte, int>();
            var result = new List<IDictionary<byte, int>>();

            for (var x = 0; x < image.Width; ++x)
            {
                for (var y = 0; y < image.Height; ++y)
                {
                    var pixel = image.GetPixel(x, y);
                    var rPower = pixel.R;
                    var gPower = pixel.G;
                    var bPower = pixel.B;

                    if (!rGisto.ContainsKey(rPower))
                    {
                        rGisto.Add(rPower, 0);
                    }
                    if (!gGisto.ContainsKey(gPower))
                    {
                        gGisto.Add(gPower, 0);
                    }
                    if (!bGisto.ContainsKey(bPower))
                    {
                        bGisto.Add(bPower, 0);
                    }

                    rGisto[rPower]++;
                    gGisto[gPower]++;
                    bGisto[bPower]++;
                }
            }

            result.Add(rGisto);
            result.Add(gGisto);
            result.Add(bGisto);

            return result;
        }

        public Bitmap Resize(Bitmap original, int customWidth, int customHeight)
        {
            int originalWidth = original.Width;
            int originalHeight = original.Height;

            float ratioX = (float)customWidth / (float)originalWidth;
            float ratioY = (float)customHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            var newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(original, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        public Bitmap ConvertToShadowsOfGray(Bitmap origin)
        {
            var newImage = new Bitmap(origin.Width, origin.Height, PixelFormat.Format24bppRgb);

            for (var y = 0; y < origin.Height; ++y)
            {
                for (var x = 0; x < origin.Width; ++x)
                {
                    var pixel = origin.GetPixel(x, y);

                    var total = (byte)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);

                    newImage.SetPixel(x, y, Color.FromArgb(total, total, total));
                }
            }

            return newImage;
        }

        public Bitmap CreateBitImage(Bitmap origin)
        {
            var newImage = new Bitmap(origin.Width, origin.Height, PixelFormat.Format24bppRgb);

            for (var y = 0; y < newImage.Height; y++)
            {
                for (var x = 0; x < newImage.Width; x++)
                {
                    var total = newImage.GetPixel(x, y).R;
                    // total = total < 127 ? (byte)0 : (byte)255;
                    newImage.SetPixel(x, y, Color.FromArgb(total, total, total));
                }
            }

            return newImage;
        }

        public Bitmap CleanFromNoise(Bitmap source)
        {
            var origin = new Bitmap(source.Width, source.Height, PixelFormat.Format24bppRgb);

            for (var k = 0; k < 2; ++k)
            {
                for (var y = 0; y < origin.Height; y += 2)
                {
                    for (var x = 0; x < origin.Width; x += 2)
                    {
                        var pixel = origin.GetPixel(x, y);
                        if (pixel.R == 255)
                        {
                            var topPixel = y - 1 < 0 ? Color.White.R : origin.GetPixel(x, y - 1).R;
                            var rightPixel = x + 1 >= origin.Width ? Color.White.R : origin.GetPixel(x + 1, y).R;
                            var bottomPixel = y + 1 >= origin.Height ? Color.White.R : origin.GetPixel(x, y + 1).R;
                            var leftPixel = x - 1 < 0 ? Color.White.R : origin.GetPixel(x - 1, y).R;

                            if (topPixel == 0 || rightPixel == 0 || bottomPixel == 0 || leftPixel == 0)
                            {
                                origin.SetPixel(x, y, Color.Black);
                            }
                        }
                    }
                }
            }

            for (var k = 0; k < 2; ++k)
            {
                for (var y = 0; y < origin.Height; y += 2)
                {
                    for (var x = 0; x < origin.Width; x += 2)
                    {
                        var pixel = origin.GetPixel(x, y);
                        if (pixel.R == 255)
                        {
                            if (y - 1 >= 0)
                            {
                                origin.SetPixel(x, y - 1, Color.White);
                            }
                            if (x + 1 < origin.Width)
                            {
                                origin.SetPixel(x + 1, y, Color.White);
                            }
                            if (y + 1 < origin.Height)
                            {
                                origin.SetPixel(x, y + 1, Color.White);
                            }
                            if (x - 1 >= origin.Width)
                            {
                                origin.SetPixel(x - 1, y, Color.White);
                            }
                        }
                    }
                }
            }

            return origin;
        }

        public Bitmap MinMaxFilter(Bitmap origin)
        {
            var newImage = new Bitmap(origin.Width, origin.Height, PixelFormat.Format24bppRgb);
            newImage = this.FilterPart(origin, false);
            newImage = this.FilterPart(newImage, false);
            return newImage;
        }

        private Bitmap FilterPart(Bitmap origin, bool isMin)
        {
            var baseColor = isMin ? Color.White : Color.Black;
            var newImage = new Bitmap(origin.Width, origin.Height, PixelFormat.Format24bppRgb);
            for (var y = 0; y < origin.Height; ++y)
            {
                for (var x = 0; x < origin.Width; ++x)
                {
                    var pixelsUnderMask = new List<Color>
                    {
                        x - 1 < 0 || y - 1 < 0 ? baseColor : origin.GetPixel(x - 1, y - 1),
                        y - 1 < 0 ? baseColor : origin.GetPixel(x, y - 1),
                        x + 1 >= origin.Width || y - 1 < 0 ? baseColor : origin.GetPixel(x + 1, y - 1),
                        x - 1 < 0 ? baseColor : origin.GetPixel(x - 1, y),
                        origin.GetPixel(x, y),
                        x + 1 >= origin.Width ? baseColor : origin.GetPixel(x + 1, y),
                        x - 1 < 0 || y + 1 >= origin.Height ? baseColor : origin.GetPixel(x - 1, y + 1),
                        y + 1 >= origin.Height ? baseColor : origin.GetPixel(x, y + 1),
                        x + 1 >= origin.Width || y + 1 >= origin.Height ? baseColor : origin.GetPixel(x + 1, y + 1)
                    };

                    var totalPixel = isMin ? pixelsUnderMask.Select(item => item.R).Min() : pixelsUnderMask.Select(item => item.R).Max();

                    newImage.SetPixel(x, y, Color.FromArgb(totalPixel, totalPixel, totalPixel));
                }
            }

            return newImage;
        }
    }
}
