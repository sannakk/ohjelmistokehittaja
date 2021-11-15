using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjasto
{
    class Tiedot
    {
        string kirjanNimi;
        int sivuMaara;
        string kirjailija;
        int kirjaKpl;
        int kpl;
        int kpl2;

        public Tiedot(string kirja, int sivut, string tekija, int maara)
        {
            kirjanNimi = kirja;
            sivuMaara = sivut;
            kirjailija = tekija;
            kirjaKpl = maara;
        }

        public string Teos()
        {
            return kirjanNimi;
        }
        public int KirjojenMaarat()
        {
            return kirjaKpl;
        }
        public void Lainaa(int kpl)
        {
            Console.WriteLine("Monta haluat lainata? ");
            kpl = int.Parse(Console.ReadLine());

            if (kpl > kirjaKpl)
            {
                Console.WriteLine("Et voi lainata näin montaa kirjaa!");
                Takaisin();
            }
            else
            {
                kirjaKpl = kirjaKpl - kpl;
                Console.WriteLine("Lainasit kirjoja " + kpl + " kpl, " + "kirjoja tällä hetkellä jäljellä " + kirjaKpl + " kpl.");
                Takaisin();
            }

        }

        public void Palauta(int kpl2)
        {
            Console.WriteLine("Monta haluat palauttaa? ");
            kpl2 = int.Parse(Console.ReadLine());

            if (kpl2 >= kirjaKpl)
            {
                Console.WriteLine("Et voi palauttaa kirjaa, kaikki kappaleet ovat kirjastossamme!");
                Takaisin();
            }
            else
            {
                kirjaKpl = kirjaKpl + kpl2;
                Console.WriteLine("Kirjoja tällä hetkellä: " + kirjaKpl);
                Takaisin();
            }
        }

        public int Sivut()
        {
            return sivuMaara;
        }

        public string Kirjoittaja()
        {
            return kirjailija;
        }


        public void PalautaLainaa()
        {   
            Console.WriteLine("1. Lainaa kirja");
            Console.WriteLine("2. Palauta kirja");
            int valinta2 = int.Parse(Console.ReadLine());
            switch (valinta2)
            {
                case 1:
                    Lainaa(kpl);
                    break;
                case 2:
                    Palauta(kpl2);
                    break;
                default:
                    Console.WriteLine("Tarkista antamasi numero!");
                    break;
            }
        }

        public void Takaisin()
        {
            Console.WriteLine("Palaa takaisin? Kyllä (k)");
            string takas = Console.ReadLine();
            if (takas == "k")
            {
                (jotain);
            }
        }
    }
}


