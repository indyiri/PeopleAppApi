using ExternalPeopleApp.Mvc.UI.Services;
using ExternalPeopleApp.Mvc.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExternalPeopleApp.Mvc.UI.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentApiService _service;
        public DepartmentController(DepartmentApiService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var departments = await _service.GetDepartmentsAsync();
            return View(departments);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var department = await _service.GetDepartmentByIdAsync(id);
            return View(department);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
                
            var created = await _service.CreateDepartmentAsync(model);

            if (created == null)
            {
                ModelState.AddModelError("", "Failed to create department.");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
