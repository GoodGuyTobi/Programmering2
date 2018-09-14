using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForms
{
    class Animal
    {
        string species;
        int legs;

        public Animal(string species, int legs)
        {
            this.species = species;
            this.legs = legs;
        }

        public override string ToString()
        {
            return $"{species} has {legs} legs";
        }
    }
}
