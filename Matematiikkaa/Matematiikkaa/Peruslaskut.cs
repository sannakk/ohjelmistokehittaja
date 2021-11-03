using System;
using System.Collections.Generic;
using System.Text;

namespace Matematiikkaa
{
    class Peruslaskut
    {
        int summa;
        int erotus;
        int osamaara;
        int tulo;

        public int Summa(int a, int b)
        {
            return a + b;
        }

        public int Erotus(int a, int b)
        {
            return a - b;
        }

        public double Osamäärä(int a, int b)
        {
            return a / (double)b;
        }

        public int Tulo(int a, int b)
        {
            return a * b;
        }
    }
}

