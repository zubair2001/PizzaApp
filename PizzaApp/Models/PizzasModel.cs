namespace PizzaApp.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Sausage { get; set; }
        public bool Mushrooms { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public bool BlackOlives { get; set; }
        public bool Pineapple { get; set; }
        public bool Spinach { get; set; }
        public bool Ham { get; set; }
        public float FinalPrice { get; set; }
    }
}