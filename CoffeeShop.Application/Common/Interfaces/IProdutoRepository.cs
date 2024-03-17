using CoffeeShop.Domain.Entities;
namespace CoffeeShop.Application.Common.Interfaces

{
    public interface IProdutoRepository : IRepository<Produto>
    {
        void Update(Produto entity);
    }
}
