using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class BUS_Publisher
    {
        DAO_Publisher dataPublisher = new DAO_Publisher();
        DataTable dataTable;

        public DataTable LoadDataGridViewPublisher()
        {
            dataTable = new DataTable();
            return dataTable = dataPublisher.GetAllDataTable();
        }
    }
}
