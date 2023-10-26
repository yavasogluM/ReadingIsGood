using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadingIsGood.API.Models.Customer;
using ReadingIsGood.Services;

namespace ReadingIsGood.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService, ILogger logger)
        {
            this.customerService = customerService;
            this.logger = logger;
        }

        [HttpGet(template: "retrieve")]
        public async Task<CustomerResponse> GetCustomers([FromQuery] CustomerRequest request)
        {
            this.logger.Log(LogLevel.Information, $"GetCustomers Request Log: {System.Text.Json.JsonSerializer.Serialize(request)}");
            var list = await customerService.GetAllWithPaging(request.PageNumber, request.PageSize);
            return new CustomerResponse
            {
                Customers = list,
                IsSuccess = true
            };
        }
    }
}
