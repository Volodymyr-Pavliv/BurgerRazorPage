using BurgerRazorPage.Data;
using BurgerRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerRazorPage.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {


        public string BurgerName { get; set; }

        public float BurgerPrice { get; set; }

        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(BurgerName))
            {
                BurgerName = "Custom";
            }

            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            BurgerOrder burgerOrder = new BurgerOrder();
            
            burgerOrder.BurgerName = BurgerName;
            burgerOrder.BasePrice = BurgerPrice;

            _context.BurgerOrders.Add(burgerOrder);
            _context.SaveChanges();

        }
    }
}
