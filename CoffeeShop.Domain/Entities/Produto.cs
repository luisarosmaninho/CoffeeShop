namespace CoffeeShop.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        // Outros atributos dos produtos, se necessário
    }
}