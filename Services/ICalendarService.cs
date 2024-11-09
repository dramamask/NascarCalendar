using NascarCalendar.Models;

namespace NascarCalendar.Services;

public interface ICalendarService
{
    public Task<Calendar> GetCalendar(int year);

    public List<Race> GetSeries(string seriesIdentifier);

    public Race GetRace(string seriesIdentifier, int raceIndex);
}