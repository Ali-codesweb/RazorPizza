using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaproj.Data;
using pizzaproj.Models;
namespace pizzaproj.Pages.Checkout

{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
                public string PizzaName { get; set; }
        public string PizzaPrice { get; set; }
        public string ImageTitle { get; set; }



        // OnGet is a predefined method

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }




    }
}

