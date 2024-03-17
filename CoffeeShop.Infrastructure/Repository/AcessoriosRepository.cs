using CoffeeShop.Application.Common.Interfaces;
using CoffeeShop.Domain.Entities;
using CoffeeShop.Infrastructure.Data;


namespace CoffeeShop.Infrastructure.Repository
{
    public class AcessoriosRepository(ApplicationDbContext db) : Repository<Acessorios>(db), IAcessoriosRepository
    {
        private readonly ApplicationDbContext _db = db;

        public void Update(Acessorios entity)
        {
            _db.Acessorios.Update(entity);
        }
    }
}
