using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nietboekmaarmobiel
{
    internal class Boek
    {
        public string type;
        public string model;
        public string OS;
        public string CEO;
        public int aantalEuros;

        public Boek(string ntype, string nmodel, string nOS, string nCEO, int aantal)
        {
            type = ntype;
            model = nmodel;
            OS = nOS;
            CEO = nCEO;
            aantalEuros = aantal;
        }
    }
}
