using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nietboekmaarmobiel
{
    internal class programclass
    {
        static void Main(string[] args)
        {
            Boek boek1 = new Boek { Type= "iPhone", Model= "iPhone XS", OS= "Apple IOS", CEO= "Tim Cook", AantalEuros=269 };
            Boek boek2 = new Boek { Type= "Samsung", Model= "Samsung Galaxy s10", OS= "Android", CEO= "Kim Ki Nam", AantalEuros=599 };
            Boek boek3 = new Boek { Type= "Google Pixel", Model= "Pixel 6", OS= "Android", CEO= "Sundar Pichai", AantalEuros= 261 };

            Console.WriteLine(boek1.Type);
            Console.WriteLine(boek2.Type);
            Console.WriteLine(boek3.Type);

            Boek[] boeken = new Boek[3];
            boeken[0] = boek1;
            boeken[1] = boek2;
            boeken[2] = boek3;

            for (int i = 0; i < 3; i++)
            {
                if (boeken[i].Type == "iPhone")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is de CEO van Apple ");
                }
                else if (boeken[i].Type == "Samsung")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is een van de CEO's van Samsung ");
                }
                else if (boeken[i].Type == "Google Pixel")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is de CEO van Google ");
                }
            }
            Console.ReadLine();
        }
    }
}
