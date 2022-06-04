using System;

namespace Boodschappen_programma
{
    class Boodschappen
    {
        const string product = "Computerspel";
        const float Computerspel = 24.95f;
        const float BtwPercentage = 0.21f;
        static void Main(string[] args)
        {
            int aantal;
            float Aantalbtw;

            Console.WriteLine("Een " + product + " kost " + Computerspel + " ex btw.");
            Console.WriteLine("Voer een aantal in: ");

            aantal = Convert.ToInt32(Console.ReadLine());
            if (aantal < 0)
            {
                Console.WriteLine("dat is geen geldig getal");
            }
            else
            {
                Aantalbtw = BTWbereken(aantal);
                float totaalPrijs = aantal * Computerspel + Aantalbtw;
                if (aantal > 1)
                {
                    Console.WriteLine(aantal + " " + product + "en kost in totaal " + totaalPrijs);
                }
                else
                {
                    Console.WriteLine(aantal + " " + product + " kost in totaal " + totaalPrijs);
                }

            }
            Console.ReadLine();

        }

        public static int BTWbereken(int aantal)
        {
            float aantalbtw;
            double Prijs_ex_btw = aantal * Computerspel;
            double BtwPercentage_doub = (double)BtwPercentage;
            double Aantaldouble = aantal;
            /*int aantalbtw = (aantal * Computerspel) * BtwPercentage;*/
            aantalbtw = (float)Aantaldouble * (float)Prijs_ex_btw * (float)BtwPercentage_doub;
            return (int)aantalbtw;
        }
    }
}