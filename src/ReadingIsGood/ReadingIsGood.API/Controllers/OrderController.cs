using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadingIsGood.API.Models.Base;
using ReadingIsGood.API.Models.Order;
using ReadingIsGood.Services;

namespace ReadingIsGood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService  = orderService;
        }

        [HttpPost(template: "add-order")]
        public async Task<IActionResult> AddOrder([FromBody]AddOrderRequest request)
        {
            var list = await orderService.AddOrder(request.Count, request.BookId, request.OrderId);

            AddOrderResponse response = new AddOrderResponse();
            response.IsSuccess = true;
            response.Orders = list;

            return Ok(response);
        }
    }
}
