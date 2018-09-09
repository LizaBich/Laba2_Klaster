using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba2_Klaster
{
    public partial class Form1 : Form
    {
        private string _imagePath;

        private Bitmap _image;

        private readonly ImageProcessing.ImageProcessing _imageProcessor;

        public Form1()
        {
            InitializeComponent();

            this._imageProcessor = new ImageProcessing.ImageProcessing();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this._imagePath = openFileDialog.FileName;
                    if (this._imagePath != null && this._imagePath != string.Empty)
                    {
                        this.imagePathBox.Text = this._imagePath;
                        this.LoadImage();
                    }
                }
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            var p = power.Text == string.Empty ? 4 : Convert.ToInt32(power.Text);
            var changedImage = this._imageProcessor.ConvertToShadowsOfGray(this._image);
            changedImage = this._imageProcessor.MinMaxFilter(changedImage, p);
            changedImage = this._imageProcessor.CreateBitImage(changedImage);
            this.changedImageBox.Image = changedImage;

            var filteredImage = this._imageProcessor.CleanFromNoise(changedImage, 0);
            this.filteredImage.Image = filteredImage;
        }

        private void LoadImage()
        {
            this._image = this._imageProcessor.Resize(new Bitmap(this._imagePath), this.originalImage.Width, this.originalImage.Height);

            this.originalImage.Image = (Image)this._image;
        }

        private void DrawHisto(IList<IDictionary<byte, int>> histos, Chart chart)
        {
            for (var i = 0; i < 256; i++)
            {
                if (histos[0].Keys.Contains((byte)i))
                {
                    chart.Series["R"].Points.AddXY(i, histos[0][(byte)i]);
                }
                else
                {
                    chart.Series["R"].Points.AddXY(i, 0);
                }
                if (histos[1].Keys.Contains((byte)i))
                {
                    chart.Series["G"].Points.AddXY(i, histos[1][(byte)i]);
                }
                else
                {
                    chart.Series["G"].Points.AddXY(i, 0);
                }
                if (histos[2].Keys.Contains((byte)i))
                {
                    chart.Series["B"].Points.AddXY(i, histos[2][(byte)i]);
                }
                else
                {
                    chart.Series["B"].Points.AddXY(i, 0);
                }
            }
        }
    }
}
