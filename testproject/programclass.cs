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
            Boek boek1 = new Boek("iPhone", "iPhone XS", "Apple IOS", "Tim Cook", 269);
            Boek boek2 = new Boek("Samsung", "Samsung Galaxy s10", "Android", "Kim Ki Nam", 599);
            Boek boek3 = new Boek("Google Pixel", "Pixel 6", "Android", "Sundar Pichai", 261);

            Console.WriteLine(boek1.type);
            Console.WriteLine(boek2.type);
            Console.WriteLine(boek3.type);

            Boek[] boeken = new Boek[3];
            boeken[0] = boek1;
            boeken[1] = boek2;
            boeken[2] = boek3;

            for (int i = 0; i < 3; i++)
            {
                if (boeken[i].type == "iPhone")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is de CEO van Apple ");
                }
                else if (boeken[i].type == "Samsung")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is een van de CEO's van Samsung ");
                }
                else if (boeken[i].type == "Google Pixel")
                {
                    Console.WriteLine(boeken[i].CEO + ", dat is de CEO van Google ");
                }
            }
            Console.ReadLine();
        }
    }
}
