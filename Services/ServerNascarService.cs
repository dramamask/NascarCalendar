using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class ServerNascarService : INascarService
{
    public string GetCalendar()
    {
        using (HttpClient client = new HttpClient())
        {
            var uri = "https://cf.nascar.com/cacher/2023/race_list_basic.json";
            Task<string> t = client.GetStringAsync(uri);
            return t.Result;
        }
    }

    public string GetCalendarSync()
    {
        return "sync calendar";
    }
}