using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class CalisanAnaSayfa
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnKargoEkle;
        private Button btnDurumGuncelle;

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
            this.btnKargoEkle = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnKargoEkle
            // 
            this.btnKargoEkle.Location = new System.Drawing.Point(50, 50);
            this.btnKargoEkle.Name = "btnKargoEkle";
            this.btnKargoEkle.Size = new System.Drawing.Size(150, 40);
            this.btnKargoEkle.Text = "Kargo Ekle";
            this.btnKargoEkle.UseVisualStyleBackColor = true;
            this.btnKargoEkle.Click += new System.EventHandler(this.btnKargoEkle_Click);

            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(50, 120);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);

            // 
            // CalisanAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnKargoEkle);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Name = "CalisanAnaSayfa";
            this.Text = "Çalışan Ana Sayfa";
            this.ResumeLayout(false);
        }
    }
}
