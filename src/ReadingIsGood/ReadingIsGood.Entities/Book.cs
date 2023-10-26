namespace ReadingIsGood.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
