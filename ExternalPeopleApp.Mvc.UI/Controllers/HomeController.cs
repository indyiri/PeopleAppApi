using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExternalPeopleApp.Mvc.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
