using Microsoft.AspNetCore.Mvc;
using SharedModels;
using RESTServer;
using RESTServer.Controllers;
namespace RESTClient.Controllers
{
    public class BookClientController : Controller
    {
        private BookServerController _server = new BookServerController();
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult<Book> Books()
        {
            return View(_server.GetAll().Value);
        }
    }
}
