
public class DateAnd_Time
{
    public static void DateAndTime(int year, int day, int month, int hr, int minutes, int seconds, int milliseconds)
    {
        DateTime date = new DateTime(year, month, day, hr, minutes, seconds, milliseconds);
        Console.WriteLine("Day is " + date.Day);
        Console.WriteLine("Month is {0}", date.Month);
        Console.WriteLine("Year is {0}", date.Year);
        Console.WriteLine("Hours are {0}", date.Hour);
        Console.WriteLine("Minutes are {0}", date.Minute);
        Console.WriteLine("Seconds are {0}", date.Second);
        Console.WriteLine("Milliseconds are {0}", date.Millisecond);
    }
        
}

public class Date_Calculations
{
    public static void Daysof(int year, int day, int month, int hr, int minutes, int seconds, int milliseconds)
    {
        DateTime date = new DateTime(year, month, day, hr, minutes, seconds, milliseconds);

        Console.WriteLine("Day of Week:{0}", date.DayOfWeek);
        Console.WriteLine("Day of Year: {0}", date.DayOfYear);
        Console.WriteLine("Time of Day:{0}", date.TimeOfDay);
        Console.WriteLine("Tick:{0}", date.Ticks);
        Console.WriteLine("Kind:{0}", date.Kind);
    }
}

public class Date_Now
{
    public static void DateNow()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine(date);
        DateTime date2 =  date.AddMonths(4);
        Console.WriteLine(date2);
        DateTime date3 = date.AddDays(3);
        Console.WriteLine(date3);
    }
}

public class Time_Span
{
    public static void Time_span(int days, int hrs, int minutes, int seconds, int milliseconds)
    {
        TimeSpan ts = new TimeSpan(days, hrs, minutes, seconds, milliseconds);
        Console.WriteLine(ts.ToString());
    }
}

public class Date_Only
{
   public static DateOnly dateOnly = new DateOnly(2001, 05, 13);
}

public class Time_Only
{
    public static TimeOnly timeOnly = new TimeOnly(14, 10, 10);
}

public class DateTimeNow
{
    public static DateTime datetime = DateTime.Now;
}

public class MinMax
{
    public static DateTime maxDateTimeValue = DateTime.MaxValue;
    public static DateTime minDateTimeValue = DateTime.MinValue;
}

public class UTC_Now
{
    public static DateTime currentDateTimeUTC = DateTime.UtcNow;
}

public class DateToday
{
    public static DateTime todaysDate = DateTime.Today;
}
public class Sample
{
    public static void Main()
    {
        int year, day, month, hr, minutes, seconds, milliseconds;
        Console.WriteLine("Enter the year");
        year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the day");
        day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the hr");
        hr = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the minutes");
        minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seconds");
        seconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the milliseconds");
        milliseconds = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the month");
        month = Convert.ToInt32(Console.ReadLine());

        DateAnd_Time.DateAndTime(year, day, month, hr, minutes, seconds, milliseconds);

        Date_Calculations.Daysof(year, day, month, hr, minutes, seconds, milliseconds);

        Date_Now.DateNow();

        Console.WriteLine("Enter the day");
        int day2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the hr");
        int hr2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the minutes");
        int minutes2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seconds");
        int seconds2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the milliseconds");
        int milliseconds2 = Convert.ToInt32(Console.ReadLine());
        Time_Span.Time_span(day2, hr2, minutes2, seconds2, milliseconds2);

        Console.WriteLine(Date_Only.dateOnly);

        Console.WriteLine(Time_Only.timeOnly);

        Console.WriteLine(DateTimeNow.datetime);

        Console.WriteLine(MinMax.minDateTimeValue);
        Console.WriteLine(MinMax.maxDateTimeValue);

        Console.WriteLine(UTC_Now.currentDateTimeUTC);

        Console.WriteLine(DateToday.todaysDate);
    }

}