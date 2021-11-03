using System;

namespace Matematiikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Peruslaskut laskut = new Peruslaskut();
            int s = laskut.Summa(4, 5);
            int e = laskut.Erotus(5, 4);
            double o = laskut.Osamäärä(4, 5);
            int t = laskut.Tulo(5, 4);
            Console.WriteLine("Lukujen {0} ja {1} summa, erotus, osamäärä ja tulo ovat {2}, {3}, {4} ja {5}", 4, 5, s, e, o, t);*/
            Pankkitili sanna = new Pankkitili("Sanna", "Kunnasluoto", "123456-1234", 100.10);
            Console.WriteLine(sanna.NaytaSaldo());
            sanna.Pano(200);
            Console.WriteLine(sanna.NaytaSaldo());
            sanna.Otto(50);
            Console.WriteLine(sanna.NaytaSaldo());
        }
    }
}
