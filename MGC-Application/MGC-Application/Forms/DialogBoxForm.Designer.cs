namespace MGC_Application.Forms
{
    partial class DialogBoxForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBoxForm));
            messageTextBox = new TextBox();
            okayButton = new Button();
            noButton = new Button();
            yesButton = new Button();
            dialogTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.BackColor = SystemColors.Menu;
            messageTextBox.Enabled = false;
            messageTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageTextBox.Location = new Point(6, 7);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(272, 104);
            messageTextBox.TabIndex = 3;
            messageTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // okayButton
            // 
            okayButton.Anchor = AnchorStyles.Left;
            okayButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            okayButton.Location = new Point(198, 116);
            okayButton.Name = "okayButton";
            okayButton.Size = new Size(75, 31);
            okayButton.TabIndex = 0;
            okayButton.Text = "OK";
            okayButton.UseVisualStyleBackColor = true;
            okayButton.Click += okayButton_Click;
            // 
            // noButton
            // 
            noButton.Anchor = AnchorStyles.Left;
            noButton.Font = new Font("Arial", 12F);
            noButton.Location = new Point(92, 116);
            noButton.Name = "noButton";
            noButton.Size = new Size(75, 31);
            noButton.TabIndex = 2;
            noButton.Text = "NO";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // yesButton
            // 
            yesButton.Anchor = AnchorStyles.Left;
            yesButton.Font = new Font("Arial", 12F);
            yesButton.Location = new Point(11, 116);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(75, 31);
            yesButton.TabIndex = 1;
            yesButton.Text = "YES";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // DialogBoxForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 151);
            Controls.Add(yesButton);
            Controls.Add(messageTextBox);
            Controls.Add(noButton);
            Controls.Add(okayButton);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "DialogBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogBoxForm";
            FormClosed += DialogBoxForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox messageTextBox;
        private Button okayButton;
        private Button noButton;
        private Button yesButton;
        private System.Windows.Forms.Timer dialogTimer;
    }
}