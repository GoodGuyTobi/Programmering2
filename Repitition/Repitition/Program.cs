using System;

namespace Repitition
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur ekorre = new Djur("Ekorre",2, 8);
            Djur elefant = new Djur("Elefant", 4, 100);
            Djur albin = new Djur("Hund", 4, 13);

            int legs = ekorre.Legs;
            Console.WriteLine(legs);

        }

        static string Namn(int tal, string text)
        {
            return "";
        }
    }
}
