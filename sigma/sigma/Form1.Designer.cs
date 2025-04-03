namespace sigma
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
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(56, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "opc.tcp://192.168.15.99:4840";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(596, 31);
            button1.Name = "button1";
            button1.Size = new Size(119, 43);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(596, 108);
            button2.Name = "button2";
            button2.Size = new Size(119, 43);
            button2.TabIndex = 2;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(56, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 43);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(159, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(387, 43);
            textBox2.TabIndex = 4;
            textBox2.Text = "ns=4;i=2";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(36, 239);
            label1.Name = "label1";
            label1.Size = new Size(116, 37);
            label1.TabIndex = 5;
            label1.Text = "NodelID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(56, 349);
            label2.Name = "label2";
            label2.Size = new Size(82, 37);
            label2.TabIndex = 7;
            label2.Text = "Value";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20F);
            textBox3.Location = new Point(159, 346);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 43);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(596, 239);
            button3.Name = "button3";
            button3.Size = new Size(119, 43);
            button3.TabIndex = 8;
            button3.Text = "Read Value";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(596, 343);
            button4.Name = "button4";
            button4.Size = new Size(119, 43);
            button4.TabIndex = 9;
            button4.Text = "Daj suba";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(36, 426);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(679, 194);
            cartesianChart1.TabIndex = 11;
            cartesianChart1.Text = "cartesianChart2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 660);
            Controls.Add(cartesianChart1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}
