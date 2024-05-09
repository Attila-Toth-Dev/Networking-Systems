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
            usernameTextBox.Location = new Point(200, 162);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 29);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextAlign = HorizontalAlignment.Center;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(66, 165);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 22);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(250, 277);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(100, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // serverIpTextBox
            // 
            serverIpTextBox.Location = new Point(200, 215);
            serverIpTextBox.Name = "serverIpTextBox";
            serverIpTextBox.Size = new Size(200, 29);
            serverIpTextBox.TabIndex = 3;
            serverIpTextBox.TextAlign = HorizontalAlignment.Center;
            serverIpTextBox.TextChanged += serverIpTextBox_TextChanged;
            // 
            // serverIpLabel
            // 
            serverIpLabel.AutoSize = true;
            serverIpLabel.Location = new Point(89, 218);
            serverIpLabel.Name = "serverIpLabel";
            serverIpLabel.Size = new Size(74, 22);
            serverIpLabel.TabIndex = 8;
            serverIpLabel.Text = "IP/Port:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(584, 361);
            Controls.Add(serverIpLabel);
            Controls.Add(serverIpTextBox);
            Controls.Add(loginButton);
            Controls.Add(usernameLabel);
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
            FormClosed += LoginForm_Closed;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
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
    }
}