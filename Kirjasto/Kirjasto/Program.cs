using System;

namespace Kirjasto
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiedot kirja1 = new Tiedot("Taikurin hattu", 150, "Tove Jansson", 2);
            Tiedot kirja2 = new Tiedot("Puhdistus", 380, "Sofi Oksanen", 0);
            Tiedot kirja3 = new Tiedot("Seitsemän veljestä", 405, "Aleksis Kivi", 1);
            Console.WriteLine("Hei "  + "! Tervetuloa kirjastoon. Valitse haluamasi kirja, 1 Taikurin hattu, 2 Puhdistus, 3 Seitsemän veljestä: ");
            int valinta = int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Console.WriteLine(kirja1.kirjanNimi + "," + kirja1.sivuMaara + "sivua, " + kirja1.kirjailija + "." + " Kirjoja tällä hetkellä " + kirja1.kirjaKpl + "kpl.");
                    break;
                case 2:
                    Console.WriteLine(kirja2.kirjanNimi);
                    break;
                case 3:
                    Console.WriteLine(kirja3.kirjanNimi);
                    break;
                default:
                    Console.WriteLine("Antamallesi numerolle ei löydy kirjaa!");
                    break;
            }
            Console.WriteLine("1 Lainaa kirja, 2 Palauta kirja, 3 Takaisin");
            int valinta2 = int.Parse(Console.ReadLine());
            switch (valinta2)
            {
                case 1:
                    Tiedot.Lainaa(int);
                    Console.WriteLine();
                    break;
            }
        }
    }
}
