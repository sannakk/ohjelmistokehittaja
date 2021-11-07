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
            Console.WriteLine("Hei! Tervetuloa kirjastoon. Valitse haluamasi kirja, 1 Taikurin hattu, 2 Puhdistus, 3 Seitsemän veljestä: ");
            
        }
    }
}
