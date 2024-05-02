namespace MGC_Application
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            backgroundPanel = new Panel();
            profilePanel = new Panel();
            profileIconPictureBox = new PictureBox();
            profileNameLabel = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            backgroundPanel.SuspendLayout();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = SystemColors.Control;
            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgroundPanel.Controls.Add(profilePanel);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(284, 361);
            backgroundPanel.TabIndex = 0;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.LightBlue;
            profilePanel.BorderStyle = BorderStyle.Fixed3D;
            profilePanel.Controls.Add(profileIconPictureBox);
            profilePanel.Controls.Add(profileNameLabel);
            profilePanel.Dock = DockStyle.Fill;
            profilePanel.Location = new Point(0, 0);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(280, 357);
            profilePanel.TabIndex = 0;
            // 
            // profileIconPictureBox
            // 
            profileIconPictureBox.Image = (Image)resources.GetObject("profileIconPictureBox.Image");
            profileIconPictureBox.Location = new Point(90, 50);
            profileIconPictureBox.Name = "profileIconPictureBox";
            profileIconPictureBox.Size = new Size(100, 100);
            profileIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profileIconPictureBox.TabIndex = 0;
            profileIconPictureBox.TabStop = false;
            // 
            // profileNameLabel
            // 
            profileNameLabel.Dock = DockStyle.Fill;
            profileNameLabel.Location = new Point(0, 0);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(276, 353);
            profileNameLabel.TabIndex = 1;
            profileNameLabel.Text = "profile name";
            profileNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(284, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "&Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(180, 22);
            exitToolStripMenuItem1.Text = "&Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(menuStrip);
            Controls.Add(backgroundPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            backgroundPanel.ResumeLayout(false);
            profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel backgroundPanel;
        private Panel profilePanel;
        private Label profileNameLabel;
        private PictureBox profileIconPictureBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}