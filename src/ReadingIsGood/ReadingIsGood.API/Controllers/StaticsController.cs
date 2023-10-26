using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadingIsGood.API.Models.Statics;
using ReadingIsGood.Services;

namespace ReadingIsGood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticsController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly IOrderService orderService;
        public StaticsController(IOrderService orderService, ILogger logger)
        {
            this.orderService = orderService;
            this.logger = logger;
        }

        [HttpPost(template:"retrieve")]
        public async Task<IActionResult> GetMonthlyStatics([FromBody] StaticsRequest request)
        {
            this.logger.Log(LogLevel.Information, $"{System.Text.Json.JsonSerializer.Serialize(request)}");

            var list = new StaticsResponse
            {
                IsSuccess = true,
                Rows = new List<StaticsRowModel>
                {
                     new StaticsRowModel{ Month = "May", TotalOrderCount = 2, TotalBookCount= 5, TotalPurchasedAmount = 155.43 },
                     new StaticsRowModel{ Month = "April", TotalOrderCount = 1, TotalBookCount= 3, TotalPurchasedAmount = 55.2 }
                }
            };
            return Ok(list);
        }
    }
}
