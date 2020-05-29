using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// sepet penceresi.
    /// </summary>
    public partial class ShoppingCartPanel : UserControl
    {
        static List<ShoppingCardItemPanel> List;
        double totalPrice;
        Customer customer;
        private static ShoppingCartPanel shopping;

        /// <summary>
        /// panelin içerdiği componentlerin oluşturulduğu constructor.
        /// </summary>
        /// <param name="list"></param>
        private ShoppingCartPanel(List<ShoppingCardItemPanel> list)
        {
            InitializeComponent();
            fillPanel();
            rbCreditCard.Checked = true;
            customer = MainForm.shoppingCart.Customer;
            lblCustName.Text = customer.Name;
            txtAddress.Text = customer.Adress;
            txtEmail.Text = customer.Email;
            dtpExpDate.MinDate = DateTime.Now;
            dtpExpDate.Value = DateTime.Now;
            dtpExpDate.MaxDate = DateTime.Now.AddYears(5);
        }
        /// <summary>
        /// classın singleton olmasını sağlayan method.
        /// </summary>
        /// <param name="_list"></param>
        /// <returns></returns>
        public static ShoppingCartPanel Shopping(List<ShoppingCardItemPanel> _list)
        {
            List = _list;
            if (shopping == null)
            {
                shopping = new ShoppingCartPanel(_list);

            }
            return shopping;
        }
        /// <summary>
        /// liste halindeki ürünlerin flowpanele eklendiği ve toplam fiyatın hesaplandığı method.
        /// </summary>
        public void fillPanel()
        {
            totalPrice = 0;
            flpnlProduct.Controls.Clear();
            if (List.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add something.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Visible = false;
            }
            foreach (var item in List)
            {
                totalPrice += item.item.Product.discountedPrice * item.item.Quantity;
                flpnlProduct.Controls.Add(item);
            }
            lblTotalPrice.Text = totalPrice + " TL";
            MainForm.shoppingCart.PaymentAmount = totalPrice;

        }
        /// <summary>
        /// e mailin geçerli olup olmadığını kontrol eden fonksiyon.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// süpariş vermeye yarayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            Logger.logger("Shopping Cart Order");
            if (txtAddress.Text == "" || txtEmail.Text == "")
            {
                lblHata.Text = "Boş alan kalamaz!";
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                lblHata.Text = "Geçerli bir e-posta giriniz!";
            }

            else if (rbCreditCard.Checked && (txtCardOwner.Text == "" || !mtCardNumber.MaskFull || !mtCVC.MaskFull))
            {
                lblHata.Text = "Kart bilgilerini doğru giriniz!";
            }
            else
            {
                MainForm.shoppingCart.PlaceOrder(txtAddress.Text, txtEmail.Text);
            }
        }
        /// <summary>
        /// ödeme sayfasına yönlendiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProceedCheckout_Click(object sender, EventArgs e)
        {
            Logger.logger("Shopping Cart Checkout");
            tbcntrlShowItem.SelectedIndex = 1;

        }
        /// <summary>
        /// siparişi iptal eden method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Your order will be canceled.Do you want to proceed?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                MainForm.shoppingCart.CancelOrder();
        }
        /// <summary>
        /// alışverişe geri dönmeyi sağlayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackShopping_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        /// <summary>
        /// ürünlerin gösterildği sayfaya dönmeyi sağlayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            Logger.logger("Shopping Cart Previous");
            tbcntrlShowItem.SelectedIndex = 0;
        }
        /// <summary>
        /// nakit mi yoksa kredi kartımı olacağını değiştiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCreditCard_CheckedChanged_1(object sender, EventArgs e)
        {
            foreach (Control item in grpCreditCard.Controls)
            {
                item.Enabled = true;
            }

            btnOrder.Image = Properties.Resources.icons8_paycheque_48;
        }
        /// <summary>
        /// nakit mi yoksa kredi kartımı olacağını değiştiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCash_CheckedChanged_1(object sender, EventArgs e)
        {

            foreach (Control item in grpCreditCard.Controls)
            {
                item.Enabled = false;
            }
            btnOrder.Image = Properties.Resources.payment_method;
        }
    }
}
