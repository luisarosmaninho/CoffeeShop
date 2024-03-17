using CoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().HasData(
                 new Produto
                 {
                     Id = 1,
                     Name = "Cappuccino",
                     Description = "Smooth espresso with a generous layer of creamy milk foam, sprinkled with cocoa powder for a touch of indulgence.",
                     ImageUrl = "https://placehold.co/600x400",
                     Price = 2.50,
                 },
new Produto
{
    Id = 2,
    Name = "Latte",
    Description = "Delicate espresso combined with steamed milk, creating a smooth and balanced beverage, ideal for those who appreciate a mild and creamy coffee.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 3.00,
},
new Produto
{
    Id = 3,
    Name = "Espresso",
    Description = "Strong and intense shot of espresso, perfect for those who crave a bold coffee flavor.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 1.50,
},
new Produto
{
    Id = 4,
    Name = "Americano",
    Description = "Espresso diluted with hot water, resulting in a smooth and light coffee beverage.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 2.00,
},
new Produto
{
    Id = 5,
    Name = "Macchiato",
    Description = "Espresso with a small amount of steamed milk, providing a touch of smoothness and balance to the intense flavor of the coffee.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 2.00,
},
new Produto
{
    Id = 6,
    Name = "Iced Coffee",
    Description = "Refreshing coffee served over ice, perfect for hot summer days.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 3.00,
},
new Produto
{
    Id = 7,
    Name = "Frappe",
    Description = "Cold coffee blended with milk, ice, and flavorings, creating a creamy and refreshing beverage.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 4.00,
},
new Produto
{
    Id = 8,
    Name = "Rosmaninho Blend",
    Description = "Our exclusive blend with floral notes and a hint of honey, perfect for those seeking an aromatic experience.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 3.50,
},
new Produto
{
    Id = 9,
    Name = "Iced Latte",
    Description = "A refreshing combination of espresso and cold milk served over ice, perfect for a hot summer day.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 3.50,
},
new Produto
{
    Id = 10,
    Name = "Mocha",
    Description = "Espresso combined with steamed milk and chocolate syrup, topped with whipped cream, for an indulgent coffee treat.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 4.00,
}
   );
        }
    }

}