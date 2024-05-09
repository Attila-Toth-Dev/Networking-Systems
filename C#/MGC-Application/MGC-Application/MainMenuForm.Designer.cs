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
            playButton = new Button();
            myGamesPanel = new Panel();
            updateButton = new Button();
            uninstallButton = new Button();
            installButton = new Button();
            gameListView = new ListView();
            fileNameHeader = new ColumnHeader();
            filePathHeader = new ColumnHeader();
            menuStrip.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            myGamesPanel.SuspendLayout();
            SuspendLayout();
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
            topHeaderPanel.Controls.Add(profileButton);
            topHeaderPanel.Controls.Add(welecomeLabel);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.Location = new Point(0, 24);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(584, 62);
            topHeaderPanel.TabIndex = 3;
            // 
            // profileButton
            // 
            profileButton.BackgroundImage = (Image)resources.GetObject("profileButton.BackgroundImage");
            profileButton.BackgroundImageLayout = ImageLayout.Stretch;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Location = new Point(521, 6);
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
            // playButton
            // 
            playButton.Location = new Point(24, 15);
            playButton.Name = "playButton";
            playButton.Size = new Size(88, 43);
            playButton.TabIndex = 8;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // myGamesPanel
            // 
            myGamesPanel.BackColor = Color.Gray;
            myGamesPanel.Controls.Add(updateButton);
            myGamesPanel.Controls.Add(uninstallButton);
            myGamesPanel.Controls.Add(installButton);
            myGamesPanel.Controls.Add(playButton);
            myGamesPanel.Dock = DockStyle.Left;
            myGamesPanel.Location = new Point(0, 86);
            myGamesPanel.Name = "myGamesPanel";
            myGamesPanel.Size = new Size(134, 288);
            myGamesPanel.TabIndex = 10;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(24, 126);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 46);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // uninstallButton
            // 
            uninstallButton.Location = new Point(24, 230);
            uninstallButton.Name = "uninstallButton";
            uninstallButton.Size = new Size(88, 46);
            uninstallButton.TabIndex = 10;
            uninstallButton.Text = "Uninstall";
            uninstallButton.UseVisualStyleBackColor = true;
            uninstallButton.Click += uninstallButton_Click;
            // 
            // installButton
            // 
            installButton.Location = new Point(24, 178);
            installButton.Name = "installButton";
            installButton.Size = new Size(88, 46);
            installButton.TabIndex = 9;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += installButton_Click;
            // 
            // gameListView
            // 
            gameListView.BackColor = Color.Silver;
            gameListView.BorderStyle = BorderStyle.FixedSingle;
            gameListView.Columns.AddRange(new ColumnHeader[] { fileNameHeader, filePathHeader });
            gameListView.Dock = DockStyle.Fill;
            gameListView.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameListView.Location = new Point(134, 86);
            gameListView.Name = "gameListView";
            gameListView.Size = new Size(450, 288);
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
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(584, 374);
            Controls.Add(gameListView);
            Controls.Add(myGamesPanel);
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
        private Button playButton;
        private Panel myGamesPanel;
        private Button profileButton;
        private ListView gameListView;
        private ColumnHeader fileNameHeader;
        private ColumnHeader filePathHeader;
        private Button updateButton;
        private Button uninstallButton;
        private Button installButton;
    }
}