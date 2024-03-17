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
        public DbSet<Acessorios> Acessorios { get; set; }

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

            modelBuilder.Entity<Acessorios>().HasData(
                new Acessorios
                {
                    Id = 1,
                    Name = "Espresso Elegance Cup",
                    Description = "The Espresso Elegance Cup embodies the perfect fusion of form and function, designed to elevate your coffee-drinking experience to new heights of sophistication. Crafted from fine porcelain, its smooth, cylindrical silhouette is adorned with delicate golden accents that add a touch of luxury to your morning ritual.",
                    ImageUrl = "https://placehold.co/600x400",
                    Price = 20,
                },
new Acessorios
{
    Id = 2,
    Name = "Cozy Comfort Mug",
    Description = "The Cozy Comfort Mug is more than just a vessel for your morning pick-me-up; it's a warm embrace on a chilly day, a sanctuary of tranquility amidst the hustle and bustle of daily life. Crafted from durable ceramic, its generous size and sturdy handle provide a reassuring grip, inviting you to wrap your hands around it and savor each sip of your favorite brew.",
    ImageUrl = "https://placehold.co/600x400",
    Price = 10,
},
new Acessorios
{
    Id = 3,
    Name = "BrewMaster Pour-Over Kit",
    Description = "The BrewMaster Pour-Over Kit is the ultimate companion for coffee aficionados who appreciate the artistry and precision of manual brewing methods. This comprehensive kit includes a sleek glass pour-over coffee maker, a precision-crafted stainless steel dripper, and a set of premium reusable filters.\r\n\r\n",
    ImageUrl = "https://placehold.co/600x400",
    Price = 40,
}
);

}
    }

}