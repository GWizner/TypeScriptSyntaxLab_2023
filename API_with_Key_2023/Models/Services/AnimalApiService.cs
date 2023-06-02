using System.ComponentModel;

namespace API_with_Key_2023.Models.Services
{
    public class AnimalApiService
    {
        private readonly HttpClient _httpClient;
        public AnimalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
            
       public async Task<List<AnimalResponse>> GetAnimalBySearchTerm(string searchTerm)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"animals?name={searchTerm}");

            List<AnimalResponse> result = await response.Content.ReadAsAsync<List<AnimalResponse>>();
            //requires NuGet package Microsoft.AspNet>WebApi.Client

            return result;
        }

    }
}
