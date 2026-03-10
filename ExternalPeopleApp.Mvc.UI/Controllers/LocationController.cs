using ExternalPeopleApp.Mvc.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExternalPeopleApp.Mvc.UI.Controllers
{
    public class LocationController : Controller
    {
        private LocationApiService _service;

        public LocationController(LocationApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var locations = await _service.GetLocationsAsync();
            return View(locations);
        }
    }
}
