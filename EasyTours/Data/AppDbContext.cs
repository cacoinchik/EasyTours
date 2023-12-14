using EasyTours.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyTours.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Tour> Tours { get; set; }
    }
}
