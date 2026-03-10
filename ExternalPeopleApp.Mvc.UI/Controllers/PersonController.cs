using ExternalPeopleApp.Mvc.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExternalPeopleApp.Mvc.UI.Controllers
{
    public class PersonController : Controller
    {
        private PersonApiService _service;

        public PersonController(PersonApiService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
