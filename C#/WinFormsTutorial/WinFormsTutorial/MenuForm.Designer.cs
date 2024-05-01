namespace WinFormsTutorial
{
    partial class MenuForm
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
            titleLabel = new Label();
            stringInputLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(218, 109);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Menu Form";
            // 
            // stringInputLabel
            // 
            stringInputLabel.AutoSize = true;
            stringInputLabel.Location = new Point(218, 166);
            stringInputLabel.Name = "stringInputLabel";
            stringInputLabel.Size = new Size(0, 25);
            stringInputLabel.TabIndex = 1;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(stringInputLabel);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Launcher Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label stringInputLabel;
    }
}