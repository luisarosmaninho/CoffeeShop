namespace CoffeeShop.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        // Outros atributos dos produtos, se necessário
    }
}