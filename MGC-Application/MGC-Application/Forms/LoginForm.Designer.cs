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
            clearFieldsLabel = new Label();
            createAccountButton = new Button();
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
            usernameTextBox.Location = new Point(198, 150);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 29);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(76, 153);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 22);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(198, 293);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 40);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(198, 246);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(200, 29);
            serverIpTextBox.TabIndex = 3;
            serverIpTextBox.TextAlign = HorizontalAlignment.Center;
            serverIpTextBox.TextChanged += serverIpTextBox_TextChanged;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(76, 249);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(110, 22);
            serverIpLabel.TabIndex = 8;
            serverIpLabel.Text = "IP Address:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(198, 197);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 29);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(76, 200);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password:";
            // 
            // backgroundPanel
            // 
            backgroundPanel.BorderStyle = BorderStyle.Fixed3D;
            backgroundPanel.Controls.Add(clearFieldsLabel);
            backgroundPanel.Controls.Add(createAccountButton);
            backgroundPanel.Controls.Add(loginButton);
            backgroundPanel.Controls.Add(passwordLabel);
            backgroundPanel.Controls.Add(passwordTextBox);
            backgroundPanel.Controls.Add(serverIpLabel);
            backgroundPanel.Controls.Add(passwordPictureBox);
            backgroundPanel.Controls.Add(serverIpTextBox);
            backgroundPanel.Controls.Add(usernameTextBox);
            backgroundPanel.Controls.Add(usernameLabel);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.Size = new Size(584, 361);
            backgroundPanel.TabIndex = 11;
            // 
            // clearFieldsLabel
            // 
            clearFieldsLabel.AutoSize = true;
            clearFieldsLabel.Location = new Point(404, 249);
            clearFieldsLabel.Name = "clearFieldsLabel";
            clearFieldsLabel.Size = new Size(112, 22);
            clearFieldsLabel.TabIndex = 11;
            clearFieldsLabel.Text = "Clear Fields";
            clearFieldsLabel.Click += clearFieldsLabel_Click;
            // 
            // createAccountButton
            // 
            createAccountButton.Location = new Point(304, 293);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(94, 40);
            createAccountButton.TabIndex = 5;
            createAccountButton.Text = "Create";
            createAccountButton.UseVisualStyleBackColor = true;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = (Image)resources.GetObject("passwordPictureBox.Image");
            passwordPictureBox.Location = new Point(404, 197);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(30, 30);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPictureBox.TabIndex = 0;
            passwordPictureBox.TabStop = false;
            passwordPictureBox.MouseDown += passwordPictureBox_MouseDown;
            passwordPictureBox.MouseUp += passwordPictureBox_MouseUp;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 361);
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
        private Button createAccountButton;
        private Label clearFieldsLabel;
    }
}