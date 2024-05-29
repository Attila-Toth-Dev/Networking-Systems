namespace MGC_Application.Forms
{
    partial class PropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertiesForm));
            toolsPanel = new Panel();
            purgeButton = new Button();
            closeButton = new Button();
            toolDescPanel = new Panel();
            configDescTextBox = new TextBox();
            headerPanel = new Panel();
            headerLabel = new Label();
            toolsPanel.SuspendLayout();
            toolDescPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = Color.LightBlue;
            toolsPanel.BorderStyle = BorderStyle.Fixed3D;
            toolsPanel.Controls.Add(purgeButton);
            toolsPanel.Controls.Add(closeButton);
            toolsPanel.Location = new Point(6, 54);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Size = new Size(109, 201);
            toolsPanel.TabIndex = 0;
            // 
            // purgeButton
            // 
            purgeButton.Location = new Point(4, 3);
            purgeButton.Name = "purgeButton";
            purgeButton.Size = new Size(99, 33);
            purgeButton.TabIndex = 1;
            purgeButton.Text = "Purge";
            purgeButton.UseVisualStyleBackColor = true;
            purgeButton.Click += purgeButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(3, 162);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(99, 31);
            closeButton.TabIndex = 0;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // toolDescPanel
            // 
            toolDescPanel.BackColor = Color.LightBlue;
            toolDescPanel.BorderStyle = BorderStyle.Fixed3D;
            toolDescPanel.Controls.Add(configDescTextBox);
            toolDescPanel.Location = new Point(121, 54);
            toolDescPanel.Name = "toolDescPanel";
            toolDescPanel.Size = new Size(156, 201);
            toolDescPanel.TabIndex = 1;
            // 
            // configDescTextBox
            // 
            configDescTextBox.BackColor = Color.LightBlue;
            configDescTextBox.BorderStyle = BorderStyle.None;
            configDescTextBox.Location = new Point(3, 3);
            configDescTextBox.Multiline = true;
            configDescTextBox.Name = "configDescTextBox";
            configDescTextBox.Size = new Size(146, 190);
            configDescTextBox.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.LightBlue;
            headerPanel.BorderStyle = BorderStyle.Fixed3D;
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Location = new Point(6, 7);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(271, 41);
            headerPanel.TabIndex = 2;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(4, 8);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(155, 22);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Game Properties";
            // 
            // PropertiesForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(headerPanel);
            Controls.Add(toolDescPanel);
            Controls.Add(toolsPanel);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "PropertiesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PropertiesForm";
            FormClosed += PropertiesForm_FormClosed;
            toolsPanel.ResumeLayout(false);
            toolDescPanel.ResumeLayout(false);
            toolDescPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel toolsPanel;
        private Button closeButton;
        private Panel toolDescPanel;
        private TextBox configDescTextBox;
        private Panel headerPanel;
        private Label headerLabel;
        private Button purgeButton;
    }
}