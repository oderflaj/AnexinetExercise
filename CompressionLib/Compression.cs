using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CompressionLib
{
    public class Compression
    {
        /*
         * Write a function to perform basic string compression using the counts of repeated characters; e.g 
         * "aabcccccaaa" would become "a2b1c5a3". If the compressed string would not become smaller than the original string, 
         * just print the original string.
         */

        private static string ToCompress(string stringCompress)
        {
            if (!Regex.IsMatch(stringCompress, @"^[a-zA-Z]+$"))
            {
                throw new Exception($"The string contains invalid characters {stringCompress}");
            }

            if (!stringCompress.GroupBy(sc => sc).Any(g => g.Count() > 1))
            {
                return stringCompress;
            }

            StringBuilder stringCompressed = new StringBuilder();

            int numberRepeat = 0;
            char auxChar = ' ';

            foreach (var charToCompress in stringCompress)
            {
                if (!charToCompress.Equals(auxChar))
                {
                    if (!auxChar.Equals(' '))
                    {
                        stringCompressed.Append($"{auxChar}{numberRepeat}");
                    }

                    numberRepeat = 0;
                    auxChar = charToCompress;

                }
                numberRepeat++;

            }

            stringCompressed.Append($"{stringCompress[stringCompress.Length - 1]}{numberRepeat}");




            return stringCompressed.ToString();
        }

        public static void CompressionExecute()
        {
            try
            {
                Console.WriteLine("COMPRESSION\n************************************************************************************************");
                Console.WriteLine($"Write a function to perform basic string compression using the counts of repeated characters; e.g \"aabcccccaaa\" " +
                                $"would become \"a2b1c5a3\". If the compressed string would not become smaller than the original string, " +
                                $"just print the original string.\n");

                Console.WriteLine("Type the string to compress:\n");

                string stringToCompress = Console.ReadLine();

                Console.WriteLine("\nResult:\n");

                Console.WriteLine(ToCompress(stringToCompress));
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadKey();
        }

    }
}
