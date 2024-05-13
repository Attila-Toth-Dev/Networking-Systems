namespace MGC_Application
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            toolMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            gamesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            profileButton = new Button();
            welecomeLabel = new Label();
            gameListPanel = new Panel();
            gameInfoPanel = new Panel();
            buttonPanel = new Panel();
            playButton = new Button();
            installButton = new Button();
            progressPanel = new Panel();
            downSpeedLabel = new Label();
            downProgressLabel = new Label();
            downProgressBar = new ProgressBar();
            toolMenuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            progressPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolMenuStrip
            // 
            toolMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, gamesToolStripMenuItem, helpToolStripMenuItem });
            toolMenuStrip.Location = new Point(0, 0);
            toolMenuStrip.Name = "toolMenuStrip";
            toolMenuStrip.Size = new Size(984, 24);
            toolMenuStrip.TabIndex = 2;
            toolMenuStrip.Text = "menuStrip";
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
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "&Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(112, 22);
            exitToolStripMenuItem1.Text = "&Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size = new Size(55, 20);
            gamesToolStripMenuItem.Text = "&Games";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.PowderBlue;
            topHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            topHeaderPanel.Controls.Add(profileButton);
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Location = new Point(6, 27);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(974, 67);
            topHeaderPanel.TabIndex = 3;
            // 
            // profileButton
            // 
            profileButton.Anchor = AnchorStyles.Right;
            profileButton.BackgroundImage = (Image)resources.GetObject("profileButton.BackgroundImage");
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Location = new Point(912, 4);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(55, 55);
            profileButton.TabIndex = 1;
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // welecomeLabel
            // 
            welecomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welecomeLabel.AutoSize = true;
            welecomeLabel.Location = new Point(14, 20);
            welecomeLabel.Name = "welecomeLabel";
            welecomeLabel.Size = new Size(148, 22);
            welecomeLabel.TabIndex = 0;
            welecomeLabel.Text = "Welcome Test...";
            // 
            // gameListPanel
            // 
            gameListPanel.BackColor = Color.LightBlue;
            gameListPanel.BorderStyle = BorderStyle.Fixed3D;
            gameListPanel.Location = new Point(6, 100);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(200, 456);
            gameListPanel.TabIndex = 4;
            // 
            // gameInfoPanel
            // 
            gameInfoPanel.BackColor = Color.LightBlue;
            gameInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            gameInfoPanel.Location = new Point(212, 100);
            gameInfoPanel.Name = "gameInfoPanel";
            gameInfoPanel.Size = new Size(768, 456);
            gameInfoPanel.TabIndex = 5;
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = Color.LightBlue;
            buttonPanel.BorderStyle = BorderStyle.Fixed3D;
            buttonPanel.Controls.Add(playButton);
            buttonPanel.Controls.Add(installButton);
            buttonPanel.Location = new Point(6, 562);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(200, 95);
            buttonPanel.TabIndex = 6;
            // 
            // playButton
            // 
            playButton.Location = new Point(98, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(95, 85);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // installButton
            // 
            installButton.Location = new Point(3, 3);
            installButton.Name = "installButton";
            installButton.Size = new Size(95, 85);
            installButton.TabIndex = 0;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += installButton_Click;
            // 
            // progressPanel
            // 
            progressPanel.BackColor = Color.LightBlue;
            progressPanel.BorderStyle = BorderStyle.Fixed3D;
            progressPanel.Controls.Add(downSpeedLabel);
            progressPanel.Controls.Add(downProgressLabel);
            progressPanel.Controls.Add(downProgressBar);
            progressPanel.Location = new Point(212, 562);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(768, 95);
            progressPanel.TabIndex = 7;
            // 
            // downSpeedLabel
            // 
            downSpeedLabel.AutoSize = true;
            downSpeedLabel.ImageAlign = ContentAlignment.MiddleRight;
            downSpeedLabel.Location = new Point(622, 44);
            downSpeedLabel.Name = "downSpeedLabel";
            downSpeedLabel.RightToLeft = RightToLeft.Yes;
            downSpeedLabel.Size = new Size(136, 22);
            downSpeedLabel.TabIndex = 2;
            downSpeedLabel.Text = "Speed: 0 MB/s";
            // 
            // downProgressLabel
            // 
            downProgressLabel.AutoSize = true;
            downProgressLabel.Location = new Point(3, 44);
            downProgressLabel.Name = "downProgressLabel";
            downProgressLabel.Size = new Size(215, 22);
            downProgressLabel.TabIndex = 1;
            downProgressLabel.Text = "Download Progress: 0%";
            // 
            // downProgressBar
            // 
            downProgressBar.Location = new Point(3, 69);
            downProgressBar.Name = "downProgressBar";
            downProgressBar.Size = new Size(758, 19);
            downProgressBar.TabIndex = 0;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(984, 661);
            Controls.Add(progressPanel);
            Controls.Add(buttonPanel);
            Controls.Add(gameInfoPanel);
            Controls.Add(gameListPanel);
            Controls.Add(topHeaderPanel);
            Controls.Add(toolMenuStrip);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = toolMenuStrip;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC-Launcher";
            FormClosed += MainMenuForm_Closed;
            toolMenuStrip.ResumeLayout(false);
            toolMenuStrip.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip toolMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Panel topHeaderPanel;
        private Label welecomeLabel;
        private Panel myGamesPanel;
        private Button profileButton;
        private ProgressBar downloadBar;
        private Label downloadLabel;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel gameListPanel;
        private Panel gameInfoPanel;
        private Panel buttonPanel;
        private Button installButton;
        private Button playButton;
        private Panel progressPanel;
        private Label downSpeedLabel;
        private Label downProgressLabel;
        private ProgressBar downProgressBar;
    }
}