using CoffeeShop.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Web.Controllers
{
    public class AcessoriosController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AcessoriosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var Acessorios = _db.Acessorios.ToList();
            return View();
        }
    }
}