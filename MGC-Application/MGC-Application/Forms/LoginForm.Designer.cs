namespace MGC_Application
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            logoPictureBox = new PictureBox();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            loginButton = new Button();
            serverIpTextBox = new TextBox();
            serverIpLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            backgroundPanel = new Panel();
            directoryTextBox = new TextBox();
            passwordPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = (Image)resources.GetObject("logoPictureBox.Image");
            logoPictureBox.Location = new Point(250, 30);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(100, 100);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(200, 145);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 29);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(66, 152);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 22);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(250, 290);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(200, 242);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(200, 29);
            serverIpTextBox.TabIndex = 3;
            serverIpTextBox.TextAlign = HorizontalAlignment.Center;
            serverIpTextBox.TextChanged += serverIpTextBox_TextChanged;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(66, 245);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(115, 22);
            serverIpLabel.TabIndex = 8;
            serverIpLabel.Text = "IP/Directory:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(200, 194);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 29);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(66, 197);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // backgroundPanel
            // 
            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgroundPanel.Controls.Add(directoryTextBox);
            backgroundPanel.Controls.Add(passwordPictureBox);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(584, 361);
            backgroundPanel.TabIndex = 11;
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(404, 240);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(100, 29);
            directoryTextBox.TabIndex = 4;
            directoryTextBox.TextAlign = HorizontalAlignment.Center;
            directoryTextBox.TextChanged += directoryTextBox_TextChanged;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = (Image)resources.GetObject("passwordPictureBox.Image");
            passwordPictureBox.Location = new Point(404, 192);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(30, 30);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPictureBox.TabIndex = 0;
            passwordPictureBox.TabStop = false;
            passwordPictureBox.MouseDown += passwordPitureBox_MouseDown;
            passwordPictureBox.MouseUp += passwordPitureBox_MouseUp;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 361);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(serverIpLabel);
            Controls.Add(serverIpTextBox);
            Controls.Add(loginButton);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(logoPictureBox);
            Controls.Add(backgroundPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC-Launcher Login";
            FormClosed += LoginForm_Closed;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            backgroundPanel.ResumeLayout(false);
            backgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoPictureBox;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Button loginButton;
        private TextBox serverIpTextBox;
        private Label serverIpLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Panel backgroundPanel;
        private PictureBox passwordPictureBox;
        private TextBox directoryTextBox;
    }
}