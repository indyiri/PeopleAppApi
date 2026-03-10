using ExternalPeopleApp.Mvc.UI.ViewModels;

namespace ExternalPeopleApp.Mvc.UI.Services
{
    public class DepartmentApiService
    {
        private readonly HttpClient _httpClient;
        public DepartmentApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<DepartmentViewModel>> GetDepartmentsAsync()
        {
            var response = await _httpClient.GetAsync("api/department");

            if (!response.IsSuccessStatusCode)
            {
                return Enumerable.Empty<DepartmentViewModel>();
            }

            var departments = await response.Content.ReadFromJsonAsync<IEnumerable<DepartmentViewModel>>();

            return departments ?? Enumerable.Empty<DepartmentViewModel>();
        }

        public async Task<DepartmentViewModel?> GetDepartmentByIdAsync(long id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/department/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                    
                var department = await response.Content.ReadFromJsonAsync<DepartmentViewModel>();

                return department;
            }
            catch
            {
                return null;
            }
        }

        public async Task<DepartmentViewModel?> CreateDepartmentAsync(DepartmentViewModel model)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/department", model);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                   
                var createdDepartment = await response.Content.ReadFromJsonAsync<DepartmentViewModel>();

                return createdDepartment;
            }
            catch
            {
                return null;
            }
        }
    }
}
