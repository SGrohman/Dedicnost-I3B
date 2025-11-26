namespace Dedicnost_I3B
{
    internal class program
    {
        static void Main(string[] args)
        {
            /* 1VypisujSlova("Ahoj", "jak", "se", "nemáš?");
                VypisujSlova("Blbě");*/

            // formátování textových řetězců (bez interpolace)
            /*string pattern = "Toto je {0} a váží {1}kg";
            string objekt = "Žirafa";
            int vaha = 250;
            string vystup = string.Format(pattern, objekt, vaha);
            Console.WriteLine(vystup);*/

            Clovek Karel = new Clovek("Karel", 41);
            Student Capslock = new Student("Capslock".ToUpper(), 22, "Maniativní psychologie");
            Karel.Pozdrav();
            Capslock.Pozdrav();
            //všude kde očekávám třídu můžu doplnit třídu potomka jenom že se (musíme k němu chovat podle rozhraní předka) 
            Clovek[] Rodina = {Karel, Capslock};

            foreach (Clovek c in Rodina)
            {
                Console.WriteLine($"{c.Jmeno}");
                if (c is Student s)
                {
                    Console.WriteLine(s.Obor);
                }
            }

            // boxing
            object BoxedKarel = (object)Karel; // Při neůspěchu vyhodí Exception

            // unboxing -> musíme vybalit do stejného objektu
            Clovek? ZnovuKarel = BoxedKarel as Clovek; // Při neůspěchu uloží null
            //Console.WriteLine(ZnovuKarel == null);

        }

        //modifikátor params -> proměnný počet parametrů
        /*1static void VypisujSlova(params string[] slova)
        {
            foreach (string s in slova)
                Console.WriteLine(s);
        }*/
    }
}