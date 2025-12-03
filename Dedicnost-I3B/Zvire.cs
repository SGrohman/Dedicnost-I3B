using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost_I3B
{
    public  class Zvire(string jmeno, int vek) //konstruktor 
    {
        public virtual string VydejZvuk(string jmeno)
        {

            return ""; //string.Empty;
        }
    }
}
