using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication7._0.Models;
using WebApplication7._0.RepositoryService;

namespace WebApplication7._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TestController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IEnumerable<Test> Get() {
            var tests=_repositoryWrapper.Test.FindAll();
            return tests;
        }
    }
}
