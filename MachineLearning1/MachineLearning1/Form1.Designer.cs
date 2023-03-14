namespace MachineLearning1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "teta0:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 31);
            this.textBox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "teta1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(222, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 204);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(320, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(91, 204);
            this.listBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "h(x):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "h(x) - y:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(417, 49);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(91, 204);
            this.listBox3.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "(h(x) - y)^2:";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 25;
            this.listBox4.Location = new System.Drawing.Point(514, 49);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(123, 204);
            this.listBox4.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "t0,           t1        =         J( t0, t1):\r\n";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.HorizontalScrollbar = true;
            this.listBox5.ItemHeight = 25;
            this.listBox5.Location = new System.Drawing.Point(16, 297);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(610, 204);
            this.listBox5.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(953, 526);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox5;
    }
}

