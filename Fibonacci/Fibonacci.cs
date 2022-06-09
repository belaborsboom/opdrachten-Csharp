using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummers = new int[22];
            nummers[0] = 0;
            nummers[1] = 1;
            for (int i = 2; i < 21; i++)
            {
                int eersteNummer = nummers[i-2];
                int tweedeNummer = nummers[i-1];
                nummers[i] = eersteNummer + tweedeNummer;
            }
            for (int b = 0; b < 21; b++)
            {
                Console.WriteLine(nummers[b]);
            }
            
        }
    }
}