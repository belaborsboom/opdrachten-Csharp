using System;

namespace Overige_programmas
{
    class leeftijdgoed
    {
        static void Main(string[] args)
        {
            const int Leeftijdtehoog = 113;
            const int Leeftijdtelaag = 0;
            Console.Write("Wat is uw leeftijd? ");
            int leeftijd = Convert.ToInt16(Console.ReadLine());
            if (leeftijd > Leeftijdtehoog)
            {
                Console.WriteLine("U heeft geen geldige leeftijd ingevoerd.");
            }
            else if (leeftijd < Leeftijdtelaag)
            {
                Console.WriteLine("U heeft geen geldige leeftijd ingevoerd.");
            }
            else
            {
                Console.WriteLine("Dat is een geldige leeftijd.");
            }

            Console.ReadLine();
        }
    }
}