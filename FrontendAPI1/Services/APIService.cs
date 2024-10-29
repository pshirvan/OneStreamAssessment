using FrontendAPI.Models;

namespace FrontEndAPI.Services;

public interface IAPIService
{
    Task<string> FetchDataAsync();
    Task<string> SendDataAsync(AppDocument data);
}

public class APIService : IAPIService
{
    private readonly HttpClient _httpClient;

    public APIService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> FetchDataAsync()
    {
        var response1 = await _httpClient.GetStringAsync("http://localhost:5001/api/backend/data");
        var response2 = await _httpClient.GetStringAsync("http://localhost:5002/api/backend/data");

        return $"Response1: {response1}, Response2: {response2}";
    }

    public async Task<string> SendDataAsync(AppDocument data)
    {
        var content = JsonContent.Create(data);
        var response = await _httpClient.PostAsync("http://localhost:5001/api/backend/data", content);
        return await response.Content.ReadAsStringAsync();
    }
}
