using BurgerRazorPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BurgerRazorPage.Pages
{
    public class CreateBurgerModel : PageModel
    {

        public List<BurgersModel> fakeBurgerDB = new List<BurgersModel>()
        {
            new BurgersModel(){
                ImageTitle = "BurgerOne",
                BurgerName="ComboZalupa",
                BasePrice = 2,
                Tomato = false,
                Bacon = true,
                Sauce = true,
                Cheese = true,
                Lettuce = true,
                Beef = true,
                FinalPrice = 14 },
            new BurgersModel()
            {
                ImageTitle = "BurgerTwo",
                BurgerName = "Hamburger",
                BasePrice= 2,
                Tomato =true,
                Ketchup = true,
                Mayonnaise = true,
                Lettuce=true,
                Cheese =true,
                Beef =true,
                FinalPrice=14
            },

            new BurgersModel() {
            ImageTitle = "BurgerThree",
            BurgerName = "PressedFucker",
            BasePrice= 2,
            Tomato =true,
            Cheese=true,
            Lettuce=true,
            Beef=true,
            Ketchup=true,
            FinalPrice = 12
            },

            new BurgersModel(){
                ImageTitle = "BurgerFour",
                BurgerName = "DeadChicken",
                BasePrice= 2,
                Tomato=true,
                Cheese=true,
                Lettuce=true,
                Chicken=true,
                Bacon=true,
                Sauce=true,
                FinalPrice = 14
            },
            new BurgersModel(){
                ImageTitle = "BurgerFive",
                BurgerName = "AnalPleasure",
                BasePrice= 2,
                Cheese=true,
                Lettuce=true,
                Beef=true,
                Sauce=true,
                FinalPrice=10

            },
            new BurgersModel(){
                ImageTitle = "BurgerSix",
                BurgerName = "StripUranus",
                BasePrice = 2,
                Tomato=true,
                Cheese=true,
                Lettuce=true,
                Chicken=true,
                Bacon=true,
                Ketchup=true,
                Mayonnaise=true,
                FinalPrice=16
            }
        }; 


        public void OnGet()
        {
        }
    }
}
