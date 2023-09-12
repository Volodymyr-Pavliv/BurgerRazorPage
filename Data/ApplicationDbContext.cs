using BurgerRazorPage.Models;
using Microsoft.EntityFrameworkCore;

namespace BurgerRazorPage.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<BurgerOrder> BurgerOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
