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
    public partial class frmBorrow : Form
    {
        BUS_Borrow br = new BUS_Borrow();
        public frmBorrow()
        {
            InitializeComponent();
        }

        private void setField()
        {
            dgvBorrow.Columns["r_id"].HeaderText = "ID";
            dgvBorrow.Columns["r_name"].HeaderText = "Name";
            dgvBorrow.Columns["r_address"].HeaderText = "Address";
            dgvBorrow.Columns["r_phone_number"].HeaderText = "Phone number";
            dgvBorrow.Columns["r_email"].HeaderText = "Email";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnE_Click(sender, e);
;        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                dgvBorrow.DataSource = br.SearchBorrow("br_id", txtID.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền ID để tìm kiếm");
            }
        }

        private bool checkNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txt.Text == "" || txtDeposit.Text == ""
                || txtBID.Text == "" || txtQuanity.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtID.ResetText();
            txt.ResetText();
            txtName.ResetText();
            txtQuanity.ResetText();
            txtDeposit.ResetText();
            txtBID.ResetText();
        }
    }
}
