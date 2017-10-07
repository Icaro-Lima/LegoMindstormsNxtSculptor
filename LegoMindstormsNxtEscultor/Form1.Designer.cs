namespace LegoMindstormsNxtEscultor
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
            this.PictureBoxImage = new System.Windows.Forms.PictureBox();
            this.ButtonLoadImage = new System.Windows.Forms.Button();
            this.NumericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxImage
            // 
            this.PictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxImage.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxImage.Name = "PictureBoxImage";
            this.PictureBoxImage.Size = new System.Drawing.Size(300, 300);
            this.PictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxImage.TabIndex = 0;
            this.PictureBoxImage.TabStop = false;
            // 
            // ButtonLoadImage
            // 
            this.ButtonLoadImage.AutoSize = true;
            this.ButtonLoadImage.Location = new System.Drawing.Point(12, 318);
            this.ButtonLoadImage.Name = "ButtonLoadImage";
            this.ButtonLoadImage.Size = new System.Drawing.Size(97, 23);
            this.ButtonLoadImage.TabIndex = 1;
            this.ButtonLoadImage.Text = "Carregar Imagem";
            this.ButtonLoadImage.UseVisualStyleBackColor = true;
            this.ButtonLoadImage.Click += new System.EventHandler(this.ButtonLoadImage_Click);
            // 
            // NumericUpDownWidth
            // 
            this.NumericUpDownWidth.DecimalPlaces = 1;
            this.NumericUpDownWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownWidth.Location = new System.Drawing.Point(433, 12);
            this.NumericUpDownWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownWidth.Name = "NumericUpDownWidth";
            this.NumericUpDownWidth.Size = new System.Drawing.Size(55, 20);
            this.NumericUpDownWidth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamanho do material:";
            // 
            // NumericUpDownHeight
            // 
            this.NumericUpDownHeight.DecimalPlaces = 1;
            this.NumericUpDownHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownHeight.Location = new System.Drawing.Point(494, 12);
            this.NumericUpDownHeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownHeight.Name = "NumericUpDownHeight";
            this.NumericUpDownHeight.Size = new System.Drawing.Size(55, 20);
            this.NumericUpDownHeight.TabIndex = 4;
            // 
            // NumericUpDownDepth
            // 
            this.NumericUpDownDepth.DecimalPlaces = 1;
            this.NumericUpDownDepth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownDepth.Location = new System.Drawing.Point(555, 12);
            this.NumericUpDownDepth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUpDownDepth.Name = "NumericUpDownDepth";
            this.NumericUpDownDepth.Size = new System.Drawing.Size(55, 20);
            this.NumericUpDownDepth.TabIndex = 5;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(593, 564);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Iniciar";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(674, 564);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 7;
            this.ButtonStop.Text = "Parar";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 599);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.NumericUpDownDepth);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PictureBoxImage);
            this.Controls.Add(this.NumericUpDownHeight);
            this.Controls.Add(this.ButtonLoadImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxImage;
        private System.Windows.Forms.Button ButtonLoadImage;
        private System.Windows.Forms.NumericUpDown NumericUpDownWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDownHeight;
        private System.Windows.Forms.NumericUpDown NumericUpDownDepth;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
    }
}

