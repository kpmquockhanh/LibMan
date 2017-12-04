using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
    public class DAO_Card:Connection
    {
        public int Insert(DTO_Card card)
        {

            string sql = "INSERT INTO Card(c_id,r_id,expired_date) VALUES('"+card.ID+"','"+card.ReaderID+"','"+card.Expired_date+"')";
            return this.ExecuteNonQuery(sql);

        }

        public int Update(DTO_Card card)
        {
            string sql = "UPDATE Staff SET c_id='" + card.ID + "',r_id='" + card.ReaderID + "',expired_date='" + card.Expired_date + "'";
            return this.ExecuteNonQuery(sql);
        }

        public int Delete(string c_id)
        {
            String sql = "DELETE Staff WHERE c_id = " + c_id + ";";
            return this.ExecuteNonQuery(sql);
        }

        public DataTable GetAllDataTable()
        {
            return this.getTable("Select * from Staff");
        }

        public DataTable GetDataTableBy(String condition, String value)
        {
            return this.getTable("select * from Staff where " + condition + " = '" + value + "'");
        }
    }
}
