namespace FTP_Tutorial
{
    partial class FTP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            serverLabel = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            serverTextBox = new TextBox();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            connectButton = new Button();
            SuspendLayout();
            // 
            // serverLabel
            // 
            serverLabel.AutoSize = true;
            serverLabel.Location = new Point(45, 40);
            serverLabel.Name = "serverLabel";
            serverLabel.Size = new Size(71, 22);
            serverLabel.TabIndex = 0;
            serverLabel.Text = "Server:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(45, 88);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(107, 22);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "User name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(45, 137);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 22);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // serverTextBox
            // 
            serverTextBox.Location = new Point(161, 37);
            serverTextBox.Name = "serverTextBox";
            serverTextBox.Size = new Size(324, 29);
            serverTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(161, 85);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(324, 29);
            usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(161, 134);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(324, 29);
            passwordTextBox.TabIndex = 5;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(190, 200);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(176, 59);
            connectButton.TabIndex = 6;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // FTP
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 290);
            Controls.Add(connectButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(serverTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(serverLabel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FTP-Tutorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label serverLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox serverTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button connectButton;
    }
}
