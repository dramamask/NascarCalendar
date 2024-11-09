namespace NascarCalendar.Services;

public interface ISeriesService
{
    public string GetSeriesName(string seriesIdentifier, int year);

    public string GetSeriesImage(string seriesIdentifier, int year);
}