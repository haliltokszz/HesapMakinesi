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
        double ToplamaIslemi(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        double CikarmaIslemi(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }
        double BolmeIslemi(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
        double CarpmaIslemi(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }
        void EkranHazirla()
        {
            txtSayi1.Text = txtSayi2.Text = "0";
            txtSayi1.Focus();
        }
        void LogYaz(double sayi1,double sayi2, double sonuc)
        {
            ListViewItem liste;
            string[] degerler= new string[3];
            degerler[0] = sayi1.ToString(); degerler[1] = sayi2.ToString(); degerler[2] = sonuc.ToString();
            liste = new ListViewItem(degerler);
            listLog.Items.Add(liste);
        }
        Boolean Dogrula()
        {
            try
            {
                Convert.ToDouble(txtSayi1.Text);
                Convert.ToDouble(txtSayi2.Text);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        void Islemler(double sayi1, double sayi2, int islem)
        {
            sayi1 = 0; sayi2 = 0; double sonuc;
            if (Dogrula() == true)
            {
                sayi1 = Convert.ToDouble(txtSayi1.Text);
                sayi2 = Convert.ToDouble(txtSayi2.Text);
                switch (islem)
                {
                    case 0:
                        sonuc = ToplamaIslemi(sayi1, sayi2);
                        txtSonuc.Text = sonuc.ToString();
                        LogYaz(sayi1, sayi2, sonuc);
                        EkranHazirla();
                        break;
                    case 1:
                        sonuc = CikarmaIslemi(sayi1, sayi2);
                        txtSonuc.Text = sonuc.ToString();
                        LogYaz(sayi1, sayi2, sonuc);
                        EkranHazirla();
                        break;
                    case 2:
                        sonuc = CarpmaIslemi(sayi1, sayi2);
                        txtSonuc.Text = sonuc.ToString();
                        LogYaz(sayi1, sayi2, sonuc);
                        EkranHazirla();
                        break;
                    case 3:
                        sonuc =  BolmeIslemi(sayi1, sayi2);
                        txtSonuc.Text = sonuc.ToString();
                        LogYaz(sayi1, sayi2, sonuc);
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
            MessageBox.Show("Lütfen ondalıklı sayılar için virgül kullanınız!");
        }

        private void txtSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {//.isPunctuation fonksiyonunu çıkardık çünkü ondalıklı sayılar için noktalama işareti gerekli..
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) 
                ) e.Handled = true;
        }

        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) 
                ) e.Handled = true;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Islemler(0, 0, 0);
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            Islemler(0, 0, 1);
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            Islemler(0, 0, 2);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Islemler(0, 0, 3);
        }
    }
}
