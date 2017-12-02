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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Hayc nhập đầy đủ thông tin!");
                return;
            }
            else
            {
               // bus_book.
            }
            
        }

        private bool checkNull()
        {
            if(txtBookName.Text == "" || txtPrice.Text == "" || txtQuanity.Text == ""
                || cbxAuthor.Text == "" || cbxCategory.Text == "" || cbxPublisher.Text == "")
            {
                return false;
            }
            return true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuanity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
