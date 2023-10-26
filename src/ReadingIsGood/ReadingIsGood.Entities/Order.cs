namespace ReadingIsGood.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public List<OrderBooks> Books { get; set; }
    }

    public class OrderBooks
    {
        public int BookId { get; set; }
        public int Count { get; set; }
    }
}
