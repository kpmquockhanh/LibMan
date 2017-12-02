using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Category
    {
        DAO_Category dataCategory = new DAO_Category();
        DataTable dataTable = new DataTable();

        public DataTable LoadDataGridViewCategory()
        {
            return dataTable = dataCategory.GetAllDataTable();
        }

    }
}
