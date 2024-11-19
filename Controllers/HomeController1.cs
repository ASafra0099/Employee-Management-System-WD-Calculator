using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement_system.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
