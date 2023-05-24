using Microsoft.EntityFrameworkCore;
using WebApplication7._0.Models;

namespace WebApplication7._0.DbContexts
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Test> Test { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
