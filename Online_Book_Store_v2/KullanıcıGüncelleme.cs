using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    public partial class KullanıcıGüncelleme : UserControl
    {

        /// <summary>
        /// Customer can update his/her own personal informations.
        /// </summary>

        public KullanıcıGüncelleme()
        {
            InitializeComponent();

        }
        Customer cstmr;
        private void KullanıcıGüncelleme_Load(object sender, EventArgs e)
        {
            cstmr = Customer.getInstance();
            this.Text = cstmr.Name;
            txtboxAdSoyad.Text = cstmr.Name;
            txtboxAdress.Text = cstmr.Adress;
            txtBoxEmail.Text = cstmr.Email;
            txtboxŞifre.Text = cstmr.Password;
            txtBoxŞifreTekrar.Text = cstmr.Password;
        }

        private void txtboxAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtboxAdSoyad.Text != "" && txtboxAdSoyad.Text != cstmr.Name)
                btnGüncelle.Enabled = true;
            else
                btnGüncelle.Enabled = false;
        }

        private void txtboxAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtboxAdress.Text != "" && txtboxAdress.Text != cstmr.Adress)
                btnGüncelle.Enabled = true;
            else
                btnGüncelle.Enabled = false;
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(txtBoxEmail.Text) && txtBoxEmail.Text != cstmr.Email)
                btnGüncelle.Enabled = true;
            else
                btnGüncelle.Enabled = false;
        }

        private void txtboxŞifre_TextChanged(object sender, EventArgs e)
        {
            if (txtboxŞifre.Text != "" && txtboxŞifre.Text != cstmr.Password)
                btnGüncelle.Enabled = true;
            else
                btnGüncelle.Enabled = false;
        }

        private void txtBoxŞifreTekrar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxŞifreTekrar.Text != "" && txtBoxŞifreTekrar.Text != cstmr.Password)
                btnGüncelle.Enabled = true;
            else
                btnGüncelle.Enabled = false;
        }

        private void txtboxAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtboxAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void txtBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Logger.logger("Profile Form Update");
            DataBase db = DataBase.getInstance();

            cstmr.Name = txtboxAdSoyad.Text;
            cstmr.Adress = txtboxAdress.Text;
            cstmr.Email = txtBoxEmail.Text;
            cstmr.Password = txtboxŞifre.Text;
            db.CustomerUpdate(cstmr);
            lblUyarı.Text = "Profiliniz başarı ile güncellenmiştir!";
        }

        private void pbŞifreGöster2_MouseDown(object sender, MouseEventArgs e)
        {
            txtboxŞifre.PasswordChar = '\0';
        }

        private void pbŞifreGöster2_MouseUp(object sender, MouseEventArgs e)
        {
            txtboxŞifre.PasswordChar = '*';
        }
    }
}
