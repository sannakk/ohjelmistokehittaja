using System;

namespace Harjoituksia1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Anna eka luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku1 = luku2 + 3);

            Console.Write("Anna eka luku: ");
            int luku3 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku3 = luku4 - 2);

            Console.Write("Anna eka luku: ");
            int luku5 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku6 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku5 = luku6 * 5);

            Console.Write("Anna eka luku: ");
            int luku7 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku8 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku7 = luku7/luku8);

            Console.Write("Anna eka luku: ");
            int luku9 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku10 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku9 = luku9 % luku10);

            Console.Write("Anna eka luku: ");
            int luku11 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku12 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku11 += luku12);

            Console.Write("Anna eka luku: ");
            int luku13 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku14 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku13 -= luku14);

            Console.Write("Anna eka luku: ");
            int luku15 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku16 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku15 *= luku16 * 5);

            Console.Write("Anna eka luku: ");
            int luku17 = int.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            int luku18 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku17 /= luku18);

        }
    }
}
