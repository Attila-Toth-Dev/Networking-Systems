namespace MGC_Application.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            profileIconPanel = new Panel();
            profileIconPictureBox = new PictureBox();
            profileHeaderPanel = new Panel();
            returnButton = new Button();
            iconProfile = new Panel();
            buttonPanel = new Panel();
            profileIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).BeginInit();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // profileIconPanel
            // 
            profileIconPanel.BackColor = Color.LightBlue;
            profileIconPanel.BorderStyle = BorderStyle.Fixed3D;
            profileIconPanel.Controls.Add(profileIconPictureBox);
            profileIconPanel.Location = new Point(6, 7);
            profileIconPanel.Name = "profileIconPanel";
            profileIconPanel.Size = new Size(156, 157);
            profileIconPanel.TabIndex = 0;
            // 
            // profileIconPictureBox
            // 
            profileIconPictureBox.Location = new Point(3, 3);
            profileIconPictureBox.Name = "profileIconPictureBox";
            profileIconPictureBox.Size = new Size(146, 146);
            profileIconPictureBox.TabIndex = 0;
            profileIconPictureBox.TabStop = false;
            // 
            // profileHeaderPanel
            // 
            profileHeaderPanel.BackColor = Color.LightBlue;
            profileHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            profileHeaderPanel.Location = new Point(168, 7);
            profileHeaderPanel.Name = "profileHeaderPanel";
            profileHeaderPanel.Size = new Size(210, 448);
            profileHeaderPanel.TabIndex = 2;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.None;
            returnButton.Location = new Point(3, 4);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(146, 50);
            returnButton.TabIndex = 3;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // iconProfile
            // 
            iconProfile.BackColor = Color.LightBlue;
            iconProfile.BorderStyle = BorderStyle.Fixed3D;
            iconProfile.Location = new Point(6, 170);
            iconProfile.Name = "iconProfile";
            iconProfile.Size = new Size(156, 217);
            iconProfile.TabIndex = 4;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.None;
            buttonPanel.BackColor = Color.LightBlue;
            buttonPanel.BorderStyle = BorderStyle.Fixed3D;
            buttonPanel.Controls.Add(returnButton);
            buttonPanel.Location = new Point(6, 393);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(156, 62);
            buttonPanel.TabIndex = 5;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(384, 461);
            Controls.Add(buttonPanel);
            Controls.Add(iconProfile);
            Controls.Add(profileHeaderPanel);
            Controls.Add(profileIconPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Profile";
            FormClosed += ProfileForm_Closed;
            profileIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).EndInit();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel profileIconPanel;
        private PictureBox profileIconPictureBox;
        private Panel profileHeaderPanel;
        private Button returnButton;
        private Panel iconProfile;
        private Panel buttonPanel;
    }
}