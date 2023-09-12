using BurgerRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerRazorPage.Pages.Forms
{
    public class CustomBurgerModel : PageModel
    {
        [BindProperty]
        public BurgersModel Burger { get; set; }

        public float BurgerPrice { get; set; }

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            BurgerPrice = Burger.BasePrice;

            if (Burger.Beef) BurgerPrice += 2;
            if (Burger.Tomato) BurgerPrice += 2;
            if (Burger.Fish) BurgerPrice += 2;
            if (Burger.Cheese) BurgerPrice += 2;
            if (Burger.Bacon) BurgerPrice += 2;
            if (Burger.Sauce) BurgerPrice += 2;
            if (Burger.Ketchup) BurgerPrice += 2;
            if (Burger.Mayonnaise) BurgerPrice += 2;
            if (Burger.Lettuce) BurgerPrice += 2;
            if (Burger.Chicken) BurgerPrice += 2;

            return RedirectToPage("/Checkout/Checkout", new {Burger.BurgerName, BurgerPrice});
        }
    }
}
