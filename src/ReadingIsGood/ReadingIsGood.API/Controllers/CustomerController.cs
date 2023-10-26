using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetCustomers()
        {
            this.logger.Log(LogLevel.Information, $"Test log!");
            var list = await customerService.GetAll();
            return Ok(list);
        }
    }
}
