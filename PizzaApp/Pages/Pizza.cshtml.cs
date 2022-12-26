using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
          new PizzasModel(){
              ImageTitle="Margerita" ,
              PizzaName="Margerita",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=2
          },
          new PizzasModel(){
              ImageTitle="Bolognese" ,
              PizzaName="Bolognese",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=true,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=2
          },
          new PizzasModel(){
              ImageTitle="Carbonara" ,
              PizzaName="Carbonara",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=true,
              BlackOlives=true,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=2
          },
          new PizzasModel(){
              ImageTitle="Hawaiian" ,
              PizzaName="Hawaiian",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=true,
              Spinach=false,
              Ham=false,
              FinalPrice=2
          },
          new PizzasModel(){
              ImageTitle="MeatFeast" ,
              PizzaName="MeatFeast",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=true,
              Sausage=true,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=true,
              FinalPrice=2
          },
          new PizzasModel(){
              ImageTitle="Mushroom" ,
              PizzaName="Mushroom",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=true,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=3
          },
          new PizzasModel(){
              ImageTitle="Pepperoni" ,
              PizzaName="Pepperoni",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=true,
              Sausage=false,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=4
          },
          new PizzasModel(){
              ImageTitle="Seafood" ,
              PizzaName="Seafood",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=false,
              Onions=false,
              GreenPeppers=false,
              BlackOlives=false,
              Pineapple=false,
              Spinach=false,
              Ham=false,
              FinalPrice=5
          },
          new PizzasModel(){
              ImageTitle="Vegetarian" ,
              PizzaName="Vegetarian",
              BasePrice=2,
              TomatoSauce=true,
              Cheese=true,
              Pepperoni=false,
              Sausage=false,
              Mushrooms=false,
              Onions=true,
              GreenPeppers=true,
              BlackOlives=true,
              Pineapple=false,
              Spinach=true,
              Ham=false,
              FinalPrice=10
          },
        };
    public void OnGet()
        {
        }
    }
}
