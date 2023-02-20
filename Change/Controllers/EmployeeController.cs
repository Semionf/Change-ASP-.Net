using Microsoft.AspNetCore.Mvc;

namespace Change.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
