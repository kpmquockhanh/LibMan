using System;
using DAO;
using DTO;
using System.Data;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUS_Book
    {
        DAO_Book bookDAO = new DAO_Book();
        DAO_Book dataBook = new DAO_Book();
        DataTable dataTable = new DataTable();
        DTO_Book dto_book = new DTO_Book();
        public int InsertBook(DTO_Book book)
        {
            if (book.Name.Contains("'"))
            {
                book.Name = checkString(book.Name);
            }
            return bookDAO.Insert(book);
        }
        

        public DataTable LoadDataGridViewBook()
        {
            return dataTable = dataBook.GetAllDataTable();
        }
         public DTO_Book SearchBook(String condition, String value)
        {
            dataTable = dataBook.GetDataTableBy(condition, value);
            if (dataTable.Rows.Count>0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dto_book.Name = row["b_name"].ToString();
                    dto_book.Price = int.Parse(row["b_price"].ToString());
                    dto_book.Publication_date = DateTime.Parse(row["b_publication_date"].ToString());
                    dto_book.Quantity = int.Parse(row["b_quanity"].ToString());
                    dto_book.Category_id = int.Parse(row["category_id"].ToString());
                    dto_book.Author_id = int.Parse(row["author_id"].ToString());
                    dto_book.Publisher_id = int.Parse(row["publisher_id"].ToString());
                    return dto_book;
                    
                }
            }
            return null;
        }

        public int UpdateBook(DTO_Book book)
        {
            try
            {
                if (book.Name.Contains("'"))
                {
                    book.Name = checkString(book.Name);
                }
                return bookDAO.Update(book);
            }catch(Exception e)
            {
                return -1;
            }
            
        }

        public int DeleteBook(String book_id)
        {
            try
            {
                return bookDAO.Delete(book_id);
            }catch(Exception e)
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
