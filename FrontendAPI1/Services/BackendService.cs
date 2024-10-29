namespace FrontendAPI.Services
{
    using FrontendAPI.Models;
    using System.Net.Http.Json;

    public class BackendService : IBackendService
    {
        private readonly HttpClient _httpClient;

        public BackendService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AppDocument>> GetDocumentsFromBackendAPI2()
        {
            var ret = await _httpClient.GetFromJsonAsync<List<AppDocument>>("http://localhost:5001/api/documents") ?? new List<AppDocument>();
            return ret;
        }

        public async Task<List<AppDocument>> GetDocumentsFromBackendAPI3()
        {
            var ret = await _httpClient.GetFromJsonAsync<List<AppDocument>>("http://localhost:5002/api/documents") ?? new List<AppDocument>();
            return ret;
        }

        public async Task<AppDocument> AddDocumentToBackendAPI2(AppDocument document)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5001/api/documents", document);
            return await response.Content.ReadFromJsonAsync<AppDocument?>() ?? new AppDocument();
        }

        public async Task<AppDocument> AddDocumentToBackendAPI3(AppDocument document)
        {
            var response = await _httpClient.PostAsJsonAsync("http://localhost:5002/api/documents", document);
            return await response.Content.ReadFromJsonAsync<AppDocument?>() ?? new AppDocument();
        }
    }
}
