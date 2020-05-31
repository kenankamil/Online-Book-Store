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
            this.pnlShoppingCartPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlShoppingCartPanel.Name = "pnlShoppingCartPanel";
            this.pnlShoppingCartPanel.Size = new System.Drawing.Size(1004, 444);
            this.pnlShoppingCartPanel.TabIndex = 0;
            // 
            // tbcntrlShowItem
            // 
            this.tbcntrlShowItem.Controls.Add(this.tbShoppingList);
            this.tbcntrlShowItem.Controls.Add(this.tbOrderInformation);
            this.tbcntrlShowItem.Location = new System.Drawing.Point(3, 2);
            this.tbcntrlShowItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcntrlShowItem.Name = "tbcntrlShowItem";
            this.tbcntrlShowItem.SelectedIndex = 0;
            this.tbcntrlShowItem.Size = new System.Drawing.Size(998, 440);
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
            this.tbShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbShoppingList.Location = new System.Drawing.Point(4, 25);
            this.tbShoppingList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShoppingList.Name = "tbShoppingList";
            this.tbShoppingList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbShoppingList.Size = new System.Drawing.Size(990, 411);
            this.tbShoppingList.TabIndex = 0;
            this.tbShoppingList.Text = "Shopping List";
            this.tbShoppingList.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(649, 18);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity.Location = new System.Drawing.Point(512, 18);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 25);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProduct.Location = new System.Drawing.Point(7, 18);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(79, 25);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "Product";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(875, 50);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 18);
            this.lblTotalPrice.TabIndex = 11;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSubTotal.Location = new System.Drawing.Point(791, 49);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(84, 20);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // btnBackShopping
            // 
            this.btnBackShopping.FlatAppearance.BorderSize = 0;
            this.btnBackShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackShopping.Image = global::Online_Book_Store_v2.Properties.Resources.back_arrow;
            this.btnBackShopping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackShopping.Location = new System.Drawing.Point(3, 354);
            this.btnBackShopping.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackShopping.Name = "btnBackShopping";
            this.btnBackShopping.Size = new System.Drawing.Size(205, 50);
            this.btnBackShopping.TabIndex = 9;
            this.btnBackShopping.Text = "     Back to shopping";
            this.btnBackShopping.UseVisualStyleBackColor = true;
            this.btnBackShopping.Click += new System.EventHandler(this.btnBackShopping_Click);
            // 
            // btnProceedCheckout
            // 
            this.btnProceedCheckout.Location = new System.Drawing.Point(795, 295);
            this.btnProceedCheckout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceedCheckout.Name = "btnProceedCheckout";
            this.btnProceedCheckout.Size = new System.Drawing.Size(189, 50);
            this.btnProceedCheckout.TabIndex = 8;
            this.btnProceedCheckout.Text = "Proceed to checkout ";
            this.btnProceedCheckout.UseVisualStyleBackColor = true;
            this.btnProceedCheckout.Click += new System.EventHandler(this.btnProceedCheckout_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(795, 354);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(189, 50);
            this.btnCancelOrder.TabIndex = 7;
            this.btnCancelOrder.Text = "Clear shopping card";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // flpnlProduct
            // 
            this.flpnlProduct.AutoScroll = true;
            this.flpnlProduct.Location = new System.Drawing.Point(5, 49);
            this.flpnlProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnlProduct.Name = "flpnlProduct";
            this.flpnlProduct.Size = new System.Drawing.Size(748, 250);
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
            this.tbOrderInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbOrderInformation.Location = new System.Drawing.Point(4, 25);
            this.tbOrderInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderInformation.Name = "tbOrderInformation";
            this.tbOrderInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderInformation.Size = new System.Drawing.Size(990, 411);
            this.tbOrderInformation.TabIndex = 1;
            this.tbOrderInformation.Text = "Order information";
            this.tbOrderInformation.UseVisualStyleBackColor = true;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(327, 251);
            this.lblHata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 25);
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
            this.grpCreditCard.Location = new System.Drawing.Point(307, 58);
            this.grpCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.grpCreditCard.Name = "grpCreditCard";
            this.grpCreditCard.Padding = new System.Windows.Forms.Padding(4);
            this.grpCreditCard.Size = new System.Drawing.Size(431, 134);
            this.grpCreditCard.TabIndex = 32;
            this.grpCreditCard.TabStop = false;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(144, 29);
            this.txtCardOwner.Margin = new System.Windows.Forms.Padding(4);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(279, 24);
            this.txtCardOwner.TabIndex = 15;
            // 
            // mtCVC
            // 
            this.mtCVC.Location = new System.Drawing.Point(367, 89);
            this.mtCVC.Margin = new System.Windows.Forms.Padding(4);
            this.mtCVC.Mask = "000";
            this.mtCVC.Name = "mtCVC";
            this.mtCVC.Size = new System.Drawing.Size(36, 24);
            this.mtCVC.TabIndex = 19;
            // 
            // lblCardOwner
            // 
            this.lblCardOwner.AutoSize = true;
            this.lblCardOwner.Location = new System.Drawing.Point(21, 31);
            this.lblCardOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardOwner.Name = "lblCardOwner";
            this.lblCardOwner.Size = new System.Drawing.Size(98, 18);
            this.lblCardOwner.TabIndex = 12;
            this.lblCardOwner.Text = "Card Owner";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(317, 91);
            this.lblCVC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(42, 18);
            this.lblCVC.TabIndex = 18;
            this.lblCVC.Text = "CVC";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(12, 62);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(108, 18);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.CustomFormat = "MM/yy";
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpDate.Location = new System.Drawing.Point(144, 89);
            this.dtpExpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpExpDate.MinDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(88, 24);
            this.dtpExpDate.TabIndex = 17;
            this.dtpExpDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(1, 91);
            this.lbExpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(123, 18);
            this.lbExpDate.TabIndex = 14;
            this.lbExpDate.Text = "Expiration Date";
            // 
            // mtCardNumber
            // 
            this.mtCardNumber.Location = new System.Drawing.Point(144, 56);
            this.mtCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.mtCardNumber.Mask = "0000-0000-0000-0000";
            this.mtCardNumber.Name = "mtCardNumber";
            this.mtCardNumber.Size = new System.Drawing.Size(279, 24);
            this.mtCardNumber.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(77, 214);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(239, 18);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Choose your payment method.";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(222, 233);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(68, 22);
            this.rbCash.TabIndex = 30;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged_1);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(89, 233);
            this.rbCreditCard.Margin = new System.Windows.Forms.Padding(4);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(115, 22);
            this.rbCreditCard.TabIndex = 29;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged_1);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(77, 5);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(52, 18);
            this.lblCustName.TabIndex = 26;
            this.lblCustName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 58);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(197, 134);
            this.txtAddress.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 24);
            this.txtEmail.TabIndex = 24;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(5, 54);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(69, 18);
            this.lbAddress.TabIndex = 23;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 30);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(50, 18);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 5);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(52, 18);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Snow;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrev.Image = global::Online_Book_Store_v2.Properties.Resources.back_arrow;
            this.btnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.Location = new System.Drawing.Point(80, 279);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(197, 47);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Text = "   Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Snow;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.Image = global::Online_Book_Store_v2.Properties.Resources.icons8_paycheque_48;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(502, 279);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(236, 47);
            this.btnOrder.TabIndex = 27;
            this.btnOrder.Text = "   Place Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // ShoppingCartPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlShoppingCartPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShoppingCartPanel";
            this.Size = new System.Drawing.Size(1004, 444);
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
