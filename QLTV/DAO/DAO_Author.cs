using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Author:Connection
    {
        public int Insert(DTO_Book book)
        {
            return 0;
        }

        public int Update(DTO_Book book)
        {
            return 0;
        }

        public int Delete(string b_id)
        {
            return 0;
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Author");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from AuThor where " + condition + " = '" + value + "'");
        }
    }
}
