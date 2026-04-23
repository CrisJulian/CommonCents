namespace WinFormsApp1
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
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(139, 33);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 28, 38);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(507, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 249);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(24, 28, 38);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 25F);
            textBox2.Location = new Point(38, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 45);
            textBox2.TabIndex = 4;
            textBox2.Text = "asdffasdf";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 28, 38);
            panel1.Controls.Add(textBox1);
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(29, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 249);
            panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(24, 28, 38);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 25F);
            textBox1.Location = new Point(38, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 45);
            textBox1.TabIndex = 4;
            textBox1.Text = "asdffasdf";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 28, 38);
            panel3.Location = new Point(207, 351);
            panel3.Name = "panel3";
            panel3.Size = new Size(451, 258);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 28, 38);
            panel4.Location = new Point(685, 351);
            panel4.Name = "panel4";
            panel4.Size = new Size(436, 258);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 22, 31);
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(182, 649);
            panel5.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(15, 17, 23);
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel1);
            panel6.Location = new Point(177, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(973, 649);
            panel6.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(15, 17, 23);
            panel7.Controls.Add(textBox4);
            panel7.Controls.Add(textBox3);
            panel7.ForeColor = Color.CornflowerBlue;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(969, 47);
            panel7.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(24, 28, 38);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 25F);
            textBox3.Location = new Point(38, 43);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(280, 45);
            textBox3.TabIndex = 4;
            textBox3.Text = "asdffasdf";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(24, 28, 38);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 20F);
            textBox4.Location = new Point(17, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 36);
            textBox4.TabIndex = 5;
            textBox4.Text = "asdffasdf";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 651);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(panel6);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
