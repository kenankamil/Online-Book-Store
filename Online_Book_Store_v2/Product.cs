using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Online_Book_Store_v2
{
    /// <summary>
    /// Base class that contains all products properties
    /// </summary>
    public abstract class Product
    {
        public String name;
        public double price;
        public int id;
        public string type;
        public Image image;
        public double sale;
        public double discountedPrice;
        public abstract void printProperties();
    }
}
