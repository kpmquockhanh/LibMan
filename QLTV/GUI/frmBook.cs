using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmBook : Form
    {
        BUS_Book bus_book = new BUS_Book();
        BUS_Author bus_author = new BUS_Author();
        BUS_Publisher bus_publisher = new BUS_Publisher();
        BUS_Category bus_category = new BUS_Category();

        DataTable dataTable;
        public frmBook()
        {
            InitializeComponent();
        }
        BUS_Book bookBUS = new BUS_Book();

        private void btnA_Click(object sender, EventArgs e)
        {
            DTO_Book b = new DTO_Book();
            b.ID = 0;
            b.Name = txtName.Text;
            b.Price = int.Parse(txtPrice.Text);
            b.Publication_date = DateTime.Parse(dpPubDate.Value.ToShortDateString());
            b.Publisher_id = int.Parse(cbxPublisher.Text);
            b.Author_id = int.Parse(cbxAuthor.Text);
            b.Category_id = int.Parse(cbxCategory.Text);
            b.Quantity = int.Parse(txtQuanity.Text);
            if (bookBUS.InsertBook(b)==1)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Không thành công");

        }

        private void frmBook_Load(object sender, EventArgs e)
        {
         
            // Load DataGridView
            dataTable = new DataTable();
            dataTable = bus_book.LoadDataGridViewBook();
            dgvBook.DataSource = dataTable;

            // Load ComboxCategory
            dataTable = new DataTable();
            dataTable = bus_category.LoadDataGridViewCategory();
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "category_id";

            // Load ComboxAuthor
            dataTable = new DataTable();
            dataTable = bus_author.LoadDataGridViewAuthor();
            cbxAuthor.DataSource = dataTable;
            cbxAuthor.DisplayMember = "author_id";

            // Load ComboxPublisher
            dataTable = new DataTable();
            dataTable = bus_publisher.LoadDataGridViewPublisher();
            cbxPublisher.DataSource = dataTable;
            cbxPublisher.DisplayMember = "publisher_id";
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {}

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }

        private void txtQuanity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Hãy nhập số!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy nhập mã sách bạn cần sửa");

            
        }

        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Alo");
        }


    }
}
