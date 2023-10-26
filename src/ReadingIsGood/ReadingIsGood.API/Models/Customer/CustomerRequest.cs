using System.ComponentModel.DataAnnotations;

namespace ReadingIsGood.API.Models.Customer
{
    public class CustomerRequest
    {
        [Required]
        public int PageSize { get; set; }

        public int PageNumber { get; set; } = 5;
    }
}
