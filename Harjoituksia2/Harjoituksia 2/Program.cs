﻿using System;

namespace Harjoituksia_2
{
    class Program
    {
        static void Tehtävä1(string[] args)
        {
            Console.WriteLine("Anna eka luku: ");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toka luku: ");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                Console.WriteLine("Suuruusjärjestys");
                Console.WriteLine(luku1);
                Console.WriteLine(luku2);

            }
            else
            {
                Console.WriteLine("Suuruusjärjestys");
                Console.WriteLine(luku2);
                Console.WriteLine(luku1);
            }
        }

        static void Tehtävä2()
        {
            Console.WriteLine("Anna eka luku: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toka luku: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(" Suurin numero on: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(" Suurin numero on: " + b);
            }
            else
            {
                Console.WriteLine("Suurin numero on: " + c);
            }
        }
        static void Tehtävä3()
        {
            Console.WriteLine("Anna luku 0-9: ");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 0:
                    Console.WriteLine("nolla");
                    break;
                case 1:
                    Console.WriteLine("yksi");
                    break;
                case 2:
                    Console.WriteLine("kaksi");
                    break;
                case 3:
                    Console.WriteLine("kolme");
                    break;
                case 4:
                    Console.WriteLine("neljä");
                    break;
                case 5:
                    Console.WriteLine("viisi");
                    break;
                case 6:
                    Console.WriteLine("kuusi");
                    break;
                case 7:
                    Console.WriteLine("seitsemän");
                    break;
                case 8:
                    Console.WriteLine("kahdeksan");
                    break;
                case 9:
                    Console.WriteLine("yhdeksän");
                    break;
                default:
                    Console.Write("Syötä numero 0 - 9 väliltä");
                    break;
            }
        }
        static void Tehtävä4()
        {
            Console.WriteLine("Anna eka luku: ");
            int nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toka luku: ");
            int nro2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku: ");
            int nro3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna neljäs luku: ");
            int nro4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna viides luku: ");
            int nro5 = int.Parse(Console.ReadLine());

            if (nro1 > nro2 && nro1 > nro3 && nro1 > nro4 && nro1 > nro5)
            {
                Console.WriteLine("Suurin numero on: " + nro1);
            }
            if (nro2 > nro1 && nro2 > nro3 && nro2 > nro4 && nro2 > nro5)
            {
                Console.WriteLine("Suurin numero on: " + nro2);
            }
            if (nro3 > nro1 && nro3 > nro2 && nro3 > nro4 && nro3 > nro5)
            {
                Console.WriteLine("Suurin numero on: " + nro3);
            }
            if (nro4 > nro1 && nro4 > nro2 && nro4 > nro3 && nro4 > nro5)
            {
                Console.WriteLine("Suurin numero on: " + nro1);
            }
            if (nro5 > nro1 && nro5 > nro2 && nro5 > nro3 && nro5 > nro4)
            {
                Console.WriteLine("Suurin numero on: " + nro5);
            }
        }
        static void Tehtävä5()
        {
            Console.WriteLine("Valitse: 1 kokonaisluku, 2 doubleluku, 3 merkkijono");
            int valitse = int.Parse(Console.ReadLine());
            switch (valitse)
            {
                case 1:
                    Console.WriteLine("Syötä kokonaisluku: ");
                    int aa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tulos on: " + (aa + 1));
                    break;
                case 2:
                    Console.WriteLine("Syötä doubleluku: ");
                    double bb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Tulos on: " + (bb + 1));
                    break;
                case 3:
                    Console.WriteLine("Syötä merkkijono: ");
                    string cc = Console.ReadLine();
                    Console.WriteLine("Tulos on: " + (cc + "*"));
                    break;
                default:
                    Console.WriteLine("Tarkista!");
                    break;
            }
        }
            static void Tehtävä6()
            {
                Console.WriteLine("Syötä bonuspisteesi väliltä 1-9: ");
                int pisteet = int.Parse(Console.ReadLine());
                switch (pisteet)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Pisteesi: " + pisteet);
                        Console.WriteLine("Bonuspisteesi kerroin: 10");
                        Console.WriteLine("Yhteensä: " + (pisteet * 10));
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Pisteesi: " + pisteet);
                        Console.WriteLine("Bonuspisteesi kerroin: 100");
                        Console.WriteLine("Yhteensä: " + (pisteet * 100));
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Pisteesi: " + pisteet);
                        Console.WriteLine("Bonuspisteesi kerroin: 1000");
                        Console.WriteLine("Yhteensä: " + (pisteet * 1000));
                        break;
                    default:
                        Console.WriteLine("Tarkista syöttämäsi luku!");
                        break;
                }
            }
                /*
                static void Main)
                {
                    
                Console.WriteLine("Anna luku 0-999: ");
                int nro = int.Parse(Console.ReadLine());
                string muunnos = "";
                switch (nro)
                {
                        case 0:
                        Console.WriteLine("nolla");
                        break;
                        case 1:
                        Console.WriteLine("yksi");
                        break;
                        case 2:
                        Console.WriteLine("kaksi");
                        break;
                        case 3:
                        Console.WriteLine("kolme");
                        break;
                        case 4:
                        Console.WriteLine("neljä");
                        break;
                        case 5:
                        Console.WriteLine("viisi");
                        break;
                        case 6:
                        Console.WriteLine("kuusi");
                        break;
                        case 7:
                        Console.WriteLine("seitsemän");
                        break;
                        case 8:
                        Console.WriteLine("kahdeksan");
                        break;
                        case 9:
                        Console.WriteLine("yhdeksän");
                        break;
                        case 10:
                        Console.WriteLine("kymmenen");
                        break;
                    case 11:
                        Console.WriteLine("yksitoista");
                        break;
                    case 12:
                        Console.WriteLine("kaksitoista");
                        break;
                    case 13:
                        Console.WriteLine("kolmetoista");
                        break;
                    case 14:
                        Console.WriteLine("neljätoista");
                        break;
                    case 15:
                        Console.WriteLine("viisitoista");
                        break;
                    case 16:
                        Console.WriteLine("kuusitoista");
                        break;
                    case 17:
                        Console.WriteLine("seitsemäntoista");
                        break;
                    case 18:
                        Console.WriteLine("kahdeksantoista");
                        break;
                    case 19:
                        Console.WriteLine("yhdeksäntoista");
                        break;
                    case 20:
                        Console.WriteLine("kaksikymmentä");
                        break;
                    case 30:
                        Console.WriteLine("kolmekymmentä");
                        break;
                    case 40:
                        Console.WriteLine("neljäkymmentä");
                        break;
                    case 50:
                        Console.WriteLine("viisikymmentä");
                        break;
                    case 60:
                        Console.WriteLine("kuusikymmentä");
                        break;
                    case 70:
                        Console.WriteLine("seitsemänkymmentä");
                        break;
                    case 80:
                        Console.WriteLine("kahdeksankymmentä");
                        break;
                    case 90:
                        Console.WriteLine("yhdeksänkymmentä");
                        break;
                    default:
                        Console.WriteLine("Tarkista antamasi luku");
                        break;
                       } 
                       if (nro < 20)
                       {
                         Console.WriteLine(nro);
                       }
                       if (nro.Length > 20)
                       {
                          Console.WriteLine(nro + "sataa")
                       }*/
            }
        }
    

        
    

