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
            this.btnSayi1 = new System.Windows.Forms.Button();
            this.btnSayi2 = new System.Windows.Forms.Button();
            this.btnSayi3 = new System.Windows.Forms.Button();
            this.btnSayi4 = new System.Windows.Forms.Button();
            this.btnSayi6 = new System.Windows.Forms.Button();
            this.btnSayi5 = new System.Windows.Forms.Button();
            this.btnSayi7 = new System.Windows.Forms.Button();
            this.btnSayi8 = new System.Windows.Forms.Button();
            this.btnSayi9 = new System.Windows.Forms.Button();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.btnSayi0 = new System.Windows.Forms.Button();
            this.btnTextboxTemizle = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnİleri = new System.Windows.Forms.Button();
            this.txtSonucEkrani = new System.Windows.Forms.TextBox();
            this.txtSayiEkrani = new System.Windows.Forms.TextBox();
            this.tabHesapla = new System.Windows.Forms.TabControl();
            this.btnTopla = new System.Windows.Forms.Button();
            this.tabLogSayfasi.SuspendLayout();
            this.tabHesaplamaSayfasi.SuspendLayout();
            this.tabHesapla.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLogSayfasi
            // 
            this.tabLogSayfasi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabLogSayfasi.Controls.Add(this.btnTemizle);
            this.tabLogSayfasi.Controls.Add(this.btnGeri);
            this.tabLogSayfasi.Controls.Add(this.listLog);
            this.tabLogSayfasi.Location = new System.Drawing.Point(4, 25);
            this.tabLogSayfasi.Name = "tabLogSayfasi";
            this.tabLogSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogSayfasi.Size = new System.Drawing.Size(236, 333);
            this.tabLogSayfasi.TabIndex = 1;
            this.tabLogSayfasi.Text = "Log";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Honeydew;
            this.btnTemizle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTemizle.Location = new System.Drawing.Point(146, 288);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(86, 37);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Honeydew;
            this.btnGeri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGeri.Location = new System.Drawing.Point(8, 289);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(73, 37);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.Color.Honeydew;
            this.listLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.listLog.GridLines = true;
            this.listLog.HideSelection = false;
            this.listLog.Location = new System.Drawing.Point(0, 0);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(238, 283);
            this.listLog.TabIndex = 0;
            this.listLog.UseCompatibleStateImageBehavior = false;
            this.listLog.View = System.Windows.Forms.View.Details;
            // 
            // tabHesaplamaSayfasi
            // 
            this.tabHesaplamaSayfasi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabHesaplamaSayfasi.Controls.Add(this.btnTopla);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi1);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi2);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi3);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi4);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi6);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi5);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi7);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi8);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi9);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnVirgul);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnSayi0);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnTextboxTemizle);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnBol);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnCarpma);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnCikarma);
            this.tabHesaplamaSayfasi.Controls.Add(this.btnİleri);
            this.tabHesaplamaSayfasi.Controls.Add(this.txtSonucEkrani);
            this.tabHesaplamaSayfasi.Controls.Add(this.txtSayiEkrani);
            this.tabHesaplamaSayfasi.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabHesaplamaSayfasi.Location = new System.Drawing.Point(4, 25);
            this.tabHesaplamaSayfasi.Name = "tabHesaplamaSayfasi";
            this.tabHesaplamaSayfasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabHesaplamaSayfasi.Size = new System.Drawing.Size(236, 333);
            this.tabHesaplamaSayfasi.TabIndex = 0;
            this.tabHesaplamaSayfasi.Text = "Hesapla";
            // 
            // btnSayi1
            // 
            this.btnSayi1.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi1.Location = new System.Drawing.Point(8, 109);
            this.btnSayi1.Name = "btnSayi1";
            this.btnSayi1.Size = new System.Drawing.Size(43, 40);
            this.btnSayi1.TabIndex = 30;
            this.btnSayi1.Text = "1";
            this.btnSayi1.UseVisualStyleBackColor = false;
            this.btnSayi1.Click += new System.EventHandler(this.btnSayi1_Click);
            // 
            // btnSayi2
            // 
            this.btnSayi2.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi2.Location = new System.Drawing.Point(64, 109);
            this.btnSayi2.Name = "btnSayi2";
            this.btnSayi2.Size = new System.Drawing.Size(43, 40);
            this.btnSayi2.TabIndex = 29;
            this.btnSayi2.Text = "2";
            this.btnSayi2.UseVisualStyleBackColor = false;
            this.btnSayi2.Click += new System.EventHandler(this.btnSayi2_Click);
            // 
            // btnSayi3
            // 
            this.btnSayi3.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi3.Location = new System.Drawing.Point(122, 110);
            this.btnSayi3.Name = "btnSayi3";
            this.btnSayi3.Size = new System.Drawing.Size(43, 39);
            this.btnSayi3.TabIndex = 28;
            this.btnSayi3.Text = "3";
            this.btnSayi3.UseVisualStyleBackColor = false;
            this.btnSayi3.Click += new System.EventHandler(this.btnSayi3_Click);
            // 
            // btnSayi4
            // 
            this.btnSayi4.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi4.Location = new System.Drawing.Point(8, 156);
            this.btnSayi4.Name = "btnSayi4";
            this.btnSayi4.Size = new System.Drawing.Size(43, 39);
            this.btnSayi4.TabIndex = 27;
            this.btnSayi4.Text = "4";
            this.btnSayi4.UseVisualStyleBackColor = false;
            this.btnSayi4.Click += new System.EventHandler(this.btnSayi4_Click);
            // 
            // btnSayi6
            // 
            this.btnSayi6.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi6.Location = new System.Drawing.Point(122, 155);
            this.btnSayi6.Name = "btnSayi6";
            this.btnSayi6.Size = new System.Drawing.Size(43, 39);
            this.btnSayi6.TabIndex = 26;
            this.btnSayi6.Text = "6";
            this.btnSayi6.UseVisualStyleBackColor = false;
            this.btnSayi6.Click += new System.EventHandler(this.btnSayi6_Click);
            // 
            // btnSayi5
            // 
            this.btnSayi5.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi5.Location = new System.Drawing.Point(64, 155);
            this.btnSayi5.Name = "btnSayi5";
            this.btnSayi5.Size = new System.Drawing.Size(43, 39);
            this.btnSayi5.TabIndex = 25;
            this.btnSayi5.Text = "5";
            this.btnSayi5.UseVisualStyleBackColor = false;
            this.btnSayi5.Click += new System.EventHandler(this.btnSayi5_Click);
            // 
            // btnSayi7
            // 
            this.btnSayi7.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi7.Location = new System.Drawing.Point(8, 201);
            this.btnSayi7.Name = "btnSayi7";
            this.btnSayi7.Size = new System.Drawing.Size(43, 39);
            this.btnSayi7.TabIndex = 24;
            this.btnSayi7.Text = "7";
            this.btnSayi7.UseVisualStyleBackColor = false;
            this.btnSayi7.Click += new System.EventHandler(this.btnSayi7_Click);
            // 
            // btnSayi8
            // 
            this.btnSayi8.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi8.Location = new System.Drawing.Point(64, 201);
            this.btnSayi8.Name = "btnSayi8";
            this.btnSayi8.Size = new System.Drawing.Size(43, 39);
            this.btnSayi8.TabIndex = 23;
            this.btnSayi8.Text = "8";
            this.btnSayi8.UseVisualStyleBackColor = false;
            this.btnSayi8.Click += new System.EventHandler(this.btnSayi8_Click);
            // 
            // btnSayi9
            // 
            this.btnSayi9.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi9.Location = new System.Drawing.Point(122, 201);
            this.btnSayi9.Name = "btnSayi9";
            this.btnSayi9.Size = new System.Drawing.Size(43, 39);
            this.btnSayi9.TabIndex = 22;
            this.btnSayi9.Text = "9";
            this.btnSayi9.UseVisualStyleBackColor = false;
            this.btnSayi9.Click += new System.EventHandler(this.btnSayi9_Click);
            // 
            // btnVirgul
            // 
            this.btnVirgul.BackColor = System.Drawing.Color.Honeydew;
            this.btnVirgul.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVirgul.Location = new System.Drawing.Point(8, 246);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(43, 39);
            this.btnVirgul.TabIndex = 21;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = false;
            this.btnVirgul.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // btnSayi0
            // 
            this.btnSayi0.BackColor = System.Drawing.Color.Honeydew;
            this.btnSayi0.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSayi0.Location = new System.Drawing.Point(64, 246);
            this.btnSayi0.Name = "btnSayi0";
            this.btnSayi0.Size = new System.Drawing.Size(43, 39);
            this.btnSayi0.TabIndex = 20;
            this.btnSayi0.Text = "0";
            this.btnSayi0.UseVisualStyleBackColor = false;
            this.btnSayi0.Click += new System.EventHandler(this.btnSayi0_Click);
            // 
            // btnTextboxTemizle
            // 
            this.btnTextboxTemizle.BackColor = System.Drawing.Color.Honeydew;
            this.btnTextboxTemizle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTextboxTemizle.Location = new System.Drawing.Point(122, 246);
            this.btnTextboxTemizle.Name = "btnTextboxTemizle";
            this.btnTextboxTemizle.Size = new System.Drawing.Size(43, 39);
            this.btnTextboxTemizle.TabIndex = 19;
            this.btnTextboxTemizle.Text = "C";
            this.btnTextboxTemizle.UseVisualStyleBackColor = false;
            this.btnTextboxTemizle.Click += new System.EventHandler(this.btnTextboxTemizle_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.Honeydew;
            this.btnBol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBol.Location = new System.Drawing.Point(182, 247);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(43, 39);
            this.btnBol.TabIndex = 17;
            this.btnBol.Text = "÷";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.Color.Honeydew;
            this.btnCarpma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCarpma.Location = new System.Drawing.Point(182, 202);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(42, 39);
            this.btnCarpma.TabIndex = 16;
            this.btnCarpma.Text = "x";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.BackColor = System.Drawing.Color.Honeydew;
            this.btnCikarma.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCikarma.Location = new System.Drawing.Point(181, 156);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(43, 40);
            this.btnCikarma.TabIndex = 15;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = false;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnİleri
            // 
            this.btnİleri.BackColor = System.Drawing.Color.Honeydew;
            this.btnİleri.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnİleri.Location = new System.Drawing.Point(73, 295);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(75, 30);
            this.btnİleri.TabIndex = 14;
            this.btnİleri.Text = "İleri";
            this.btnİleri.UseVisualStyleBackColor = false;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // txtSonucEkrani
            // 
            this.txtSonucEkrani.BackColor = System.Drawing.Color.Honeydew;
            this.txtSonucEkrani.Location = new System.Drawing.Point(8, 30);
            this.txtSonucEkrani.Name = "txtSonucEkrani";
            this.txtSonucEkrani.ReadOnly = true;
            this.txtSonucEkrani.Size = new System.Drawing.Size(215, 22);
            this.txtSonucEkrani.TabIndex = 12;
            this.txtSonucEkrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSayiEkrani
            // 
            this.txtSayiEkrani.Location = new System.Drawing.Point(8, 71);
            this.txtSayiEkrani.Name = "txtSayiEkrani";
            this.txtSayiEkrani.Size = new System.Drawing.Size(215, 22);
            this.txtSayiEkrani.TabIndex = 9;
            this.txtSayiEkrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSayiEkrani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
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
            this.tabHesapla.Size = new System.Drawing.Size(244, 362);
            this.tabHesapla.TabIndex = 0;
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.Color.Honeydew;
            this.btnTopla.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTopla.Location = new System.Drawing.Point(181, 110);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(42, 40);
            this.btnTopla.TabIndex = 31;
            this.btnTopla.Text = "+";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(247, 363);
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
        private System.Windows.Forms.TextBox txtSonucEkrani;
        private System.Windows.Forms.TextBox txtSayiEkrani;
        private System.Windows.Forms.TabControl tabHesapla;
        private System.Windows.Forms.Button btnSayi1;
        private System.Windows.Forms.Button btnSayi2;
        private System.Windows.Forms.Button btnSayi3;
        private System.Windows.Forms.Button btnSayi4;
        private System.Windows.Forms.Button btnSayi6;
        private System.Windows.Forms.Button btnSayi5;
        private System.Windows.Forms.Button btnSayi7;
        private System.Windows.Forms.Button btnSayi8;
        private System.Windows.Forms.Button btnSayi9;
        private System.Windows.Forms.Button btnVirgul;
        private System.Windows.Forms.Button btnSayi0;
        private System.Windows.Forms.Button btnTextboxTemizle;
        private System.Windows.Forms.Button btnTopla;
    }
}

