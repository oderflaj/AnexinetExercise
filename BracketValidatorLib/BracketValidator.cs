using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketValidatorLib
{
    public class BracketValidator
    {
        /*
         * Write a function that receives a string and validates if all the next brackets '[', '(' are properly closed '), ']' . Here are some examples:
            a. "()[]([])([][])(())" returns true.
            b. "(((" returns false.
            c. "(]" returns false.
            d. "()(" returns false.
            e. "([)]" returns false.
         */

        private static char EvaBracket(char bracket)
        {
            if (bracket.Equals('['))
            {
                return ']';
            }
            if (bracket.Equals('('))
            {
                return ')';
            }

            throw new Exception("Character doesn't match with a bracket");

        }

        private static bool IsOpen(char bracket)
        {
            return (bracket.Equals('[') || bracket.Equals('('));
        }

        private static bool ValidBracketString(string brackets)
        {
            try
            {
                if (string.IsNullOrEmpty(brackets))
                {
                    throw new Exception("The string is empty!");
                }

                if (brackets.Length % 2 != 0)
                {
                    throw new Exception("The number of characters is odd!");
                }

                if (brackets.Where(br => !br.Equals('[') && !br.Equals(']') && !br.Equals('(') && !br.Equals(')')).Count() > 0)
                {
                    throw new Exception($"The string:\n{brackets}\nhas invalid characters");
                }

                bool flagFirst = true;

                List<char> listBracket = new List<char>();

                foreach (var bracket in brackets)
                {
                    if (flagFirst)
                    {
                        flagFirst = false;
                        listBracket.Add(bracket);
                    }
                    else
                    {
                        if (IsOpen(bracket))
                        {
                            listBracket.Add(bracket);
                        }
                        else
                        {

                            if (EvaBracket(listBracket[listBracket.Count - 1]).Equals(bracket))
                            {
                                listBracket.RemoveAt(listBracket.Count - 1);
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                }

                return listBracket.Count == 0;

            }
            catch (Exception e)
            {

                throw e;
            }


        }


        public static void BracketValidatorExecute()
        {
            try
            {

                Console.WriteLine("BRACKETS\n************************************************************************************************");
                Console.WriteLine($"Write a function that receives a string and validates if all the next brackets '[', '(' are properly closed '), ']' . Here are some examples:\n" +
                                    $"\na. \"()[]([])([][])(())\" returns true."+
                                    $"\nb. \"(((\" returns false."+
                                    $"\nc. \"(]\" returns false."+
                                    $"\nd. \"()(\" returns false."+
                                    $"\ne. \"([)]\" returns false.\n");

                Console.WriteLine("Type the Brackets:");

                string brackets = Console.ReadLine();

                Console.WriteLine($"The string is valid:{ValidBracketString(brackets)}");

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error:\n{e.Message}");
            }


            Console.ReadKey();
        }
    }
}
