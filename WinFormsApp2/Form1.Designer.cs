namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            zielony = new RadioButton();
            czerwony = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            zielony1 = new RadioButton();
            czerwony1 = new RadioButton();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            copy = new CheckBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(zielony);
            groupBox1.Controls.Add(czerwony);
            groupBox1.Location = new Point(45, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // zielony
            // 
            zielony.AutoSize = true;
            zielony.Location = new Point(6, 23);
            zielony.Name = "zielony";
            zielony.Size = new Size(62, 19);
            zielony.TabIndex = 4;
            zielony.TabStop = true;
            zielony.Text = "zielony";
            zielony.UseVisualStyleBackColor = true;
            zielony.CheckedChanged += zielony_CheckedChanged;
            // 
            // czerwony
            // 
            czerwony.AutoSize = true;
            czerwony.Location = new Point(6, 59);
            czerwony.Name = "czerwony";
            czerwony.Size = new Size(75, 19);
            czerwony.TabIndex = 6;
            czerwony.TabStop = true;
            czerwony.Text = "czerwony";
            czerwony.UseVisualStyleBackColor = true;
            czerwony.CheckedChanged += czerwony_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(313, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(313, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(82, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(313, 109);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // zielony1
            // 
            zielony1.AutoSize = true;
            zielony1.Location = new Point(6, 22);
            zielony1.Name = "zielony1";
            zielony1.Size = new Size(62, 19);
            zielony1.TabIndex = 5;
            zielony1.TabStop = true;
            zielony1.Text = "zielony";
            zielony1.UseVisualStyleBackColor = true;
            // 
            // czerwony1
            // 
            czerwony1.AutoSize = true;
            czerwony1.Location = new Point(6, 56);
            czerwony1.Name = "czerwony1";
            czerwony1.Size = new Size(75, 19);
            czerwony1.TabIndex = 7;
            czerwony1.TabStop = true;
            czerwony1.Text = "czerwony";
            czerwony1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(zielony1);
            groupBox2.Controls.Add(czerwony1);
            groupBox2.Location = new Point(45, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(476, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(633, 63);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(475, 107);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // copy
            // 
            copy.AutoSize = true;
            copy.Location = new Point(475, 26);
            copy.Name = "copy";
            copy.Size = new Size(52, 19);
            copy.TabIndex = 12;
            copy.Text = "copy";
            copy.UseVisualStyleBackColor = true;
            copy.CheckedChanged += copy_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(633, 105);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(copy);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "`";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private RadioButton zielony;
        private RadioButton zielony1;
        private RadioButton czerwony;
        private RadioButton czerwony1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private CheckBox copy;
        private Button button2;
    }
}
