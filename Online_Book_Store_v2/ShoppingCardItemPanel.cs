using System;
using System.Drawing;
using System.Windows.Forms;


namespace Online_Book_Store_v2
{ /// <summary>
/// shoppincard panelinde gösterilen ürünlerin paneli.
/// </summary>
    public class ShoppingCardItemPanel : Panel
    {
        private Label lblItemName;
        private Label lblItemType;
        private Label lblPrice;
        private Button btnRemove;
        private ComboBox cbQuantity;
        private PictureBox pbThumbnail;
        public ItemToPurchase item;
        /// <summary>
        /// panelin içerdiği componentlerin oluşturulduğu constructor.
        /// </summary>
        /// <param name="item"></param>
        public ShoppingCardItemPanel(ItemToPurchase item)
        {
            this.item = item;
            this.Size = new Size(530, 90);
            this.BorderStyle = BorderStyle.FixedSingle;

            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.lblItemName.AutoSize = false;
            this.lblItemName.Size = new System.Drawing.Size(200, 20);
            this.lblItemName.Text = item.Product.name;
            this.lblItemName.BackColor = Color.Transparent;
            this.lblItemName.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

            // 
            // label2
            // 
            this.lblItemType.AutoSize = false;
            this.lblItemType.Size = new System.Drawing.Size(200, 15);
            this.lblItemName.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemType.TabIndex = 0;
            if (item.Product is Book)
                lblItemType.Text = "Book";
            else if (item.Product is Magazine)
                lblItemType.Text = "Magazine";
            else
                lblItemType.Text = "Music CD";
            lblItemType.BackColor = Color.Transparent;

            // 
            // label3
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblItemName.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Text = item.Product.discountedPrice * item.Quantity + " TL";
            this.lblPrice.BackColor = Color.Transparent;

            // 
            // button1
            // 
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.TextAlign = ContentAlignment.MiddleRight;
            this.btnRemove.Size = new System.Drawing.Size(130, 25);
            this.btnRemove.FlatStyle = FlatStyle.Flat;
            this.btnRemove.BackColor = Color.Snow;
            this.btnRemove.Click += new EventHandler(butonClick);
            this.btnRemove.Image = Properties.Resources.garbage_16;
            this.btnRemove.ImageAlign = ContentAlignment.MiddleLeft;


            // 
            // comboBox1
            // 
            for (int i = 1; i <= 100; i++)
            {
                this.cbQuantity.Items.Add(i.ToString());
            }
            this.cbQuantity.SelectedIndex = item.Quantity - 1;
            this.cbQuantity.SelectedIndexChanged += new EventHandler(cbChange);
            this.cbQuantity.IntegralHeight = false;
            this.cbQuantity.MaxDropDownItems = 6;
            this.cbQuantity.Size = new System.Drawing.Size(61, 21);
            this.cbQuantity.TabIndex = 0;

            // 
            // pictureBox1
            // 

            this.pbThumbnail.Size = new System.Drawing.Size(59, 78);
            this.pbThumbnail.Image = item.Product.image;
            this.pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbThumbnail.BackColor = Color.Transparent;

            this.Controls.Add(lblItemName);
            this.Controls.Add(lblItemType);
            this.Controls.Add(lblPrice);
            this.Controls.Add(cbQuantity);
            this.Controls.Add(pbThumbnail);
            this.Controls.Add(btnRemove);




            this.Controls[0].Location = new Point(63, 24);// Name label 
            this.Controls[0].BringToFront();
            this.Controls[1].Location = new Point(63, 54);// Type label
            this.Controls[1].BringToFront();
            this.Controls[2].Location = new Point(465, 26);// Price label
            this.Controls[2].BringToFront();
            this.Controls[3].Location = new Point(375, 24);//  Combobox
            this.Controls[3].BringToFront();
            this.Controls[4].Location = new Point(3, 3);// picturebox
            this.Controls[4].BringToFront();
            this.Controls[5].Location = new Point(390, 55);//Button

        }
        /// <summary>
        /// alınmak istenin ürün sayısını değiştiren method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cbChange(object sender, EventArgs e)

        {
            item.Quantity = cbQuantity.SelectedIndex + 1;
            lblPrice.Text = item.Product.discountedPrice * item.Quantity + " TL";
            MainForm.shoppingCart.refreshPanel();
        }
        /// <summary>
        /// ürünü sepetten çıkartan button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void butonClick(object sender, EventArgs e)
        {
            Logger.logger("Shopping Cart Product Remove");
            MainForm.shoppingCart.removeProduct(this.item);
        }
    }
}
