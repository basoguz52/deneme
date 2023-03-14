namespace Diziler
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "kisiler[]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Yazdır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "sayilar[]";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 5;
            this.button3.Text = "Yazdır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "ondalıklı sayılar[]";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "Yazdır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "harfler[]";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 41);
            this.button5.TabIndex = 9;
            this.button5.Text = "Bastır";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 34;
            this.listBox1.Location = new System.Drawing.Point(400, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 174);
            this.listBox1.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(570, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 41);
            this.button6.TabIndex = 11;
            this.button6.Text = "Bastır";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(509, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 41);
            this.button7.TabIndex = 12;
            this.button7.Text = "Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(448, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(177, 41);
            this.button8.TabIndex = 13;
            this.button8.Text = "Ödev";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 34;
            this.listBox2.Location = new System.Drawing.Point(704, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(273, 174);
            this.listBox2.TabIndex = 14;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(752, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(177, 41);
            this.button9.TabIndex = 18;
            this.button9.Text = "For Each";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(813, 211);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 41);
            this.button10.TabIndex = 17;
            this.button10.Text = "Sil";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(874, 211);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 41);
            this.button11.TabIndex = 16;
            this.button11.Text = "Bastır";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(704, 211);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(103, 41);
            this.button12.TabIndex = 15;
            this.button12.Text = "Bastır";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 364);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

