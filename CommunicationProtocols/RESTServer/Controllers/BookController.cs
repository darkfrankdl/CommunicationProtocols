using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> _books;
        public BookController() 
        {
            _books = new List<Book>() { new Book() { Id = 1 } };
        }

        [HttpGet]
        public ActionResult<Book> Get(int id)
        {
            Book book = _books[id];
            return book;
        }
    }
}
