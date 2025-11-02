using MagazineApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MagazineApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
 