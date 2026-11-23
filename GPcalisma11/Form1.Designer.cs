namespace GPcalisma11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            txtUrunAdi = new TextBox();
            labUrunAdi = new Label();
            labMiktar = new Label();
            txtMiktar = new TextBox();
            labKdv = new Label();
            labFiyat = new Label();
            txtKdv = new TextBox();
            txtFiyat = new TextBox();
            btnEkle = new Button();
            btnYazdir = new Button();
            dgvUrunler = new DataGridView();
            lblSaat = new Label();
            lblAraToplam = new Label();
            lblKdvToplam = new Label();
            lblGenelToplam = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(174, 79);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(184, 23);
            txtUrunAdi.TabIndex = 0;
            // 
            // labUrunAdi
            // 
            labUrunAdi.AutoSize = true;
            labUrunAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labUrunAdi.Location = new Point(48, 77);
            labUrunAdi.Name = "labUrunAdi";
            labUrunAdi.Size = new Size(72, 21);
            labUrunAdi.TabIndex = 1;
            labUrunAdi.Text = "Ürün Adı";
            // 
            // labMiktar
            // 
            labMiktar.AutoSize = true;
            labMiktar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labMiktar.Location = new Point(65, 119);
            labMiktar.Name = "labMiktar";
            labMiktar.Size = new Size(55, 21);
            labMiktar.TabIndex = 2;
            labMiktar.Text = "Miktar";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(174, 121);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(184, 23);
            txtMiktar.TabIndex = 3;
            // 
            // labKdv
            // 
            labKdv.AutoSize = true;
            labKdv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labKdv.Location = new Point(65, 212);
            labKdv.Name = "labKdv";
            labKdv.Size = new Size(40, 21);
            labKdv.TabIndex = 4;
            labKdv.Text = "KDV";
            // 
            // labFiyat
            // 
            labFiyat.AutoSize = true;
            labFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labFiyat.Location = new Point(65, 165);
            labFiyat.Name = "labFiyat";
            labFiyat.Size = new Size(43, 21);
            labFiyat.TabIndex = 5;
            labFiyat.Text = "Fiyat";
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(174, 210);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(184, 23);
            txtKdv.TabIndex = 6;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(174, 167);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(184, 23);
            txtFiyat.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(476, 81);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(183, 65);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new Point(476, 168);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(183, 65);
            btnYazdir.TabIndex = 9;
            btnYazdir.Text = "Yazdır";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(61, 254);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(529, 147);
            dgvUrunler.TabIndex = 10;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSaat.Location = new Point(632, 266);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(40, 21);
            lblSaat.TabIndex = 11;
            lblSaat.Text = "Saat";
            // 
            // lblAraToplam
            // 
            lblAraToplam.AutoSize = true;
            lblAraToplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAraToplam.Location = new Point(632, 304);
            lblAraToplam.Name = "lblAraToplam";
            lblAraToplam.Size = new Size(88, 21);
            lblAraToplam.TabIndex = 12;
            lblAraToplam.Text = "Ara Toplam";
            // 
            // lblKdvToplam
            // 
            lblKdvToplam.AutoSize = true;
            lblKdvToplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKdvToplam.Location = new Point(632, 343);
            lblKdvToplam.Name = "lblKdvToplam";
            lblKdvToplam.Size = new Size(90, 21);
            lblKdvToplam.TabIndex = 13;
            lblKdvToplam.Text = "Kdv Toplam";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGenelToplam.Location = new Point(630, 380);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(104, 21);
            lblGenelToplam.TabIndex = 14;
            lblGenelToplam.Text = "Genel Toplam";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 450);
            Controls.Add(lblGenelToplam);
            Controls.Add(lblKdvToplam);
            Controls.Add(lblAraToplam);
            Controls.Add(lblSaat);
            Controls.Add(dgvUrunler);
            Controls.Add(btnYazdir);
            Controls.Add(btnEkle);
            Controls.Add(txtFiyat);
            Controls.Add(txtKdv);
            Controls.Add(labFiyat);
            Controls.Add(labKdv);
            Controls.Add(txtMiktar);
            Controls.Add(labMiktar);
            Controls.Add(labUrunAdi);
            Controls.Add(txtUrunAdi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private TextBox txtUrunAdi;
        private Label labUrunAdi;
        private Label labMiktar;
        private TextBox txtMiktar;
        private Label labKdv;
        private Label labFiyat;
        private TextBox txtKdv;
        private TextBox txtFiyat;
        private Button btnEkle;
        private Button btnYazdir;
        private DataGridView dgvUrunler;
        private Label lblSaat;
        private Label lblAraToplam;
        private Label lblKdvToplam;
        private Label lblGenelToplam;
        private System.Windows.Forms.Timer timer1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
