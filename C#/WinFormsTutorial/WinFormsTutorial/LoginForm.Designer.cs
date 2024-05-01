namespace WinFormsTutorial
{
    partial class LoginForm
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            sayHelloButton = new Button();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            welcomeLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(37, 123);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(154, 120);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(182, 33);
            firstNameTextBox.TabIndex = 1;
            // 
            // sayHelloButton
            // 
            sayHelloButton.Location = new Point(171, 251);
            sayHelloButton.Name = "sayHelloButton";
            sayHelloButton.Size = new Size(138, 66);
            sayHelloButton.TabIndex = 3;
            sayHelloButton.Text = " Say Hello!";
            sayHelloButton.UseVisualStyleBackColor = true;
            sayHelloButton.Click += sayHelloButton_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(154, 179);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(182, 33);
            lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(37, 182);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 25);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(194, 61);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(95, 25);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(welcomeLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(sayHelloButton);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Button sayHelloButton;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private Label welcomeLabel;
    }
}
