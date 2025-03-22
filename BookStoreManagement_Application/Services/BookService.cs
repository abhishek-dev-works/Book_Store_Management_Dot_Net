using System.Collections.Generic;
using System.Linq;
using BookStoreManagement_Db_Context.DataContext;
using BookStoreManagement_Application.Interfaces;

public class BookService : IBookService
{
    private readonly ApplicationDbContext _context;

    public BookService(ApplicationDbContext context)
    {
        _context = context;
    }

    public Book? GetBookById(int id)
    {
        return _context?.Books?.FirstOrDefault(b => b.Id == id);
    }

    public List<Book>? GetAllBooks()
    {
        return _context?.Books?.ToList();
    }

    public void AddNewBook(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }
}
