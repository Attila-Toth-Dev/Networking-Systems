namespace MGC_Application.Forms
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            backgroundPanel = new Panel();
            cancelButton = new Button();
            passwordLabel = new Label();
            usernameLabel = new Label();
            logoPictureBox = new PictureBox();
            saveButton = new Button();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.BackColor = Color.LightBlue;
            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgroundPanel.Controls.Add(cancelButton);
            backgroundPanel.Controls.Add(passwordLabel);
            backgroundPanel.Controls.Add(usernameLabel);
            backgroundPanel.Controls.Add(logoPictureBox);
            backgroundPanel.Controls.Add(saveButton);
            backgroundPanel.Controls.Add(passwordTextBox);
            backgroundPanel.Controls.Add(usernameTextBox);
            backgroundPanel.Location = new Point(6, 5);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(272, 351);
            backgroundPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(137, 290);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(100, 43);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 225);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 177);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 22);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "Username:";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(83, 25);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(100, 100);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 3;
            logoPictureBox.TabStop = false;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(31, 290);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 43);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(117, 222);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(119, 29);
            passwordTextBox.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(117, 174);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(119, 29);
            usernameTextBox.TabIndex = 0;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(backgroundPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "CreateAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccountForm";
            FormClosed += CreateAccountForm_FormClosed;
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel backgroundPanel;
        private Button saveButton;
        private TextBox passwordTextBox;
        private TextBox usernameTextBox;
        private Button cancelButton;
        private Label passwordLabel;
        private Label usernameLabel;
        private PictureBox logoPictureBox;
    }
}