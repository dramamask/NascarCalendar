namespace NascarCalendar.Services;

public interface INascarService
{
    public Task<string> GetCalendar();
}