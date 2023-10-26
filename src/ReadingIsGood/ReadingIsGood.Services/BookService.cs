using ReadingIsGood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Services
{
    public class BookService : IBookService
    {
        public List<Book> tempBooks = new List<Book>
        {
            new Book { Id = 1, Stock = 3, Name = "Book 1", Description = "Book1 description...", Price = 100 },
            new Book { Id = 2, Stock = 2, Name = "Book 2", Description = "Book2 description...", Price = 300 },
            new Book { Id = 3, Stock = 10, Name = "Book 3", Description = "Book3 description...", Price = 20 },
            new Book { Id = 4, Stock = 5, Name = "Book 4", Description = "Book4 description...", Price = 90 }
        };

        public async Task<List<Book>> GetAll()
        {
            return tempBooks.OrderBy(x => x.Id).ToList();
        }

        public async Task<int> GetBookCount(int bookId)
        {
            var book = await GetById(bookId);
            return book == null ? 0 : book.Stock;
        }

        public async Task<Book> GetById(int id)
        {
            return tempBooks.FirstOrDefault(x => x.Id == id);
        }
    }
}
