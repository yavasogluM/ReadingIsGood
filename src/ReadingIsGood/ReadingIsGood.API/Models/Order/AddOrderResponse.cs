using ReadingIsGood.API.Models.Base;

namespace ReadingIsGood.API.Models.Order
{
    public class AddOrderResponse : BaseResponse
    {
        public List<Entities.Order> Orders { get; set; }
    }
}
