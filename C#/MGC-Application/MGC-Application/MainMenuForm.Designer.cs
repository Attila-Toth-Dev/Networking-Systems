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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            topHeaderPanel = new Panel();
            profileButton = new Button();
            welecomeLabel = new Label();
            gameListView = new ListView();
            fileNameHeader = new ColumnHeader();
            filePathHeader = new ColumnHeader();
            bottomPanel = new Panel();
            downloadProgressBar = new ProgressBar();
            leftPanel = new Panel();
            menuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(684, 24);
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
            topHeaderPanel.Controls.Add(profileButton);
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(0, 24);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(684, 62);
            topHeaderPanel.TabIndex = 3;
            // 
            // profileButton
            // 
            profileButton.BackgroundImage = (Image)resources.GetObject("profileButton.BackgroundImage");
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Location = new Point(621, 6);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(50, 50);
            profileButton.TabIndex = 1;
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
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
            // gameListView
            // 
            gameListView.BackColor = Color.Silver;
            gameListView.BorderStyle = BorderStyle.FixedSingle;
            gameListView.Columns.AddRange(new ColumnHeader[] { fileNameHeader, filePathHeader });
            gameListView.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameListView.Location = new Point(125, 86);
            gameListView.Name = "gameListView";
            gameListView.Size = new Size(559, 308);
            gameListView.TabIndex = 11;
            gameListView.UseCompatibleStateImageBehavior = false;
            gameListView.View = View.Details;
            // 
            // fileNameHeader
            // 
            fileNameHeader.Text = "File Name";
            fileNameHeader.Width = 100;
            // 
            // filePathHeader
            // 
            filePathHeader.Text = "File Path";
            filePathHeader.Width = 500;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.Gray;
            bottomPanel.BorderStyle = BorderStyle.FixedSingle;
            bottomPanel.Controls.Add(downloadProgressBar);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 394);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(684, 67);
            bottomPanel.TabIndex = 11;
            // 
            // downloadProgressBar
            // 
            downloadProgressBar.Location = new Point(0, 57);
            downloadProgressBar.Name = "downloadProgressBar";
            downloadProgressBar.Size = new Size(684, 10);
            downloadProgressBar.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Gray;
            leftPanel.BorderStyle = BorderStyle.FixedSingle;
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 86);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(128, 308);
            leftPanel.TabIndex = 12;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(684, 461);
            Controls.Add(leftPanel);
            Controls.Add(gameListView);
            Controls.Add(bottomPanel);
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
            FormClosed += MainMenuForm_Closed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
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
        private Panel myGamesPanel;
        private Button profileButton;
        private ListView gameListView;
        private ColumnHeader fileNameHeader;
        private ColumnHeader filePathHeader;
        private Panel bottomPanel;
        private ProgressBar downloadBar;
        private Label downloadLabel;
        private Panel leftPanel;
        private ProgressBar downloadProgressBar;
    }
}