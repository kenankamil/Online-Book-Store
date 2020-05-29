using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store_v2
{
    class FactoryPanelCreator
    {
        public ProductPanel CreatePanel(Product p)
        {
            ProductPanel panel = null;

            if (p is Book)
            {
                panel = new BookPanel((Book)p);
            }
            else if (p is Magazine)
            {
                panel = new MagazinePanel((Magazine)p);
            }
            else
                panel = new MusicCDPanel((MusicCD)p);

            return panel;
        }
    }
}
