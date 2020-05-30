using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// musteri classi , uye verileri vs burada tanimlidir.
    /// </summary>
   public class Customer
    {
        private long id;
        private string name;
        private string username;
        private string adress;
        private string email;
        private string password;
        private int purchCount;
        private static Customer instance;
        private int isAdmin;

        public void printCustomerDetails()
        {
            
        }
        public void saveCustomer()
        {

        }
        public void printCustomerPurchases()
        {

        }

        private Customer() { }
        public long PurchCount
        {
            get { return purchCount; }
            set { purchCount = (int)value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public static Customer getInstance()
        {
            if (instance == null)
                instance = new Customer();
            return instance;
        }

    }

}
