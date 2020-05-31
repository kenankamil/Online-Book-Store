using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{

    /// <summary>
    /// Book class's attributes and methods
    /// </summary>
    public class Book:Product
    {
        public String author;
        public String publisher;
        public String ISBN;
        public int page;
        public string summary;
        

        public override void printProperties()  
        {
            BookDetailsForm bookForm = new BookDetailsForm(this);
            bookForm.ShowDialog();
            bookForm.Dispose();
        }   
    }
}
