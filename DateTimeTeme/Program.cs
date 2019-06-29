using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTeme
{
   class Program
   {
      static void Main(string[] args)
      {
         //Problema1.
         Problema1DisplayTime();
         //Problema2.
         Problema2AddYears();
         //Problema3.
         Problema3HumanFriendly();
         //Problema4.
         Problema4AddSeconds();
         //Problema5.
         Problema5TimeInMillisseconds();
         //Problema6.
         Problema6SixMonths();
         //Problema7.
         Problema7FirstAndLastSecond();
         //Problema8.
         Problema8DifferenceInSeconds();
         //Problema9.
         Problema9CalculateTheAge();
         //Problema10
         Problema10AfterBefore30Days();
         //Problema11
         Problema11NumberOfDays();
         //Problema12
         Problema12YTT();
         //Problema13
         Problema13Next5Days();
         //Problema14
         Problema14MondayOfAWeek();
         //Problema15
         Problema15DaysBetween2Dates();
      }

      public static void Problema1DisplayTime()
      {
         Console.WriteLine("Prob 1");
         DateTime myDate = DateTime.Now;
         Console.Write("a)  ");
         Console.WriteLine("Current date and time: " + myDate);


         Console.Write("b)  ");
         Console.WriteLine("Current year: " + myDate.Year);


         Console.Write("c)  ");
         Console.WriteLine("Month of year: " + myDate.Month);


         Console.Write("d)  ");
         int weekNumber = (int)myDate.Month * 4;
         int dayNumber = (int)myDate.Day;
         if (dayNumber <= 7)
         {
            weekNumber = weekNumber - 3;
         }
         if (dayNumber >= 7 && dayNumber <= 14)
         {
            weekNumber = weekNumber - 2;
         }
         if (dayNumber >= 14 && dayNumber <=21)
         {
            weekNumber = weekNumber - 1;
         }
         Console.WriteLine("week number of the year: " + weekNumber);


         Console.Write("e)  ");
         Console.WriteLine("Weekday of the week: " + (int)myDate.DayOfWeek);


         Console.Write("f)  ");
         Console.WriteLine("Day of year: " + myDate.DayOfYear);


         Console.Write("g)  ");
         Console.WriteLine("Day of the month: " + myDate.Day);


         Console.Write("h)  ");
         Console.WriteLine("Day of the week: " + myDate.DayOfWeek);

         Console.Write("i) ");
         int year = (int)myDate.Year;
         if (DateTime.IsLeapYear(year))
         {
            Console.WriteLine(" This year is a leap year");
         }
         else
         {
            Console.WriteLine(" This year is not a leap year");
         }
         Console.WriteLine("\n");
      }
      public static void Problema2AddYears()
      {
         Console.WriteLine("Prob2");
         DateTime myDate = DateTime.Now;
         Console.WriteLine("Current year :" + myDate.Year);
         int yearsToAdd = 5;
         DateTime newDate = myDate.AddYears(yearsToAdd);
         int newYear = newDate.Year;
         Console.WriteLine("years to add:" + yearsToAdd);
         Console.WriteLine("Current year after adding " + yearsToAdd + " years" + " is: " + newYear);
         Console.WriteLine("\n");
      }
      public static void Problema3HumanFriendly()
      {
         Console.WriteLine("Prob3");
         DateTime myDateTime = DateTime.Now;
         string myDate = myDateTime.ToLongDateString();
         string myTime = myDateTime.ToLongTimeString();
         Console.WriteLine($"The date is {myDate} at the hour {myTime}");
         Console.WriteLine("\n");
      }
      public static void Problema4AddSeconds()
      {
         Console.WriteLine("Prob4");
         DateTime myTime = DateTime.Now;
         Console.WriteLine("Current time :" + myTime.ToLongTimeString());
         int secondsToAdd = 5;
         DateTime newTime = myTime.AddSeconds(5);
         Console.WriteLine($"The time after adding {secondsToAdd} seconds is {newTime.ToLongTimeString()}");
         Console.WriteLine("\n");
      }

      public static void Problema5TimeInMillisseconds()
      {
         Console.WriteLine("Prob5");
         DateTime myTime = DateTime.Now;
         DateTime timeBegining = new DateTime(myTime.Year, myTime.Month, myTime.Day, 0, 0, 0, 0);
         TimeSpan timeInMiliseconds = myTime.Subtract(timeBegining);
         Console.WriteLine($"Time in milliseconds: {timeInMiliseconds.TotalMilliseconds}");
         Console.WriteLine("\n");
         

      }

      public static void Problema6SixMonths()
      {
         Console.WriteLine("Prob6");
         DateTime now = DateTime.Now;
         Console.WriteLine($"Present Date {now}");
         DateTime sixMonth = now.AddMonths(6);
         Console.WriteLine($"The date after 6 months : {sixMonth}");
         Console.WriteLine("\n");
      }
      public static void Problema7FirstAndLastSecond()
      {
         Console.WriteLine("Prob7");
         DateTime now = DateTime.Now;
         DateTime startOfDay = now.Date;
         DateTime endOfDay = startOfDay.AddDays(1).AddSeconds(-1);
         Console.WriteLine(startOfDay.AddSeconds(1));
         Console.WriteLine(endOfDay);
         Console.WriteLine("\n");
      }
      public static void Problema8DifferenceInSeconds()
      {
         Console.WriteLine("Prob8");
         DateTime firstDate = DateTime.Now;
         DateTime secondDate = firstDate.AddDays(5).AddHours(4);
         Console.WriteLine($"first date is:{firstDate}");
         Console.WriteLine($"secoond date is:{secondDate}");
         TimeSpan theDifference = secondDate.Subtract(firstDate);
         Console.WriteLine($"The difference in seconds is: {theDifference.TotalSeconds} seconds");
         Console.WriteLine("\n");
      }

      public static void Problema9CalculateTheAge()
      {
         Console.WriteLine("Prob9");
         DateTime myBirthday = DateTime.Parse("6/22/1995");
         int myAge = DateTime.Now.Year - (myBirthday.Year);
         Console.WriteLine($"My birthday is on 6/22/1995");
         Console.WriteLine(myAge);
         Console.WriteLine("\n");
      }
      public static void Problema10AfterBefore30Days()
      {
         Console.WriteLine("Prob10");
         DateTime now = DateTime.Now;
         Console.WriteLine($"Present date is {now}");
         DateTime after30D = now.AddDays(30);
         DateTime before30D = now.AddDays(-30);
         Console.WriteLine($"The date before is {before30D}");
         Console.WriteLine($"The date after is {after30D}");
         Console.WriteLine("\n");
      }

      public static void Problema11NumberOfDays()
      {
         Console.WriteLine("Prob11");
         DateTime date1 = new DateTime(1987, 12, 6);
         DateTime date2 = new DateTime(1456, 11, 5);
         Console.WriteLine($"first date is:{date1}");
         Console.WriteLine($"secoond date is:{date2}");
         TimeSpan theDifference = date1.Subtract(date2);
         Console.WriteLine($"The difference in days is: {theDifference.TotalDays} days");
         Console.WriteLine("\n");
      }

      public static void Problema12YTT()
      {
         Console.WriteLine("Prob12");
         DateTime now = DateTime.Now;
         Console.WriteLine($"Present date is {now}");
         DateTime after1D = now.AddDays(1);
         DateTime before1D = now.AddDays(-1);
         Console.WriteLine($"The date before is {before1D}");
         Console.WriteLine($"The date after is {after1D}");
         Console.WriteLine("\n");
      }
      public static void Problema13Next5Days()
      {
         Console.WriteLine("Prob13");
         DateTime now = DateTime.Now;
         Console.WriteLine($"Present date is {now}");
         DateTime after1D = now.AddDays(1);
         int count = 1;
         for (int i = 0; i < 5; i++)
         {
            Console.WriteLine(now.AddDays(count));
            count++;
         }
         
         Console.WriteLine("\n");
      }
      public static void Problema14MondayOfAWeek()
      {
         Console.WriteLine("Prob14");
         DateTime now = DateTime.Now;
         DateTime myDate = new DateTime(2015,1,1);
         Console.WriteLine($"Present date {myDate}");
         int givenWeek = 50;
         DateTime atWeek = myDate.AddDays(givenWeek * 7);
         Console.WriteLine($"The date at the given week {atWeek}");
         Console.WriteLine(atWeek.AddDays(-3).ToLongDateString());
         Console.WriteLine("\n");
      }
      public static void Problema15DaysBetween2Dates()
      {
         Console.WriteLine("Prob15");
         DateTime date1 = new DateTime(2000, 2, 2);
         DateTime date2 = new DateTime(2001, 2, 28);
         Console.WriteLine($"first date is:{date1}");
         Console.WriteLine($"secoond date is:{date2}");
         TimeSpan theDifference = date2.Subtract(date1);
         Console.WriteLine($"The difference in days is: {theDifference.TotalDays} days");
         Console.WriteLine("\n");
      }
   }
}
