using System;

namespace GuessGame
{
    class GuessGame
    {
        static void Main(string[] args)
        {
            string secretWord = "informatica";
            string guessedWord = "";

            for (int hoevaakherhaald = 0; guessedWord != secretWord && hoevaakherhaald < 3; hoevaakherhaald++)
            {
                Console.Write("Enter guess: ");
                guessedWord = Console.ReadLine();
            }
            if (guessedWord == secretWord)
            {
                Console.WriteLine("You've won!");
            }

            else
            {
                Console.WriteLine("helaas, niet goed geraden");
            }
            Console.ReadLine();
        }
    }
}