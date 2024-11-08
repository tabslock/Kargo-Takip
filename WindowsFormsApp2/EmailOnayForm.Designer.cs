partial class EmailOnayForm
{
    private Guna.UI2.WinForms.Guna2TextBox txtKod;
    private Guna.UI2.WinForms.Guna2Button btnOnayla;

    private void InitializeComponent()
    {
        this.txtKod = new Guna.UI2.WinForms.Guna2TextBox();
        this.btnOnayla = new Guna.UI2.WinForms.Guna2Button();

        // 
        // txtKod
        // 
        this.txtKod.PlaceholderText = "Onay Kodu";
        this.txtKod.Location = new System.Drawing.Point(50, 50);
        this.txtKod.Size = new System.Drawing.Size(200, 36);

        // 
        // btnOnayla
        // 
        this.btnOnayla.Text = "Onayla";
        this.btnOnayla.Location = new System.Drawing.Point(50, 100);
        this.btnOnayla.Size = new System.Drawing.Size(200, 45);
        this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);

        // 
        // EmailOnayForm
        // 
        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.txtKod);
        this.Controls.Add(this.btnOnayla);
        this.Text = "Email Onayı";
    }
}
