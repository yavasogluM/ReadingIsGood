using ReadingIsGood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Services
{
    public class OrderService : IOrderService
    {
        private readonly IBookService bookService;
        public OrderService(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public readonly List<Order> tempOrders = new List<Order>
        {
              new Order { Id = 1, CustomerId = 1, CreateDate = DateTime.Now, Books = new List<OrderBooks>
              {
                  new OrderBooks {  BookId = 1, Count = 1 },
                  new OrderBooks {  BookId = 2, Count = 1 },
                  new OrderBooks {  BookId = 3, Count = 4 }
              } },
              new Order { Id = 2, CustomerId = 2, CreateDate = DateTime.Now.AddMonths(-1),Books = new List<OrderBooks>
              {
                  new OrderBooks {  BookId = 2, Count = 3 },
              } },
              new Order { Id = 3, CustomerId = 3, CreateDate = DateTime.Now.AddMonths(1),Books = new List<OrderBooks>
              {
                  new OrderBooks {  BookId = 1, Count = 1 },
              } }
        };
        public async Task<List<Order>> GetAll()
        {
            return tempOrders.OrderBy(o => o.Id).ToList();
        }

        public async Task<Order> GetById(int id)
        {
            return tempOrders.FirstOrDefault(x => x.Id == id);
        }

        private async Task CheckBookStock(int bookId, int count)
        {
            var bookStock = await bookService.GetBookCount(bookId);
            if (bookStock < count)
            {
                throw new Exception($"You have reached book limit for this book");
            }
            var totalBookCountOnOrders = tempOrders.Select(o => o.Books.Where(x => x.BookId == bookId).Sum(x => x.Count)).Sum();
            if (totalBookCountOnOrders > bookStock)
            {
                throw new Exception($"You have reached book limit for this book");
            }
        }

        public async Task<List<Order>> AddOrder(int count, int bookId, int orderId)
        {
            if (count <= 0)
            {
                throw new Exception("");
            }

            await CheckBookStock(bookId, count);


            var order = tempOrders.FirstOrDefault(x => x.Id == orderId);
            if (order == null)
            {
                var lastId = tempOrders != null || tempOrders.Count() == 0 ? 1 : tempOrders.Count + 1;
                tempOrders.Add(new Order { Id = lastId, Books = new List<OrderBooks> { new OrderBooks { Count = count, BookId = bookId } } });
            }
            else
            {
                order.Books.Add(new OrderBooks { Count = count, BookId = bookId });
            }
            return tempOrders;
        }
    }
}
