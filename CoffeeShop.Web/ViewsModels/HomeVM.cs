using CoffeeShop.Domain.Entities;

namespace CoffeeShop.Web.ViewModels
{
    public class HomeVM
    {
        public IEnumerable< Produto>? VillaList { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly? CheckOutDate { get; set; }
        public int Nights { get; set; }
    }
}
