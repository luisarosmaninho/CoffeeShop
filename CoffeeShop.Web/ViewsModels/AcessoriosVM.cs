using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Web.ViewModels
{
    public class AcessoriosVM
    {
        public Acessorios Acessorios { get; set; } = null!;

        [ValidateNever]
        public IEnumerable<SelectListItem> ProdutoList { get; set; } = null!;
    }
}
