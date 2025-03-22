using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Interfaces
{
    public interface IBookService
    {
        Book? GetBookById(int id);
        List<Book>? GetAllBooks();
        void AddNewBook(Book book);
    }
}
