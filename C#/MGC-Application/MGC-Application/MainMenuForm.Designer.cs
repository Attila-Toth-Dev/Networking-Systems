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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            ListViewItem listViewItem1 = new ListViewItem("Breakout");
            ListViewItem listViewItem2 = new ListViewItem("Cursorblade");
            ListViewItem listViewItem3 = new ListViewItem("Force Reboot");
            ListViewItem listViewItem4 = new ListViewItem("Hardware Tycoon");
            ListViewItem listViewItem5 = new ListViewItem("Hell Bullet");
            ListViewItem listViewItem6 = new ListViewItem("Mindustry");
            ListViewItem listViewItem7 = new ListViewItem("Mini Doom");
            ListViewItem listViewItem8 = new ListViewItem("Pathogen-X");
            ListViewItem listViewItem9 = new ListViewItem("Space Janitor");
            toolMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            consoleToolStripMenuItem = new ToolStripMenuItem();
            gamesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            profileButton = new Button();
            welecomeLabel = new Label();
            gameListPanel = new Panel();
            gameListView = new ListView();
            gameListHeader = new ColumnHeader();
            buttonPanel = new Panel();
            uninstallButton = new Button();
            updateButton = new Button();
            playButton = new Button();
            installButton = new Button();
            progressPanel = new Panel();
            downSpeedLabel = new Label();
            downProgressLabel = new Label();
            downProgressBar = new ProgressBar();
            gameInfoPanel = new Panel();
            gameFolderPathLabel = new Label();
            panel1 = new Panel();
            gameFolderPathButton = new Button();
            gameFolderPathTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            downloadTimer = new System.Windows.Forms.Timer(components);
            toolMenuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            gameListPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            progressPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
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
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consoleToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // consoleToolStripMenuItem
            // 
            consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            consoleToolStripMenuItem.Size = new Size(117, 22);
            consoleToolStripMenuItem.Text = "&Console";
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
            gameListPanel.Controls.Add(gameListView);
            gameListPanel.Location = new Point(6, 100);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(303, 477);
            gameListPanel.TabIndex = 5;
            // 
            // gameListView
            // 
            gameListView.BackColor = SystemColors.InactiveCaption;
            gameListView.CheckBoxes = true;
            gameListView.Columns.AddRange(new ColumnHeader[] { gameListHeader });
            gameListView.Dock = DockStyle.Fill;
            gameListView.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            gameListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9 });
            gameListView.Location = new Point(0, 0);
            gameListView.Name = "gameListView";
            gameListView.Size = new Size(299, 473);
            gameListView.TabIndex = 0;
            gameListView.UseCompatibleStateImageBehavior = false;
            gameListView.View = View.Details;
            gameListView.Click += gameListView_Click;
            // 
            // gameListHeader
            // 
            gameListHeader.Text = "             My Game Library";
            gameListHeader.Width = 295;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.BackColor = Color.LightBlue;
            buttonPanel.BorderStyle = BorderStyle.Fixed3D;
            buttonPanel.Controls.Add(uninstallButton);
            buttonPanel.Controls.Add(updateButton);
            buttonPanel.Controls.Add(playButton);
            buttonPanel.Controls.Add(installButton);
            buttonPanel.Location = new Point(6, 583);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(411, 74);
            buttonPanel.TabIndex = 6;
            // 
            // uninstallButton
            // 
            uninstallButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uninstallButton.Location = new Point(307, 3);
            uninstallButton.Name = "uninstallButton";
            uninstallButton.RightToLeft = RightToLeft.No;
            uninstallButton.Size = new Size(95, 65);
            uninstallButton.TabIndex = 4;
            uninstallButton.Text = "Uninstall";
            uninstallButton.UseVisualStyleBackColor = true;
            uninstallButton.Click += uninstallButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.Enabled = false;
            updateButton.Location = new Point(105, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(95, 65);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playButton.Location = new Point(4, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(95, 65);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // installButton
            // 
            installButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            installButton.Location = new Point(206, 3);
            installButton.Name = "installButton";
            installButton.Size = new Size(95, 65);
            installButton.TabIndex = 3;
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
            progressPanel.Location = new Point(423, 583);
            progressPanel.Name = "progressPanel";
            progressPanel.Size = new Size(311, 74);
            progressPanel.TabIndex = 7;
            // 
            // downSpeedLabel
            // 
            downSpeedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downSpeedLabel.AutoSize = true;
            downSpeedLabel.ImageAlign = ContentAlignment.MiddleRight;
            downSpeedLabel.Location = new Point(3, 25);
            downSpeedLabel.Name = "downSpeedLabel";
            downSpeedLabel.RightToLeft = RightToLeft.Yes;
            downSpeedLabel.Size = new Size(136, 22);
            downSpeedLabel.TabIndex = 2;
            downSpeedLabel.Text = "Speed: 0 MB/s";
            // 
            // downProgressLabel
            // 
            downProgressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downProgressLabel.AutoSize = true;
            downProgressLabel.Location = new Point(3, 3);
            downProgressLabel.Name = "downProgressLabel";
            downProgressLabel.Size = new Size(215, 22);
            downProgressLabel.TabIndex = 1;
            downProgressLabel.Text = "Download Progress: 0%";
            // 
            // downProgressBar
            // 
            downProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            downProgressBar.Location = new Point(3, 48);
            downProgressBar.Name = "downProgressBar";
            downProgressBar.Size = new Size(301, 19);
            downProgressBar.TabIndex = 0;
            // 
            // gameInfoPanel
            // 
            gameInfoPanel.BackColor = Color.LightBlue;
            gameInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            gameInfoPanel.Enabled = false;
            gameInfoPanel.Location = new Point(315, 100);
            gameInfoPanel.Name = "gameInfoPanel";
            gameInfoPanel.Size = new Size(665, 477);
            gameInfoPanel.TabIndex = 8;
            // 
            // gameFolderPathLabel
            // 
            gameFolderPathLabel.AutoSize = true;
            gameFolderPathLabel.Location = new Point(3, 6);
            gameFolderPathLabel.Name = "gameFolderPathLabel";
            gameFolderPathLabel.Size = new Size(108, 22);
            gameFolderPathLabel.TabIndex = 0;
            gameFolderPathLabel.Text = "Folder Path";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(gameFolderPathButton);
            panel1.Controls.Add(gameFolderPathTextBox);
            panel1.Controls.Add(gameFolderPathLabel);
            panel1.Location = new Point(740, 583);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 74);
            panel1.TabIndex = 9;
            // 
            // gameFolderPathButton
            // 
            gameFolderPathButton.Location = new Point(117, 3);
            gameFolderPathButton.Name = "gameFolderPathButton";
            gameFolderPathButton.Size = new Size(113, 29);
            gameFolderPathButton.TabIndex = 0;
            gameFolderPathButton.Text = "Folder";
            gameFolderPathButton.UseVisualStyleBackColor = true;
            gameFolderPathButton.Click += gameFolderPathButton_Click;
            // 
            // gameFolderPathTextBox
            // 
            gameFolderPathTextBox.Enabled = false;
            gameFolderPathTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameFolderPathTextBox.Location = new Point(3, 41);
            gameFolderPathTextBox.Name = "gameFolderPathTextBox";
            gameFolderPathTextBox.Size = new Size(230, 26);
            gameFolderPathTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // downloadTimer
            // 
            downloadTimer.Tick += downloadTimer_Tick;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(984, 661);
            Controls.Add(panel1);
            Controls.Add(gameInfoPanel);
            Controls.Add(progressPanel);
            Controls.Add(buttonPanel);
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
            gameListPanel.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            progressPanel.ResumeLayout(false);
            progressPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip toolMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
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
        private Panel buttonPanel;
        private Button installButton;
        private Button playButton;
        private Panel progressPanel;
        private Label downSpeedLabel;
        private Label downProgressLabel;
        private ProgressBar downProgressBar;
        private Button uninstallButton;
        private Button updateButton;
        private ListView gameListView;
        private Panel gameInfoPanel;
        public ColumnHeader gameListHeader;
        private Label gameFolderPathLabel;
        private Panel panel1;
        private TextBox gameFolderPathTextBox;
        private Button gameFolderPathButton;
        private ToolStripMenuItem consoleToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer downloadTimer;
    }
}