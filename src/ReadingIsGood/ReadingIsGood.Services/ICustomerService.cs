using ReadingIsGood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Services
{
    public interface ICustomerService : IBaseService<Customer>
    {
        Task<List<Customer>> GetAllWithPaging(int pageSize = 5, int pageNumber = 1);
    }
}
