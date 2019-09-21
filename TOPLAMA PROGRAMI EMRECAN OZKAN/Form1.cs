using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOPLAMA_PROGRAMI_EMRECAN_OZKAN
{
    public partial class FormToplama : Form
    {
        public FormToplama()
        {
            InitializeComponent();
        }
        void logYaz(string cikti)
        {
            listViewLoglama.Items.Add(cikti);
        }

        int Topla(int sayi1, int sayi2)
        {
            return (sayi1 + sayi2);
        }

        private Boolean Dogrula()
        {
            try
            {
                Convert.ToInt32(textBoxBirinciSayı.Text);
                Convert.ToInt32(textBoxİkinciSayı.Text);
                return true;
            }
            catch (Exception e)
            {
                logYaz("Başarısız oldu! " + e.Message);
                return false;
            }
        }

        void EkraniAyarla(bool toplamBasarili = false)
        {
            if (!toplamBasarili)
            {
                textBoxBirinciSayı.Text = textBoxİkinciSayı.Text = "0";
                textBoxBirinciSayı.Focus();
            }
            
        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            bool dogrulamaSonucu = Dogrula();
            if (dogrulamaSonucu)
            {
                int toplam = Topla(Convert.ToInt32(textBoxBirinciSayı.Text), Convert.ToInt32(textBoxİkinciSayı.Text));
                textBoxSonuç.Text = toplam.ToString();
                logYaz("Başarılı bir giriş: " + textBoxSonuç.Text);
                EkraniAyarla(dogrulamaSonucu);
            }
            else
            {
                MessageBox.Show("Girdiklerin yanlış değerler.");
                logYaz("Başarısız bir giriş: " + textBoxSonuç.Text);
            }
            EkraniAyarla(dogrulamaSonucu);

        }

        private void FormToplama_Shown(object sender, EventArgs e)
        {
            EkraniAyarla();
        }

        private void TextBoxBirinciSayı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void TextBoxİkinciSayı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)
                )
                e.Handled = true;
        }

        private void Buttonİleri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabLoglama;
        }

        private void ButtonGeri_Click(object sender, EventArgs e)
        {
            tabGenel.SelectedTab = tabToplama;
        }

        private void ButtonTemizle_Click(object sender, EventArgs e)
        {
            listViewLoglama.Items.Clear();
        }

        private void ButtonSecileniSil_Click(object sender, EventArgs e)
        {
            listViewLoglama.Items.Remove(listViewLoglama.FocusedItem);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // Linked-In e gider...
            System.Diagnostics.Process.Start("https://github.com/paradyo");
        }
    }
}
