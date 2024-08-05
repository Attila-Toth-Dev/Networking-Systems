namespace MGC_Application.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            launcherPictureBox = new PictureBox();
            serverIPLabel = new Label();
            backgroundPanel = new Panel();
            connectButton = new Button();
            serverIPTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)launcherPictureBox).BeginInit();
            backgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // launcherPictureBox
            // 
            launcherPictureBox.BackColor = Color.LightBlue;
            launcherPictureBox.Image = (Image)resources.GetObject("launcherPictureBox.Image");
            launcherPictureBox.Location = new Point(121, 51);
            launcherPictureBox.Name = "launcherPictureBox";
            launcherPictureBox.Size = new Size(140, 140);
            launcherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            launcherPictureBox.TabIndex = 0;
            launcherPictureBox.TabStop = false;
            // 
            // serverIPLabel
            // 
            serverIPLabel.AutoSize = true;
            serverIPLabel.BackColor = Color.LightBlue;
            serverIPLabel.ImageAlign = ContentAlignment.MiddleLeft;
            serverIPLabel.Location = new Point(23, 213);
            serverIPLabel.Name = "serverIPLabel";
            serverIPLabel.Size = new Size(141, 33);
            serverIPLabel.TabIndex = 2;
            serverIPLabel.Text = "Server IP:";
            // 
            // backgroundPanel
            // 
            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgroundPanel.Controls.Add(connectButton);
            backgroundPanel.Controls.Add(launcherPictureBox);
            backgroundPanel.Controls.Add(serverIPTextBox);
            backgroundPanel.Controls.Add(serverIPLabel);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(378, 344);
            backgroundPanel.TabIndex = 5;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(121, 270);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(140, 46);
            connectButton.TabIndex = 4;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // serverIPTextBox
            // 
            serverIPTextBox.Location = new Point(170, 213);
            serverIPTextBox.Name = "serverIPTextBox";
            serverIPTextBox.Size = new Size(164, 40);
            serverIPTextBox.TabIndex = 3;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(378, 344);
            Controls.Add(backgroundPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC-Launcher";
            FormClosed += WelcomeForm_Closed;
            ((System.ComponentModel.ISupportInitialize)launcherPictureBox).EndInit();
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox launcherPictureBox;
        private Label serverIPLabel;
        private Panel backgroundPanel;
        private TextBox serverIPTextBox;
        private Button connectButton;
    }
}
