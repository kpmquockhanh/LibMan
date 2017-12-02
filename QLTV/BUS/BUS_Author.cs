using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Author
    {
        DAO_Author dataAuthor = new DAO_Author();
        DataTable dataTable = new DataTable();

        public DataTable LoadDataGridViewAuthor()
        {
            return dataTable = dataAuthor.GetAllDataTable();
        }

    }
}
