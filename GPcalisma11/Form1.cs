namespace GPcalisma11
{
    public partial class Form1 : Form
    {
        double araToplam = 0;
        double kdvToplam = 0;
        double genelToplam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            dgvUrunler.ColumnCount = 6;
            dgvUrunler.Columns[0].Name = "Ürün Adý";
            dgvUrunler.Columns[1].Name = "Miktar";
            dgvUrunler.Columns[2].Name = "Birim Fiyat";
            dgvUrunler.Columns[3].Name = "KDV (%)";
            dgvUrunler.Columns[4].Name = "KDV Tutarý";
            dgvUrunler.Columns[5].Name = "Toplam Tutar";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = "Tarih/Saat: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtUrunAdi.Text;
                double miktar = Convert.ToDouble(txtMiktar.Text);
                double fiyat = Convert.ToDouble(txtFiyat.Text);
                double kdvOrani = Convert.ToDouble(txtKdv.Text); // Örn: 18 veya 20

                // Hesaplamalar
                double satirAraToplam = miktar * fiyat;
                double satirKdvTutar = satirAraToplam * (kdvOrani / 100);
                double satirToplam = satirAraToplam + satirKdvTutar;

                // Tabloya (DataGridView) Ekle
                dgvUrunler.Rows.Add(ad, miktar, fiyat.ToString("C2"), kdvOrani, satirKdvTutar.ToString("C2"), satirToplam.ToString("C2"));

                // Genel Toplamlarý Güncelle
                araToplam += satirAraToplam;
                kdvToplam += satirKdvTutar;
                genelToplam += satirToplam;

                lblAraToplam.Text = "Ara Toplam: " + araToplam.ToString("C2");
                lblKdvToplam.Text = "KDV Toplam: " + kdvToplam.ToString("C2");
                lblGenelToplam.Text = "Genel Toplam: " + genelToplam.ToString("C2");
                // Kutularý Temizle
                txtUrunAdi.Clear();
                txtMiktar.Clear();
                txtFiyat.Clear();
                txtUrunAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen sayýsal deðerleri doðru giriniz!\nHata: " + ex.Message);
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.Rows.Count > 0)
            {
                printPreviewDialog1.ShowDialog(); // Fiþi ekranda göster (Ýstersen direkt printDocument1.Print() yapabilirsin)
            }
            else
            {
                MessageBox.Show("Yazdýrýlacak ürün yok!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font baslikFont = new Font("Arial", 16, FontStyle.Bold);
            Font altBaslikFont = new Font("Arial", 10, FontStyle.Bold);
            Font icerikFont = new Font("Arial", 10, FontStyle.Regular);
            SolidBrush firca = new SolidBrush(Color.Black);

            int baslangicX = 50;
            int y = 50; // Y ekseni konumu

            // Fatura Baþlýðý ve Tarih
            e.Graphics.DrawString("FÝÞ / FATURA BÝLGÝSÝ", baslikFont, firca, baslangicX + 250, y);
            y += 40;
            e.Graphics.DrawString(lblSaat.Text, icerikFont, firca, baslangicX, y);
            y += 40;

            // Çizgi Çek
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", icerikFont, firca, baslangicX, y);
            y += 20;

            // Sütun Baþlýklarý
            e.Graphics.DrawString("Ürün Adý", altBaslikFont, firca, baslangicX, y);
            e.Graphics.DrawString("Miktar", altBaslikFont, firca, baslangicX + 200, y);
            e.Graphics.DrawString("Fiyat", altBaslikFont, firca, baslangicX + 300, y);
            e.Graphics.DrawString("KDV", altBaslikFont, firca, baslangicX + 400, y);
            e.Graphics.DrawString("Toplam", altBaslikFont, firca, baslangicX + 500, y);
            y += 20;

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", icerikFont, firca, baslangicX, y);
            y += 30;

            // Tablodaki (DataGridView) Verileri Yazdýrma Döngüsü
            for (int i = 0; i < dgvUrunler.Rows.Count; i++)
            {
                if (dgvUrunler.Rows[i].Cells[0].Value != null)
                {
                    e.Graphics.DrawString(dgvUrunler.Rows[i].Cells[0].Value.ToString(), icerikFont, firca, baslangicX, y); // Adý
                    e.Graphics.DrawString(dgvUrunler.Rows[i].Cells[1].Value.ToString(), icerikFont, firca, baslangicX + 200, y); // Miktar
                    e.Graphics.DrawString(dgvUrunler.Rows[i].Cells[2].Value.ToString(), icerikFont, firca, baslangicX + 300, y); // Fiyat
                    e.Graphics.DrawString("%" + dgvUrunler.Rows[i].Cells[3].Value.ToString(), icerikFont, firca, baslangicX + 400, y); // KDV Oraný
                    e.Graphics.DrawString(dgvUrunler.Rows[i].Cells[5].Value.ToString(), icerikFont, firca, baslangicX + 500, y); // Toplam Tutar
                    y += 25;
                }
            }

            y += 20;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------", icerikFont, firca, baslangicX, y);
            y += 30;

            // Alt Kýsým Toplamlar
            e.Graphics.DrawString("Ara Toplam: " + araToplam.ToString("C2"), altBaslikFont, firca, baslangicX + 400, y);
            y += 25;
            e.Graphics.DrawString("KDV Toplam: " + kdvToplam.ToString("C2"), altBaslikFont, firca, baslangicX + 400, y);
            y += 25;
            e.Graphics.DrawString("GENEL TOPLAM: " + genelToplam.ToString("C2"), baslikFont, firca, baslangicX + 330, y);
        }
    }
}
