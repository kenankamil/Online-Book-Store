using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store_v2
{
    public partial class adminControl : Form
    {
        public adminControl()
        {
            InitializeComponent();
        }



        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void Dg_customers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_customerName_panel.Text = dg_customers.SelectedRows[0].Cells[1].Value.ToString();
                tb_customerAddress_panel.Text = dg_customers.SelectedRows[0].Cells[2].Value.ToString();
                tb_customerMail_panel.Text = dg_customers.SelectedRows[0].Cells[3].Value.ToString();
                tb_customerUsername_panel.Text = dg_customers.SelectedRows[0].Cells[4].Value.ToString();
                tb_customerPw_panel.Text = dg_customers.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch { }
        }


        private void Btn_customerAdd_panel_Click(object sender, EventArgs e)
        {

            
        }

        private void Dg_books_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tb_bookName_control.Text = dg_books.SelectedRows[0].Cells[1].Value.ToString();
                tb_bookAuthor_control.Text = dg_books.SelectedRows[0].Cells[2].Value.ToString();
                tb_bookPublisher_control.Text = dg_books.SelectedRows[0].Cells[3].Value.ToString();
                tb_bookPage_control.Text = dg_books.SelectedRows[0].Cells[4].Value.ToString();
                tb_bookPrice_control.Text = dg_books.SelectedRows[0].Cells[5].Value.ToString();
                tb_bookSale_control.Text = dg_books.SelectedRows[0].Cells[6].Value.ToString();
                tb_bookCategory_control.Text = dg_books.SelectedRows[0].Cells[7].Value.ToString();
                tb_bookDescription_control.Text = dg_books.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch
            {

            }
        }


        private void Btn_addBook_control_Click(object sender, EventArgs e)
        {

           
        }

        private void Btn_customerDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_customers.SelectedRows)
            {
                dg_customers.Rows.RemoveAt(item.Index);
            }
        }

        private void Btn_books_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dg_books.SelectedRows)
            {
                dg_books.Rows.RemoveAt(item.Index);
            }
        }

        private void Btn_addMagazine_control_Click(object sender, EventArgs e)
        {

            
        }
    }
}
