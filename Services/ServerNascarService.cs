using NascarCalendar.Models;
using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class ServerNascarService(HttpClient http) : INascarService
{
    public async Task<Calendar> GetCalendar()
    {
        HttpResponseMessage res = await http.GetAsync("https://cf.nascar.com/cacher/2023/race_list_basic.json");

        if (!res.IsSuccessStatusCode)
        {
            string msg = await res.Content.ReadAsStringAsync();
            // TODO: Log the error somewhere
            throw new Exception(msg);
        }

        return await res.Content.ReadFromJsonAsync<Calendar>();
    }
}