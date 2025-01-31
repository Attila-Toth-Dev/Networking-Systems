﻿namespace MGC_Application.Forms
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "--- Game Name ---" }, -1, Color.Black, Color.Empty, null);
            ListViewItem listViewItem2 = new ListViewItem("--- Game Name ---");
            ListViewItem listViewItem3 = new ListViewItem("--- Game Name ---");
            toolMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            profilePictureBox = new PictureBox();
            welecomeLabel = new Label();
            gameListPanel = new Panel();
            installedIcon = new Panel();
            gameListView = new ListView();
            gameListHeader = new ColumnHeader();
            buttonLayoutPanel = new Panel();
            uninstallButton = new Button();
            updateButton = new Button();
            playButton = new Button();
            installButton = new Button();
            progressLayoutPanel = new Panel();
            percentLabel = new Label();
            installLabel = new Label();
            progressBar = new ProgressBar();
            cancelButton = new Button();
            gameInfoPanel = new Panel();
            gameFilePathLabel = new Label();
            filePathLayoutPanel = new Panel();
            gameFilePathButton = new Button();
            gameFilePathTextBox = new TextBox();
            installWorker = new System.ComponentModel.BackgroundWorker();
            updateWorker = new System.ComponentModel.BackgroundWorker();
            toolsPanel = new Panel();
            propertiesButton = new Button();
            toolMenuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            gameListPanel.SuspendLayout();
            buttonLayoutPanel.SuspendLayout();
            progressLayoutPanel.SuspendLayout();
            filePathLayoutPanel.SuspendLayout();
            toolsPanel.SuspendLayout();
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
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.LightBlue;
            topHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            topHeaderPanel.Controls.Add(profilePictureBox);
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Location = new Point(6, 27);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(974, 67);
            topHeaderPanel.TabIndex = 3;
            // 
            // profilePictureBox
            // 
            profilePictureBox.Image = (Image)resources.GetObject("profilePictureBox.Image");
            profilePictureBox.Location = new Point(911, 3);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(56, 56);
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 0;
            profilePictureBox.TabStop = false;
            profilePictureBox.Click += profilePictureBox_Click;
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
            gameListPanel.Controls.Add(installedIcon);
            gameListPanel.Controls.Add(gameListView);
            gameListPanel.Location = new Point(6, 100);
            gameListPanel.Name = "gameListPanel";
            gameListPanel.Size = new Size(303, 477);
            gameListPanel.TabIndex = 5;
            // 
            // installedIcon
            // 
            installedIcon.BackColor = SystemColors.ButtonShadow;
            installedIcon.BorderStyle = BorderStyle.Fixed3D;
            installedIcon.Location = new Point(273, 5);
            installedIcon.Name = "installedIcon";
            installedIcon.Size = new Size(20, 20);
            installedIcon.TabIndex = 0;
            // 
            // gameListView
            // 
            gameListView.BackColor = SystemColors.InactiveCaption;
            gameListView.Columns.AddRange(new ColumnHeader[] { gameListHeader });
            gameListView.Dock = DockStyle.Fill;
            gameListView.GridLines = true;
            gameListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            gameListView.Location = new Point(0, 0);
            gameListView.Name = "gameListView";
            gameListView.Size = new Size(299, 473);
            gameListView.TabIndex = 0;
            gameListView.UseCompatibleStateImageBehavior = false;
            gameListView.View = View.Details;
            gameListView.SelectedIndexChanged += gameListView_SelectedIndexChanged;
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
            progressLayoutPanel.Controls.Add(percentLabel);
            progressLayoutPanel.Controls.Add(installLabel);
            progressLayoutPanel.Controls.Add(progressBar);
            progressLayoutPanel.Location = new Point(517, 583);
            progressLayoutPanel.Name = "progressLayoutPanel";
            progressLayoutPanel.Size = new Size(217, 74);
            progressLayoutPanel.TabIndex = 7;
            // 
            // percentLabel
            // 
            percentLabel.AutoSize = true;
            percentLabel.Location = new Point(127, 10);
            percentLabel.Name = "percentLabel";
            percentLabel.Size = new Size(38, 22);
            percentLabel.TabIndex = 2;
            percentLabel.Text = "0%";
            // 
            // installLabel
            // 
            installLabel.AutoSize = true;
            installLabel.Location = new Point(3, 10);
            installLabel.Name = "installLabel";
            installLabel.Size = new Size(129, 22);
            installLabel.TabIndex = 1;
            installLabel.Text = "File Progress:";
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            progressBar.Location = new Point(3, 41);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(206, 26);
            progressBar.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(3, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(78, 32);
            cancelButton.TabIndex = 0;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
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
            gameFilePathLabel.Location = new Point(3, 10);
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
            gameFilePathButton.Location = new Point(117, 7);
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
            gameFilePathTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameFilePathTextBox.Location = new Point(3, 41);
            gameFilePathTextBox.Multiline = true;
            gameFilePathTextBox.Name = "gameFilePathTextBox";
            gameFilePathTextBox.Size = new Size(230, 26);
            gameFilePathTextBox.TabIndex = 0;
            // 
            // installWorker
            // 
            installWorker.WorkerReportsProgress = true;
            installWorker.WorkerSupportsCancellation = true;
            installWorker.DoWork += installWorker_DoWork;
            installWorker.ProgressChanged += installWorker_ProgressChanged;
            installWorker.RunWorkerCompleted += installWorker_RunWorkerCompleted;
            // 
            // updateWorker
            // 
            updateWorker.WorkerReportsProgress = true;
            updateWorker.WorkerSupportsCancellation = true;
            updateWorker.DoWork += updateWorker_DoWork;
            updateWorker.ProgressChanged += updateWorker_ProgressChanged;
            updateWorker.RunWorkerCompleted += updateWorker_RunWorkerCompleted;
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = Color.LightBlue;
            toolsPanel.BorderStyle = BorderStyle.Fixed3D;
            toolsPanel.Controls.Add(propertiesButton);
            toolsPanel.Controls.Add(cancelButton);
            toolsPanel.Location = new Point(423, 583);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(88, 74);
            toolsPanel.TabIndex = 1;
            // 
            // propertiesButton
            // 
            propertiesButton.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            propertiesButton.Location = new Point(3, 36);
            propertiesButton.Name = "propertiesButton";
            propertiesButton.Size = new Size(78, 32);
            propertiesButton.TabIndex = 1;
            propertiesButton.Text = "Config";
            propertiesButton.UseVisualStyleBackColor = true;
            propertiesButton.Click += propertiesButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(984, 661);
            Controls.Add(toolsPanel);
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
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            gameListPanel.ResumeLayout(false);
            buttonLayoutPanel.ResumeLayout(false);
            progressLayoutPanel.ResumeLayout(false);
            progressLayoutPanel.PerformLayout();
            filePathLayoutPanel.ResumeLayout(false);
            filePathLayoutPanel.PerformLayout();
            toolsPanel.ResumeLayout(false);
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
        //private Panel myGamesPanel;
        //private ProgressBar downloadBar;
        //private Label downloadLabel;
        private Panel gameListPanel;
        private Panel buttonLayoutPanel;
        private Button installButton;
        private Button playButton;
        private Panel progressLayoutPanel;
        private ProgressBar progressBar;
        private Button uninstallButton;
        private Button updateButton;
        private ListView gameListView;
        private Panel gameInfoPanel;
        public ColumnHeader gameListHeader;
        private Label gameFilePathLabel;
        private Panel filePathLayoutPanel;
        private Button gameFilePathButton;
        private Label installLabel;
        private Label percentLabel;
        private Panel installedIcon;
        private System.ComponentModel.BackgroundWorker installWorker;
        private System.ComponentModel.BackgroundWorker updateWorker;
        public PictureBox profilePictureBox;
        private Button cancelButton;
        private Panel toolsPanel;
        private Button propertiesButton;
        public TextBox gameFilePathTextBox;
    }
}