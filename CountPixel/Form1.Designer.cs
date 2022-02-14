namespace CountPixel
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
            this.emguPictureBox = new System.Windows.Forms.PictureBox();
            this.binaryPictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.PixelCountLabel1 = new System.Windows.Forms.Label();
            this.PixelCountLabel2 = new System.Windows.Forms.Label();
            this.PixelCountLabel3 = new System.Windows.Forms.Label();
            this.PixelCountLabel4 = new System.Windows.Forms.Label();
            this.PixelCountLabel5 = new System.Windows.Forms.Label();
            this.PixelCountLabel6 = new System.Windows.Forms.Label();
            this.PixelCountLabel7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // emguPictureBox
            // 
            this.emguPictureBox.Location = new System.Drawing.Point(12, 12);
            this.emguPictureBox.Name = "emguPictureBox";
            this.emguPictureBox.Size = new System.Drawing.Size(339, 315);
            this.emguPictureBox.TabIndex = 0;
            this.emguPictureBox.TabStop = false;
            this.emguPictureBox.UseWaitCursor = true;
            // 
            // binaryPictureBox
            // 
            this.binaryPictureBox.Location = new System.Drawing.Point(460, 12);
            this.binaryPictureBox.Name = "binaryPictureBox";
            this.binaryPictureBox.Size = new System.Drawing.Size(328, 315);
            this.binaryPictureBox.TabIndex = 1;
            this.binaryPictureBox.TabStop = false;
            this.binaryPictureBox.UseWaitCursor = true;
            // 
            // thresholdTrackBar
            // 
            this.thresholdTrackBar.Location = new System.Drawing.Point(12, 356);
            this.thresholdTrackBar.Maximum = 255;
            this.thresholdTrackBar.Name = "thresholdTrackBar";
            this.thresholdTrackBar.Size = new System.Drawing.Size(776, 56);
            this.thresholdTrackBar.TabIndex = 2;
            this.thresholdTrackBar.UseWaitCursor = true;
            this.thresholdTrackBar.Scroll += new System.EventHandler(this.thresholdTrackBar_Scroll);
            // 
            // PixelCountLabel1
            // 
            this.PixelCountLabel1.AutoSize = true;
            this.PixelCountLabel1.Location = new System.Drawing.Point(457, 336);
            this.PixelCountLabel1.Name = "PixelCountLabel1";
            this.PixelCountLabel1.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel1.TabIndex = 3;
            this.PixelCountLabel1.Text = "1";
            this.PixelCountLabel1.UseWaitCursor = true;
            // 
            // PixelCountLabel2
            // 
            this.PixelCountLabel2.AutoSize = true;
            this.PixelCountLabel2.Location = new System.Drawing.Point(512, 336);
            this.PixelCountLabel2.Name = "PixelCountLabel2";
            this.PixelCountLabel2.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel2.TabIndex = 4;
            this.PixelCountLabel2.Text = "2";
            this.PixelCountLabel2.UseWaitCursor = true;
            // 
            // PixelCountLabel3
            // 
            this.PixelCountLabel3.AutoSize = true;
            this.PixelCountLabel3.Location = new System.Drawing.Point(566, 336);
            this.PixelCountLabel3.Name = "PixelCountLabel3";
            this.PixelCountLabel3.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel3.TabIndex = 5;
            this.PixelCountLabel3.Text = "3";
            this.PixelCountLabel3.UseWaitCursor = true;
            // 
            // PixelCountLabel4
            // 
            this.PixelCountLabel4.AutoSize = true;
            this.PixelCountLabel4.Location = new System.Drawing.Point(613, 336);
            this.PixelCountLabel4.Name = "PixelCountLabel4";
            this.PixelCountLabel4.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel4.TabIndex = 6;
            this.PixelCountLabel4.Text = "4";
            this.PixelCountLabel4.UseWaitCursor = true;
            // 
            // PixelCountLabel5
            // 
            this.PixelCountLabel5.AutoSize = true;
            this.PixelCountLabel5.Location = new System.Drawing.Point(666, 336);
            this.PixelCountLabel5.Name = "PixelCountLabel5";
            this.PixelCountLabel5.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel5.TabIndex = 7;
            this.PixelCountLabel5.Text = "5";
            this.PixelCountLabel5.UseWaitCursor = true;
            // 
            // PixelCountLabel6
            // 
            this.PixelCountLabel6.AutoSize = true;
            this.PixelCountLabel6.Location = new System.Drawing.Point(713, 336);
            this.PixelCountLabel6.Name = "PixelCountLabel6";
            this.PixelCountLabel6.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel6.TabIndex = 8;
            this.PixelCountLabel6.Text = "6";
            this.PixelCountLabel6.UseWaitCursor = true;
            // 
            // PixelCountLabel7
            // 
            this.PixelCountLabel7.AutoSize = true;
            this.PixelCountLabel7.Location = new System.Drawing.Point(755, 336);
            this.PixelCountLabel7.Name = "PixelCountLabel7";
            this.PixelCountLabel7.Size = new System.Drawing.Size(16, 17);
            this.PixelCountLabel7.TabIndex = 9;
            this.PixelCountLabel7.Text = "7";
            this.PixelCountLabel7.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PixelCountLabel7);
            this.Controls.Add(this.PixelCountLabel6);
            this.Controls.Add(this.PixelCountLabel5);
            this.Controls.Add(this.PixelCountLabel4);
            this.Controls.Add(this.PixelCountLabel3);
            this.Controls.Add(this.PixelCountLabel2);
            this.Controls.Add(this.PixelCountLabel1);
            this.Controls.Add(this.thresholdTrackBar);
            this.Controls.Add(this.binaryPictureBox);
            this.Controls.Add(this.emguPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form1";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emguPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox emguPictureBox;
        private System.Windows.Forms.PictureBox binaryPictureBox;
        private System.Windows.Forms.TrackBar thresholdTrackBar;
        private System.Windows.Forms.Label PixelCountLabel1;
        private System.Windows.Forms.Label PixelCountLabel2;
        private System.Windows.Forms.Label PixelCountLabel3;
        private System.Windows.Forms.Label PixelCountLabel4;
        private System.Windows.Forms.Label PixelCountLabel5;
        private System.Windows.Forms.Label PixelCountLabel6;
        private System.Windows.Forms.Label PixelCountLabel7;
    }
}
