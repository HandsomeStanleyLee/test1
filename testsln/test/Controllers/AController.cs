using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class AController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string hello()
        {
            return "Hello";
        }
    }
}
