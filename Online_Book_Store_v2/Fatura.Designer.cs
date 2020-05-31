namespace Online_Book_Store_v2
{
    partial class Fatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fatura));
            this.pnlFatura = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFiyatS = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.araToplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toplam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblŞirket = new System.Windows.Forms.Label();
            this.lblAlıcı = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.pbMaliyeBak = new System.Windows.Forms.PictureBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.pnlFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaliyeBak)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFatura
            // 
            this.pnlFatura.Controls.Add(this.btnPDF);
            this.pnlFatura.Controls.Add(this.lblDate);
            this.pnlFatura.Controls.Add(this.lblFiyatS);
            this.pnlFatura.Controls.Add(this.lblFiyat);
            this.pnlFatura.Controls.Add(this.listView1);
            this.pnlFatura.Controls.Add(this.lblAdres);
            this.pnlFatura.Controls.Add(this.lblŞirket);
            this.pnlFatura.Controls.Add(this.lblAlıcı);
            this.pnlFatura.Controls.Add(this.lblTarih);
            this.pnlFatura.Controls.Add(this.pbMaliyeBak);
            this.pnlFatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFatura.Location = new System.Drawing.Point(0, 0);
            this.pnlFatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFatura.Name = "pnlFatura";
            this.pnlFatura.Size = new System.Drawing.Size(1116, 703);
            this.pnlFatura.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(887, 657);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(229, 31);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Tarih";
            // 
            // lblFiyatS
            // 
            this.lblFiyatS.AutoSize = true;
            this.lblFiyatS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatS.Location = new System.Drawing.Point(928, 425);
            this.lblFiyatS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyatS.Name = "lblFiyatS";
            this.lblFiyatS.Size = new System.Drawing.Size(24, 25);
            this.lblFiyatS.TabIndex = 8;
            this.lblFiyatS.Text = "F";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(857, 425);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(60, 25);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.adet,
            this.araToplam,
            this.toplam});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1083, 416);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 90;
            // 
            // name
            // 
            this.name.Text = "Ürün İsmi";
            this.name.Width = 400;
            // 
            // adet
            // 
            this.adet.Text = "Adet";
            this.adet.Width = 80;
            // 
            // araToplam
            // 
            this.araToplam.Text = "Ara Toplam";
            this.araToplam.Width = 110;
            // 
            // toplam
            // 
            this.toplam.Text = "Toplam";
            this.toplam.Width = 130;
            // 
            // lblAdres
            // 
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(673, 492);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(188, 128);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "adres";
            // 
            // lblŞirket
            // 
            this.lblŞirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞirket.Location = new System.Drawing.Point(440, 492);
            this.lblŞirket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblŞirket.Name = "lblŞirket";
            this.lblŞirket.Size = new System.Drawing.Size(225, 165);
            this.lblŞirket.TabIndex = 4;
            this.lblŞirket.Text = "şirket bilgileri";
            // 
            // lblAlıcı
            // 
            this.lblAlıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlıcı.Location = new System.Drawing.Point(233, 492);
            this.lblAlıcı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlıcı.Name = "lblAlıcı";
            this.lblAlıcı.Size = new System.Drawing.Size(199, 165);
            this.lblAlıcı.TabIndex = 3;
            this.lblAlıcı.Text = "alıcı bilgileri";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(843, 31);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 25);
            this.lblTarih.TabIndex = 2;
            // 
            // pbMaliyeBak
            // 
            this.pbMaliyeBak.Image = ((System.Drawing.Image)(resources.GetObject("pbMaliyeBak.Image")));
            this.pbMaliyeBak.Location = new System.Drawing.Point(16, 473);
            this.pbMaliyeBak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMaliyeBak.Name = "pbMaliyeBak";
            this.pbMaliyeBak.Size = new System.Drawing.Size(200, 185);
            this.pbMaliyeBak.TabIndex = 10;
            this.pbMaliyeBak.TabStop = false;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(357, 660);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(358, 40);
            this.btnPDF.TabIndex = 11;
            this.btnPDF.Text = "Show PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 703);
            this.Controls.Add(this.pnlFatura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.pnlFatura.ResumeLayout(false);
            this.pnlFatura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaliyeBak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFatura;
        private System.Windows.Forms.Label lblFiyatS;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader araToplam;
        private System.Windows.Forms.ColumnHeader toplam;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblŞirket;
        private System.Windows.Forms.Label lblAlıcı;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.PictureBox pbMaliyeBak;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPDF;
    }
}