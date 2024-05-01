namespace MGC_Launcher
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pnl_gameList = new Panel();
            lbl_gameList = new Label();
            pnl_gameHeader = new Panel();
            pnl_gameList.SuspendLayout();
            pnl_gameHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_gameList
            // 
            pnl_gameList.BorderStyle = BorderStyle.Fixed3D;
            pnl_gameList.Controls.Add(pnl_gameHeader);
            pnl_gameList.Dock = DockStyle.Left;
            pnl_gameList.Location = new Point(0, 0);
            pnl_gameList.Name = "pnl_gameList";
            pnl_gameList.Size = new Size(200, 450);
            pnl_gameList.TabIndex = 0;
            // 
            // lbl_gameList
            // 
            lbl_gameList.AutoSize = true;
            lbl_gameList.Location = new Point(80, 26);
            lbl_gameList.Name = "lbl_gameList";
            lbl_gameList.Size = new Size(46, 15);
            lbl_gameList.TabIndex = 0;
            lbl_gameList.Text = "GAMES";
            // 
            // pnl_gameHeader
            // 
            pnl_gameHeader.BorderStyle = BorderStyle.Fixed3D;
            pnl_gameHeader.Controls.Add(lbl_gameList);
            pnl_gameHeader.Dock = DockStyle.Top;
            pnl_gameHeader.Location = new Point(0, 0);
            pnl_gameHeader.Name = "pnl_gameHeader";
            pnl_gameHeader.Size = new Size(196, 75);
            pnl_gameHeader.TabIndex = 0;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_gameList);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC-Launcher";
            pnl_gameList.ResumeLayout(false);
            pnl_gameHeader.ResumeLayout(false);
            pnl_gameHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_gameList;
        private Panel pnl_gameHeader;
        private Label lbl_gameList;
    }
}