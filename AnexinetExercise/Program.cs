using System;

namespace AnexinetExercise
{
    class Program
    {

        static void MessageWelcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Anexinet Excercise!\n****************************************************************");
            Console.WriteLine("Type the number of the option to execute some Exercise:\n");
            Console.WriteLine("1) Calculation of Leap Year");
            Console.WriteLine("2) Find repeated Characters");
            Console.WriteLine("3) Make basic compress");
            Console.WriteLine("4) Validate [] ()");
            Console.WriteLine("5) Calculate Box Area\n");
            Console.WriteLine("\n\"q\" To Exit\n");
        }

        static void Main(string[] args)
        {

            MessageWelcome();

            var option = "";

            while ((option = Console.ReadLine()) != "q")
            {
                if(!option.Equals("1")&& !option.Equals("2") && !option.Equals("3") && !option.Equals("4") && !option.Equals("5"))
                {
                    Console.WriteLine("\nType a valid option.");
                    continue;
                }
                else
                {
                    Console.Clear();


                    if (option.Equals("1"))
                    {
                        LeapYearLib.LeapYear.LeapYearExecute();
                    }

                    if (option.Equals("2"))
                    {
                        CharactersRepeatedLib.CharactersRepeated.CharactersRepeatedExecute();
                    }

                    if (option.Equals("3"))
                    {
                        CompressionLib.Compression.CompressionExecute();
                    }

                    if (option.Equals("4"))
                    {
                        BracketValidatorLib.BracketValidator.BracketValidatorExecute();
                    }

                    if (option.Equals("5"))
                    {
                        BoxAreaLib.BoxArea.BoxAreaExecute();
                    }

                    MessageWelcome();
                }
            }
            

        }
    }
}
