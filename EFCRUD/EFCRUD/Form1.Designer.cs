namespace EFCRUD
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(15, 238);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(111, 39);
            this.btnkaydet.TabIndex = 0;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(143, 238);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(111, 39);
            this.btnsil.TabIndex = 0;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(268, 238);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(111, 39);
            this.btntemizle.TabIndex = 0;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meslek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yaş:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(129, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(189, 32);
            this.txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(129, 71);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(189, 32);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(129, 108);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(189, 32);
            this.txtMeslek.TabIndex = 2;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(129, 145);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(189, 32);
            this.txtYas.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 246);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(806, 342);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtMeslek);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkaydet);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

