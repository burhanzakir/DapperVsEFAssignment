namespace Assignment.Domain.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public long CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;
    }


    public class ProductDtoList
    {
        public Product[] Products { get; set; }
    }

}
