using ExternalPeopleApp.Mvc.UI.ViewModels;

namespace ExternalPeopleApp.Mvc.UI.Services
{
    public class LocationApiService
    {
        private readonly HttpClient _httpClient;
        public LocationApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<LocationViewModel>> GetLocationsAsync()
        {
            var response = await _httpClient.GetAsync("api/location");

            if (!response.IsSuccessStatusCode)
            {
                return Enumerable.Empty<LocationViewModel>();
            }

            var departments = await response.Content.ReadFromJsonAsync<IEnumerable<LocationViewModel>>();

            return departments ?? Enumerable.Empty<LocationViewModel>();
        }
    }
}
