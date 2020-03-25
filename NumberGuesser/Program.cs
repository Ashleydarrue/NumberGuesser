using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppinfo function to get info

            GreetUser(); // Ask user for name and greet


            while (true) {

                // Init correct number
                //int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                // Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is incorrect 
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure user inputs a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        // Keep Going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                      PrintColorMessage(ConsoleColor.Red, "Wrong Number, Guess again!");
                    }
                }

                //Output success message

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!");

                // Ask user to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();
                

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else {
                    return;
                }

            }

        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ashley Arrue";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by  {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser()
        {
            //Ask Users name
            Console.WriteLine("what is your name?");

            //Get user input
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message 
         static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user inout is not a number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
