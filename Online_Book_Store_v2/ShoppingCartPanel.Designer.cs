namespace Online_Book_Store_v2
{
    partial class ShoppingCartPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlShoppingCartPanel = new System.Windows.Forms.Panel();
            this.tbcntrlShowItem = new System.Windows.Forms.TabControl();
            this.tbShoppingList = new System.Windows.Forms.TabPage();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnBackShopping = new System.Windows.Forms.Button();
            this.btnProceedCheckout = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.flpnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.tbOrderInformation = new System.Windows.Forms.TabPage();
            this.lblHata = new System.Windows.Forms.Label();
            this.grpCreditCard = new System.Windows.Forms.GroupBox();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.mtCVC = new System.Windows.Forms.MaskedTextBox();
            this.lblCardOwner = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.mtCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlShoppingCartPanel.SuspendLayout();
            this.tbcntrlShowItem.SuspendLayout();
            this.tbShoppingList.SuspendLayout();
            this.tbOrderInformation.SuspendLayout();
            this.grpCreditCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShoppingCartPanel
            // 
            this.pnlShoppingCartPanel.Controls.Add(this.tbcntrlShowItem);
            this.pnlShoppingCartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShoppingCartPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlShoppingCartPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlShoppingCartPanel.Name = "pnlShoppingCartPanel";
            this.pnlShoppingCartPanel.Size = new System.Drawing.Size(753, 361);
            this.pnlShoppingCartPanel.TabIndex = 0;
            // 
            // tbcntrlShowItem
            // 
            this.tbcntrlShowItem.Controls.Add(this.tbShoppingList);
            this.tbcntrlShowItem.Controls.Add(this.tbOrderInformation);
            this.tbcntrlShowItem.Location = new System.Drawing.Point(2, 2);
            this.tbcntrlShowItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcntrlShowItem.Name = "tbcntrlShowItem";
            this.tbcntrlShowItem.SelectedIndex = 0;
            this.tbcntrlShowItem.Size = new System.Drawing.Size(748, 358);
            this.tbcntrlShowItem.TabIndex = 0;
            // 
            // tbShoppingList
            // 
            this.tbShoppingList.Controls.Add(this.lblPrice);
            this.tbShoppingList.Controls.Add(this.lblQuantity);
            this.tbShoppingList.Controls.Add(this.lblProduct);
            this.tbShoppingList.Controls.Add(this.lblTotalPrice);
            this.tbShoppingList.Controls.Add(this.lblSubTotal);
            this.tbShoppingList.Controls.Add(this.btnBackShopping);
            this.tbShoppingList.Controls.Add(this.btnProceedCheckout);
            this.tbShoppingList.Controls.Add(this.btnCancelOrder);
            this.tbShoppingList.Controls.Add(this.flpnlProduct);
            this.tbShoppingList.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbShoppingList.Location = new System.Drawing.Point(4, 22);
            this.tbShoppingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbShoppingList.Name = "tbShoppingList";
            this.tbShoppingList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbShoppingList.Size = new System.Drawing.Size(740, 332);
            this.tbShoppingList.TabIndex = 0;
            this.tbShoppingList.Text = "Shopping List";
            this.tbShoppingList.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(487, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(384, 15);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(5, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 20);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "Product";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(656, 41);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 16);
            this.lblTotalPrice.TabIndex = 11;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubTotal.Location = new System.Drawing.Point(593, 40);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 17);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // btnBackShopping
            // 
            this.btnBackShopping.FlatAppearance.BorderSize = 0;
            this.btnBackShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackShopping.Image = global::Online_Book_Store_v2.Properties.Resources.back_arrow;
            this.btnBackShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackShopping.Location = new System.Drawing.Point(2, 288);
            this.btnBackShopping.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackShopping.Name = "btnBackShopping";
            this.btnBackShopping.Size = new System.Drawing.Size(154, 41);
            this.btnBackShopping.TabIndex = 9;
            this.btnBackShopping.Text = "     Back to shopping";
            this.btnBackShopping.UseVisualStyleBackColor = true;
            this.btnBackShopping.Click += new System.EventHandler(this.btnBackShopping_Click);
            // 
            // btnProceedCheckout
            // 
            this.btnProceedCheckout.Location = new System.Drawing.Point(596, 240);
            this.btnProceedCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProceedCheckout.Name = "btnProceedCheckout";
            this.btnProceedCheckout.Size = new System.Drawing.Size(142, 41);
            this.btnProceedCheckout.TabIndex = 8;
            this.btnProceedCheckout.Text = "Proceed to checkout ";
            this.btnProceedCheckout.UseVisualStyleBackColor = true;
            this.btnProceedCheckout.Click += new System.EventHandler(this.btnProceedCheckout_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(596, 288);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(142, 41);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Clear shopping card";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // flpnlProduct
            // 
            this.flpnlProduct.AutoScroll = true;
            this.flpnlProduct.Location = new System.Drawing.Point(4, 40);
            this.flpnlProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpnlProduct.Name = "flpnlProduct";
            this.flpnlProduct.Size = new System.Drawing.Size(561, 203);
            this.flpnlProduct.TabIndex = 0;
            // 
            // tbOrderInformation
            // 
            this.tbOrderInformation.Controls.Add(this.lblHata);
            this.tbOrderInformation.Controls.Add(this.grpCreditCard);
            this.tbOrderInformation.Controls.Add(this.lblInfo);
            this.tbOrderInformation.Controls.Add(this.rbCash);
            this.tbOrderInformation.Controls.Add(this.rbCreditCard);
            this.tbOrderInformation.Controls.Add(this.lblCustName);
            this.tbOrderInformation.Controls.Add(this.txtAddress);
            this.tbOrderInformation.Controls.Add(this.txtEmail);
            this.tbOrderInformation.Controls.Add(this.lbAddress);
            this.tbOrderInformation.Controls.Add(this.lbEmail);
            this.tbOrderInformation.Controls.Add(this.lbName);
            this.tbOrderInformation.Controls.Add(this.btnPrev);
            this.tbOrderInformation.Controls.Add(this.btnOrder);
            this.tbOrderInformation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOrderInformation.Location = new System.Drawing.Point(4, 22);
            this.tbOrderInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrderInformation.Name = "tbOrderInformation";
            this.tbOrderInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbOrderInformation.Size = new System.Drawing.Size(740, 332);
            this.tbOrderInformation.TabIndex = 1;
            this.tbOrderInformation.Text = "Order information";
            this.tbOrderInformation.UseVisualStyleBackColor = true;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(245, 204);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 19);
            this.lblHata.TabIndex = 33;
            // 
            // grpCreditCard
            // 
            this.grpCreditCard.Controls.Add(this.txtCardOwner);
            this.grpCreditCard.Controls.Add(this.mtCVC);
            this.grpCreditCard.Controls.Add(this.lblCardOwner);
            this.grpCreditCard.Controls.Add(this.lblCVC);
            this.grpCreditCard.Controls.Add(this.lblCardNumber);
            this.grpCreditCard.Controls.Add(this.dtpExpDate);
            this.grpCreditCard.Controls.Add(this.lbExpDate);
            this.grpCreditCard.Controls.Add(this.mtCardNumber);
            this.grpCreditCard.Location = new System.Drawing.Point(230, 47);
            this.grpCreditCard.Name = "grpCreditCard";
            this.grpCreditCard.Size = new System.Drawing.Size(314, 109);
            this.grpCreditCard.TabIndex = 32;
            this.grpCreditCard.TabStop = false;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(91, 22);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(210, 22);
            this.txtCardOwner.TabIndex = 15;
            // 
            // mtCVC
            // 
            this.mtCVC.Location = new System.Drawing.Point(272, 72);
            this.mtCVC.Mask = "000";
            this.mtCVC.Name = "mtCVC";
            this.mtCVC.Size = new System.Drawing.Size(28, 22);
            this.mtCVC.TabIndex = 19;
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(16, 25);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(79, 16);
            this.lblCardOwner.TabIndex = 12;
            this.lblCardOwner.Text = "Card Owner";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(238, 74);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(34, 16);
            this.lblCVC.TabIndex = 18;
            this.lblCVC.Text = "CVC";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(9, 50);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(87, 16);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "MM/yy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(91, 72);
            this.dtpExpDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpExpDate.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(67, 22);
            this.dtpExpDate.TabIndex = 17;
            this.dtpExpDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(1, 74);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(95, 16);
            this.lbExpDate.TabIndex = 14;
            this.lbExpDate.Text = "Expiration Date";
            // 
            // mtCardNumber
            // 
            this.mtCardNumber.Location = new System.Drawing.Point(91, 44);
            this.mtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtCardNumber.Name = "mtCardNumber";
            this.mtCardNumber.Size = new System.Drawing.Size(210, 22);
            this.mtCardNumber.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(58, 174);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(188, 16);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Choose your payment method.";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(155, 189);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(55, 20);
            this.rbCash.TabIndex = 30;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged_1);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(67, 189);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(93, 20);
            this.rbCreditCard.TabIndex = 29;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged_1);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(58, 4);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(44, 16);
            this.lblCustName.TabIndex = 26;
            this.lblCustName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(61, 47);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(149, 110);
            this.txtAddress.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(61, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(4, 44);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(55, 16);
            this.lbAddress.TabIndex = 23;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(17, 24);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 16);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 4);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Snow;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrev.Image = global::Online_Book_Store_v2.Properties.Resources.back_arrow;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(5, 227);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(148, 38);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "   Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Snow;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.Image = global::Online_Book_Store_v2.Properties.Resources.icons8_paycheque_48;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(406, 227);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(148, 38);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // ShoppingCartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlShoppingCartPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShoppingCartPanel";
            this.Size = new System.Drawing.Size(753, 361);
            this.pnlShoppingCartPanel.ResumeLayout(false);
            this.tbcntrlShowItem.ResumeLayout(false);
            this.tbShoppingList.ResumeLayout(false);
            this.tbShoppingList.PerformLayout();
            this.tbOrderInformation.ResumeLayout(false);
            this.tbOrderInformation.PerformLayout();
            this.grpCreditCard.ResumeLayout(false);
            this.grpCreditCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShoppingCartPanel;
        private System.Windows.Forms.TabControl tbcntrlShowItem;
        private System.Windows.Forms.TabPage tbShoppingList;
        private System.Windows.Forms.TabPage tbOrderInformation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnBackShopping;
        private System.Windows.Forms.Button btnProceedCheckout;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.FlowLayoutPanel flpnlProduct;
        private System.Windows.Forms.GroupBox grpCreditCard;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.MaskedTextBox mtCVC;
        private System.Windows.Forms.Label lblCardOwner;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label lbExpDate;
        private System.Windows.Forms.MaskedTextBox mtCardNumber;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblHata;
    }
}
