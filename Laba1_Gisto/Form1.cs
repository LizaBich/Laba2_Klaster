using Laba2_Klaster.Klasterization;
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
        private readonly KlasterProcessing _klasterization;

        public Form1()
        {
            InitializeComponent();

            this._imageProcessor = new ImageProcessing.ImageProcessing();
            this._klasterization = new KlasterProcessing();
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            var p = power.Text == string.Empty ? 4 : Convert.ToInt32(power.Text);
            var changedImage = this._imageProcessor.ConvertToShadowsOfGray(this._image);
            changedImage = this._imageProcessor.MinMaxFilter(changedImage, p);
            changedImage = this._imageProcessor.CreateBitImage(changedImage);
            this.changedImageBox.Image = changedImage;
            this._image = changedImage;
        }

        private void klasterButton_Click(object sender, EventArgs e)
        {
            this.Status.Text = "Data is processed...";
            var count = Convert.ToInt32(this.CountOfClasters.Text);
            var labels = this._klasterization.CreateListOfObjects(this._imageProcessor.ConvertToBoolMatrix(this._image));
            var klasters = this._klasterization.DivideOnKlastersAsync(count, labels);
            this.RenderResults(klasters);
            this.Status.Text = "Data processed successfully.";
        }

        private void LoadImage()
        {
            this._image = this._imageProcessor.Resize(new Bitmap(this._imagePath), this.originalImage.Width, this.originalImage.Height);

            this.originalImage.Image = (Image)this._image;
        }

        private void RenderResults(List<List<PropertiesOfObject>> klasters)
        {
            var count = klasters.Count;
            this.CountOfElems0.Text = count >= 1 ? $"Items: {klasters[0].Count}" : $"Items: {string.Empty}";
            this.CountOfElems1.Text = count >= 2 ? $"Items: {klasters[1].Count}" : $"Items: {string.Empty}";
            this.CountOfElems2.Text = count >= 3 ? $"Items: {klasters[2].Count}" : $"Items: {string.Empty}";
            this.CountOfElems3.Text = count >= 4 ? $"Items: {klasters[3].Count}" : $"Items: {string.Empty}";
            this.CountOfElems4.Text = count >= 5 ? $"Items: {klasters[4].Count}" : $"Items: {string.Empty}";
        }
    }
}
