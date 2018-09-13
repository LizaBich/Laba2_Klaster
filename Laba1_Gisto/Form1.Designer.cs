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
            this.imagePathBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.changedImageBox = new System.Windows.Forms.PictureBox();
            this.power = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountOfClasters = new System.Windows.Forms.TextBox();
            this.klasterButton = new System.Windows.Forms.Button();
            this.Klaster0 = new System.Windows.Forms.GroupBox();
            this.klaster1 = new System.Windows.Forms.GroupBox();
            this.klaster2 = new System.Windows.Forms.GroupBox();
            this.klaster3 = new System.Windows.Forms.GroupBox();
            this.klaster4 = new System.Windows.Forms.GroupBox();
            this.CountOfElems0 = new System.Windows.Forms.Label();
            this.CountOfElems1 = new System.Windows.Forms.Label();
            this.CountOfElems2 = new System.Windows.Forms.Label();
            this.CountOfElems3 = new System.Windows.Forms.Label();
            this.CountOfElems4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).BeginInit();
            this.Results.SuspendLayout();
            this.Klaster0.SuspendLayout();
            this.klaster1.SuspendLayout();
            this.klaster2.SuspendLayout();
            this.klaster3.SuspendLayout();
            this.klaster4.SuspendLayout();
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
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(514, 12);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(105, 34);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // changedImageBox
            // 
            this.changedImageBox.Location = new System.Drawing.Point(725, 72);
            this.changedImageBox.Name = "changedImageBox";
            this.changedImageBox.Size = new System.Drawing.Size(700, 393);
            this.changedImageBox.TabIndex = 6;
            this.changedImageBox.TabStop = false;
            // 
            // power
            // 
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(964, 13);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(100, 34);
            this.power.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(755, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Count of filter iterations";
            // 
            // Results
            // 
            this.Results.Controls.Add(this.klaster4);
            this.Results.Controls.Add(this.klaster3);
            this.Results.Controls.Add(this.klaster2);
            this.Results.Controls.Add(this.klaster1);
            this.Results.Controls.Add(this.Klaster0);
            this.Results.Controls.Add(this.Status);
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(13, 471);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(1412, 408);
            this.Results.TabIndex = 17;
            this.Results.TabStop = false;
            this.Results.Text = "Results";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(6, 30);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 29);
            this.Status.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1085, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Count of klasters";
            // 
            // CountOfClasters
            // 
            this.CountOfClasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfClasters.Location = new System.Drawing.Point(1252, 12);
            this.CountOfClasters.Name = "CountOfClasters";
            this.CountOfClasters.Size = new System.Drawing.Size(100, 34);
            this.CountOfClasters.TabIndex = 19;
            // 
            // klasterButton
            // 
            this.klasterButton.Location = new System.Drawing.Point(625, 12);
            this.klasterButton.Name = "klasterButton";
            this.klasterButton.Size = new System.Drawing.Size(105, 34);
            this.klasterButton.TabIndex = 20;
            this.klasterButton.Text = "Klaster";
            this.klasterButton.UseVisualStyleBackColor = true;
            this.klasterButton.Click += new System.EventHandler(this.klasterButton_Click);
            // 
            // Klaster0
            // 
            this.Klaster0.Controls.Add(this.CountOfElems0);
            this.Klaster0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klaster0.Location = new System.Drawing.Point(12, 98);
            this.Klaster0.Name = "Klaster0";
            this.Klaster0.Size = new System.Drawing.Size(255, 304);
            this.Klaster0.TabIndex = 1;
            this.Klaster0.TabStop = false;
            this.Klaster0.Text = "Klaster 1";
            // 
            // klaster1
            // 
            this.klaster1.Controls.Add(this.CountOfElems1);
            this.klaster1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaster1.Location = new System.Drawing.Point(291, 98);
            this.klaster1.Name = "klaster1";
            this.klaster1.Size = new System.Drawing.Size(255, 304);
            this.klaster1.TabIndex = 2;
            this.klaster1.TabStop = false;
            this.klaster1.Text = "Klaster 2";
            // 
            // klaster2
            // 
            this.klaster2.Controls.Add(this.CountOfElems2);
            this.klaster2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaster2.Location = new System.Drawing.Point(577, 98);
            this.klaster2.Name = "klaster2";
            this.klaster2.Size = new System.Drawing.Size(255, 304);
            this.klaster2.TabIndex = 2;
            this.klaster2.TabStop = false;
            this.klaster2.Text = "Klaster 3";
            // 
            // klaster3
            // 
            this.klaster3.Controls.Add(this.CountOfElems3);
            this.klaster3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaster3.Location = new System.Drawing.Point(862, 98);
            this.klaster3.Name = "klaster3";
            this.klaster3.Size = new System.Drawing.Size(255, 304);
            this.klaster3.TabIndex = 2;
            this.klaster3.TabStop = false;
            this.klaster3.Text = "Klaster 4";
            // 
            // klaster4
            // 
            this.klaster4.Controls.Add(this.CountOfElems4);
            this.klaster4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klaster4.Location = new System.Drawing.Point(1141, 98);
            this.klaster4.Name = "klaster4";
            this.klaster4.Size = new System.Drawing.Size(255, 304);
            this.klaster4.TabIndex = 2;
            this.klaster4.TabStop = false;
            this.klaster4.Text = "Klaster 5";
            // 
            // CountOfElems0
            // 
            this.CountOfElems0.AutoSize = true;
            this.CountOfElems0.Location = new System.Drawing.Point(7, 46);
            this.CountOfElems0.Name = "CountOfElems0";
            this.CountOfElems0.Size = new System.Drawing.Size(65, 25);
            this.CountOfElems0.TabIndex = 0;
            this.CountOfElems0.Text = "Items:";
            // 
            // CountOfElems1
            // 
            this.CountOfElems1.AutoSize = true;
            this.CountOfElems1.Location = new System.Drawing.Point(6, 46);
            this.CountOfElems1.Name = "CountOfElems1";
            this.CountOfElems1.Size = new System.Drawing.Size(65, 25);
            this.CountOfElems1.TabIndex = 1;
            this.CountOfElems1.Text = "Items:";
            // 
            // CountOfElems2
            // 
            this.CountOfElems2.AutoSize = true;
            this.CountOfElems2.Location = new System.Drawing.Point(6, 46);
            this.CountOfElems2.Name = "CountOfElems2";
            this.CountOfElems2.Size = new System.Drawing.Size(65, 25);
            this.CountOfElems2.TabIndex = 2;
            this.CountOfElems2.Text = "Items:";
            // 
            // CountOfElems3
            // 
            this.CountOfElems3.AutoSize = true;
            this.CountOfElems3.Location = new System.Drawing.Point(6, 46);
            this.CountOfElems3.Name = "CountOfElems3";
            this.CountOfElems3.Size = new System.Drawing.Size(65, 25);
            this.CountOfElems3.TabIndex = 3;
            this.CountOfElems3.Text = "Items:";
            // 
            // CountOfElems4
            // 
            this.CountOfElems4.AutoSize = true;
            this.CountOfElems4.Location = new System.Drawing.Point(6, 46);
            this.CountOfElems4.Name = "CountOfElems4";
            this.CountOfElems4.Size = new System.Drawing.Size(65, 25);
            this.CountOfElems4.TabIndex = 4;
            this.CountOfElems4.Text = "Items:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1463, 891);
            this.Controls.Add(this.klasterButton);
            this.Controls.Add(this.CountOfClasters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.changedImageBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.imagePathBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second lab (klaster)";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changedImageBox)).EndInit();
            this.Results.ResumeLayout(false);
            this.Results.PerformLayout();
            this.Klaster0.ResumeLayout(false);
            this.Klaster0.PerformLayout();
            this.klaster1.ResumeLayout(false);
            this.klaster1.PerformLayout();
            this.klaster2.ResumeLayout(false);
            this.klaster2.PerformLayout();
            this.klaster3.ResumeLayout(false);
            this.klaster3.PerformLayout();
            this.klaster4.ResumeLayout(false);
            this.klaster4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imagePathBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.PictureBox changedImageBox;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Results;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountOfClasters;
        private System.Windows.Forms.Button klasterButton;
        private System.Windows.Forms.GroupBox klaster4;
        private System.Windows.Forms.Label CountOfElems4;
        private System.Windows.Forms.GroupBox klaster3;
        private System.Windows.Forms.Label CountOfElems3;
        private System.Windows.Forms.GroupBox klaster2;
        private System.Windows.Forms.Label CountOfElems2;
        private System.Windows.Forms.GroupBox klaster1;
        private System.Windows.Forms.Label CountOfElems1;
        private System.Windows.Forms.GroupBox Klaster0;
        private System.Windows.Forms.Label CountOfElems0;
    }
}

