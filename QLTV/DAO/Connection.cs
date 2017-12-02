using System;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class Connection
    {
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        SqlConnection connection;

        public Connection(String con = "Data Source=KPM\\KPMSERVER;Initial Catalog=QuanLyThuVien;Integrated Security=True")
        {
            //Data Source=.\\KPMSERVER;Initial Catalog=QuanLyThuVien;Integrated Security=True
            connection = new SqlConnection(con);
        }
        public DataTable getTable(String sql)
        {
            connection.Open();
            DataTable dt = new DataTable();
            dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            connection.Close();

            return dt;
        }

        public int ExecuteNonQuery(String sql)
        {
            connection.Open();
            command = new SqlCommand(sql, connection);
           
            int i=command.ExecuteNonQuery();
            connection.Close();
            return i;
        }
    }
}
