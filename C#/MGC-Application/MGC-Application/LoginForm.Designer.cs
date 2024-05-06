﻿namespace MGC_Application
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
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            signUpButton = new Button();
            serverIpTextBox = new TextBox();
            serverIpLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
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
            usernameTextBox.Location = new Point(200, 155);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 29);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(200, 205);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 29);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextAlign = HorizontalAlignment.Center;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(66, 158);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 22);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(64, 208);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(200, 309);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(300, 309);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(100, 40);
            signUpButton.TabIndex = 6;
            signUpButton.Text = "Sign-Up";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(200, 252);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(200, 29);
            serverIpTextBox.TabIndex = 3;
            serverIpTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(64, 255);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(95, 22);
            serverIpLabel.TabIndex = 8;
            serverIpLabel.Text = "Server IP:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 361);
            Controls.Add(serverIpLabel);
            Controls.Add(serverIpTextBox);
            Controls.Add(signUpButton);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(logoPictureBox);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MGC Launcher Login";
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoPictureBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Button signUpButton;
        private TextBox serverIpTextBox;
        private Label serverIpLabel;
    }
}