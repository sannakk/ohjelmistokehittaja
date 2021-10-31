using System;

namespace Harjoituksia3
{
    class Harjoituksia
    {
        static void Tehtävä1()
        {
            int nro1 = 40;
            int nro2 = 20;
            int tulos = nro1 + nro2;
            Console.WriteLine(tulos);
        }

        static void Tehtävä2()
        {
            double cel = 30;
            double fah = (cel * 1.8) + 32;
            Console.WriteLine("Lämpötila °F: " + fah);
        }
        static void Tehtävä3()
        {
            decimal luku1 = 2;
            decimal luku2 = 5;
            decimal plus = luku1 + luku2;
            decimal miinus = luku1 - luku2;
            decimal kerto = luku1 * luku2;
            decimal jako = luku1 / luku2;
            Console.WriteLine("Yhteenlasku: " + plus);
            Console.WriteLine("Vähennyslasku: " + miinus);
            Console.WriteLine("Kertolasku: " + kerto);
            Console.WriteLine("Jakolasku: " + jako);
        }

        static void Tehtävä4()
        {
            int luk1 = 56;
            int luk2 = 24;
            int jaannos = luk1 % luk2;
            Console.WriteLine("Antamasi lukujen jakojäännös: " + jaannos);
        }

        static void Tehtävä5()
        {
            Console.WriteLine("Anna nimesi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi);
        }
        static void Tehtävä6()
        {
            Console.WriteLine("Syötä numero: ");
            int nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen numero: ");
            int nro2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yhteenlaskun tulos: " + (nro1 + nro2));
        }
        static void Tehtävä7()
        {
            Console.WriteLine("Syötä lämpötila °C: ");
            double cel = Convert.ToDouble(Console.ReadLine());
            double fah = (cel * 1.8) + 32;
            Console.WriteLine("Lämpötila °F: " + fah);
        }
        static void Tehtävä8()
        {
            Console.WriteLine("Syötä luku: ");
            decimal luku1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku: ");
            decimal luku2 = Convert.ToDecimal(Console.ReadLine());
            decimal plus = luku1 + luku2;
            decimal miinus = luku1 - luku2;
            decimal kerto = luku1 * luku2;
            decimal jako = luku1 / luku2;
            Console.WriteLine("Yhteenlasku: " + plus);
            Console.WriteLine("Vähennyslasku: " + miinus);
            Console.WriteLine("Kertolasku: " + kerto);
            Console.WriteLine("Jakolasku: " + jako);
        }

        static void Tehtävä9()
        {
            Console.WriteLine("Syötä luku: ");
            int luk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku: ");
            int luk2 = int.Parse(Console.ReadLine());
            int jaannos = luk1 % luk2;
            Console.WriteLine("Antamasi lukujen jakojäännös: " + jaannos);
        }
        static void Tehtävä10()
        {
            Console.WriteLine("Syötä luku välillä 1-10: ");
            int luku = int.Parse(Console.ReadLine());
            for (int x = 1; x <= 10; x++)
                Console.WriteLine(luku + "x" + x + "=" + (luku * x));
        }
        static void Tehtävä11()
        {
            Console.WriteLine("Anna ikäsi: ");
            int ika = int.Parse(Console.ReadLine());
            Console.WriteLine(ika + "-näytät ikäistäsi nuoremmalta!");
        }
        static void Main()
        {
            Console.WriteLine("Anna lukua 10 suurempi luku: ");
            int nro = int.Parse(Console.ReadLine());
            Console.WriteLine(nro);
        }

            static void Tehtävä13()
        {
            Console.WriteLine("Anna sana: ");
            string sana = Console.ReadLine();
            int kaannos = sana.Length;
            Console.WriteLine(sana[kaannos - 1] + sana.Substring(1, kaannos - 2) + sana[0]);
        }
        static void Tehtävä14()
        {
            Console.WriteLine("Anna kokonaisluku: ");
            int nroo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen kokonaisluku: ");
            int nroo2 = int.Parse(Console.ReadLine());
            if (nroo1 < 0 && nroo2 < 0)
            {
                Console.WriteLine("Molemmat ovat negatiivisia");
            }
            if (nroo1 >= 0 && nroo2 >= 0)
            {
                Console.WriteLine("Molemmat ovat positiivisia");
            }
            if (nroo1 < 0 && nroo2 >= 0 || nroo2 < 0 && nroo1 >= 0)
            {
                Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
            }
        }
        static void Tehtävä16()
        {
            for(int x= 1; x < 100; x = x+2)
            {
                Console.WriteLine(x);
            }
        }
        static void Tehtävä17()
        {
            for (int x = 1; x < 100; x++)
            if (x % 3 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
}
