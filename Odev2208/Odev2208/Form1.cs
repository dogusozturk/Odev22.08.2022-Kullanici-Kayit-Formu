using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2208
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            bool key = true;

            Kullanici kullanici = new Kullanici();

            if (dm.NullVeriControl(textBoxIsim.Text) != null)
            {
                kullanici.Isim = textBoxIsim.Text;
            }
            else
            {
                message = "isim boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(textBoxSoyisim.Text) != null)
            {
                kullanici.Soyisim = textBoxSoyisim.Text;
            }
            else
            {
                message = "Soyisim boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(maskedTextBoxTc.Text) != null)
            {
                if (dm.DigitControl(maskedTextBoxTc.Text, 11) == true)
                {
                    if (dm.CiftSayiKontrol(maskedTextBoxTc.Text) == true)
                    {
                        kullanici.TcKimlikNo = maskedTextBoxTc.Text;
                    }
                    else
                    {
                        message = "Geçerli bir tc kimlik no değil.";
                        MessageBox.Show(message);
                        key = false;
                    }
                }
                else
                {
                    message = "Geçerli bir tc kimlik no değil.";
                    MessageBox.Show(message);
                    key = false;
                }

            }
            else
            {
                message = "Tc boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(maskedTextBoxGsm.Text) != null)
            {
                if (dm.DigitControl(maskedTextBoxGsm.Text, 14))
                {
                    if (maskedTextBoxGsm.Text[1] == '5')
                    {
                        kullanici.GsmNo = textBoxAlanKodu.Text + maskedTextBoxGsm.Text;
                    }
                    else
                    {
                        message = "Geçerli bir GSM no değil";
                        MessageBox.Show(message);
                        key = false;
                    }
                }
                else
                {
                    message = "Geçerli bir GSM no değil";
                    MessageBox.Show(message);
                    key = false;
                }
            }
            else
            {
                message = "Gsm boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(textBoxEposta.Text) != null)
            {
                kullanici.Eposta = textBoxEposta.Text;
            }
            else
            {
                message = "Eposta boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(textBoxAdres.Text) != null)
            {
                kullanici.Adres = textBoxAdres.Text;
            }
            else
            {
                message = "Adres boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (dm.NullVeriControl(textBoxSifre.Text) != null)
            {
                if (dm.DigitControl(textBoxSifre.Text))
                {
                    kullanici.Sifre = textBoxSifre.Text;
                }
                else
                {
                    message = "Şifre en az 6 karakterli olmalıdır";
                    MessageBox.Show(message);
                    key = false;
                }
            }
            else
            {
                message = "Şifre boş bırakılamaz";
                MessageBox.Show(message);
                key = false;
            }
            if (textBoxSifre2.Text != textBoxSifre.Text)
            {
                message = "Şifre tekrar; Şifre ile aynı olmalıdır.";
                MessageBox.Show(message);
                key = false;
            }
            progressBar1.Maximum = 1000000;
            progressBar1.Minimum = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                i++;
            }
            DialogResult confirmResult = MessageBox.Show("Kayıdınızın Tamamlanmasını Onaylıyor musunuz?", "Kullanıcı Kayıt Formu", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti !", "Başarılı !", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Kayıt İşleminiz İptal Edildi !", "Başarısız !", MessageBoxButtons.OK);
            }
            
        }
    }
}
