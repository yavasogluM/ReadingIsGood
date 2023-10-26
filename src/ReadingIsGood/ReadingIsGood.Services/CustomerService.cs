using ReadingIsGood.Entities;

namespace ReadingIsGood.Services
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers = new List<Customer>
        {
             new Customer{ Id = 1, FullName = "Customer 1", Detail = "Customer 1 detail"},
             new Customer{ Id = 2, FullName = "Customer 2", Detail = "Customer 2 detail"},
             new Customer{ Id = 3, FullName = "Customer 3", Detail = "Customer 3 detail"},
             new Customer{ Id = 4, FullName = "Customer 4", Detail = "Customer 4 detail"},
             new Customer{ Id = 5, FullName = "Customer 5", Detail = "Customer 5 detail"},
             new Customer{ Id = 6, FullName = "Customer 6", Detail = "Customer 6 detail"},
             new Customer{ Id = 7, FullName = "Customer 7", Detail = "Customer 7 detail"},
             new Customer{ Id = 8, FullName = "Customer 8", Detail = "Customer 8 detail"},
             new Customer{ Id = 9, FullName = "Customer 9", Detail = "Customer 9 detail"},
        };

        public async Task<List<Customer>> GetAll()
        {
            return customers;
        }

        public async Task<Customer> GetById(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }

        public async Task<List<Customer>> GetAllWithPaging(int pageSize = 5, int pageNumber = 1)
        {
            return customers.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }
    }
}