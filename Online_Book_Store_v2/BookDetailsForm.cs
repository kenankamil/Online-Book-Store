using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Online_Book_Store_v2
{
    public partial class BookDetailsForm : Form
    {
        Book book;

        /// <summary>
        /// When a specific book get double clicked, this form shows up
        /// </summary>
        /// <param name="_book"></param>

        public BookDetailsForm(Book _book)
        {
            this.book = _book;
            InitializeComponent();
            this.Text = book.name;
            lblName.Text = book.name;
            lblPage.Text = "page:" + book.page.ToString();
            lblPublisher.Text = book.publisher;
            lblSummary.Text = book.summary;
            lblWriter.Text = book.author;

            lblADiscount.Text = book.discountedPrice.ToString();
            lblCategory.Text = "type:" + book.type;
            if (book.sale > 0 && book.sale < 100)
            {
                lblBDiscounte.Text = book.price + " ₺ %" + book.sale;
            }
            else lblBDiscounte.Text = "";

            lblADiscount.Text = (book.price - book.price * (book.sale / 100)) + " ₺";
            pcbBookPic.Image = book.image;
            nupQuantity.Text = "01";
        }

        private void btnAddCard_Click(object sender, EventArgs e) ///Adds that book to shopping card
        {
            Logger.logger(book.name + " Form Addcart");
            if (nupQuantity.Text != "" && int.Parse(nupQuantity.Text) != 0)
            {
                foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
                {
                    if (it.Product == this.book)
                    {
                        it.Quantity += int.Parse(nupQuantity.Text);

                        if (it.Quantity > 99)
                        {
                            MessageBox.Show("You have reached maximum capacity." + Environment.NewLine + "Max Capacity: 99", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            it.Quantity = 99;
                        }

                        MessageBox.Show(int.Parse(nupQuantity.Text) + " " + it.Product.name + " has been added to your shopping cart.", "Info");
                        return;
                    }
                }
                ItemToPurchase item = new ItemToPurchase();
                item.Product = this.book;
                item.Quantity = int.Parse(nupQuantity.Text);
                MainForm.shoppingCart.ItemsToPurchase.Add(item);
                MessageBox.Show(item.Quantity + " " + item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)///Returns to Book Form
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  /// You can move the form 
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnltop_MouseMove(object sender, MouseEventArgs e) ///MouseMove event for upper panel to move the Form
        {
            Drag_Form(Handle, e);
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e)  { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }

        private void lblTop_MouseMove(object sender, MouseEventArgs e)///MouseMove event for upperlabel to move the Form
        {
            Drag_Form(Handle, e);
        }
    }
}
