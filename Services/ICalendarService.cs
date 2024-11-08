using NascarCalendar.Models;

namespace NascarCalendar.Services;

public interface ICalendarService
{
    public Task<Calendar> GetCalendar();

    public Race GetRace(string seriesName, int raceIndex);
}