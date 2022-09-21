using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio.Animais
{
    public static class AnimalControl
    {
        private static readonly List<Animal> _animals = new List<Animal>();

        public static void Add(Animal animal) => _animals.Add(animal);

        public static void Remove(Animal animal) => _animals.Remove(animal);

        public static Animal[] GetAnimals() => _animals.ToArray();

        public static Animal[] AnimalsIn(Filo filo) => _animals.Where(an => an.Filo == filo).ToArray();

        public static Animal[] OfType(Tipo tipo) => _animals.Where(an => an.Tipo == tipo).ToArray();
    }
}
