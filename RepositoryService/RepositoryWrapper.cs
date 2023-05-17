using WebApplication7._0.DbContexts;

namespace WebApplication7._0.RepositoryService
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private ITestRepository _test;

        public RepositoryWrapper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }
        public ITestRepository Test
        {
            get {
                if (_test==null) {
                    _test = new TestRepository(_applicationDbContext);
                }
                return _test;
            }
        }

        public void save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
