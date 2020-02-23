using System;
using System.Collections.Generic;
using System.Linq;

namespace CharactersRepeatedLib
{
    public class CharactersRepeated
    {

        private static char[] FindDuplicatedCharter(string stringA, string stringB)
        {

            try
            {
                string errorMessage = "";

                var duplicatedInA = stringA.GroupBy(a => a).Where(ag => ag.Count() > 1).Select(a => a).ToArray();
                var duplicatedInB = stringB.GroupBy(b => b).Where(bg => bg.Count() > 1).Select(b => b).ToArray();

                if (duplicatedInA.Length > 0)
                {

                    errorMessage += $"\nThe String A has characters repeated:";
                    foreach (var duplA in duplicatedInA)
                    {
                        errorMessage += $" {duplA.Key},";
                    }
                }


                if (duplicatedInB.Length > 0)
                {

                    errorMessage += $"\nThe String A has characters repeated:";
                    foreach (var duplB in duplicatedInB)
                    {
                        errorMessage += $" {duplB.Key},";
                    }
                }

                if (errorMessage.Length > 0)
                {
                    throw new Exception(errorMessage);
                }


                IEnumerable<char> listRepeated = from charA in stringA
                                                 join charB in stringB on charA equals charB
                                                 select charA;
                return listRepeated.ToArray();
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public static void CharactersRepeatedExecute()
        {
            try
            {
                Console.WriteLine("REPEATED CHARACTERS\n************************************************************************************************");
                Console.WriteLine($"Given 2 strings of unknown characters (but it cannot be repeated) create a function that returns " +
                                  $"an array of the characters that are repeated in both strings in the most efficient way.\n");

                Console.WriteLine("Type the String A:");

                string stringA = Console.ReadLine();


                Console.WriteLine("Type the String B:");

                string stringB = Console.ReadLine();

                //string stringA = "qwert94mnzxda813560'?";
                //string stringB = "qw*r123456789/vbnmx";

                char[] duplicatedChars = FindDuplicatedCharter(stringA, stringB);

                Console.WriteLine($"\nDuplicated Characters in strings:\nA: {stringA} \nB: {stringB}");
                foreach (var duplicatedChar in duplicatedChars)
                {
                    Console.WriteLine($" ->{duplicatedChar}");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error:{e.Message}");
            }

            Console.ReadKey();
        }

    }
}
