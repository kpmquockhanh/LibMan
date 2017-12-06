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
    public partial class frmCategory : Form
    {
        BUS_Book bus_book = new BUS_Book();
        BUS_Category bus_category = new BUS_Category();
        DataTable dataTable;
        String id;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
         {
             this.Close();
         }
 
         private void frmCategory_Load(object sender, EventArgs e)
         {
             dataTable = new DataTable();
             dataTable = bus_category.LoadDataGridViewCategory();
             dgvCategory.DataSource = dataTable;
         }
 
         private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             int i = e.RowIndex;
             try
             {
                 dgvCategory.Rows[e.RowIndex].Selected = true;
                 txtID.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                 id = txtID.Text;
                 txtName.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                 //txtID.Enabled = false;
             }
             catch (ArgumentOutOfRangeException)
             { }
         }
 
         private void txtID_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
             {
                 e.Handled = true;
                 MessageBox.Show("Hãy nhập số!");
             }
         }
 
         private void btnAdd_Click(object sender, EventArgs e)
         {
             if (checkNull())
             {
                 DTO_Category b = new DTO_Category();
                 b.Category_id = int.Parse(txtID.Text);
                 b.Category_name = txtName.Text;
                 if (bus_category.InsertCategory(b) == 1)
                 {
                     MessageBox.Show("Thành công");
                     frmCategory_Load(sender, e);
                     reset();
                 }
                 else
                     MessageBox.Show("Không thành công");
             }
             else
             {
                 MessageBox.Show("Hãy nhập đủ thông tin");
             }
         }
         private bool checkNull()
         {
             if (txtID.Text == "" || txtName.Text == "")
             {
                 return false;
             }
             return true;
         }
         public void reset()
         {
             txtID.Text = "";
             txtName.Text = "";
         }
         private void btnEdit_Click(object sender, EventArgs e)
         {
             if (checkNull())
             {
                 DTO_Category b = new DTO_Category();
                 b.Category_id = int.Parse(id);
                 b.Category_name = txtName.Text;
                 if (bus_category.UpdateCategory(b) == 1)
                 {
                     MessageBox.Show("Thành công");
                     frmCategory_Load(sender, e);
                     reset();
                 }
                 else
                     MessageBox.Show("Không thành công");
 
             }
             else
             {
                 MessageBox.Show("Hãy điển đủ thông tin!");
             }
         }
 
         private void btnDelete_Click(object sender, EventArgs e)
         {
             if (checkNull())
             {
                 DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách "
  +txtName.Text + " và các sách trong hạng mục " + txtName.Text + "?", "Thông báo", MessageBoxButtons.YesNo,
 MessageBoxIcon.Question);
                 if (DialogResult.Yes == dlr)
                 {
                     if ((bus_book.DeleteBookByCategory(txtID.Text) == 1
                         && bus_category.DeleteCategory(txtID.Text) == 1)
                         || (bus_book.DeleteBookByCategory(txtID.Text) == 0
                         && bus_category.DeleteCategory(txtID.Text) == 1))
                     {
                         MessageBox.Show("Thành công");
                         frmCategory_Load(sender, e);
                         reset();
                     }
                     else
                         MessageBox.Show("Không thành công");
                 }
                 if (DialogResult.No == dlr)
                 {
                     this.Close();
                 }
             }
             else
             {
                 MessageBox.Show("Hãy tìm thông tin tác giả cần xóa hoặc chọn item tác giả trong bảng tác giả!");
             }
         }
 
         private void btnSeach_Click(object sender, EventArgs e)
         {
             if (txtID.Text != "")
             {
                 DTO_Category dTO_Category = new DTO_Category();
                 String id = txtID.Text;
                 dTO_Category = bus_category.SearchCategory("category_id", txtID.Text);
                 if (dTO_Category != null)
                 {
                     txtName.Text = dTO_Category.Category_name;
                 }
                 else
                 {
                     MessageBox.Show("Không tìm thấy!");
                 }
             }
             else
             {
                 MessageBox.Show("Hãy nhập mã sách cần tìm!");
             }
 
         }
     }
 }
    }
}
