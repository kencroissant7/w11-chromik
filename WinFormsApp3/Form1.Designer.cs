namespace WinFormsApp3
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
            textBox1 = new TextBox();
            otworz = new Button();
            otworz2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 0;
            // 
            // otworz
            // 
            otworz.Location = new Point(312, 40);
            otworz.Name = "otworz";
            otworz.Size = new Size(116, 23);
            otworz.TabIndex = 1;
            otworz.Text = "otworz";
            otworz.UseVisualStyleBackColor = true;
            otworz.Click += otworz_Click;
            // 
            // otworz2
            // 
            otworz2.Location = new Point(312, 85);
            otworz2.Name = "otworz2";
            otworz2.Size = new Size(116, 23);
            otworz2.TabIndex = 2;
            otworz2.Text = "otworz z filtrem";
            otworz2.UseVisualStyleBackColor = true;
            otworz2.Click += otworz2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(312, 127);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 3;
            button3.Text = "wyslij email";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 585);
            Controls.Add(button3);
            Controls.Add(otworz2);
            Controls.Add(otworz);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button otworz;
        private Button otworz2;
        private Button button3;
    }
}
