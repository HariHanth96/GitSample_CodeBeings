using Microsoft.AspNetCore.Mvc;

namespace GitSample_CodeBeings.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
