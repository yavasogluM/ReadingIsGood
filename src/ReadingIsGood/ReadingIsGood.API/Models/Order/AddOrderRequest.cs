using Microsoft.AspNetCore.Mvc;
using ReadingIsGood.API.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace ReadingIsGood.API.Models.Order
{
    public class AddOrderRequest : BaseRequest
    {
        //int count, int bookId, int orderId
        [Required]
        public int Count { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int OrderId { get; set; }
    }
}
