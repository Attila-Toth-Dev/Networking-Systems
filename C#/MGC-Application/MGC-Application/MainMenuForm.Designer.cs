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
            ListViewItem listViewItem9 = new ListViewItem("Breakout");
            ListViewItem listViewItem10 = new ListViewItem("Chaddius Maximus");
            ListViewItem listViewItem11 = new ListViewItem("Hell Bullet");
            ListViewItem listViewItem12 = new ListViewItem("Island Maker");
            ListViewItem listViewItem13 = new ListViewItem("Mini Doom");
            ListViewItem listViewItem14 = new ListViewItem("Space Janitor");
            ListViewItem listViewItem15 = new ListViewItem("Steel Breakers");
            ListViewItem listViewItem16 = new ListViewItem("Thrones Tale");
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
            toolMenuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            gameListPanel.SuspendLayout();
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
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            gameListView.Items.AddRange(new ListViewItem[] { listViewItem9, listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16 });
            gameListView.Location = new Point(0, 0);
            gameListView.Name = "gameListView";
            gameListView.Size = new Size(299, 473);
            gameListView.TabIndex = 0;
            gameListView.UseCompatibleStateImageBehavior = false;
            gameListView.View = View.Details;
            gameListView.ItemChecked += gameListView_ItemChecked;
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
            uninstallButton.Size = new Size(95, 63);
            uninstallButton.TabIndex = 3;
            uninstallButton.Text = "Uninstall";
            uninstallButton.UseVisualStyleBackColor = true;
            uninstallButton.Click += removeButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateButton.Location = new Point(105, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(95, 63);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // playButton
            // 
            playButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playButton.Location = new Point(4, 3);
            playButton.Name = "playButton";
            playButton.Size = new Size(95, 63);
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
            installButton.Size = new Size(95, 63);
            installButton.TabIndex = 0;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += addButton_Click;
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
            progressPanel.Size = new Size(557, 74);
            progressPanel.TabIndex = 7;
            // 
            // downSpeedLabel
            // 
            downSpeedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downSpeedLabel.AutoSize = true;
            downSpeedLabel.ImageAlign = ContentAlignment.MiddleRight;
            downSpeedLabel.Location = new Point(411, 20);
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
            downProgressLabel.Location = new Point(3, 20);
            downProgressLabel.Name = "downProgressLabel";
            downProgressLabel.Size = new Size(215, 22);
            downProgressLabel.TabIndex = 1;
            downProgressLabel.Text = "Download Progress: 0%";
            // 
            // downProgressBar
            // 
            downProgressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downProgressBar.Location = new Point(3, 45);
            downProgressBar.Name = "downProgressBar";
            downProgressBar.Size = new Size(547, 19);
            downProgressBar.TabIndex = 0;
            // 
            // gameInfoPanel
            // 
            gameInfoPanel.BackColor = Color.LightBlue;
            gameInfoPanel.BorderStyle = BorderStyle.Fixed3D;
            gameInfoPanel.Location = new Point(315, 100);
            gameInfoPanel.Name = "gameInfoPanel";
            gameInfoPanel.Size = new Size(665, 477);
            gameInfoPanel.TabIndex = 8;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(984, 661);
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
    }
}