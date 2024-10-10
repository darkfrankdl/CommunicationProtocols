using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels;

namespace RESTServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookServerController : ControllerBase
    {
        List<Book> _books;
        public BookServerController() 
        {
            _books = new List<Book>() { new Book() { Id = 1 } };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            return _books;
        }
    }
}
