using NascarCalendar.Models;

namespace NascarCalendar.Services;

public interface ICalendarService
{
    public Task<Calendar> GetCalendar();

    public List<Race> GetSeries(string seriesName);

    public Race GetRace(string seriesName, int raceIndex);
}