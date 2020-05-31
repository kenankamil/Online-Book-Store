using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    /// <summary>
    /// Database class's attributes and methods
    /// </summary>
    class DataBase
    {
        static private DataBase db;
        private DataBase() { }
        ///If object equals null, means no object, then creates an object and returns it.
        public static DataBase getInstance()
        {
            if (db == null)
                db = new DataBase();
            return db;
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=den1.mssql7.gear.host;User ID=bookstoreprj;Password=Zc3nF5Ht2p!!");
        public void CustomerUpdate(Customer customer) ///musteri bilgileri databasede guncellenir.
        {
            string record = "UPDATE CUSTOMER SET NAME=@NAME, ADDRESS=@ADDRESS, EMAIL=@EMAIL, PASSWORD=@PASSWORD, USERNAME=@USERNAME, PURCHASES=@PURCHASES where EMAIL=@EMAIL";
            db.sqlConnection.Open();
            SqlCommand command = new SqlCommand(record, sqlConnection);
            command.Parameters.AddWithValue("ID", customer.Id);
            command.Parameters.AddWithValue("NAME", customer.Name);
            command.Parameters.AddWithValue("ADDRESS", customer.Adress);
            command.Parameters.AddWithValue("EMAIL", customer.Email);
            command.Parameters.AddWithValue("PASSWORD", customer.Password);
            command.Parameters.AddWithValue("USERNAME", customer.Username);
            command.Parameters.AddWithValue("PURCHASES", customer.PurchCount);
            command.ExecuteNonQuery();
            db.sqlConnection.Close();
        }
        public Customer CustomerHandler(string email, string password) ///musteri bilgileri giris yapilirken databaseden kontrol edilir.
        {
            Customer customer = null;
            try
            {
                db.sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[CUSTOMER] where EMAIL = @EMAIL", sqlConnection);
                command.Parameters.AddWithValue("EMAIL", email);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                sqlDataReader.Read();

                if (password == (string)sqlDataReader["PASSWORD"])
                {
                    customer = Customer.getInstance();
                    customer.Name = (string)sqlDataReader["NAME"];
                    customer.Adress = (string)sqlDataReader["ADDRESS"];
                    customer.Email = (string)sqlDataReader["EMAIL"];
                    customer.Password = (string)sqlDataReader["PASSWORD"];
                    customer.Username = (string)sqlDataReader["USERNAME"];
                    customer.IsAdmin = (int)sqlDataReader["ISADMIN"];
                    if (!DBNull.Value.Equals(sqlDataReader["PURCHASES"]))
                        customer.PurchCount = (int)sqlDataReader["PURCHASES"];
                }
            }
            catch (InvalidOperationException)
            {

            }
            catch (Exception ex)
            {

            }
            db.sqlConnection.Close();
            return customer;
        }
        public List<Product> BookLoader() ///Loads to books
        {
            List<Product> booklist = new List<Product>();
            db.sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT *FROM [dbo].[BOOK]", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            Book book;
            while (sqlDataReader.Read())
            {
                book = new Book();
                book.id = (int)sqlDataReader["ID"];
                book.name = (string)sqlDataReader["NAME"];
                book.ISBN = (string)sqlDataReader["ISBN"];
                book.author = (string)sqlDataReader["AUTHOR"];
                book.publisher = (string)sqlDataReader["PUBLISHER"];
                book.page = (int)sqlDataReader["PAGE"];
                book.price = Convert.ToDouble(sqlDataReader["PRICE"]);
                book.sale = Convert.ToDouble(sqlDataReader["SALE"]);

                if (book.sale <= 0 || book.sale >= 100)
                    book.discountedPrice = book.price;
                else
                    book.discountedPrice = book.price - (book.price * book.sale) / 100;

                book.type = (string)sqlDataReader["CATEGORY"];
                book.summary = (string)sqlDataReader["SUMMARY"];
                
                ///image islemleri
                try
                {
                    book.image = Image.FromFile(Application.StartupPath + @"\Resources" + (string)sqlDataReader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    book.image = Properties.Resources.dasdas;
                }
                booklist.Add(book);
            }
            db.sqlConnection.Close();
            return booklist;
        }
        public List<Product> MusicCDLoader() ///Loads to Musics
        {
            List<Product> musicList = new List<Product>();
            db.sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[MUSICCD]", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            MusicCD musicCd;
            while (sqlDataReader.Read())
            {
                musicCd = new MusicCD();
                musicCd.id = (int)sqlDataReader["ID"];
                musicCd.name = (string)sqlDataReader["NAME"];
                musicCd.price = Convert.ToDouble(sqlDataReader["PRICE"]);
                musicCd.singer = (string)sqlDataReader["SINGER"];
                musicCd.type = (string)sqlDataReader["TYPE"];
                musicCd.description = (string)sqlDataReader["DESCRIPTION"];
                musicCd.sale = Convert.ToDouble(sqlDataReader["SALE"]);

                if (musicCd.sale <= 0 || musicCd.sale >= 100)
                    musicCd.discountedPrice = musicCd.price;
                else
                    musicCd.discountedPrice = musicCd.price - (musicCd.price * musicCd.sale) / 100;

                //image islemleri  
                try
                {
                    musicCd.image = Image.FromFile(Application.StartupPath + @"\Resources" + (string)sqlDataReader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    musicCd.image = Properties.Resources.dasdas;
                }
                musicList.Add(musicCd);
            }
            db.sqlConnection.Close();
            return musicList;
        }
        public List<Product> MagazineLoader() ///Loads to Magazines
        {
            List<Product> magazineList = new List<Product>();
            db.sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[MAGAZINE]", sqlConnection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            Magazine magazine;
            while (sqlDataReader.Read())
            {
                magazine = new Magazine();
                magazine.id = (int)sqlDataReader["ID"];
                magazine.name = (string)sqlDataReader["NAME"];
                magazine.description = (string)sqlDataReader["DESCRIPTION"];
                magazine.issue = (string)sqlDataReader["ISSUE"];
                magazine.price = Convert.ToDouble(sqlDataReader["PRICE"]);
                magazine.sale = Convert.ToDouble(sqlDataReader["SALE"]);
                magazine.type = (string)sqlDataReader["TYPE"];

                if (magazine.sale <= 0 || magazine.sale >= 100)
                    magazine.discountedPrice = magazine.price;
                else
                    magazine.discountedPrice = magazine.price - (magazine.price * magazine.sale) / 100;

                ///image islemleri
                try
                {
                    magazine.image = Image.FromFile(Application.StartupPath + @"\Resources" + (string)sqlDataReader["IMAGEDEST"] + ".png");
                }
                catch (Exception)
                {
                    magazine.image = Properties.Resources.dasdas;
                }
                magazineList.Add(magazine);
            }
            db.sqlConnection.Close();
            return magazineList;
        }
        public void DbUpdate(string[] values, string command) ///Updates the Database
        {
            sqlConnection.Open();
            SqlCommand sqlcommand = new SqlCommand(command, sqlConnection);
            for (int i = 0; i < values.Length; i++)
            {
                sqlcommand.Parameters.AddWithValue("" + i, values[i]);
            }
            sqlcommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
