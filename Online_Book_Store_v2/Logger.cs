using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// kullanicinin program uzerinde tikladigi butonlar vs kayit altina alinir.
    /// </summary>
    class Logger
    {
        public static void logger(string btnLog)
        {
            Customer cstmr = Customer.getInstance();
            string log = cstmr.Name + "\t\t" + btnLog + " Button\t\t" + DateTime.Now.ToShortDateString() + "\t" + DateTime.Now.ToLongTimeString();
            string path = Application.StartupPath + @"/Log.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", "Username", "Button Info", "Date", "Time"));
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", cstmr.Name, btnLog, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", cstmr.Name, btnLog, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
            }
        }
    }
}
