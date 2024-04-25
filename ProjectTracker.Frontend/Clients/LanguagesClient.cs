using ProjectTracker.Frontend.Models;

namespace ProjectTracker.Frontend.Clients;

public class LanguagesClient(HttpClient httpClient)
{
    public async Task<Language[]> GetLanguagesAsync() 
        => await httpClient.GetFromJsonAsync<Language[]>("languages") ?? [];

}
