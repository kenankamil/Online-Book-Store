using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// Contains products that added to shopping cart
    /// </summary>
    public class ShoppingCart
    {

        public List<ItemToPurchase> ItemsToPurchase;
        
        public Customer Customer;
        public double PaymentAmount;
        public int PaymentType;
        ShoppingCartPanel shoppingPanel;
        List<ShoppingCardItemPanel> list;
        /// <summary>
        /// Constructor
        /// </summary>
        public ShoppingCart()
        {
            ItemsToPurchase = new List<ItemToPurchase>();
        }
        /// <summary>
        /// Shows invoice
        /// </summary>
        /// <param name="shipmentAdress"></param>
        /// <param name="email"></param>
        public void PlaceOrder(string shipmentAdress, string email)
        {
            shoppingPanel.Visible = false;
            shoppingPanel.Dispose();
            Fatura fatura = new Fatura(shipmentAdress, email);
            fatura.ShowDialog();
            ItemsToPurchase.Clear();
            list.Clear();
        }
        /// <summary>
        ///  Deletes product from list
        /// </summary>
        /// <param name="item"></param>
        public void removeProduct(ItemToPurchase item)
        {
            ItemsToPurchase.Remove(item);
            foreach (var it in list)
            {
                if (it.item == item)
                {
                    list.Remove(it);
                    break;
                }
            }
            refreshPanel();
        }
        /// <summary>
        /// Refreshes the Panel
        /// </summary>
        public void refreshPanel()
        {
            shoppingPanel.fillPanel();
        }
        /// <summary>
        /// Shows the products
        /// </summary>
        /// <returns></returns>
        public List<ShoppingCardItemPanel> printProducts()
        {
            list = new List<ShoppingCardItemPanel>();
            foreach (ItemToPurchase item in ItemsToPurchase)
            {
                ShoppingCardItemPanel pnl = new ShoppingCardItemPanel(item);
                list.Add(pnl);
            }
            shoppingPanel = ShoppingCartPanel.Shopping(list);
            if (list.Count != 0)
                shoppingPanel.Show();

            return list;
        }

        /// <summary>
        /// Cancels all Orders
        /// </summary>
        public void CancelOrder()
        {
            ItemsToPurchase.Clear();
            list.Clear();
            PaymentAmount = 0;
            shoppingPanel.Visible = false;
            shoppingPanel.Dispose();
        }
        public void sendInvoicebySMS()
        {
            MessageBox.Show("Order information sent to your phone number and E-mail, Thanks for choosing us!", "E-mail and Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void sendInvoidcebyEmail()
        {
            SmtpClient sc = new SmtpClient();

            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("smtpicinmail@gmail.com", "ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("smtpicinmail@gmail.com", "Information");
            mail.Subject = "BOOK STORE";
            mail.To.Add(MainForm.shoppingCart.Customer.Email);
            mail.Attachments.Add(new Attachment(@"OrderInformation.pdf"));
            mail.IsBodyHtml = true;
            mail.Body = (" < p><p>You completed your order successfully.<p><p>Thanks for choosing us! <p>") + Environment.NewLine;

            sc.Send(mail);
        }
        public void getPDF()
        {
            Document document = new Document();
            using (var stream = new FileStream("OrderInformation.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream("OrderInformation.jpeg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);
                    float maxWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin; float maxHeight = document.PageSize.Height - document.TopMargin - document.BottomMargin; if (image.Height > maxHeight || image.Width > maxWidth) image.ScaleToFit(maxWidth, maxHeight);
                    document.Add(image);
                }
                document.Close();
            }
                System.Diagnostics.Process.Start(@"OrderInformation.pdf");
        }
    }
}
