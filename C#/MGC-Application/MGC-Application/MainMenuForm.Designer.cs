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
            myGamesListBox = new ListBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            profileIconPictureBox = new PictureBox();
            welecomeLabel = new Label();
            selectedGameNameLabel = new Label();
            panel1 = new Panel();
            installButton = new Button();
            updateButton = new Button();
            playButton = new Button();
            gameDescLabel = new Label();
            myGamesPanel = new Panel();
            menuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).BeginInit();
            myGamesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // myGamesListBox
            // 
            myGamesListBox.BackColor = Color.Gray;
            myGamesListBox.BorderStyle = BorderStyle.FixedSingle;
            myGamesListBox.Cursor = Cursors.Hand;
            myGamesListBox.Dock = DockStyle.Left;
            myGamesListBox.FormattingEnabled = true;
            myGamesListBox.HorizontalScrollbar = true;
            myGamesListBox.ItemHeight = 22;
            myGamesListBox.Items.AddRange(new object[] { "- Breakout" });
            myGamesListBox.Location = new Point(0, 0);
            myGamesListBox.Name = "myGamesListBox";
            myGamesListBox.Size = new Size(140, 288);
            myGamesListBox.TabIndex = 1;
            myGamesListBox.SelectedIndexChanged += myGamesListBox_SelectedIndexChanged;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(584, 24);
            menuStrip.TabIndex = 2;
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
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.LightBlue;
            topHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            topHeaderPanel.Controls.Add(profileIconPictureBox);
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(0, 24);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(584, 62);
            topHeaderPanel.TabIndex = 3;
            // 
            // profileIconPictureBox
            // 
            profileIconPictureBox.Image = (Image)resources.GetObject("profileIconPictureBox.Image");
            profileIconPictureBox.Location = new Point(524, 3);
            profileIconPictureBox.Name = "profileIconPictureBox";
            profileIconPictureBox.Size = new Size(55, 55);
            profileIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profileIconPictureBox.TabIndex = 1;
            profileIconPictureBox.TabStop = false;
            profileIconPictureBox.Click += profileIconPictureBox_Click;
            // 
            // welecomeLabel
            // 
            welecomeLabel.AutoSize = true;
            welecomeLabel.Location = new Point(14, 20);
            welecomeLabel.Name = "welecomeLabel";
            welecomeLabel.Size = new Size(148, 22);
            welecomeLabel.TabIndex = 0;
            welecomeLabel.Text = "Welcome Test...";
            // 
            // selectedGameNameLabel
            // 
            selectedGameNameLabel.AutoSize = true;
            selectedGameNameLabel.Location = new Point(156, 101);
            selectedGameNameLabel.Name = "selectedGameNameLabel";
            selectedGameNameLabel.Size = new Size(110, 22);
            selectedGameNameLabel.TabIndex = 4;
            selectedGameNameLabel.Text = "game name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(156, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 2);
            panel1.TabIndex = 5;
            // 
            // installButton
            // 
            installButton.Location = new Point(484, 306);
            installButton.Name = "installButton";
            installButton.Size = new Size(88, 43);
            installButton.TabIndex = 6;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(390, 306);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 43);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            playButton.Location = new Point(156, 306);
            playButton.Name = "playButton";
            playButton.Size = new Size(88, 43);
            playButton.TabIndex = 8;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // gameDescLabel
            // 
            gameDescLabel.AutoSize = true;
            gameDescLabel.Location = new Point(156, 131);
            gameDescLabel.Name = "gameDescLabel";
            gameDescLabel.Size = new Size(105, 22);
            gameDescLabel.TabIndex = 9;
            gameDescLabel.Text = "game desc";
            // 
            // myGamesPanel
            // 
            myGamesPanel.Controls.Add(myGamesListBox);
            myGamesPanel.Dock = DockStyle.Left;
            myGamesPanel.Location = new Point(0, 86);
            myGamesPanel.Name = "myGamesPanel";
            myGamesPanel.Size = new Size(134, 288);
            myGamesPanel.TabIndex = 10;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(584, 374);
            Controls.Add(myGamesPanel);
            Controls.Add(gameDescLabel);
            Controls.Add(playButton);
            Controls.Add(updateButton);
            Controls.Add(installButton);
            Controls.Add(panel1);
            Controls.Add(selectedGameNameLabel);
            Controls.Add(topHeaderPanel);
            Controls.Add(menuStrip);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Launcher Menu";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).EndInit();
            myGamesPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Panel topHeaderPanel;
        private Label welecomeLabel;
        private Label selectedGameNameLabel;
        private Panel panel1;
        private Button installButton;
        private Button updateButton;
        private Button playButton;
        private PictureBox profileIconPictureBox;
        private Label gameDescLabel;
        private ListBox myGamesListBox;
        private Panel myGamesPanel;
    }
}