using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Borrow
    {
        DAO_Borrow borrowDAO = new DAO_Borrow();

        public int InsertBorrow(DTO_Borrow borrow)
        {
            //if (borrow.Na.Contains("'"))
            //{
            //    borrow.Name = checkString(borrow.Name);
            //}
            return borrowDAO.Insert(borrow);
        }


        public DataTable LoadDataGridViewBorrow()
        {
            return borrowDAO.GetAllDataTable();
        }
        public DataTable SearchBorrow(String condition, String value)
        {
            return borrowDAO.GetDataTableBy(condition, value);

        }

        public int UpdateBorrow(DTO_Borrow borrow)
        {

            //if (borrow.Name.Contains("'"))
            //{
            //    borrow.Name = checkString(borrow.Name);
            //}
            return borrowDAO.Update(borrow);


        }

        public int DeleteBorrow(DTO_Borrow borrow)
        {
            return borrowDAO.Delete(borrow.ID.ToString());
        }
        //public String checkString(String name)
        //{
        //    String[] tmp = name.Split('\'');
        //    String text = null;
        //    for (int i = 0; i < tmp.Length; i++)
        //    {
        //        if (i == tmp.Length - 1)
        //        {
        //            text += tmp[i];
        //        }
        //        else
        //        {
        //            text += tmp[i];
        //            text += "''";
        //        }
        //    }
        //    return text;
        //}
    }
}
