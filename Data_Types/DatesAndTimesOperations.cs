using System;
using static System.Console;


namespace Data_Types;

public static class DatesAndTimesOperations
{
    public static void UseDatesAndTimes()
    {
        WriteLine("=> Dates and Times:");

        //This constructor takes (year, month, day)
        DateTime dt = new DateTime(2015, 10, 17);

        //What day of the month is this?
        WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

        //Month is now December
        dt = dt.AddMonths(2);
        WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
    }
}