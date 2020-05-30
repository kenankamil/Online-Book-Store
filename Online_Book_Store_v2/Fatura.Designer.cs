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
            this.pnlFatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaliyeBak)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFatura
            // 
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
            this.pnlFatura.Name = "pnlFatura";
            this.pnlFatura.Size = new System.Drawing.Size(837, 571);
            this.pnlFatura.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(586, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(172, 25);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Tarih";
            // 
            // lblFiyatS
            // 
            this.lblFiyatS.AutoSize = true;
            this.lblFiyatS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyatS.Location = new System.Drawing.Point(729, 542);
            this.lblFiyatS.Name = "lblFiyatS";
            this.lblFiyatS.Size = new System.Drawing.Size(19, 20);
            this.lblFiyatS.TabIndex = 8;
            this.lblFiyatS.Text = "F";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(676, 542);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(47, 20);
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
            this.listView1.Location = new System.Drawing.Point(12, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(813, 339);
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
            this.lblAdres.Location = new System.Drawing.Point(586, 55);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(141, 104);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "adres";
            // 
            // lblŞirket
            // 
            this.lblŞirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞirket.Location = new System.Drawing.Point(400, 25);
            this.lblŞirket.Name = "lblŞirket";
            this.lblŞirket.Size = new System.Drawing.Size(169, 134);
            this.lblŞirket.TabIndex = 4;
            this.lblŞirket.Text = "şirket bilgileri";
            // 
            // lblAlıcı
            // 
            this.lblAlıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlıcı.Location = new System.Drawing.Point(245, 25);
            this.lblAlıcı.Name = "lblAlıcı";
            this.lblAlıcı.Size = new System.Drawing.Size(149, 134);
            this.lblAlıcı.TabIndex = 3;
            this.lblAlıcı.Text = "alıcı bilgileri";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(632, 25);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 20);
            this.lblTarih.TabIndex = 2;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 571);
            this.Controls.Add(this.pnlFatura);
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
    }
}