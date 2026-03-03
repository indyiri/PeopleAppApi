using PeopleApp.Domain.Models;
using System.ComponentModel;
using System.Security.Principal;

namespace PeopleApp.API.UI.Contracts.Departments
{
    public class GetDepartmentsResponse
    {
        IEnumerable<DepartmentApiViewModel> _departments;
        public GetDepartmentsResponse(IEnumerable<Department> departments)
        {
            _departments = departments.Select(x => new DepartmentApiViewModel
            { Id = x.Id, Name = x.Name });
                
        }
        public IEnumerable<DepartmentApiViewModel> Departments => _departments;
    }
}
