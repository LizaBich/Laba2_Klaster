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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imagePathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.processButton = new System.Windows.Forms.Button();
            this.changedImageBox = new System.Windows.Forms.PictureBox();
            this.filteredImage = new System.Windows.Forms.PictureBox();
            this.filteredHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            chartArea3.Name = "ChartArea1";
            this.filteredHisto.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.filteredHisto.Legends.Add(legend3);
            this.filteredHisto.Location = new System.Drawing.Point(742, 512);
            this.filteredHisto.Name = "filteredHisto";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.LegendText = "R";
            series7.Name = "R";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "G";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.Name = "B";
            this.filteredHisto.Series.Add(series7);
            this.filteredHisto.Series.Add(series8);
            this.filteredHisto.Series.Add(series9);
            this.filteredHisto.Size = new System.Drawing.Size(700, 393);
            this.filteredHisto.TabIndex = 14;
            this.filteredHisto.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1507, 891);
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
    }
}

