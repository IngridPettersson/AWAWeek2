using System;

namespace GuessTheNumber
{
    class ProgramGuessTheNumber
    {
        static int max = 1000;
        static int min = 1;
        static int guessedNumber;
        static int numberOfGuesses = 0;
        static bool correctGuess = false;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 1000 and press any key once you have chosen a number...");
            Console.ReadLine();
            Console.WriteLine("I will guess correct number with max 10 guesses as long as you tell me if your number is higher or lower than my guessed number.\n\nLet's begin!\n\nPress any key to get started...");
            Console.ReadLine();

            do
            {
                PlayGame();
            } while (!correctGuess);

        }

        private static void PlayGame()
        {
            numberOfGuesses++;
            guessedNumber = ShowGuessedNumber();
            Console.WriteLine($"My guess number {numberOfGuesses}: {guessedNumber}\n");
            GetUserFeedback();
        }

        private static int ShowGuessedNumber()
        {
            return (max + min) / 2;

        }

        private static void GetUserFeedback()
        {
            Console.WriteLine($"Press [H] if your number is higher than {guessedNumber}.");
            Console.WriteLine($"Press [L] if your number is lower than {guessedNumber}.");
            Console.WriteLine($"Press [C] if {guessedNumber} is correct!\n");
            ConsoleKey input = Console.ReadKey(true).Key;

            if (input == ConsoleKey.H)
            {
                min = guessedNumber + 1;
            }
            if (input == ConsoleKey.L)
            {
                max = guessedNumber - 1;
            }
            if (input == ConsoleKey.C)
            {
                Console.Clear();
                if (numberOfGuesses < 6)
                    Console.WriteLine("Give me a match at least!");
                else if (numberOfGuesses >= 6)
                    Console.WriteLine("I told you!");
                correctGuess = true;
            }
        }



    }
}
