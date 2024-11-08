using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class ServerNascarService(HttpClient http) : INascarService
{
    public async Task<string> GetCalendar()
    {
        var uri = "https://cf.nascar.com/cacher/2023/race_list_basic.json";
        return await http.GetStringAsync(uri);
    }
}