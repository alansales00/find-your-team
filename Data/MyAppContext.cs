using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext()
        {
        }

        public MyAppContext(DbContextOptions<MyAppContext> options) :
            base(options) 
        { }

        public DbSet<Player>? Players { get; set; }

        public DbSet<Game>? Games { get; set; }

    }
}
