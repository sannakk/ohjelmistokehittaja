using System;
using System.Collections.Generic;
using System.Text;

namespace Matematiikkaa
{
    class Pankkitili
    {
        string tilinumero;
        double saldo;
        string etunimi;
        string sukunimi;

        public Pankkitili(string enimi, string snimi, string tnro, double sdo)
        {
            etunimi = enimi;
            sukunimi = snimi;
            tilinumero = tnro;
            saldo = sdo;
        }

        public double NaytaSaldo()
        {
            return Math.Round(saldo, 2);
        }

        public void Pano(double rahaa)
        {
            saldo += rahaa;
        }

        public void Otto(double rahaa)
        {
            if(rahaa > saldo)
            {
                Console.WriteLine("Tililläsi ei ole tarpeeksi rahaa!");
            }
            else
            {
                saldo -= rahaa;
                NaytaSaldo();
            }
        }
    }
}
