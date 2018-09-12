namespace Laba2_Klaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imagePathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.changedImageBox = new System.Windows.Forms.PictureBox();
            this.filteredImage = new System.Windows.Forms.PictureBox();
            this.filteredHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePathBox
            // 
            this.imagePathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathBox.Location = new System.Drawing.Point(12, 12);
            this.imagePathBox.Name = "imagePathBox";
            this.imagePathBox.Size = new System.Drawing.Size(384, 34);
            this.imagePathBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(403, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(105, 34);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(12, 71);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(700, 393);
            this.originalImage.TabIndex = 2;
            this.originalImage.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(514, 12);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(105, 34);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Start";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // changedImageBox
            // 
            this.changedImageBox.Location = new System.Drawing.Point(742, 71);
            this.changedImageBox.Name = "changedImageBox";
            this.changedImageBox.Size = new System.Drawing.Size(700, 393);
            this.changedImageBox.TabIndex = 6;
            this.changedImageBox.TabStop = false;
            // 
            // filteredImage
            // 
            this.filteredImage.Location = new System.Drawing.Point(12, 512);
            this.filteredImage.Name = "filteredImage";
            this.filteredImage.Size = new System.Drawing.Size(700, 393);
            this.filteredImage.TabIndex = 13;
            this.filteredImage.TabStop = false;
            // 
            // filteredHisto
            // 
            chartArea1.Name = "ChartArea1";
            this.filteredHisto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.filteredHisto.Legends.Add(legend1);
            this.filteredHisto.Location = new System.Drawing.Point(742, 512);
            this.filteredHisto.Name = "filteredHisto";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "R";
            series1.Name = "R";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "G";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "B";
            this.filteredHisto.Series.Add(series1);
            this.filteredHisto.Series.Add(series2);
            this.filteredHisto.Series.Add(series3);
            this.filteredHisto.Size = new System.Drawing.Size(700, 393);
            this.filteredHisto.TabIndex = 14;
            this.filteredHisto.Text = "chart1";
            // 
            // power
            // 
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(906, 12);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(100, 34);
            this.power.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Count of filter iterations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1528, 891);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.filteredHisto);
            this.Controls.Add(this.filteredImage);
            this.Controls.Add(this.changedImageBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.imagePathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second lab (klaster)";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredHisto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagePathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.PictureBox changedImageBox;
        private System.Windows.Forms.PictureBox filteredImage;
        private System.Windows.Forms.DataVisualization.Charting.Chart filteredHisto;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.Label label1;
    }
}

