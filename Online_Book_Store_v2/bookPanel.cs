using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Online_Book_Store_v2
{
    class BookPanel: ProductPanel   ///inheritance product panel to book panel 
    {
        public Label Author;
        public Label Publisher;
        public Label Price1;
        public Label Price2;
        public Book book;
        

        public BookPanel(Book item) ///Each of every book shows in different squares
        {
            book = item;
            this.BackColor = Color.Transparent;
            this.Size = new Size(350, 190);
            this.BorderStyle = BorderStyle.FixedSingle;


            picBox = new PictureBox();
            picBox.Size = new Size(105, 160);
            picBox.BackgroundImage = item.image;
            picBox.BackgroundImageLayout = ImageLayout.Zoom;

            magnifier = new PictureBox();
            magnifier.Size = new Size(32, 32);
            magnifier.BackgroundImage = Properties.Resources.magnifier;
            magnifier.BackgroundImageLayout = ImageLayout.Zoom;
            magnifier.Cursor = Cursors.Hand;
            magnifier.Click += new EventHandler(magnifierClick);

            picAdd = new PictureBox();
            picAdd.Size = new Size(32, 32);
            picAdd.BackgroundImage = Properties.Resources.cart;
            picAdd.BackgroundImageLayout = ImageLayout.Zoom;
            picAdd.Cursor = Cursors.Hand;
            picAdd.Click += new EventHandler(addCart);

            name = new Label();
            name.AutoSize = true;
            name.Text = item.name;
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(name);

            Author = new Label();
            Author.AutoSize = true;
            Author.Text = item.author;
            Author.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Controls.Add(Author);

            Publisher = new Label();
            Publisher.AutoSize = true;
            Publisher.Text = item.publisher;
            Publisher.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Publisher.ForeColor = Color.Black;
            this.Controls.Add(Publisher);

            Price1 = new Label();
            Price1.AutoSize = true;

            if (item.sale > 0 && item.sale < 100)
                Price1.Text = item.price + "TL  %" + item.sale;
            else
                Price1.Text = "";

            Price1.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Price1.ForeColor = Color.Black;
            this.Controls.Add(Price1);

            Price2 = new Label();
            Price2.AutoSize = true;
            Price2.Text = item.discountedPrice + " TL";
            Price2.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));      
            this.Controls.Add(Price2);

            this.Controls[0].Location = new Point(125, 20);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(125, 50);// author label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(125, 80);// publisher label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(125, 110);//  Price1 label
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(210, 110);// Price2 label
            this.Controls[4].BringToFront();
            this.Controls.Add(picBox);
            this.Controls[5].Location = new Point(10, 15); //Item image
            this.Controls.Add(magnifier);
            this.Controls[6].Location = new Point(250, 140); //Magnifier image
            this.Controls.Add(picAdd);
            this.Controls[7].Location = new Point(305, 140); //Add to cart image
        }

        void magnifierClick(object sender, EventArgs e)
        {
           
            Logger.logger(book.name + " Panel Magnifier");
            book.printProperties();
        }

        void addCart(object sender, EventArgs e)
        {

            Logger.logger(book.name + " Panel Add Cart");
            foreach (var it in MainForm.shoppingCart.ItemsToPurchase)
            {
                if (it.Product == this.book)
                {
                    it.Quantity++;
                    MessageBox.Show(it.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ItemToPurchase item = new ItemToPurchase();
            item.Product = this.book;
            item.Quantity = 1;
            MainForm.shoppingCart.ItemsToPurchase.Add(item);
            MessageBox.Show(item.Product.name + " has been added to your shopping cart.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

