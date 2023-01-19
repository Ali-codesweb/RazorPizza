using Microsoft.EntityFrameworkCore;
using pizzaproj.Models;

namespace pizzaproj.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Define tables of the database
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }


    }
}