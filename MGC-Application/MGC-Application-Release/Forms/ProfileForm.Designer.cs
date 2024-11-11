namespace MGC_Application_Release.Forms
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
            ListViewItem listViewItem7 = new ListViewItem("Character");
            ListViewItem listViewItem8 = new ListViewItem("Fish Monster");
            ListViewItem listViewItem9 = new ListViewItem("Goblin Head");
            ListViewItem listViewItem10 = new ListViewItem("Ogre");
            ListViewItem listViewItem11 = new ListViewItem("Overlord");
            ListViewItem listViewItem12 = new ListViewItem("Pirate");
            profileIconPanel = new Panel();
            profileIconPictureBox = new PictureBox();
            profileHeaderPanel = new Panel();
            panel1 = new Panel();
            profileNameLabel = new Label();
            profileBioTextBox = new TextBox();
            returnButton = new Button();
            iconProfile = new Panel();
            profileIconListView = new ListView();
            profileIconPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).BeginInit();
            profileHeaderPanel.SuspendLayout();
            iconProfile.SuspendLayout();
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
            profileIconPictureBox.Image = (Image)resources.GetObject("profileIconPictureBox.Image");
            profileIconPictureBox.Location = new Point(3, 3);
            profileIconPictureBox.Name = "profileIconPictureBox";
            profileIconPictureBox.Size = new Size(146, 146);
            profileIconPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profileIconPictureBox.TabIndex = 0;
            profileIconPictureBox.TabStop = false;
            // 
            // profileHeaderPanel
            // 
            profileHeaderPanel.BackColor = Color.LightBlue;
            profileHeaderPanel.BorderStyle = BorderStyle.Fixed3D;
            profileHeaderPanel.Controls.Add(panel1);
            profileHeaderPanel.Controls.Add(profileNameLabel);
            profileHeaderPanel.Controls.Add(profileBioTextBox);
            profileHeaderPanel.Location = new Point(168, 7);
            profileHeaderPanel.Name = "profileHeaderPanel";
            profileHeaderPanel.Size = new Size(210, 265);
            profileHeaderPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 5;
            // 
            // profileNameLabel
            // 
            profileNameLabel.AutoSize = true;
            profileNameLabel.Location = new Point(3, 3);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(141, 22);
            profileNameLabel.TabIndex = 4;
            profileNameLabel.Text = "usernameLabel";
            // 
            // profileBioTextBox
            // 
            profileBioTextBox.BackColor = Color.LightBlue;
            profileBioTextBox.BorderStyle = BorderStyle.None;
            profileBioTextBox.Location = new Point(3, 31);
            profileBioTextBox.Multiline = true;
            profileBioTextBox.Name = "profileBioTextBox";
            profileBioTextBox.Size = new Size(200, 227);
            profileBioTextBox.TabIndex = 0;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.None;
            returnButton.Location = new Point(3, 62);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(146, 33);
            returnButton.TabIndex = 3;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // iconProfile
            // 
            iconProfile.BackColor = Color.LightBlue;
            iconProfile.BorderStyle = BorderStyle.Fixed3D;
            iconProfile.Controls.Add(profileIconListView);
            iconProfile.Controls.Add(returnButton);
            iconProfile.Location = new Point(6, 170);
            iconProfile.Name = "iconProfile";
            iconProfile.Size = new Size(156, 102);
            iconProfile.TabIndex = 4;
            // 
            // profileIconListView
            // 
            profileIconListView.BackColor = SystemColors.InactiveCaption;
            profileIconListView.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileIconListView.FullRowSelect = true;
            profileIconListView.GridLines = true;
            profileIconListView.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            profileIconListView.Location = new Point(4, 3);
            profileIconListView.Name = "profileIconListView";
            profileIconListView.Size = new Size(145, 53);
            profileIconListView.TabIndex = 4;
            profileIconListView.UseCompatibleStateImageBehavior = false;
            profileIconListView.View = View.SmallIcon;
            profileIconListView.Click += profileIconListView_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(384, 279);
            Controls.Add(iconProfile);
            Controls.Add(profileHeaderPanel);
            Controls.Add(profileIconPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Profile";
            FormClosed += ProfileForm_Closed;
            profileIconPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profileIconPictureBox).EndInit();
            profileHeaderPanel.ResumeLayout(false);
            profileHeaderPanel.PerformLayout();
            iconProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel profileIconPanel;
        private PictureBox profileIconPictureBox;
        private Panel profileHeaderPanel;
        private Button returnButton;
        private Panel iconProfile;
        private TextBox profileBioTextBox;
        private Label profileNameLabel;
        private Panel panel1;
        private ListView profileIconListView;
    }
}