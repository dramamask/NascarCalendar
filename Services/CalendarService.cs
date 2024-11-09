using NascarCalendar.Models;
using System.Net;
using System.Net.Http.Json;

namespace NascarCalendar.Services;

public class CalendarService(HttpClient http) : ICalendarService
{
    private Calendar calendar = null;

    public async Task<Calendar> GetCalendar(int year)
    {
        var url = "https://cf.nascar.com/cacher/" + year.ToString() + "/race_list_basic.json";
        HttpResponseMessage res = await http.GetAsync(url);

        if (!res.IsSuccessStatusCode)
        {
            string msg = await res.Content.ReadAsStringAsync();
            // TODO: Log the error somewhere
            throw new Exception(msg);
        }

        if (res.StatusCode == HttpStatusCode.NoContent)
        {
            return default(Calendar);
        }

        calendar = await res.Content.ReadFromJsonAsync<Calendar>();

        return calendar;
    }

    public List<Race> GetSeries(string seriesName)
    {
        switch (seriesName) {
            case "series_1":
                return calendar.series_1;
            case "series_2":
                return calendar.series_2;
            case "series_3":
                return calendar.series_3;
            default:
                return null;
        }
    }

    public Race GetRace(string seriesName, int raceIndex)
    {
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