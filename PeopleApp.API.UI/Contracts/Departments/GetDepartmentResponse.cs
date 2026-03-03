using PeopleApp.Domain.Models;

namespace PeopleApp.API.UI.Contracts.Departments
{
    public class GetDepartmentResponse
    {
        public GetDepartmentResponse(Department department)
        {
            Id = department.Id;
            Name = department.Name;
        }
        public  long Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
