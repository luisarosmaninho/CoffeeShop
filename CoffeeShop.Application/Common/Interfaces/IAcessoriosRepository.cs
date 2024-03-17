using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Application.Common.Interfaces
{
    public interface IAcessoriosRepository : IRepository<Acessorios>
    {
        void Update(Acessorios entity);
    }
}
