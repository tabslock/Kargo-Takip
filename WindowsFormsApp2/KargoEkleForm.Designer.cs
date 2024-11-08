namespace WindowsFormsApp2
{
    partial class KargoEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKargoAdi;
        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.TextBox txtKargoAdi;
        private System.Windows.Forms.TextBox txtGonderen;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Button btnEkle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKargoAdi = new System.Windows.Forms.Label();
            this.lblGonderen = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.txtKargoAdi = new System.Windows.Forms.TextBox();
            this.txtGonderen = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label ve Textbox Ayarları
            lblKargoAdi.Text = "Kargo Adı:";
            lblKargoAdi.Location = new System.Drawing.Point(30, 30);

            lblGonderen.Text = "Gönderen:";
            lblGonderen.Location = new System.Drawing.Point(30, 70);

            lblAlici.Text = "Alıcı:";
            lblAlici.Location = new System.Drawing.Point(30, 110);

            txtKargoAdi.Location = new System.Drawing.Point(150, 30);
            txtGonderen.Location = new System.Drawing.Point(150, 70);
            txtAlici.Location = new System.Drawing.Point(150, 110);

            // Ekle Butonu
            btnEkle.Text = "Kargo Ekle";
            btnEkle.Location = new System.Drawing.Point(100, 150);
            btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.Controls.Add(lblKargoAdi);
            this.Controls.Add(lblGonderen);
            this.Controls.Add(lblAlici);
            this.Controls.Add(txtKargoAdi);
            this.Controls.Add(txtGonderen);
            this.Controls.Add(txtAlici);
            this.Controls.Add(btnEkle);

            this.Text = "Kargo Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
