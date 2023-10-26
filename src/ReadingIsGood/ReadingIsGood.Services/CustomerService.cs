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
        };

        public async Task<List<Customer>> GetAll()
        {
            return customers;
        }

        public async Task<Customer> GetById(int id)
        {
            return customers.FirstOrDefault(x => x.Id == id);
        }


    }
}