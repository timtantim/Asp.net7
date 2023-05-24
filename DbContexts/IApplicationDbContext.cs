using Microsoft.EntityFrameworkCore;
using WebApplication7._0.Models;

namespace WebApplication7._0.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Test> Test { get; set; }
        DbSet<Book> Books { get; set; }
    }
}
