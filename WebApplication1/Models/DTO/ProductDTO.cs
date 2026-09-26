namespace WebApplication1.Models.DTO
{
    public class ProductDTO
    {
        public ProductDTO(int id, string name, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity; 
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}