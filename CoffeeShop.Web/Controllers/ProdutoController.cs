using Microsoft.AspNetCore.Mvc;
using CoffeeShop.Infrastructure.Data;
namespace CoffeeShop.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProdutoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var produto = _db.Produtos.ToList();
            return View(produto);
        }
    }
}
