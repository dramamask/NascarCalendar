using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class ServerNascarService : INascarService
{
    public async Task<string> GetCalendar()
    {
        using (HttpClient client = new HttpClient())
        {
            var uri = "https://cf.nascar.com/cacher/2023/race_list_basic.json";
            return await client.GetStringAsync(uri);
        }
    }

    public string GetCalendarSync()
    {
        return "sync calendar";
    }
}