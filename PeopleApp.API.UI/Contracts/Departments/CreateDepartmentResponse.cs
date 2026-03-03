using PeopleApp.Domain.Models;

namespace PeopleApp.API.UI.Contracts.Departments
{
    public class CreateDepartmentResponse
    {
        DepartmentApiViewModel _department = new DepartmentApiViewModel();
        public CreateDepartmentResponse(Department department)
        {
            _department.Id = department.Id;
            _department.Name = department.Name;
        }
        public DepartmentApiViewModel Department => _department;
    }
}
