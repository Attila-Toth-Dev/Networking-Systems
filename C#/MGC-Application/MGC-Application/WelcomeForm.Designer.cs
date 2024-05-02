namespace MGC_Application
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            launcherPictureBox = new PictureBox();
            loadingProgressBar = new ProgressBar();
            loadBarTimer = new System.Windows.Forms.Timer(components);
            loadProgressLabel = new Label();
            loadingValueLabel = new Label();
            secretPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)launcherPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secretPictureBox).BeginInit();
            SuspendLayout();
            // 
            // launcherPictureBox
            // 
            launcherPictureBox.BackColor = Color.LightBlue;
            launcherPictureBox.Image = (Image)resources.GetObject("launcherPictureBox.Image");
            launcherPictureBox.Location = new Point(220, 64);
            launcherPictureBox.Name = "launcherPictureBox";
            launcherPictureBox.Size = new Size(140, 140);
            launcherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            launcherPictureBox.TabIndex = 0;
            launcherPictureBox.TabStop = false;
            // 
            // loadingProgressBar
            // 
            loadingProgressBar.Location = new Point(140, 290);
            loadingProgressBar.Name = "loadingProgressBar";
            loadingProgressBar.Size = new Size(300, 23);
            loadingProgressBar.TabIndex = 1;
            // 
            // loadBarTimer
            // 
            loadBarTimer.Enabled = true;
            loadBarTimer.Tick += loadBarTimer_Tick;
            // 
            // loadProgressLabel
            // 
            loadProgressLabel.AutoSize = true;
            loadProgressLabel.BackColor = Color.LightBlue;
            loadProgressLabel.Location = new Point(140, 254);
            loadProgressLabel.Name = "loadProgressLabel";
            loadProgressLabel.Size = new Size(234, 22);
            loadProgressLabel.TabIndex = 2;
            loadProgressLabel.Text = "Loading MGC Laucncher...";
            // 
            // loadingValueLabel
            // 
            loadingValueLabel.AutoSize = true;
            loadingValueLabel.BackColor = Color.LightBlue;
            loadingValueLabel.Location = new Point(391, 254);
            loadingValueLabel.Name = "loadingValueLabel";
            loadingValueLabel.RightToLeft = RightToLeft.Yes;
            loadingValueLabel.Size = new Size(49, 22);
            loadingValueLabel.TabIndex = 3;
            loadingValueLabel.Text = "00%";
            loadingValueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // secretPictureBox
            // 
            secretPictureBox.BackColor = Color.LightBlue;
            secretPictureBox.Location = new Point(12, 12);
            secretPictureBox.Name = "secretPictureBox";
            secretPictureBox.Size = new Size(100, 50);
            secretPictureBox.TabIndex = 4;
            secretPictureBox.TabStop = false;
            secretPictureBox.Click += secretPictureBox_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 361);
            Controls.Add(secretPictureBox);
            Controls.Add(loadingValueLabel);
            Controls.Add(loadProgressLabel);
            Controls.Add(loadingProgressBar);
            Controls.Add(launcherPictureBox);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC-Launcher";
            ((System.ComponentModel.ISupportInitialize)launcherPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)secretPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox launcherPictureBox;
        private ProgressBar loadingProgressBar;
        private System.Windows.Forms.Timer loadBarTimer;
        private Label loadProgressLabel;
        private Label loadingValueLabel;
        private PictureBox secretPictureBox;
    }
}
