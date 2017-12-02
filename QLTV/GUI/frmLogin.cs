using System;
using System.Windows.Forms;
using DAO;
namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Connection conn = new Connection();
            // MessageBox.Show(conn.ExecuteNonQuery("insert into test values('ahihi')").ToString());
            frmBook book = new frmBook();
            book.ShowDialog();
        }

    }
}
