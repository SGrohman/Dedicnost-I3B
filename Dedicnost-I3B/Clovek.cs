using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_I3B
{
    public class Clovek
    {
        public string Jmeno { get; set; }
        public int Vek { get; set; }

        public Clovek(string Jmeno,int vek)
        {
            this.Jmeno = Jmeno;
            Vek = vek;
        }
        // přetěžovaní metod (OVERLOADING)
        // virtual -> povoluje úpravy v potomcích
        public virtual void Pozdrav()
        {
            Console.WriteLine($"Dobrý den, tady {Jmeno}");
        }
        // přetíženo počtem parametrů (1)
        public void Pozdrav(string text)
        {
            Console.WriteLine(text);
        }
        // přetíženo datovým typem parametrů
        public void Pozdrav(int kolikrat)
        {
            for (int i = 0; i < kolikrat; i++)
            {
                Pozdrav();
            }

            
        }
    }
}
