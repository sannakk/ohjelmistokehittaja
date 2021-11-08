using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjasto
{
    class Tiedot
    {
        public string kirjanNimi;
        public int sivuMaara;
        public string kirjailija;
        public int kirjaKpl;

        public Tiedot(string kirja, int sivut, string tekija, int maara)
        {
            kirjanNimi = kirja;
            sivuMaara = sivut;
            kirjailija = tekija;
            kirjaKpl = maara;
        }

        public int KirjojenMaarat()
        {
            return kirjaKpl;
        }
        public void Lainaa(int kpl)
        {
            if (kpl > kirjaKpl)
            {
                Console.WriteLine("Et voi lainata näin montaa kirjaa!");
            }
            else
            {
                kirjaKpl = kirjaKpl - kpl;
            }
            Console.WriteLine("Lainasit kirjoja " + kpl + " kpl, " + "kirjoja tällä hetkellä jäljellä " + kirjaKpl + " kpl.");
        }

        public void LisaaKappale(int kpl)
        {
            kirjaKpl = kirjaKpl + kpl;
            Console.WriteLine("Kirjoja tällä hetkellä: " + kirjaKpl);
        }

        public int Sivut()
        {
            return sivuMaara;
        }
    }
}
