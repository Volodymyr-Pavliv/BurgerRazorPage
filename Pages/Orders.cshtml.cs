using BurgerRazorPage.Data;
using BurgerRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerRazorPage.Pages
{
    public class OrdersModel : PageModel
    {

        public List<BurgerOrder> BurgerOrders = new List<BurgerOrder>();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            BurgerOrders = _context.BurgerOrders.ToList();
        }
    }
}
