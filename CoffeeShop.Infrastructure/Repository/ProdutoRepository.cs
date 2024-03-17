using CoffeeShop.Application.Common.Interfaces;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Infrastructure.Data;

namespace CoffeeShop.Infrastructure.Repository
{
    public class ProdutoRepository(ApplicationDbContext db) : Repository<Produto>(db), IProdutoRepository
    {
        private readonly ApplicationDbContext _db = db;

        public void Update(Produto entity)
        {
            _db.Produtos.Update(entity);
        }
    }
}
