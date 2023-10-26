using ReadingIsGood.API.Models.Base;
using ReadingIsGood.Entities;

namespace ReadingIsGood.API.Models.Customer
{
    public class CustomerResponse : BaseResponse
    {
        public List<Entities.Customer> Customers { get; set; }
    }
}
