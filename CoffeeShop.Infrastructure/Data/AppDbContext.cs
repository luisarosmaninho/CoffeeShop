using Microsoft.EntityFrameworkCore;
using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {

        public DbSet<Produto> Produtos { get; set; }

    }
}