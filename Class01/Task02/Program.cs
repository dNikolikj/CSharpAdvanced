using System;
using System.Collections.Generic;
using System.Linq;
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Create a console application that checks if a day is a working day 🔹
            //The app should request for a user to enter a date as an input or multiple inputs(single strings formatted according to your machine settings, e.g. "04-04-2022" = DD - MM - YYYY)
            //The app should then open and see if the day is a working day
            //It should show the user a message whether the date they entered is working or not
            //Weekends are not working
            //1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October and 8 December(non - working holidays) are not working days as well
            //It should ask the user if they want to check another date
            //Yes - the app runs again
            //No - the app closes
            List<DateTime> holidays = new List<DateTime>()
{
            new DateTime(2022, 1, 1),
            new DateTime(2022, 1, 7),
            new DateTime(2022, 4, 20),
            new DateTime(2022, 5, 1),
            new DateTime(2022, 5, 25),
            new DateTime(2022, 8, 3),
            new DateTime(2022, 9, 8),
            new DateTime(2022, 10, 12),
            new DateTime(2022, 10, 23),
            new DateTime(202, 12, 8)
};

            do
            {

                Console.WriteLine("Enter day for date");
                string inputDay = Console.ReadLine();

                bool isDayParsed = int.TryParse(inputDay, out int dayParsed);

                if (!isDayParsed)
                {
                    Console.WriteLine("Invalid input for day day");
                    return;
                }

                Console.WriteLine("Enter month for date");
                string inputMonth = Console.ReadLine();

                bool isMonthParsed = int.TryParse(inputMonth, out int monthParsed);

                if (!isMonthParsed)
                {
                    Console.WriteLine("Invalid input for month");
                    return;
                }

                Console.WriteLine("Enter year for date");
                string inputYear = Console.ReadLine();

                bool isYearParsed = int.TryParse(inputYear, out int yearParsed);

                if (!isYearParsed)
                {
                    Console.WriteLine("Invalid input for year");
                    return;
                }

                DateTime date = new DateTime(yearParsed, monthParsed, dayParsed);

                foreach (DateTime holidayDay in holidays)
                {
                    if (date.Day == holidayDay.Day && date.Month == holidayDay.Month)
                    {
                        Console.WriteLine($"{date} is a holiday");
                    }
                }

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine($"{date} is on weekend {date.DayOfWeek}");
                }
                else
                {
                    Console.WriteLine($"{date} is a working day");
                }

                Console.WriteLine("Check another date? y/n");

            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
