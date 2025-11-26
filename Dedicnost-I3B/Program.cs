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
        }

        //modifikátor params -> proměnný počet parametrů
        /*static void VypisujSlova(params string[] slova)
        {
            foreach (string s in slova)
                Console.WriteLine(s);
        }*/
    }
}