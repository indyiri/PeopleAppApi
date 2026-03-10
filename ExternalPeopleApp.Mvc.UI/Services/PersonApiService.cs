namespace ExternalPeopleApp.Mvc.UI.Services
{
    public class PersonApiService
    {
        private readonly HttpClient _httpClient;
        public PersonApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


    }
}
