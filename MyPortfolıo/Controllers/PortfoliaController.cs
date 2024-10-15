using Microsoft.AspNetCore.Mvc;

namespace MyPortfolıo.Controllers
{
    public class PortfoliaController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
