using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Online_Book_Store_v2
{
    /// <summary>
    /// Base panel 
    /// </summary>
    class ProductPanel : Panel
    {
        public Label name;
        public PictureBox picBox;
        public PictureBox magnifier;
        public PictureBox picAdd;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}

