using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class WebshopContext :DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<BasketPosition> BasketPosition { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; }
        public DbSet<OrderPosition> OrderPosition { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=localhost;" +
                " Database=Sklep;" +
                " Trusted_Connection=Treu");
        }
    }
}
