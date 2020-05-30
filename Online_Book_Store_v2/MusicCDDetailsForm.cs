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
    public partial class MusicCDDetailsForm : Form
    {/// <summary>
     /// muzik verilerinin detaylı gösterildiği form.
     /// </summary>
        MusicCD musicCD;
        /// <summary>
        /// classın constructor methodu. 
        /// </summary>
        /// <param name="musicCD"></param> verilerin tutulduğu class
        public MusicCDDetailsForm(MusicCD musicCD)
        {
            this.musicCD = musicCD;
            InitializeComponent();
            this.Text = musicCD.name;
            pcbPicture.Image = musicCD.image;
            pcbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblName.Text = musicCD.name;
            lblSinger.Text = musicCD.singer;
            lblCategory.Text = "type:" + musicCD.type;
            if (musicCD.sale > 0 && musicCD.sale < 100)
                lblBDiscounte.Text = musicCD.price + " TL  %" + musicCD.sale;
            else
                lblBDiscounte.Text = "";
            lblADiscounte.Text = (musicCD.price - musicCD.price * (musicCD.sale / 100)) + " TL";
            string[] descriptionText = musicCD.description.Split('$');
            lblSongList.Text = "";
            for (int i = 0; i < descriptionText.Length; i++)
            {
                lblSongList.Text += descriptionText[i] + Environment.NewLine;
            }
            nupQuantity.Text = "01";
            pcbPicture.BackgroundImageLayout = ImageLayout.Zoom;
        }
        /// <summary>
        /// formu kapatmaya yarayan buton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  //paneli hareket ettirmek için
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// formun hareket etmesini sağlayan method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnltop_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e);
        }
        /// <summary>
        /// formun hareket etmesini sağlayan method.
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="e"></param>
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }
        /// <summary>
        /// ürünü sepete ekleyen method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            Logger.logger(musicCD.name + " Form Add Cart");
            if (nupQuantity.Text != "" && int.Parse(nupQuantity.Text) != 0)
            {
                foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
                {
                    if (it.Product == this.musicCD)
                    {
                        it.Quantity += int.Parse(nupQuantity.Text);

                        if (it.Quantity > 99)
                        {
                            MessageBox.Show("You have reached maximum capacity." + Environment.NewLine + "Max Capacity: 99", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            it.Quantity = 99;
                        }
                        else
                            MessageBox.Show(int.Parse(nupQuantity.Text) + " " + it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                ItemToPurchase item = new ItemToPurchase();
                item.Product = this.musicCD;
                item.Quantity = int.Parse(nupQuantity.Text);
                MainForm.shoppingCart.ItemsToPurchase.Add(item);
                MessageBox.Show(item.Quantity + " " + item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
