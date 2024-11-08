using NascarCalendar.Models;

namespace NascarCalendar.Services;

public interface INascarService
{
    public Task<Calendar> GetCalendar();
}