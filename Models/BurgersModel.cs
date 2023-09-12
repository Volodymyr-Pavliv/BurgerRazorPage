namespace BurgerRazorPage.Models
{
    public class BurgersModel
    {

        public string ImageTitle { get; set; }

        public string BurgerName { get; set; }

        public float BasePrice { get; set; } = 2;

        public bool Beef { get; set; }

        public bool Tomato { get; set; }

        public bool Cheese { get; set; }

        public bool Bacon { get; set; }

        public bool Sauce { get; set; }

        public bool Ketchup { get; set; }

        public bool Mayonnaise { get; set; }

        public bool Lettuce { get; set; }

        public bool Chicken { get; set; }

        public bool  Fish { get; set; }

        public float FinalPrice { get; set; }

    }
}
