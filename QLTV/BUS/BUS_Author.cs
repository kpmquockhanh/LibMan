using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_Author
    {
        DAO_Author authorDAO = new DAO_Author();
        DataTable dataTable = new DataTable();
        DTO_Author dto_auther = new DTO_Author();
        public int InsertBook(DTO_Author author)
        {
            if (author.Author_name.Contains("'"))
            {
                author.Author_name = checkString(author.Author_name);
            }
            return authorDAO.Insert(author);
        }


        public DataTable LoadDataGridViewAuthor()
        {
            return dataTable = authorDAO.GetAllDataTable();
        }
        public DTO_Author SearchAuthor(String condition, String value)
        {
            dataTable = authorDAO.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_auther.Author_id = int.Parse(row["author_name"].ToString());
                    dto_auther.Author_name = row["author_name"].ToString();
                    return dto_auther;
                }
            }
            return null;
        }

        public int UpdateAuthor(DTO_Author author)
        {
            try
            {
                if (author.Author_name.Contains("'"))
                {
                    author.Author_name = checkString(author.Author_name);
                }
                return authorDAO.Update(author);
            }
            catch (Exception e)
            {
                return -1;
            }

        }

        public int DeleteAuthor(DTO_Author author)
        {
            try
            {
                if (author.Author_name.Contains("'"))
                {
                    author.Author_name = checkString(author.Author_name);
                }
                return authorDAO.Delete(author.Author_name);
            }
            catch (Exception e)
            {
                return -1;
            }

        }
        public String checkString(String name)
        {
            String[] tmp = name.Split('\'');
            String text = null;
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i == tmp.Length - 1)
                {
                    text += tmp[i];
                }
                else
                {
                    text += tmp[i];
                    text += "''";
                }
            }
            return text;
        }
    }
}
