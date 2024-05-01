namespace IntroWinForms
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 74);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 123);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(337, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 172);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(337, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 222);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // button1
            // 
            button1.Location = new Point(337, 379);
            button1.Name = "button1";
            button1.Size = new Size(232, 59);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(337, 323);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(232, 23);
            progressBar1.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(337, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 23);
            textBox4.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(337, 266);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 520);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private ProgressBar progressBar1;
        private TextBox textBox4;
        private CheckBox checkBox1;
    }
}
