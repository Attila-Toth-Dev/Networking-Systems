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
            gamesListPanel = new Panel();
            myGamesListBox = new ListBox();
            topLeftPanel = new Panel();
            myGamesHeaderLabel = new Label();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            welecomeLabel = new Label();
            selectedGameNameLabel = new Label();
            panel1 = new Panel();
            installButton = new Button();
            updateButton = new Button();
            playButton = new Button();
            gamesListPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            menuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gamesListPanel
            // 
            gamesListPanel.BorderStyle = BorderStyle.Fixed3D;
            gamesListPanel.Controls.Add(myGamesListBox);
            gamesListPanel.Controls.Add(topLeftPanel);
            gamesListPanel.Dock = DockStyle.Left;
            gamesListPanel.Location = new Point(0, 24);
            gamesListPanel.Name = "gamesListPanel";
            gamesListPanel.Size = new Size(140, 337);
            gamesListPanel.TabIndex = 1;
            // 
            // myGamesListBox
            // 
            myGamesListBox.BackColor = Color.LightBlue;
            myGamesListBox.Cursor = Cursors.Hand;
            myGamesListBox.Dock = DockStyle.Fill;
            myGamesListBox.FormattingEnabled = true;
            myGamesListBox.ItemHeight = 22;
            myGamesListBox.Items.AddRange(new object[] { "- Tank Game", "- Breakout" });
            myGamesListBox.Location = new Point(0, 60);
            myGamesListBox.Name = "myGamesListBox";
            myGamesListBox.Size = new Size(136, 273);
            myGamesListBox.TabIndex = 1;
            myGamesListBox.SelectedIndexChanged += myGamesListBox_SelectedIndexChanged;
            // 
            // topLeftPanel
            // 
            topLeftPanel.BackColor = Color.LightBlue;
            topLeftPanel.BorderStyle = BorderStyle.Fixed3D;
            topLeftPanel.Controls.Add(myGamesHeaderLabel);
            topLeftPanel.Dock = DockStyle.Top;
            topLeftPanel.Location = new Point(0, 0);
            topLeftPanel.Name = "topLeftPanel";
            topLeftPanel.Size = new Size(136, 60);
            topLeftPanel.TabIndex = 0;
            // 
            // myGamesHeaderLabel
            // 
            myGamesHeaderLabel.AutoSize = true;
            myGamesHeaderLabel.Location = new Point(8, 18);
            myGamesHeaderLabel.Name = "myGamesHeaderLabel";
            myGamesHeaderLabel.Size = new Size(111, 22);
            myGamesHeaderLabel.TabIndex = 0;
            myGamesHeaderLabel.Text = "MY GAMES";
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
            topHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(140, 24);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(444, 62);
            topHeaderPanel.TabIndex = 3;
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
            panel1.Size = new Size(416, 10);
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
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(584, 361);
            Controls.Add(playButton);
            Controls.Add(updateButton);
            Controls.Add(installButton);
            Controls.Add(panel1);
            Controls.Add(selectedGameNameLabel);
            Controls.Add(topHeaderPanel);
            Controls.Add(gamesListPanel);
            Controls.Add(menuStrip);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Launcher Menu";
            gamesListPanel.ResumeLayout(false);
            topLeftPanel.ResumeLayout(false);
            topLeftPanel.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel gamesListPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ListBox myGamesListBox;
        private Panel topLeftPanel;
        private Label myGamesHeaderLabel;
        private Panel topHeaderPanel;
        private Label welecomeLabel;
        private Label selectedGameNameLabel;
        private Panel panel1;
        private Button installButton;
        private Button updateButton;
        private Button playButton;
    }
}