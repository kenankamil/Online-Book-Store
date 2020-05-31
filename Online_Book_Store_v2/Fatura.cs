using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// Fatura sınıfının olusturulmasi, ve faturanin yaratilmasi
    /// </summary>
    public partial class Fatura : Form
    {
        public Fatura(string teslimatAdresi, string email) ///fatura olusturulur, formda gosterimi yapilir
        {
            InitializeComponent();
            lblŞirket.Text = "Online Book Store" + Environment.NewLine + "Eskişehir - OGU" + Environment.NewLine + "Tel: 0222 222 22 22";
            lblDate.Text = DateTime.Now.ToLongDateString();
            Customer cust = Customer.getInstance();
            lblAlıcı.Text = "Bill To:" + Environment.NewLine + cust.Name + Environment.NewLine + email + Environment.NewLine + cust.Adress;
            lblAdres.Text = "Ship To:" + Environment.NewLine + teslimatAdresi;
            foreach (var item in MainForm.shoppingCart.ItemsToPurchase)
            {
                ListViewItem l_item = new ListViewItem();
                if (item.Product is Book)
                    l_item.Text = item.Product.id.ToString();
                if (item.Product is Magazine)
                    l_item.Text = item.Product.id.ToString();
                if (item.Product is MusicCD)
                    l_item.Text =  item.Product.id.ToString();
                l_item.SubItems.Add(item.Product.name.ToString());
                l_item.SubItems.Add(item.Quantity.ToString());
                l_item.SubItems.Add(item.Product.discountedPrice.ToString());
                l_item.SubItems.Add((item.Product.discountedPrice * item.Quantity).ToString());
                listView1.Items.Add(l_item);
            }
            lblFiyatS.Text = MainForm.shoppingCart.PaymentAmount.ToString() + " TL";
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            bitmap.Save(@"OrderInformation.jpeg", ImageFormat.Jpeg);
            MainForm.shoppingCart.getPDF();
            File.Delete(@"OrderInformation.jpeg");
            this.Close();

        }
    }
}
