using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            HesapOlusturmaForm hesapOlusturmaForm = new HesapOlusturmaForm();
            hesapOlusturmaForm.Show();
            this.Hide(); // Ana sayfayı gizle
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            GirisYapForm girisYapmaForm = new GirisYapForm();
            girisYapmaForm.Show();
            this.Hide(); // Ana sayfayı gizle
        }

        private void btnKargoTakibi_Click(object sender, EventArgs e)
        {
            KargoTakipForm kargoTakibiForm = new KargoTakipForm();
            kargoTakibiForm.Show();
            this.Hide(); // Ana sayfayı gizle
        }

        private void btnCalisanGiris_Click(object sender, EventArgs e)
        {
            CalisanGirisForm calisanGirisForm = new CalisanGirisForm();
            calisanGirisForm.Show();
            this.Hide(); // Ana sayfayı gizle
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}
