using System;
using DAO;
using DTO;
using System.Data;


namespace BUS
{
    public class BUS_Book
    {
        //Trong này chỉ xử lí dữ liệu từ form thôi rồi đưa vào DAO
        DAO_Book dataBook = new DAO_Book();
        DataTable dataTable = new DataTable();
        
        public DataTable LoadDataGridViewBook()
        {
            return dataTable =  dataBook.GetAllDataTable();
        }

        public int InsertBook(String name, String publicaionDate, String price, String quanity, String category, String author, String publisher)
        {

            dataBook.Insert()
        }
        
    }
}
