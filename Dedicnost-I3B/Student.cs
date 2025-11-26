using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_I3B
{
    public class Student : Clovek
    {
        public string Obor {  get; private set; }

        public Student(string jmeno, int vek, string obor) : base(jmeno, vek)
        {
            Obor = obor;
        }

        // base odkazuje na předka 
        // this odkazuje na aktuální třídu

        // override upravuje virtuální metodu (překrývá jí) polymorfizmus
        public override void Pozdrav()
        {
            //base.Pozdrav();
            //this.Pozdrav();

            Console.WriteLine("Ahoj, jsem {0} a studuji obor {1}", Jmeno, Obor);
            //                $"Ahoj, jsem {Jmeno} a studuji obor {Obor}"
        }
    }
}
