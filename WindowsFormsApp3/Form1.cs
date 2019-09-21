using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void SayiGirme(string rakam)
        {
            if (txtSayiEkrani.Text == "0")
            {
                txtSayiEkrani.Text = rakam;
            }else
                txtSayiEkrani.Text += rakam;
        }
        double ToplamaIslemi(double sayi, double sonuc)
        {
            return sonuc+= sayi;
        }
        double CikarmaIslemi(double sayi, double sonuc)
        {
            return sonuc -= sayi;
        }
        double BolmeIslemi(double sayi, double sonuc)
        {
            return sonuc /= sayi;
        }
        double CarpmaIslemi(double sayi, double sonuc)
        {
            return sonuc *= sayi;
        }
        void EkranHazirla()
        {
            txtSayiEkrani.Text = "0";
            txtSayiEkrani.Focus();
        }
        void LogYaz(double sayi1, double sayi2, double sonuc)
        {
            ListViewItem liste;
            string[] degerler= new string[3];
            degerler[0] = sayi1.ToString(); degerler[1] = sayi2.ToString(); degerler[2]=sonuc.ToString();
            liste = new ListViewItem(degerler);
            listLog.Items.Add(liste);
        }


        void Islemler(double sayi1, double gecici, int islem)
        {
            double sonuc;
            if (SayiMi(txtSayiEkrani.Text) == true)
            {
                sayi1 = Convert.ToDouble(txtSayiEkrani.Text);
                switch (islem)
                {
                    case 0:
                        sonuc = ToplamaIslemi(sayi1, gecici);
                        txtSonucEkrani.Text = sonuc.ToString();
                        LogYaz(sayi1, gecici, sonuc);
                        EkranHazirla();
                        break;
                    case 1:
                        sonuc = CikarmaIslemi(sayi1, gecici);
                        txtSonucEkrani.Text = sonuc.ToString();
                        LogYaz(sayi1, gecici, sonuc);
                        EkranHazirla();
                        break;
                    case 2:
                        sonuc = CarpmaIslemi(sayi1, gecici);
                        txtSonucEkrani.Text = sonuc.ToString();
                        LogYaz(sayi1, gecici, sonuc);
                        EkranHazirla();
                        break;
                    case 3:
                        sonuc =  BolmeIslemi(sayi1, gecici);
                        txtSonucEkrani.Text = sonuc.ToString();
                        LogYaz(sayi1, gecici, sonuc);
                        EkranHazirla();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Bir hata alındı!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranHazirla();
            txtSonucEkrani.Text = "0";
            listLog.View = View.Details;
            listLog.GridLines = true;
            listLog.FullRowSelect = true;

            listLog.Columns.Add("Birinci Sayı", 100);
            listLog.Columns.Add("İkinci Sayı", 100);
            listLog.Columns.Add("Sonuç", 100);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
        }
        bool SayiMi(string text)
        {
            int kacinciHarf = 0, virgulHakki =0;
            foreach (char chr in text)
            {
                
                if (kacinciHarf == 0 && Char.IsPunctuation(chr) || Char.IsWhiteSpace(chr) || Char.IsLetter(chr)) return false;
                else if (kacinciHarf != 0 && chr != ',' && Char.IsPunctuation(chr) || Char.IsWhiteSpace(chr) || Char.IsLetter(chr)) return false;
                else if (chr == ',')
                {
                    virgulHakki++;
                    if (virgulHakki > 1)
                    {
                        return false;
                    }
                }
                kacinciHarf++;
            }
            return true;
        }
        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44)
            {
                e.Handled = false;
            }      
            else if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                ) e.Handled = true;
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (SayiMi(txtSayiEkrani.Text) == true)
            {
                Islemler(Convert.ToDouble(txtSayiEkrani.Text), Convert.ToDouble(txtSonucEkrani.Text), 1);
            }
            else MessageBox.Show("Girdiğiniz değeri kontrol ediniz!");
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            if (SayiMi(txtSayiEkrani.Text))
            {
                Islemler(Convert.ToDouble(txtSayiEkrani.Text), Convert.ToDouble(txtSonucEkrani.Text), 2);
            }
            else MessageBox.Show("Girdiğiniz değeri kontrol ediniz!");
            
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (SayiMi(txtSayiEkrani.Text))
            {
                Islemler(Convert.ToDouble(txtSayiEkrani.Text), Convert.ToDouble(txtSonucEkrani.Text), 3);
            }
            else MessageBox.Show("Girdiğiniz değeri kontrol ediniz!");
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            tabHesapla.SelectedTab = tabLogSayfasi;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            tabHesapla.SelectedTab = tabHesaplamaSayfasi;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem secilikayitbilgisi in listLog.SelectedItems)
            {
                secilikayitbilgisi.Remove();
            }
        }

        private void btnSayi1_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi1.Text);
        }

        private void btnSayi2_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi2.Text);
        }

        private void btnSayi3_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi3.Text);

        }

        private void btnSayi4_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi4.Text);
        }

        private void btnSayi5_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi5.Text);
        }

        private void btnSayi6_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi6.Text);
        }

        private void btnSayi7_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi7.Text);
        }

        private void btnSayi8_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi8.Text);
        }

        private void btnSayi9_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi9.Text);

        }

        private void btnSayi0_Click(object sender, EventArgs e)
        {
            SayiGirme(btnSayi0.Text);
        }

        private void btnTextboxTemizle_Click(object sender, EventArgs e)
        {
            EkranHazirla();
            txtSonucEkrani.Text = "0";
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            txtSayiEkrani.Text += ",";
        }

        private void btnTopla_Click_3(object sender, EventArgs e)
        {
            if (SayiMi(txtSayiEkrani.Text) == true)
            {
                Islemler(Convert.ToDouble(txtSayiEkrani.Text), Convert.ToDouble(txtSonucEkrani.Text), 0);
            }
            else MessageBox.Show("Girdiğiniz değeri kontrol ediniz!");
            
        }
    }
}
