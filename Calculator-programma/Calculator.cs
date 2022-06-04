using System;

namespace Calculator_programma
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            int uitkomst;

            Console.WriteLine("Welkom bij de rekenmachine!");
            Console.WriteLine("Wat is het eerste getal dat je bij elkaar wil optellen? ");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal dat je bij het eerste getal wil optellen? ");
            getal2 = Convert.ToInt32(Console.ReadLine());
            uitkomst = getal1 + getal2;
            Console.WriteLine("de uitkomst van de twee getallen is " + uitkomst);

            Console.ReadLine();


        }
    }
}
