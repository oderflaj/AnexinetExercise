using System;

namespace LeapYearLib
{
    public class LeapYear
    {
        private static bool ValidateLeapYear(int year)
        {
            if (year == 400 || (year % 400) == 0)
            {
                return true;
            }

            if (year == 100 || year == 0 || (year % 100) == 0)
            {
                return false;
            }

            if (year == 4 || (year % 4) == 0)
            {
                return true;
            }

            return false;
        }

        public static string CalcLeapYear(string dateEntered)
        {
            try
            {
                DateTime dateToParse = DateTime.Parse(dateEntered);

                int leapYear = dateToParse.Year;

                return $"{dateToParse.Year.ToString()} {(ValidateLeapYear(leapYear) ? "IS A LEAP YEAR" : "is NOT a leap Year") }";

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public static void LeapYearExecute()
        {
            string dateRead = "";

            try
            {
                Console.WriteLine("LEAP YEAR\n************************************************************************************************");
                Console.WriteLine($"Write a function that receives a string, if possible transform it to a date and return\n" +
                                  $" whether the year of the date is a leap year. " +
                                  $"\nIf the string can't be transformed to a date throw an exception. (Datetime.IsLeapYear() can’t be used)" +
                                  $"\na.A leap year is divisible by 4 unless it is divisible by 100 and not by 400.");

                Console.WriteLine("Calculating Leap Year \n\nType the date and press Enter\n");

                dateRead = Console.ReadLine();

                Console.WriteLine(LeapYear.CalcLeapYear(dateRead));
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}: \"{dateRead}\" is not a valid Date! ");

            }
            Console.ReadKey();
        }
    }
}
