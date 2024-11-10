namespace NascarCalendar.Services;

/**
 * ErrorService
 *
 * This class contains methods that are used to check for errors in the URL.
 *
 * @package NascarCalendar
 */
public class ErrorService() : IErrorService
{
    /**
        * CheckPageURL
        *
        * This method checks to ensure that the series identifier and year
        * that are used in the URL are valid.
        *
        * @param string seriesIdentifier
        * @param int year

        * @return void
        */
    public void CheckPageURL(string seriesIdentifier, int year)
    {
        CheckSeriesIdentifier(seriesIdentifier);
        CheckYear(year);
    }

    /**
        * CheckSeriesIdentifier
        *
        * This method checks to ensure that the series identifier used in the URL is valid.
        *
        * @param string seriesIdentifier
        *
        * @return void
        */
    private static void CheckSeriesIdentifier(string seriesIdentifier)
    {
        switch (seriesIdentifier)
        {
            case "series_1":
            case "series_2":
            case "series_3":
                return;
            default:
                throw new Exception("Invalid series identifier used in the URL. " + GetURLErrorMessage());
        }
    }

    /**
        * CheckYear
        *
        * This method checks to ensure that the year used in the URL is valid.
        *
        * @param int year
        *
        * @return void
        */
    private static void CheckYear(int year)
    {
        if (year < 2015 || year > 2024)
        {
            throw new Exception("Invalid year used in the URL. " + GetURLErrorMessage());
        }
    }

    /**
        * GetURLErrorMessage
        *
        * This method returns the error message that is displayed when the URL is invalid.
        *
        * @return string
        */
    private static string GetURLErrorMessage()
    {
        var error = "The proper URL format is `/{seriesIdentifier}/{Year}`,";
        error += " where {seriesIdentifier} is 'series_1', 'series_2', or 'series_3',";
        error += " and {Year} is a 4-digit number between 2015 and 2024.";

        return error;
    }
}
