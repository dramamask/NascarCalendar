using NascarCalendar.Models;
using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class CalendarService(HttpClient http) : ICalendarService
{
    private Calendar calendar = null;

    public async Task<Calendar> GetCalendar()
    {
        HttpResponseMessage res = await http.GetAsync("https://cf.nascar.com/cacher/2023/race_list_basic.json");

        if (!res.IsSuccessStatusCode)
        {
            string msg = await res.Content.ReadAsStringAsync();
            // TODO: Log the error somewhere
            throw new Exception(msg);
        }

        calendar = await res.Content.ReadFromJsonAsync<Calendar>();

        return calendar;
    }

    public Race GetRace(string seriesName, int raceIndex) {
        switch (seriesName) {
            case "series_1":
                return calendar.series_1[raceIndex];
            case "series_2":
                return calendar.series_2[raceIndex];
            case "series_3":
                return calendar.series_3[raceIndex];
            default:
                return null;
        }
    }
}