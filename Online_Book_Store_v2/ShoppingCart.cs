using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// sepete eklenen ürünleri tutan class.
    /// </summary>
    public class ShoppingCart
    {

        public List<ItemToPurchase> ItemsToPurchase;
        //Customerın tüm elemanlarını içerir
        public Customer Customer;        
        public double PaymentAmount;
        public int PaymentType;
        ShoppingCartPanel shoppingPanel;
        List<ShoppingCardItemPanel> list;
        /// <summary>
        /// classın constructorı.
        /// </summary>
        public ShoppingCart()
        {
            ItemsToPurchase = new List<ItemToPurchase>();
        }
        /// <summary>
        /// sipariş verildikten sonra fatura forumunun açılmasını sağlar.
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
        ///  ürünü listeden silen method.
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
        /// paneli yenileyen fonksiyon.
        /// </summary>
        public void refreshPanel()
        {
            shoppingPanel.fillPanel();
        }
        /// <summary>
        /// ürünleri gösteren fonksiyon.
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
        /// bütün ürünleri iptal eden fonksiyon.
        /// </summary>
        public void CancelOrder()
        {
            ItemsToPurchase.Clear();
            list.Clear();
            PaymentAmount = 0;
            shoppingPanel.Visible = false;
            shoppingPanel.Dispose();
        }
    }
}
