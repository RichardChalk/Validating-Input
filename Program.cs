using System;

namespace Validating_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string choiceStr;
            int choiceInt;

            while (true)
            {
                Console.WriteLine("1: Option 1");
                Console.WriteLine("2: Option 2");
                Console.WriteLine("3: Option 3");
                Console.WriteLine("4: Option 4");
                Console.WriteLine("5: Exit");

                Console.WriteLine("\nChoose an option: ");

                // .Trim removes all leading/trailing spaces
                choiceStr = Console.ReadLine().Trim();

                // if the correct text alternative is chosen we break the loop... success!
                if (
                    choiceStr.ToLower() == "option 1" ||
                    choiceStr.ToLower() == "option 2" ||
                    choiceStr.ToLower() == "option 3" ||
                    choiceStr.ToLower() == "option 4" ||
                    choiceStr.ToLower() == "exit"
                   )
                {
                    Console.WriteLine("Success! You inputted a Correct String!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                // if not an INT or not a number between 1-5
                if (!int.TryParse(choiceStr, out choiceInt) || choiceInt < 1 || choiceInt > 5)
                {
                    Console.WriteLine($"\n{choiceInt} is out of range or is not an 'INT'. Please try again: ");
                    Console.WriteLine("Press any key to continue:...");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine("Success!! You inputted a Correct INT!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}
