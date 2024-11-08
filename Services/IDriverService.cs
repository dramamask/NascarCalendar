using NascarCalendar.Models;

namespace NascarCalendar.Services;

public interface IDriverService
{
    public string GetDriverPicture(string seriesName, int raceIndex);
}