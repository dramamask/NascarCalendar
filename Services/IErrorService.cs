namespace NascarCalendar.Services;

public interface IErrorService
{
    public void CheckPageURL(string seriesIdentifier, int year);
}