using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Online_Book_Store_v2
{
    public partial class MagazineDetailsForm : Form
    {

        /// <summary>
        /// secilen derginin detaylarini gosteren formdur
        /// </summary>

        Magazine magazine;
        public MagazineDetailsForm(Magazine magazine) ///secilen dergiye ozel bilgiler yerlestirilir, kullaniciya sunulur.
        {
            InitializeComponent();

            this.magazine = magazine;
            this.Text = magazine.name;

            pcbPicture.Image = magazine.image;
            pcbPicture.SizeMode = PictureBoxSizeMode.Zoom;
          

            lblName.Text = magazine.name;
            
            lblCategory.Text = "type:" + magazine.type;

            if (magazine.sale > 0 && magazine.sale < 100)
                lblBDiscount.Text = magazine.price + " TL  %" + magazine.sale;
            else
                lblBDiscount.Text = "";

            lblADiscounte.Text = (magazine.price - magazine.price * (magazine.sale / 100)) + " TL";
            lblSum.Text = magazine.description;

           
        }
        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  /// panelin hareketini saglamak için gerekli kod
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnltop_MouseMove(object sender, MouseEventArgs e) ///formun uzerine panel yerlestirilir, bu paneli hareket ettirerek formun hareketini saglamis oluruz.
        {
            Drag_Form(Handle, e);
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } } ///drag form

        private void btnBack_Click(object sender, EventArgs e) ///detayli urun gosterimini kapatir.
        {
            this.Close();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {

        }

        private void lblTop_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);        
        }
    }
}
