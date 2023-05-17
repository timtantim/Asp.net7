using WebApplication7._0.DbContexts;
using WebApplication7._0.Models;

namespace WebApplication7._0.RepositoryService
{
    public class TestRepository : RepositoryBase<Test>, ITestRepository
    {
        public TestRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
