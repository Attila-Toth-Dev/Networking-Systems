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
            gameIconPanel = new Panel();
            panel1 = new Panel();
            usernameLabel = new Label();
            gamesListPanel = new Panel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            gameIconPanel.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // gameIconPanel
            // 
            gameIconPanel.BorderStyle = BorderStyle.Fixed3D;
            gameIconPanel.Controls.Add(panel1);
            gameIconPanel.Dock = DockStyle.Top;
            gameIconPanel.Location = new Point(0, 24);
            gameIconPanel.Name = "gameIconPanel";
            gameIconPanel.Size = new Size(584, 57);
            gameIconPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(usernameLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 53);
            panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(19, 15);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(94, 22);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "username";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gamesListPanel
            // 
            gamesListPanel.BorderStyle = BorderStyle.Fixed3D;
            gamesListPanel.Dock = DockStyle.Left;
            gamesListPanel.Location = new Point(0, 81);
            gamesListPanel.Name = "gamesListPanel";
            gamesListPanel.Size = new Size(140, 380);
            gamesListPanel.TabIndex = 1;
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
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(584, 461);
            Controls.Add(gamesListPanel);
            Controls.Add(gameIconPanel);
            Controls.Add(menuStrip);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Launcher Menu";
            gameIconPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel gameIconPanel;
        private Panel gamesListPanel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Panel panel1;
        private Label usernameLabel;
    }
}