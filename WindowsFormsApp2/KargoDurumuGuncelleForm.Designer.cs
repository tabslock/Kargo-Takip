namespace WindowsFormsApp2
{
    partial class KargoDurumuGuncelleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKargoID;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtKargoID;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Button btnGuncelle;

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
            this.lblKargoID = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtKargoID = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();

            lblKargoID.Text = "Kargo ID:";
            lblKargoID.Location = new System.Drawing.Point(30, 30);

            lblDurum.Text = "Yeni Durum:";
            lblDurum.Location = new System.Drawing.Point(30, 70);

            txtKargoID.Location = new System.Drawing.Point(150, 30);
            txtDurum.Location = new System.Drawing.Point(150, 70);

            btnGuncelle.Text = "Durum Güncelle";
            btnGuncelle.Location = new System.Drawing.Point(100, 110);
            btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.Controls.Add(lblKargoID);
            this.Controls.Add(lblDurum);
            this.Controls.Add(txtKargoID);
            this.Controls.Add(txtDurum);
            this.Controls.Add(btnGuncelle);

            this.Text = "Kargo Durumu Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
