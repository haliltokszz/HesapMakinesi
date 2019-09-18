namespace WindowsFormsApp3
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
            this.tabLogSayfasi = new System.Windows.Forms.TabPage();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListView();
            this.tabHesaplamaSayfasi = new System.Windows.Forms.TabPage();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.tabHesapla = new System.Windows.Forms.TabControl();
            this.tabLogSayfasi.SuspendLayout();
            this.tabHesaplamaSayfasi.SuspendLayout();
            this.tabHesapla.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLogSayfasi
            // 
            this.tabLogSayfasi.Controls.Add(this.btnTemizle);
            this.tabLogSayfasi.Controls.Add(this.btnGeri);
            this.tabLogSayfasi.Controls.Add(this.listLog);
            this.tabLogSayfasi.Location = new System.Drawing.Point(4, 25);
            this.tabLogSayfasi.Name = "tabLogSayfasi";
            this.tabLogSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogSayfasi.Size = new System.Drawing.Size(394, 333);
            this.tabLogSayfasi.TabIndex = 1;
            this.tabLogSayfasi.Text = "Log";
            this.tabLogSayfasi.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(211, 289);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(86, 37);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(79, 289);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(73, 37);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listLog
            // 
            this.listLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.listLog.GridLines = true;
            this.listLog.HideSelection = false;
            this.listLog.Location = new System.Drawing.Point(0, 0);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(394, 283);
            this.listLog.TabIndex = 0;
            this.listLog.UseCompatibleStateImageBehavior = false;
            this.listLog.View = System.Windows.Forms.View.Details;
            // 
            // tabHesaplamaSayfasi
            // 
            this.tabHesaplamaSayfasi.Controls.Add(this.btnBol);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnCarpma);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnCikarma);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnİleri);
            this.tabHesaplamaSayfasi.Controls.Add(this.txtSonuc);
            this.tabHesaplamaSayfasi.Controls.Add(this.txtSayi2);
            this.tabHesaplamaSayfasi.Controls.Add(this.txtSayi1);
            this.tabHesaplamaSayfasi.Controls.Add(this.lblSonuc);
            this.tabHesaplamaSayfasi.Controls.Add(this.lblSayi2);
            this.tabHesaplamaSayfasi.Controls.Add(this.lblSayi1);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnTopla);
            this.tabHesaplamaSayfasi.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabHesaplamaSayfasi.Location = new System.Drawing.Point(4, 25);
            this.tabHesaplamaSayfasi.Name = "tabHesaplamaSayfasi";
            this.tabHesaplamaSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabHesaplamaSayfasi.Size = new System.Drawing.Size(394, 333);
            this.tabHesaplamaSayfasi.TabIndex = 0;
            this.tabHesaplamaSayfasi.Text = "Hesapla";
            this.tabHesaplamaSayfasi.UseVisualStyleBackColor = true;
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(217, 170);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(76, 39);
            this.btnBol.TabIndex = 17;
            this.btnBol.Text = "÷";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(97, 170);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(82, 39);
            this.btnCarpma.TabIndex = 16;
            this.btnCarpma.Text = "x";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(217, 101);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(76, 40);
            this.btnCikarma.TabIndex = 15;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.Location = new System.Drawing.Point(157, 284);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 30);
            this.btnİleri.TabIndex = 14;
            this.btnİleri.Text = "İleri";
            this.btnİleri.UseVisualStyleBackColor = true;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(193, 229);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ReadOnly = true;
            this.txtSonuc.Size = new System.Drawing.Size(100, 22);
            this.txtSonuc.TabIndex = 12;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(193, 60);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 9;
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(193, 16);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 7;
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi1_KeyPress);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(105, 232);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(52, 17);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(94, 65);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(74, 17);
            this.lblSayi2.TabIndex = 10;
            this.lblSayi2.Text = "İkinci Sayı:";
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(94, 21);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(56, 17);
            this.lblSayi1.TabIndex = 8;
            this.lblSayi1.Text = "İlk Sayı:";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(97, 101);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(82, 40);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // tabHesapla
            // 
            this.tabHesapla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHesapla.Controls.Add(this.tabHesaplamaSayfasi);
            this.tabHesapla.Controls.Add(this.tabLogSayfasi);
            this.tabHesapla.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabHesapla.Location = new System.Drawing.Point(0, 1);
            this.tabHesapla.Name = "tabHesapla";
            this.tabHesapla.SelectedIndex = 0;
            this.tabHesapla.Size = new System.Drawing.Size(402, 362);
            this.tabHesapla.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 363);
            this.Controls.Add(this.tabHesapla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabLogSayfasi.ResumeLayout(false);
            this.tabHesaplamaSayfasi.ResumeLayout(false);
            this.tabHesaplamaSayfasi.PerformLayout();
            this.tabHesapla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabLogSayfasi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listLog;
        private System.Windows.Forms.TabPage tabHesaplamaSayfasi;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TabControl tabHesapla;
    }
}

