using System;

namespace Harjoituksia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna eka luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toka luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                Console.WriteLine(luku1);
                Console.Write(luku2);
            }
            else
            {
                Console.WriteLine(luku2);
                Console.Write(luku1);
            }

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(" Suurin numero on: ")
            }

        }
    }
}
