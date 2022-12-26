using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models; 

namespace PizzaApp.Pages.forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]  
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Mushrooms) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 1;
            if (Pizza.Onions) PizzaPrice += 1;
            if (Pizza.GreenPeppers) PizzaPrice += 1;
            if (Pizza.BlackOlives) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 1;
            if (Pizza.Spinach) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Sausage) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Check",new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
