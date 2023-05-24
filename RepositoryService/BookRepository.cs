using WebApplication7._0.DbContexts;
using WebApplication7._0.Models;

namespace WebApplication7._0.RepositoryService
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
