using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{    /// <summary>
/// Main Application Form 
/// </summary>
    public partial class MainForm : Form
    {
        WebClient wc = new WebClient();
        Customer user;
        List<Product> booklist;
        List<Product> musiclist;
        List<Product> magazinelist;
        List<Product> CurrentProductList;
        List<Product> tmpList;
        List<ShoppingCardItemPanel> list;
        FactoryPanelCreator panelCreator;
        ArrayList productList;

        public static ShoppingCart shoppingCart;
        public MainForm()
        {
            InitializeComponent();

            shoppingCart = new ShoppingCart();
            user = Customer.getInstance();

            btnAdmin.Visible = Convert.ToBoolean(user.IsAdmin);
            this.Text += " - " + user.Name;
            shoppingCart.Customer = user;

            CurrentProductList = new List<Product>();
            lblName.Text = user.Name;
            cmbSortBy.SelectedIndex = 0;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  //paneli hareket ettirmek için
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        /// <summary>
        /// This function created for move the Panel with MouseMove event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Drag_Form(Handle, e); //panel2 hareket etmesi için
        }
        /// <summary>
        /// Copyright function for move the panel  / Drag_Form
        /// </summary>
        /// <param name="Handle"></param>
        /// <param name="e"></param>
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }
        /// <summary>
        /// Exit button code to close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This Function changes the state of the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// This function shows the Book Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            flpnlShowItem.Controls.Clear();
            CurrentProductList.Clear();
            cmbCategory.Items.Clear();
            string[] category = new string[] { "All", "Adventure", "Horror", "Sci-Fi" };
            cmbCategory.Items.AddRange(category);
            cmbCategory.SelectedIndex = 0;
            foreach (var item in (List<Product>)productList[0])
            {
                if (item.type == cmbCategory.SelectedItem.ToString())
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
                else if (cmbCategory.SelectedItem.ToString() == "All")
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
            }
            cmbSortBy.SelectedIndex = 0;

        }
        /// <summary>
        /// This func shows the Magazine Form when you clicked the related button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            flpnlShowItem.Controls.Clear();
            CurrentProductList.Clear();
            cmbCategory.Items.Clear();
            string[] category = new string[] { "All", "History", "Science", "Sport" };
            cmbCategory.Items.AddRange(category);
            cmbCategory.SelectedIndex = 0;
            foreach (var item in (List<Product>)productList[1])
            {
                if (item.type == cmbCategory.SelectedItem.ToString())
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
                else if (cmbCategory.SelectedItem.ToString() == "All")
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
            }

        }
        /// <summary>
        /// This function shows the Shopping Cart Form when you clicked the related button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            Logger.logger("Main Form Shopping Cart");
            CurrentProductList.Clear();
            list = new List<ShoppingCardItemPanel>();
            list = shoppingCart.printProducts();
            ShoppingCartPanel pnl = ShoppingCartPanel.Shopping(list);
            flpnlShowItem.Controls.Clear();
            pnl.fillPanel();
            flpnlShowItem.Controls.Add(pnl);

        }
        /// <summary>
        /// This function shows the Music Form when you clicked the related button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMusicCd_Click(object sender, EventArgs e)
        {
            flpnlShowItem.Controls.Clear();
            CurrentProductList.Clear();
            cmbCategory.Items.Clear();
            string[] category = new string[] { "All", "Rap", "Metal", "Rock", "Pop" };
            cmbCategory.Items.AddRange(category);
            cmbCategory.SelectedIndex = 0;
            foreach (var item in (List<Product>)productList[2])
            {
                if (item.type == cmbCategory.SelectedItem.ToString())
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
                else if (cmbCategory.SelectedItem.ToString() == "All")
                {
                    CurrentProductList.Add(item);
                    ProductPanel pnl = panelCreator.CreatePanel(item);
                    flpnlShowItem.Controls.Add(pnl);
                }
            }
        }

        /// <summary>
        /// This function contains codes that must run before the Main Form get loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            panelCreator = new FactoryPanelCreator();
            DataBase dh = DataBase.getInstance();
            productList = new ArrayList();
            booklist = dh.BookLoader();
            CurrentProductList.AddRange(booklist);
            musiclist = dh.MusicCDLoader();
            magazinelist = dh.MagazineLoader();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);
            btnBook.PerformClick();
        }
        /// <summary>
        /// With this function, you can categorize the products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpnlShowItem.Controls.Clear();

            switch (cmbCategory.SelectedIndex)
            {
                case 0:
                    foreach (var item in CurrentProductList.ToList())
                    {

                        ProductPanel pnl = panelCreator.CreatePanel(item);
                        flpnlShowItem.Controls.Add(pnl);
                    }
                    break;
                default:
                    foreach (var item in CurrentProductList)
                    {
                        if (item.type == cmbCategory.SelectedItem.ToString())
                        {
                            ProductPanel pnl = panelCreator.CreatePanel(item);
                            flpnlShowItem.Controls.Add(pnl);
                        }
                    }
                    break;

            }

        }
        /// <summary>
        /// This function shows the Administration Form that you can add, delete or update products and customers. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Logger.logger(" Main Form Root");
            DataBase dh = DataBase.getInstance();
            adminControl admin = new adminControl();
            admin.ShowDialog();
            booklist.Clear();
            musiclist.Clear();
            magazinelist.Clear();
            CurrentProductList.Clear();
            booklist = dh.BookLoader();
            CurrentProductList.AddRange(booklist);

            musiclist = dh.MusicCDLoader();
            magazinelist = dh.MagazineLoader();
            productList.Clear();
            productList.Add(booklist);
            productList.Add(magazinelist);
            productList.Add(musiclist);

            btnAdmin.Visible = Convert.ToBoolean(user.IsAdmin);

        }

        /// <summary>
        /// This timer shows the count of the products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (shoppingCart.ItemsToPurchase.Count == 0)
            {
                this.btnShoppingCart.Text = "Shopping Cart";
            }
            else
            {
                this.btnShoppingCart.Text = "Shopping Cart(" + shoppingCart.ItemsToPurchase.Count + ")";
            }
        }
        /// <summary>
        /// This shows all products that added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_home_Click(object sender, EventArgs e)
        {
            tmpList = new List<Product>();


            flpnlShowItem.Controls.Clear();
            for (int i = 0; i < productList.Count; i++)
            {
                foreach (var item in (List<Product>)productList[i])
                {
                    tmpList.Add(item);
                }
            }
            foreach (var item in tmpList)
            {

                CurrentProductList.Add(item);
                ProductPanel pnl = panelCreator.CreatePanel(item);
                flpnlShowItem.Controls.Add(pnl);

            }
        }
        /// <summary>
        /// With this function you can sort your products via name or price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSortBy.SelectedIndex)
            {
                case 1:
                    CurrentProductList = CurrentProductList.OrderBy(o => o.name).ToList();
                    break;

                case 2:
                    CurrentProductList = CurrentProductList.OrderByDescending(o => o.name).ToList();
                    break;

                case 3:
                    CurrentProductList = CurrentProductList.OrderBy(o => o.discountedPrice).ToList();
                    break;

                case 4:
                    CurrentProductList = CurrentProductList.OrderByDescending(o => o.discountedPrice).ToList();
                    break;

                default:
                    break;
            }
            flpnlShowItem.Controls.Clear();
            foreach (Product item in CurrentProductList)
            {
                ProductPanel pnl = panelCreator.CreatePanel(item);
                flpnlShowItem.Controls.Add(pnl);
            }
        }
        /// <summary>
        /// This function shows the details of customers profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserAdmin_Click(object sender, EventArgs e)
        {
            Logger.logger(" Main Form My Profile");
            KullanıcıGüncelleme userPanel = new KullanıcıGüncelleme();
            flpnlShowItem.Controls.Clear();
            flpnlShowItem.Controls.Add(userPanel);
            lblName.Text = user.Name.ToString();
        }
    }
}
