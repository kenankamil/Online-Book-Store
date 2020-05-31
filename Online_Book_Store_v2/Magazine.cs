using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
    ///Magazine Class get created
    public class Magazine : Product
    {
        public String issue;
        public string description;
       
       
        public override void printProperties()
        {
            MagazineDetailsForm magazineForm = new MagazineDetailsForm(this);
            magazineForm.ShowDialog();
            magazineForm.Dispose();
            
        }

    }
}
