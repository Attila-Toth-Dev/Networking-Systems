namespace MGC_Launcher
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pb_logo = new PictureBox();
            lbl_loginHeader = new Label();
            btn_login = new Button();
            txb_username = new TextBox();
            txb_password = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            lbl_clearfields = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_logo).BeginInit();
            SuspendLayout();
            // 
            // pb_logo
            // 
            pb_logo.Image = (Image)resources.GetObject("pb_logo.Image");
            pb_logo.Location = new Point(143, 83);
            pb_logo.Name = "pb_logo";
            pb_logo.Size = new Size(100, 50);
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pb_logo.TabIndex = 0;
            pb_logo.TabStop = false;
            // 
            // lbl_loginHeader
            // 
            lbl_loginHeader.AutoSize = true;
            lbl_loginHeader.Location = new Point(176, 150);
            lbl_loginHeader.Name = "lbl_loginHeader";
            lbl_loginHeader.Size = new Size(42, 15);
            lbl_loginHeader.TabIndex = 1;
            lbl_loginHeader.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(155, 365);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txb_username
            // 
            txb_username.Location = new Point(143, 211);
            txb_username.Name = "txb_username";
            txb_username.Size = new Size(100, 23);
            txb_username.TabIndex = 3;
            txb_username.TextChanged += txb_username_TextChanged;
            // 
            // txb_password
            // 
            txb_password.Location = new Point(143, 262);
            txb_password.Name = "txb_password";
            txb_password.Size = new Size(100, 23);
            txb_password.TabIndex = 4;
            txb_password.TextChanged += txb_password_TextChanged;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(67, 214);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(62, 15);
            lbl_username.TabIndex = 5;
            lbl_username.Text = "username:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(67, 265);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(63, 15);
            lbl_password.TabIndex = 6;
            lbl_password.Text = " password:";
            // 
            // lbl_clearfields
            // 
            lbl_clearfields.AutoSize = true;
            lbl_clearfields.Location = new Point(167, 305);
            lbl_clearfields.Name = "lbl_clearfields";
            lbl_clearfields.Size = new Size(63, 15);
            lbl_clearfields.TabIndex = 7;
            lbl_clearfields.Text = "clear fields";
            lbl_clearfields.Click += lbl_clearfields_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 461);
            Controls.Add(lbl_clearfields);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(txb_password);
            Controls.Add(txb_username);
            Controls.Add(btn_login);
            Controls.Add(lbl_loginHeader);
            Controls.Add(pb_logo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pb_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_logo;
        private Label lbl_loginHeader;
        private Button btn_login;
        private TextBox txb_username;
        private TextBox txb_password;
        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_clearfields;
    }
}
