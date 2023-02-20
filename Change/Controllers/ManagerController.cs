using Microsoft.AspNetCore.Mvc;

namespace Change.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
