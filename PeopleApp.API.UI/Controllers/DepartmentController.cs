using Microsoft.AspNetCore.Mvc;
using PeopleApp.API.UI.Contracts.Departments;
using PeopleApp.Application.Interfaces;
using PeopleApp.Application.Services;

namespace PeopleApp.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        IDepartment _service;
        public DepartmentController(IDepartment service)
        {
            _service = service;
        }
        #region Get
        [HttpGet]
        public ActionResult<IEnumerable<DepartmentApiViewModel>> Get()
        {
            try
            {
                var result = _service.GetDepartments();
                if (result.Succeeded)
                {
                    var response = new GetDepartmentsResponse(result.Departments!);
                    return Ok(response.Departments);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetDetails(long id)
        {
            try
            {
                var result = _service.GetDepartment(id);
                if (result.Succeeded)
                {
                    var response = new GetDepartmentResponse(result.Department!);
                    return Ok(response);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion
        #region Add - Post
        [HttpPost]
        public IActionResult Add(CreateDepartmentRequest request)
        {
            try
            {
                var result = _service.Add(request.Name);
                if (result.Succeeded)
                {
                    var created = new CreateDepartmentResponse(result.Department!);
                    return Ok(created);
                }
                return BadRequest(result.Error);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }
}
