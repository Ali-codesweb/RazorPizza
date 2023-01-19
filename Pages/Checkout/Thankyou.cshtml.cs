using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizzaproj.Data;
using pizzaproj.Models;
namespace pizzaproj.Pages.Thankyou

{
    [BindProperties(SupportsGet = true)]
    public class ThankyouModel : PageModel
    {

        public string PizzaName { get; set; }
        public string PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public bool Hame { get; set; }

        private readonly ApplicationDBContext _context;
        public ThankyouModel(ApplicationDBContext context)
        {
            _context = context;
        }


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
            Console.WriteLine("Get");
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = ImageTitle;
            pizzaOrder.BasePrice = float.Parse(PizzaPrice);
            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }




    }
}

