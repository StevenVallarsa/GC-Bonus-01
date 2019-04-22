using System;

namespace GC_Bonus_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");
            bool isTrue = true;

            while (isTrue)
            {
                Console.Write("\nEnter a numerical grade: ");
                int grade = CheckValidity();
                char gradeLetter;

                if (grade >= 88)
                {
                    gradeLetter = 'A';
                }
                else if (grade >= 80)
                {
                    gradeLetter = 'B';
                }
                else if (grade >= 67)
                {
                    gradeLetter = 'C';
                }
                else if (grade >= 60)
                {
                    gradeLetter = 'D';
                }
                else
                {
                    gradeLetter = 'F';
                }

                Console.WriteLine("Letter Grade: {0}", gradeLetter);


                // Ask user if they want to do this again
                // - Takes first letter of response: if not
                //   "y" or "n" will ask user to try again.
                while (true)
                {
                    Console.Write("\nContinue? (y/n) ");
                    string answer = Console.ReadLine().ToLower();

                    if (answer[0] == 'n')
                    {
                        isTrue = false;
                        break;
                    }
                    else if (answer[0] == 'y')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Oops. That's not a valid input. Please try again.");
                    }
                }
            }

            Console.WriteLine("\nGoodbye!");
        }

        // Method to check validity of user input.
        static int CheckValidity()
        {

            // Keep asking for user input until valid number is returned.
            while (true)
            {

                string userInput = Console.ReadLine();

                try
                {
                    int output = Convert.ToInt32(userInput);
                    if (output >= 0 && output <= 100)
                    {
                        return output;
                    }

                    Console.Write("Oops. That's not a valid input. Please try again: ");

                }
                catch (Exception)
                {
                    Console.Write("Oops. That's not a valid input. Please try again: ");
                }

            }
        }
    }
}
