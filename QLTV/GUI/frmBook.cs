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
        public frmBook()
        {
            InitializeComponent();
        }
        BUS_Book bookBUS = new BUS_Book();

        private void btnA_Click(object sender, EventArgs e)
        {
            DTO_Book b = new DTO_Book();
            b.ID = int.Parse(txtID.Text);
            b.Name = txtName.Text;
            b.Price = int.Parse(txtPrice.Text);
            b.Publication_date = DateTime.Parse(dpPubDate.Value.ToShortDateString());
            b.Publisher_id = int.Parse(txtPublisher.Text);
            b.Author_id = int.Parse(txtAuthor.Text);
            b.Category_id = int.Parse(txtCate.Text);
            b.Quantity = int.Parse(txtQuanity.Text);
            if (bookBUS.InsertBook(b)==1)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Không thành công");

        }
    }
}
