using System;
using DAO;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Book:DAO_Book
    {
        DAO_Book bookDAO = new DAO_Book();
        public int InsertBook(DTO_Book book)
        {
            //Xử lí dữ liệu trước



            //Dùng DAO class
            return bookDAO.Insert(book);

        }
        
        
    }
}
