using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7._0.Models;
using WebApplication7._0.RepositoryService;

namespace WebApplication7._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        public BookController(IRepositoryWrapper repositoryWrapper)
        {
            _repository=repositoryWrapper;
        }

        [HttpGet("GetBooks")]
        public IEnumerable<Book> GetBooks()
        {
            return _repository.Book.FindAll();
        }
    }
}
