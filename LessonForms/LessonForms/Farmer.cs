using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForms
{
    class Farmer
    {
        string name;

        List<Animal> animalList;

        public Farmer(string name)
        {
            this.Name = name;
            animalList = new List<Animal>();
        }

        public string Name { get => name; set => name = value; }

        public void AddAnimal(string species, int legs)
        {
            Animal animal = new Animal(species, legs);

            animalList.Add(animal);
        }

        public List<string> GetAnimalInfo()
        {
            List<string> info = new List<string>();

            foreach (Animal animal in animalList)
            {
                info.Add(animal.ToString());
            }

            return info;
        }
    }
}
