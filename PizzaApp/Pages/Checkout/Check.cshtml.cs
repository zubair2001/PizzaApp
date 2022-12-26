using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Data;
using PizzaApp.Models;

namespace PizzaApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckModel(ApplicationDBContext context)
        {
            _context = context;
        }
        
        public void OnGet()
        {
            if (string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom Pizza";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}
