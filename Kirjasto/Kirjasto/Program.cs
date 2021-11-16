using System;

namespace Kirjasto
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiedot kirja1 = new Tiedot("Taikurin hattu", 150, "Tove Jansson", 2);
            Tiedot kirja2 = new Tiedot("Puhdistus", 380, "Sofi Oksanen", 1);
            Tiedot kirja3 = new Tiedot("Seitsemän veljestä", 405, "Aleksis Kivi", 3);
            Console.WriteLine("Tervetuloa kirjastoon!");
            Console.WriteLine("Valitse: ");
            Console.WriteLine("1. " + kirja1.Teos());
            Console.WriteLine("2. " + kirja2.Teos());
            Console.WriteLine("3. " + kirja3.Teos());
            int valinta = int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Console.WriteLine("Kirja: " + kirja1.Teos());
                    Console.WriteLine("Sivumäärä: " + kirja1.Sivut());
                    Console.WriteLine("Kirjailija: " + kirja1.Kirjoittaja());
                    Console.WriteLine("Kirjojen määrä: " + kirja1.KirjojenMaarat() + "kpl");
                    kirja1.PalautaLainaa();
                    break;
                case 2:
                    Console.WriteLine("Kirja: " + kirja2.Teos());
                    Console.WriteLine("Sivumäärä: " + kirja2.Sivut());
                    Console.WriteLine("Kirjailija: " + kirja2.Kirjoittaja());
                    Console.WriteLine("Kirjojen määrä: " + kirja2.KirjojenMaarat() + "kpl");
                    kirja2.PalautaLainaa();
                    break;
                case 3:
                    Console.WriteLine("Kirja: " + kirja3.Teos());
                    Console.WriteLine("Sivumäärä: " + kirja3.Sivut());
                    Console.WriteLine("Kirjailija: " + kirja3.Kirjoittaja());
                    Console.WriteLine("Kirjojen määrä: " + kirja3.KirjojenMaarat() + "kpl");
                    kirja3.PalautaLainaa();
                    break;
                default:
                    Console.WriteLine("Tarkista antamasi numero!");
                    break;
            }                   
            }
        }
    }

