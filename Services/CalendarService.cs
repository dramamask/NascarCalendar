using NascarCalendar.Models;
using System.Net;

namespace NascarCalendar.Services;

/**
 * Calendar Service
 * This service class knows how to fetch the NASCAR schedule from the NASCAR website.
 *
 * @package NascarCalendar
 */
public class CalendarService(HttpClient http) : ICalendarService
{
    // The calendar object that will be populated with the fetched data
    private Calendar calendar = new();

    /**
     * Fetches the schedule for the specified year from the NASCAR website.
     *
     * @param year The year to fetch the schedule for
     *
     * @return the schedule for the specified year
     */
    public async Task<Calendar> GetCalendar(int year)
    {
        var url = "https://cf.nascar.com/cacher/" + year.ToString() + "/race_list_basic.json";
        HttpResponseMessage res = await http.GetAsync(url);

        if (!res.IsSuccessStatusCode) {
            string msg = await res.Content.ReadAsStringAsync();
            throw new Exception(msg);
        }

        if (res.StatusCode == HttpStatusCode.NoContent) {
            return calendar;
        }

        var parsedJson = await res.Content.ReadFromJsonAsync<Calendar>();

        if (parsedJson != null) {
            calendar = parsedJson;
        }

        return calendar;
    }

    /**
     * Returns all the info for the specified series, from the currently loaded calendar.
     *
     * @param seriesIdentifier The identifier of the series
     *
     * @return a list of all the races in the series
     */
    public List<Race> GetSeries(string seriesIdentifier)
    {
        switch (seriesIdentifier) {
            case "series_1":
                return calendar.series_1 ?? ([]);
            case "series_2":
                return calendar.series_2 ?? ([]);
            case "series_3":
                return calendar.series_3 ?? ([]);
            default:
                return [];
        }
    }

    /**
     * Returns the info for a single race in the specified series, from the currently
     * loaded calendar.
     *
     * @param seriesIdentifier The identifier of the series
     * @param raceIndex The index
     *
     * @return the race info
     */
    public Race GetRace(string seriesIdentifier, int raceIndex)
    {
        switch (seriesIdentifier) {
            case "series_1":
                return calendar.series_1?[raceIndex] ?? (new Race());
            case "series_2":
                return calendar.series_2?[raceIndex] ?? (new Race());
            case "series_3":
                return calendar.series_3?[raceIndex] ?? (new Race());
            default:
                return new Race();
        }
    }
}