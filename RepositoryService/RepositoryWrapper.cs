using WebApplication7._0.DbContexts;

namespace WebApplication7._0.RepositoryService
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _applicationDbContext;
        private ITestRepository? _test;
        private IBookRepository? _bookRepository;

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

        public IBookRepository Book {
            get {
                if (_bookRepository == null) { 
                    _bookRepository=new BookRepository(_applicationDbContext);
                }
                return _bookRepository;
            }
        }

        public void save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
