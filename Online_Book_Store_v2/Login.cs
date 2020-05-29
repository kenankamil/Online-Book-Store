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
{
    public partial class Login : Form
    {
        /// <summary>
        /// uye girisinin yapildigi formdur. kullanici mail-sifre araciligiyla programa giris yapar.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        public static bool CheckForInternetConnection() ///internet baglantisi kontrol edilir.
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        private void btnGiriş_Click(object sender, EventArgs e) ///giris butonuna tiklandiginda gerekli kontroller yapilir
        {
            DataBase dh = DataBase.getInstance();
            Customer logined = Customer.getInstance();
            Customer customer = dh.CustomerHandler(txtboxEmail.Text.Trim(), txtBoxŞifre.Text.Trim());
            if (customer != null)
            {
                this.Hide();
                logined = customer;
                Logger.logger("Login");
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
                mainform = null;
                GC.Collect();
                txtboxEmail.Clear();
                txtBoxŞifre.Clear();
            }
            else
                lblUyarı.Text = "Kullanıcı şifre hatalı!";
        }

        
        private void Login_Shown(object sender, EventArgs e)///internet baglantisini kontrol eden metod calistirilir, sorun varsa hata verilir.
        {
            if (!CheckForInternetConnection())
            {
                MessageBox.Show("İnternet bağlantınızı kontrol edin. Uygulama kapatılacaktır.", "Bağlantı Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnGiriş_Click(this.btnGiriş, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pbŞifreGöster_MouseDown_1(object sender, MouseEventArgs e)///sifre kontrol
        {
            txtBoxŞifre.PasswordChar = '\0';
        }

        private void pbŞifreGöster_MouseUp_1(object sender, MouseEventArgs e)///sifre kontrol icin mouseup event
        {
            txtBoxŞifre.PasswordChar = '*';
        }

        private void btnÜyeol_Click(object sender, EventArgs e) ///uye ol butonu ile uyelik olusturma formuna yonlendirme
        {
            signUp form = new signUp();
            this.Hide();
            form.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)///close event
        {
            Application.Exit();
        }
        private void btn_minimize_Click(object sender, EventArgs e)///minimize etme butonu
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public const int WM_NCLBUTTONDOWN = 0xA1; public const int HT_CAPTION = 0x2;[DllImportAttribute("user32.dll")]  
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);[DllImportAttribute("user32.dll")] ///panelin hareketini saglamak icin kullanildi
        public static extern bool ReleaseCapture();
        private void pnlÜst_MouseMove(object sender, MouseEventArgs e) ///formun panel yardimiyla hareketi saglandi
        {
            Drag_Form(Handle, e);
        }
        public static void Drag_Form(IntPtr Handle, MouseEventArgs e) { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } }

        private void txtBoxŞifre_Enter(object sender, EventArgs e)
        {
            txtBoxŞifre.SelectAll();
        }

        private void txtboxEmail_Enter(object sender, EventArgs e)
        {
            txtboxEmail.SelectAll();
        }

        private void txtboxEmail_Click(object sender, EventArgs e)
        {
            txtboxEmail.Clear();
        }

        private void txtBoxŞifre_Click(object sender, EventArgs e)
        {
            txtBoxŞifre.Clear();
        }

        private void txtBoxŞifre_TextChanged(object sender, EventArgs e)
        {
            txtBoxŞifre.PasswordChar = '*';
        }
    }
}
