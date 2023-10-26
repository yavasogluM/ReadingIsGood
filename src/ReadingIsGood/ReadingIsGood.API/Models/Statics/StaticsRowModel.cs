namespace ReadingIsGood.API.Models.Statics
{
    public class StaticsRowModel //Order Row Model
    {
        public string Month { get; set; }
        public int TotalOrderCount { get; set; }
        public int TotalBookCount { get; set; }
        public double TotalPurchasedAmount { get; set; }
    }
}
