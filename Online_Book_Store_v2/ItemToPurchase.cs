using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{

    /// <summary>
    /// This class contains the quantity to items that purschased
    /// </summary>

   public class ItemToPurchase
    {
        private Product product;
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
