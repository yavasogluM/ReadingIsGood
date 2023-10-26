using ReadingIsGood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Services
{
    public interface IBookService : IBaseService<Book>
    {
        Task<int> GetBookCount(int bookId);
    }
}
