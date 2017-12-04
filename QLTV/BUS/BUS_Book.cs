using System;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_Book
    {
        DAO_Book bookDAO = new DAO_Book();
        public int InsertBook(DTO_Book book)
        {
            //Xử lí dữ liệu trước



            //Dùng DAO class
            return bookDAO.Insert(book);

        }
        
        public int DeleteBook(string id)
        {
            //Xử lí dữ liệu trước

            //Dùng DAO
            return bookDAO.Delete(id);
        }

        public int UpdateBook(DTO_Book book)
        {
            //Xử lí dữ liệu trước

            //Dùng DAO
            return bookDAO.Update(book);
        }

        public DataTable getAllDataTable()
        {
            //Xử lí dữ liệu trước

            //Dùng DAO
            return bookDAO.GetAllDataTable();
        }

    }
}
