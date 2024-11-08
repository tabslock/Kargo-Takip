using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CalisanAnaSayfa : Form
    {
        public CalisanAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKargoEkle_Click(object sender, EventArgs e)
        {
            KargoEkleForm kargoEkle = new KargoEkleForm();
            kargoEkle.Show();
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            KargoDurumuGuncelleForm durumGuncelle = new KargoDurumuGuncelleForm();
            durumGuncelle.Show();
        }
    }
}
