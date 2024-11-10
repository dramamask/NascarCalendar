namespace NascarCalendar.Services;

/**
 * Series Service
 * This service class contains methods to get the name and image URL of a series.
 *
 * @package NascarCalendar
 */
public class SeriesService() : ISeriesService
{
    /**
     * This method returns the name of a series based on the series identifier and year.
     *
     * @param seriesIdentifier The identifier of the series. E.g. "series_1"
     * @param year The year of the series.
     *
     * @return The name of the series.
     */
    public string GetSeriesName(string seriesIdentifier, int year)
    {
        switch (seriesIdentifier) {
            case "series_1":
                return "NASCAR Cup Series";
            case "series_2":
                return "NASCAR Xfinity Series";
            case "series_3":
                if (year < 2023) {
                    return "NASCAR Camping World Truck Series";
                } else {
                    return "NASCAR CRAFTSMAN Truck Series";
                }
            default:
                return "";
        }
    }

   /**
    * This method returns the image URL of a series based on the series identifier and year.
    *
    * @param seriesIdentifier The identifier of the series. E.g. "series_1"
    * @param year The year of the series.
    *
    * @return The image URL of the series.
    */
    public string GetSeriesImage(string seriesIdentifier, int year)
    {
        switch (seriesIdentifier) {
            case "series_1":
                return "https://www.nascar.com/wp-content/uploads/sites/7/2023/05/10/nascar_cup_series_logo.svg";
            case "series_2":
                return "https://www.nascar.com/wp-content/uploads/sites/7/2023/05/10/nascar_xfinity_series_logos-1.svg";
            case "series_3":
                if (year < 2023) {
                    return "https://www.nascar.com/wp-content/uploads/sites/8/2022/05/19/NCWTS-Primary-RGB_240x115.png";
                } else {
                    return "https://www.nascar.com/wp-content/uploads/sites/7/2023/05/10/nascar_craftsman_truck_series_logo.svg";
                }
            default:
                return "";
        }
    }
}