namespace SinemaBufe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmisir = new System.Windows.Forms.TextBox();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbilet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkasa = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.txtbilet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmisir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mısır:";
            // 
            // txtmisir
            // 
            this.txtmisir.Location = new System.Drawing.Point(125, 61);
            this.txtmisir.Name = "txtmisir";
            this.txtmisir.Size = new System.Drawing.Size(160, 29);
            this.txtmisir.TabIndex = 1;
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(125, 106);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(160, 29);
            this.txtsu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Su:";
            // 
            // txtcay
            // 
            this.txtcay.Location = new System.Drawing.Point(125, 157);
            this.txtcay.Name = "txtcay";
            this.txtcay.Size = new System.Drawing.Size(160, 29);
            this.txtcay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Çay:";
            // 
            // txtbilet
            // 
            this.txtbilet.Location = new System.Drawing.Point(125, 208);
            this.txtbilet.Name = "txtbilet";
            this.txtbilet.Size = new System.Drawing.Size(160, 29);
            this.txtbilet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bilet:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(404, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Tablosu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bilet: 8TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Çay: 2TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Su: 1 TL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mısır: 4TL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lblkasa);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbltoplam);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(649, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 302);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Toplam:";
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(150, 69);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(49, 21);
            this.lbltoplam.TabIndex = 8;
            this.lbltoplam.Text = "00 TL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.Location = new System.Drawing.Point(37, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(416, 48);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sinema Büfe Satış Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(50, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 109);
            this.panel1.TabIndex = 9;
            // 
            // lblkasa
            // 
            this.lblkasa.AutoSize = true;
            this.lblkasa.Location = new System.Drawing.Point(150, 237);
            this.lblkasa.Name = "lblkasa";
            this.lblkasa.Size = new System.Drawing.Size(49, 21);
            this.lblkasa.TabIndex = 11;
            this.lblkasa.Text = "00 TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Kasa:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1038, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Büfe Sinema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbilet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmisir;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblkasa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}

