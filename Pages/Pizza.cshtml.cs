using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaproj.Models;
namespace pizzaproj.Pages

{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakeDB = new List<PizzasModel>(){
        new PizzasModel(){
            Beef=true,
            Cheese=true,
            ImageTitle="Bolognese",
            PizzaName="Aliasgar",
            FinalPrice=4
        },
        new PizzasModel(){
            Mushroom=true,
            Cheese=true,
            Hame=true,
            ImageTitle="Mushroom",
            PizzaName="Aliasgar",
            FinalPrice=4
        },
      };
    
    }
}

