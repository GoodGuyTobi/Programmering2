using System;
using System.Collections.Generic;
using System.Text;

namespace Repitition
{
    class Djur
    {
        // Instansvariabler
        string name;
        int legs;
        int age;
        static int count = 0;

        // Properties/egenskap (enkapsulering)
        public string Name { get => name; set => name = value; }
        public int Legs { get => legs; }
        public int Count { get => count; }

        public Djur(string name, int legs, int age)
        {
            this.legs = legs;
            this.age = age;
            Name = name;

            count++;
        }

        public override string ToString()
        {
            return $"Ras: {Name}\n" +
                $"Antal ben: {legs}\n" +
                $"Levnadsålder: {age}\n" +
                $"Antal djur skapade: {count}";
        }
    }
}
