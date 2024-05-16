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
            ListViewItem listViewItem10 = new ListViewItem("Breakout");
            ListViewItem listViewItem11 = new ListViewItem("Cursorblade");
            ListViewItem listViewItem12 = new ListViewItem("Force Reboot");
            ListViewItem listViewItem13 = new ListViewItem("Hardware Tycoon");
            ListViewItem listViewItem14 = new ListViewItem("Hell Bullet");
            ListViewItem listViewItem15 = new ListViewItem("Mindustry");
            ListViewItem listViewItem16 = new ListViewItem("Mini Doom");
            ListViewItem listViewItem17 = new ListViewItem("Pathogen-X");
            ListViewItem listViewItem18 = new ListViewItem("Space Janitor");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            toolMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            welecomeLabel = new Label();
            gameListPanel = new Panel();
            gameListView = new ListView();
            gameListHeader = new ColumnHeader();
            buttonLayoutPanel = new Panel();
            uninstallButton = new Button();
            updateButton = new Button();
            playButton = new Button();
            installButton = new Button();
            progressLayoutPanel = new Panel();
            downloadSpeedLabel = new Label();
            downloadProgressLabel = new Label();
            downloadProgressbar = new ProgressBar();
            gameInfoPanel = new Panel();
            gameFilePathLabel = new Label();
            filePathLayoutPanel = new Panel();
            gameFilePathButton = new Button();
            gameFilePathTextBox = new TextBox();
            toolMenuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            gameListPanel.SuspendLayout();
            buttonLayoutPanel.SuspendLayout();
            progressLayoutPanel.SuspendLayout();
            filePathLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolMenuStrip
            // 
            toolMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
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
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "&Menu";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "&Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.PowderBlue;
            topHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Location = new Point(6, 27);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(974, 67);
            topHeaderPanel.TabIndex = 3;
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
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            gameListView.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
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
            // buttonLayoutPanel
            // 
            buttonLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonLayoutPanel.BackColor = Color.LightBlue;
            buttonLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            buttonLayoutPanel.Controls.Add(uninstallButton);
            buttonLayoutPanel.Controls.Add(updateButton);
            buttonLayoutPanel.Controls.Add(playButton);
            buttonLayoutPanel.Controls.Add(installButton);
            buttonLayoutPanel.Location = new Point(6, 583);
            buttonLayoutPanel.Name = "buttonLayoutPanel";
            buttonLayoutPanel.Size = new Size(411, 74);
            buttonLayoutPanel.TabIndex = 6;
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
            updateButton.Click += updateButton_Click;
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
            // progressLayoutPanel
            // 
            progressLayoutPanel.BackColor = Color.LightBlue;
            progressLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            progressLayoutPanel.Controls.Add(downloadSpeedLabel);
            progressLayoutPanel.Controls.Add(downloadProgressLabel);
            progressLayoutPanel.Controls.Add(downloadProgressbar);
            progressLayoutPanel.Location = new Point(423, 583);
            progressLayoutPanel.Name = "progressLayoutPanel";
            progressLayoutPanel.Size = new Size(311, 74);
            progressLayoutPanel.TabIndex = 7;
            // 
            // downloadSpeedLabel
            // 
            downloadSpeedLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloadSpeedLabel.AutoSize = true;
            downloadSpeedLabel.ImageAlign = ContentAlignment.MiddleRight;
            downloadSpeedLabel.Location = new Point(3, 25);
            downloadSpeedLabel.Name = "downloadSpeedLabel";
            downloadSpeedLabel.RightToLeft = RightToLeft.Yes;
            downloadSpeedLabel.Size = new Size(136, 22);
            downloadSpeedLabel.TabIndex = 2;
            downloadSpeedLabel.Text = "Speed: 0 MB/s";
            // 
            // downloadProgressLabel
            // 
            downloadProgressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            downloadProgressLabel.AutoSize = true;
            downloadProgressLabel.Location = new Point(3, 3);
            downloadProgressLabel.Name = "downloadProgressLabel";
            downloadProgressLabel.Size = new Size(215, 22);
            downloadProgressLabel.TabIndex = 1;
            downloadProgressLabel.Text = "Download Progress: 0%";
            // 
            // downloadProgressbar
            // 
            downloadProgressbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            downloadProgressbar.Location = new Point(3, 48);
            downloadProgressbar.Name = "downloadProgressbar";
            downloadProgressbar.Size = new Size(301, 19);
            downloadProgressbar.TabIndex = 0;
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
            // gameFilePathLabel
            // 
            gameFilePathLabel.AutoSize = true;
            gameFilePathLabel.Location = new Point(3, 6);
            gameFilePathLabel.Name = "gameFilePathLabel";
            gameFilePathLabel.Size = new Size(108, 22);
            gameFilePathLabel.TabIndex = 0;
            gameFilePathLabel.Text = "Folder Path";
            // 
            // filePathLayoutPanel
            // 
            filePathLayoutPanel.BackColor = Color.LightBlue;
            filePathLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            filePathLayoutPanel.Controls.Add(gameFilePathButton);
            filePathLayoutPanel.Controls.Add(gameFilePathTextBox);
            filePathLayoutPanel.Controls.Add(gameFilePathLabel);
            filePathLayoutPanel.Location = new Point(740, 583);
            filePathLayoutPanel.Name = "filePathLayoutPanel";
            filePathLayoutPanel.Size = new Size(240, 74);
            filePathLayoutPanel.TabIndex = 9;
            // 
            // gameFilePathButton
            // 
            gameFilePathButton.Location = new Point(117, 3);
            gameFilePathButton.Name = "gameFilePathButton";
            gameFilePathButton.Size = new Size(113, 29);
            gameFilePathButton.TabIndex = 0;
            gameFilePathButton.Text = "Folder";
            gameFilePathButton.UseVisualStyleBackColor = true;
            gameFilePathButton.Click += gameFolderPathButton_Click;
            // 
            // gameFilePathTextBox
            // 
            gameFilePathTextBox.Enabled = false;
            gameFilePathTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameFilePathTextBox.Location = new Point(3, 41);
            gameFilePathTextBox.Name = "gameFilePathTextBox";
            gameFilePathTextBox.Size = new Size(230, 26);
            gameFilePathTextBox.TabIndex = 0;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(984, 661);
            Controls.Add(filePathLayoutPanel);
            Controls.Add(gameInfoPanel);
            Controls.Add(progressLayoutPanel);
            Controls.Add(buttonLayoutPanel);
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
            buttonLayoutPanel.ResumeLayout(false);
            progressLayoutPanel.ResumeLayout(false);
            progressLayoutPanel.PerformLayout();
            filePathLayoutPanel.ResumeLayout(false);
            filePathLayoutPanel.PerformLayout();
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
        private ProgressBar downloadBar;
        private Label downloadLabel;
        private Panel gameListPanel;
        private Panel buttonLayoutPanel;
        private Button installButton;
        private Button playButton;
        private Panel progressLayoutPanel;
        private Label downloadSpeedLabel;
        private Label downloadProgressLabel;
        private ProgressBar downloadProgressbar;
        private Button uninstallButton;
        private Button updateButton;
        private ListView gameListView;
        private Panel gameInfoPanel;
        public ColumnHeader gameListHeader;
        private Label gameFilePathLabel;
        private Panel filePathLayoutPanel;
        private TextBox gameFilePathTextBox;
        private Button gameFilePathButton;
    }
}