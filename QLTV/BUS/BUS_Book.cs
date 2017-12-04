using System;
using DAO;
using DTO;
using System.Data;
using System.Text.RegularExpressions;

namespace BUS
{
    public class BUS_Book:DAO_Book
    {
        DAO_Book bookDAO = new DAO_Book();
        DAO_Book dataBook = new DAO_Book();
        DataTable dataTable = new DataTable();
        public int InsertBook(DTO_Book book)
        {
            if (book.Name.Contains("'"))
            {
                String[] tmp = book.Name.Split('\'');
                book.Name = null;
                for (int i=0; i < tmp.Length; i++)
                {
                    if (i == tmp.Length - 1)
                    {
                        book.Name += tmp[i];
                    }
                    else
                    {
                        book.Name += tmp[i];
                        book.Name += "''"; 
                    }   
                }
            }
            return bookDAO.Insert(book);
        }
        

        public DataTable LoadDataGridViewBook()
        {
            return dataTable = dataBook.GetAllDataTable();
        }


    }
}
