using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Online_Book_Store_v2
{

    /// <summary>
    /// Ths creates the general structure of the admin panel.
    /// Uses the datagridviews to user/product management
    /// </summary>

    public partial class adminControl : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=den1.mssql7.gear.host;User ID=bookstoreprj;Password=Zc3nF5Ht2p!!");
        DataSet dataset;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        int index;
        static TextBox[] customerTextArray;
        static TextBox[] bookTextArray;
        static TextBox[] magazineTextArray;
        static TextBox[] musicCDTextArray;
        DataBase dh;


        string ImageDest;
        public void refreshPanel()  ///Refreshing panels for new coming datas.
        {
            dataset.Clear();
            dh = DataBase.getInstance();
            cmd = new SqlCommand("SELECT * FROM [BOOK]; SELECT * FROM [CUSTOMER];SELECT * FROM [MUSICCD];SELECT * FROM [MAGAZINE];", sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataset);
        }
        public adminControl()   ///This codes runes when the form get loaded
        {
            InitializeComponent();
            dh = DataBase.getInstance();
            dataset = new DataSet();
            cmd = new SqlCommand("SELECT * FROM [BOOK]; SELECT * FROM [CUSTOMER];SELECT * FROM [MUSICCD];SELECT * FROM [MAGAZINE];", sqlConnection);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataset);
            dg_books.DataSource = dataset.Tables[0];
            dg_customers.DataSource = dataset.Tables[1];
            dg_musicCD.DataSource = dataset.Tables[2];
            dg_magazines.DataSource = dataset.Tables[3];
            dg_customers.SelectAll();
            customerTextArray = new TextBox[] { tb_customerUsername, tb_customerName, tb_customerAddress, tb_customerMail, tb_customerPw };
            bookTextArray = new TextBox[] { tb_bookName, tb_bookPrice, tb_isbn, tb_bookAuthor, tb_bookPublisher, tb_bookPage, tb_bookSale, tb_bookDescription, tb_bookCategory, txtBookImageName };
            magazineTextArray = new TextBox[] { tb_magazineName, tb_magazinePrice, tb_magazineIssue, tb_magazineCategory, tb_magazineSale, tb_magazineDescription, txtMgzImageName };
            musicCDTextArray = new TextBox[] { tb_musicCDName, tb_musicCDPrice, tb_musicCDSinger, tb_musicCDCategory, tb_musicCDDescription, tb_musicCDSale, txtMusicImageName };
            btn_addBook.Enabled = false;
            btn_addMagazine.Enabled = false;
            btn_addMusic.Enabled = false;
            btn_updateBook.Enabled = false;
            btn_deleteBook.Enabled = false;
            btn_deleteMagazine.Enabled = false;
            btn_updateMagazine.Enabled = false;
            btn_deleteMusic.Enabled = false;
            btn_updateMusic.Enabled = false;
            btn_customerDelete.Enabled = false;
            btn_customer_update.Enabled = false; //customer update 'di sonra degistir.

        }

        private void txtNameControl_KeyPress(object sender, KeyPressEventArgs e)    /// name textbox icin keypress islemi, istenmeyen karakter girişi engeli
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) || System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }

        }

        private void txtCharacterControl_KeyPress(object sender, KeyPressEventArgs e) ///keypress islemi, istenmeyen karakter girisi engeli
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        bool IsValidEmail(string email) ///Checks the email
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

        private bool checkWhiteSpace(TextBox[] array)   ///Checks the whitespaces in array
        {
            foreach (var item in array)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                    return false;
            }
            return true;
        }

        private void DigitControl(object sender, KeyPressEventArgs e)   ///Controls the digits to keypress event, designer included
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Dg_customers_CellClick(object sender, DataGridViewCellEventArgs e) ///datagrid cell click, fullrowselect modunda tum satiri secer, textboxlara yazdirir.
        {

            index = e.RowIndex;
            btn_customerDelete.Enabled = true;
            btn_customer_update.Enabled = true; //cust update 
            DataGridViewRow row = dg_customers.Rows[index];
            DataGridViewCellCollection cells = row.Cells;
            tb_customerName.Text = cells[1].Value.ToString();
            tb_customerAddress.Text = cells[2].Value.ToString();
            tb_customerMail.Text = cells[3].Value.ToString();
            tb_customerPw.Text = cells[4].Value.ToString();
            tb_customerUsername.Text = cells[5].Value.ToString();
            if ((int)cells[6].Value == 1)
            {
                cbIsRoot.Checked = true;
            }
            else
            {
                cbIsRoot.Checked = false;
            }
        }

        private void btn_customerDelete_Click(object sender, EventArgs e)   ///Deletes the customer
        {
            string table = "";
            string Id;

            var btn = sender as Button;
            if (btn.Name == "btn_customerDelete")
            {
                Customer cstmr = Customer.getInstance();
                table = "[Customer]";
                DataGridViewRow row = dg_customers.Rows[index];

                Id = row.Cells[0].Value.ToString();
                if (Id == cstmr.Id.ToString())
                {
                    MessageBox.Show("You can't delete yourself.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else if (btn.Name == "btn_deleteBook")
            {
                table = "[Book]";
                DataGridViewRow row = dg_books.Rows[index];
                Id = row.Cells[0].Value.ToString();
                tb_bookName.Text = "";
                tb_bookAuthor.Text = "";
                tb_bookPublisher.Text = "";
                tb_bookPage.Text = "";
                tb_bookPrice.Text = "";
                tb_bookSale.Text = "";
                tb_bookCategory.Text = "";
                tb_bookDescription.Text = "";
                tb_isbn.Text = "";
            }
            else if (btn.Name == "btn_deleteMusic")
            {
                table = "[MusicCD]";
                DataGridViewRow row = dg_musicCD.Rows[index];
                Id = row.Cells[0].Value.ToString();
                tb_musicCDName.Text = "";
                tb_musicCDSinger.Text = "";
                tb_musicCDDescription.Text = "";
                tb_musicCDPrice.Text = "";
                tb_musicCDSale.Text = "";
                tb_musicCDCategory.Text = "";
            }
            else
            {
                table = "[Magazine]";
                DataGridViewRow row = dg_magazines.Rows[index];
                Id = row.Cells[0].Value.ToString();
                tb_magazineName.Text = "";
                tb_magazineCategory.Text = "";
                tb_magazinePrice.Text = "";
                tb_magazineSale.Text = "";
                tb_magazineIssue.Text = "";
                tb_magazineDescription.Text = "";
            }
            sqlConnection.Open();
            string command = "DELETE FROM " + table + " WHERE ID = '" + Id + "'";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            refreshPanel();

        }

        private void btn_addBook_Click(object sender, EventArgs e)///Adds book
        {
            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdString = "INSERT INTO BOOK (NAME,PRICE,ISBN, AUTHOR, PUBLISHER, PAGE, SALE, SUMMARY, CATEGORY,IMAGEDEST) VALUES (@0, @1, @2, @3,@4, @5, @6, @7, @8,@9)";
            string[] values = new string[bookTextArray.Length];
            for (int i = 0; i < bookTextArray.Length; i++)
            {
                values[i] = bookTextArray[i].Text;
            }
            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\" + txtBookImageName.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }
            dh.DbUpdate(values, cmdString);
            refreshPanel();
        }

        private void btn_addMagazine_Click(object sender, EventArgs e) ///Adds Magazine
        {
            if (!checkWhiteSpace(magazineTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdString = "INSERT INTO MAGAZINE (NAME,PRICE,ISSUE, TYPE, SALE, DESCRIPTION,IMAGEDEST) VALUES (@0, @1, @2, @3,@4, @5,@6)";
            string[] values = new string[magazineTextArray.Length];
            for (int i = 0; i < magazineTextArray.Length; i++)
            {
                values[i] = magazineTextArray[i].Text;
            }
            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\" + txtMgzImageName.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }
            dh.DbUpdate(values, cmdString);
            refreshPanel();
        }

        private void btn_addMusic_Click(object sender, EventArgs e) ///Adds MusicCD
        {
            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdString = "INSERT INTO MUSICCD (NAME, PRICE, SINGER,TYPE, DESCRIPTION, SALE,IMAGEDEST) VALUES (@0, @1, @2, @3,@4, @5, @6)";
            string[] values = new string[musicCDTextArray.Length];

            for (int i = 0; i < musicCDTextArray.Length; i++)
            {
                values[i] = musicCDTextArray[i].Text;
            }

            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\" + txtMusicImageName.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }
            dh.DbUpdate(values, cmdString);
            refreshPanel();
        }

        private void cbIsRoot_CheckedChanged_1(object sender, EventArgs e)///Checks the state of customer if he/she is admin or not
        {
            Customer cstmr = Customer.getInstance();

            if (tb_customerMail.Text == cstmr.Email && cbIsRoot.Checked == false)    //username to mail
            {
                DialogResult dr = MessageBox.Show("If you do this you will lose your root access. Do you want to proceed?.", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    btn_customer_update.PerformClick();
                    cstmr.IsAdmin = 1;
                    this.Close();
                }
                else
                    cbIsRoot.Checked = true;
            }
        }

        private void tb_bookPage_KeyPress(object sender, KeyPressEventArgs e)///keypress control
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_magazineIssue_KeyPress(object sender, KeyPressEventArgs e)///keypress event for magazine count
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_customer_update_Click(object sender, EventArgs e) ///Click event for customer update
        {
            if (!checkWhiteSpace(customerTextArray) || !IsValidEmail(tb_customerMail.Text))
            {
                MessageBox.Show("There are invalid data. Please fill all fields and/or enter a valid mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kayit = "UPDATE CUSTOMER SET Username=@USERNAME, Name=@NAME,Address=@ADDRESS,Email=@EMAIL,Password=@PASSWORD,Purchases=@PURCHASES,IsAdmin=@ISADMIN where ID=@ID";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(kayit, sqlConnection);

            DataGridViewRow row = dg_customers.Rows[index];
            cmd.Parameters.AddWithValue("ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("Username", tb_customerUsername.Text);
            cmd.Parameters.AddWithValue("Name", tb_customerName.Text);
            cmd.Parameters.AddWithValue("Address", tb_customerAddress.Text);
            cmd.Parameters.AddWithValue("Email", tb_customerMail.Text);
            cmd.Parameters.AddWithValue("Password", tb_customerPw.Text);
            cmd.Parameters.AddWithValue("Purchases", row.Cells[7].Value);
            if (cbIsRoot.Checked)
                cmd.Parameters.AddWithValue("IsAdmin", 1);
            else
                cmd.Parameters.AddWithValue("IsAdmin", 0);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            refreshPanel();
        }

        private void btn_updateBook_Click(object sender, EventArgs e) ///Click event for book update
        {
            if (!checkWhiteSpace(bookTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow row = dg_books.Rows[index];
            string kayit = "UPDATE Book SET NAME=@1,PRICE=@2,ISBN=@3,AUTHOR=@4,PUBLISHER=@5,PAGE=@6,SALE=@7,SUMMARY=@8,CATEGORY=@9,IMAGEDEST=@10 where ID=@0";
            string[] values = { row.Cells[0].Value.ToString(), tb_bookName.Text,tb_bookPrice.Text, tb_isbn.Text, tb_bookAuthor.Text, tb_bookPublisher.Text, tb_bookPage.Text, tb_bookSale.Text,
                tb_bookDescription.Text, tb_bookCategory.Text,txtBookImageName.Text };
            dh.DbUpdate(values, kayit);
            refreshPanel();
        }

        private void btn_updateMagazine_Click(object sender, EventArgs e) ///Click event for Magazine Update
        {
            if (!checkWhiteSpace(magazineTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kayit = "UPDATE Magazine SET NAME=@1,PRICE=@2,ISSUE=@3,TYPE=@4,SALE=@5,DESCRIPTION=@6,IMAGEDEST=@7 where ID=@0";
            DataGridViewRow row = dg_magazines.Rows[index];
            string[] values = { row.Cells[0].Value.ToString(), tb_magazineName.Text, tb_magazinePrice.Text,tb_magazineIssue.Text, tb_magazineCategory.Text, tb_magazineSale.Text,
                tb_magazineDescription.Text,txtMgzImageName.Text };
            dh.DbUpdate(values, kayit);
            refreshPanel();
        }

        private void btn_updateMusic_Click(object sender, EventArgs e)///Music Update
        {
            if (!checkWhiteSpace(musicCDTextArray))
            {
                MessageBox.Show("There are invalid data. Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string kayit = "UPDATE MusicCD SET NAME=@1,PRICE=@2,SINGER=@3,TYPE=@4,DESCRIPTION=@5,SALE=@6,IMAGEDEST=@7  where ID=@0";
            DataGridViewRow row = dg_musicCD.Rows[index];
            string[] values = { row.Cells[0].Value.ToString(), tb_musicCDName.Text, tb_musicCDPrice.Text, tb_musicCDSinger.Text, tb_musicCDCategory.Text, tb_musicCDDescription.Text, tb_musicCDSale.Text, txtMusicImageName.Text };
            dh.DbUpdate(values, kayit);
            refreshPanel();
        }

        private void tabControl_adminPanel_SelectedIndexChanged(object sender, EventArgs e) 
        {
            DataGridViewCellEventArgs a = new DataGridViewCellEventArgs(0, 0);

            if (tabControl_adminPanel.SelectedIndex == 0)
            {
                dg_customers.ClearSelection();
                Dg_customers_CellClick(dg_customers, a);
            }
            else if (tabControl_adminPanel.SelectedIndex == 1)
            {
                dg_books.ClearSelection();
                dg_books_CellClick(dg_books, a);
            }
            else if (tabControl_adminPanel.SelectedIndex == 2)
            {
                dg_magazines.ClearSelection();
                dg_magazines_CellClick(dg_magazines, a);
            }
            else
            {
                dg_musicCD.ClearSelection();
                dg_musicCD_CellClick(dg_musicCD, a);
            }
        }

        private void btn_addBookPicture_Click(object sender, EventArgs e) /// Add picture button
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "PNG Files (*.png) | *.png";
            openFileDialog1.Title = "Resim Seciniz";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            ImageDest = openFileDialog1.FileName;
            try
            {
                pb_Books.Image = Image.FromFile(ImageDest);
            }
            catch (Exception) { }
        }

        private void btn_addMagazinePicture_Click(object sender, EventArgs e) ///Add pic to Magazine
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "PNG Files (*.png) | *.png";
            openFileDialog1.Title = "Resim Seciniz";
            openFileDialog1.ShowDialog();
            ImageDest = openFileDialog1.FileName;

            try
            {
                pb_Magazines.Image = Image.FromFile(ImageDest);
            }
            catch (Exception)
            { }

        }
        private void btn_addMusicPicture_Click(object sender, EventArgs e) ///Add pic to Music
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "PNG Files (*.png) | *.png";
            openFileDialog1.Title = "Resim Seciniz";
            openFileDialog1.ShowDialog();
            ImageDest = openFileDialog1.FileName;

            try
            {
                pb_MusicCd.Image = Image.FromFile(ImageDest);
            }
            catch (Exception)
            { }
        }

        private void dg_books_CellClick(object sender, DataGridViewCellEventArgs e) ///Selecting row from datagridview
        {
            index = e.RowIndex;
            btn_addBook.Enabled = false;
            btn_updateBook.Enabled = true;
            btn_deleteBook.Enabled = true;
            btn_addBookPicture.Enabled = true;
            if (index == dg_books.RowCount - 1)
            {
                pb_Books.Image = null;
                btn_addBook.Enabled = true;
                btn_updateBook.Enabled = false;
                btn_deleteBook.Enabled = false;
                btn_addBookPicture.Enabled = true;
            }
            if (dg_books.Rows.Count == 1)
            {
                tb_bookName.Text = "";
                tb_bookAuthor.Text = "";
                tb_bookPublisher.Text = "";
                tb_bookPage.Text = "";
                tb_bookPrice.Text = "";
                tb_bookSale.Text = "";
                tb_bookCategory.Text = "";
                tb_bookDescription.Text = "";
                tb_isbn.Text = "";
                txtMgzImageName.Text = "";
            }
            else
            {
                DataGridViewRow row = dg_books.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                tb_bookName.Text = cells[1].Value.ToString();
                tb_bookAuthor.Text = cells[4].Value.ToString();
                tb_bookPublisher.Text = cells[5].Value.ToString();
                tb_bookPage.Text = cells[6].Value.ToString();
                tb_bookPrice.Text = cells[2].Value.ToString();
                tb_bookSale.Text = cells[7].Value.ToString();
                tb_bookCategory.Text = cells[9].Value.ToString();
                tb_bookDescription.Text = cells[8].Value.ToString();
                tb_isbn.Text = cells[3].Value.ToString();
                txtBookImageName.Text = cells[10].Value.ToString();
            }
            if (ImageDest != null)
            {
                string destPath = Application.StartupPath + @"\Resources\" + txtBookImageName.Text + ".png";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\");
                File.Copy(ImageDest, destPath, true);
                ImageDest = null;
            }

            if (index != dg_books.RowCount - 1)
            {
                try
                {
                    pb_Books.Image = Image.FromFile(Application.StartupPath + @"\Resources\" + txtBookImageName.Text + ".png");
                }
                catch (Exception)
                {
                    pb_Books.Image = Properties.Resources.dasdas;
                }
            }

        }

        private void dg_magazines_CellClick(object sender, DataGridViewCellEventArgs e)///Selecting spesific magazine from magazine datagrid
        {
            index = e.RowIndex;
            btn_addMagazine.Enabled = false;
            btn_deleteMagazine.Enabled = true;
            btn_updateMagazine.Enabled = true;

            if (index == dg_magazines.RowCount - 1)
            {
                pb_Magazines.Image = null;
                btn_addMagazine.Enabled = true;
                btn_deleteMagazine.Enabled = false;
                btn_updateMagazine.Enabled = false;
                btn_addMagazinePicture.Enabled = true;
            }
            if (dg_magazines.Rows.Count == 1)
            {
                tb_magazineName.Text = "";
                tb_magazineCategory.Text = "";
                tb_magazinePrice.Text = "";
                tb_magazineSale.Text = "";
                tb_magazineIssue.Text = "";
                tb_magazineDescription.Text = "";
                txtMgzImageName.Text = "";
            }
            else
            {
                DataGridViewRow row = dg_magazines.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                tb_magazineName.Text = cells[1].Value.ToString();
                tb_magazinePrice.Text = cells[2].Value.ToString();
                tb_magazineIssue.Text = cells[3].Value.ToString();
                tb_magazineCategory.Text = cells[4].Value.ToString();
                tb_magazineSale.Text = cells[5].Value.ToString();
                tb_magazineDescription.Text = cells[6].Value.ToString();
                txtMgzImageName.Text = cells[7].Value.ToString();
            }

            if (index != dg_magazines.RowCount - 1)
            {
                try
                {
                    pb_Magazines.Image = Image.FromFile(Application.StartupPath + @"\Resources\" + txtMgzImageName.Text + ".png");
                }
                catch (Exception)
                {
                    pb_Magazines.Image = Properties.Resources.dasdas;
                }
            }
        }

        private void dg_musicCD_CellClick(object sender, DataGridViewCellEventArgs e)///Selecting spesific magazine from music datagrid
        {
            index = e.RowIndex;
            btn_addMusic.Enabled = false;
            btn_updateMusic.Enabled = true;
            btn_deleteMusic.Enabled = true;

            if (index == dg_musicCD.RowCount - 1)
            {
                pb_MusicCd.Image = null;
                btn_addMusic.Enabled = true;
                btn_updateMusic.Enabled = false;
                btn_deleteMusic.Enabled = false;
                btn_addMusicPicture.Enabled = true;
            }
            if (dg_musicCD.Rows.Count == 1)
            {
                tb_musicCDName.Text = "";
                tb_musicCDSinger.Text = "";
                tb_musicCDDescription.Text = "";
                tb_musicCDPrice.Text = "";
                tb_musicCDSale.Text = "";
                tb_musicCDCategory.Text = "";
            }
            else
            {
                DataGridViewRow row = dg_musicCD.Rows[index];
                DataGridViewCellCollection cells = row.Cells;
                tb_musicCDName.Text = cells[1].Value.ToString();
                tb_musicCDSinger.Text = cells[3].Value.ToString();
                tb_musicCDDescription.Text = cells[5].Value.ToString();
                tb_musicCDPrice.Text = cells[2].Value.ToString();
                tb_musicCDSale.Text = cells[6].Value.ToString();
                tb_musicCDCategory.Text = cells[4].Value.ToString();
                txtMusicImageName.Text = cells[7].Value.ToString();
            }

            if (index != dg_musicCD.RowCount - 1)
            {
                try
                {
                    pb_MusicCd.Image = Image.FromFile(Application.StartupPath + @"\Resources\" + txtMusicImageName.Text + ".png");
                }
                catch (Exception)
                {
                    pb_MusicCd.Image = Properties.Resources.dasdas;
                }
            }
        }
    }
}