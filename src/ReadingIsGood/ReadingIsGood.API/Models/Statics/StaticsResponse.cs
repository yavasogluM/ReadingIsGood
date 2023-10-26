using ReadingIsGood.API.Models.Base;

namespace ReadingIsGood.API.Models.Statics
{
    public class StaticsResponse : BaseResponse
    {
        public List<StaticsRowModel> Rows { get; set; }
    }
}
