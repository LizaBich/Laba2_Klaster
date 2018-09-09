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
            try
            {
                var changedImage = this._imageProcessor.ConvertToShadowsOfGray(this._image);
                var temporary = this._imageProcessor.MinMaxFilter(changedImage);
                this.changedImageBox.Image = temporary;
                // this.DrawHisto(this._imageProcessor.Calculate(changedImage), this.changedHisto);

                var filteredImage = this._imageProcessor.CreateBitImage(temporary);
                this.filteredImage.Image = filteredImage;
                // this.DrawHisto(this._imageProcessor.Calculate(filteredImage), this.filteredHisto);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Constant value is invalid!");
            }
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
