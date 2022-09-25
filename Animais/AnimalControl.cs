using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBio.Animais
{
    public class AnimalControl : IEnumerable<Animal>
    {
        private static readonly object _lock = new object();
        private static AnimalControl _instance;
        public static AnimalControl Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new AnimalControl();
                }
                return _instance;
            }

            private set => _instance = value;
        }
        private AnimalControl() { _animals = AnimalModels.Animals().ToList(); }


        private readonly List<Animal> _animals = new List<Animal>();
        public void Add(Animal an) => _animals.Add(an);
        public Animal[] ByFilo(Filo filo) => _animals.Where(an => an.Filo == filo).ToArray();
        public Animal[] ByType(Tipo tipo) => _animals.Where(an => an.Tipo == tipo).ToArray();
        public Animal[] ByName(string name) => _animals.Where(an => an.Nome.ToLower().StartsWith(name.ToLower())).ToArray();


        public Animal[] FindType(Enum @enum)
        {
            var props = typeof(Animal).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            var flattenedProps = 
                props.Union(props.SelectMany(x => x.PropertyType.GetProperties(BindingFlags.Public | BindingFlags.Instance)));

            var propy = flattenedProps.First(x => x.PropertyType == @enum.GetType());

            if (propy.ReflectedType == typeof(Animal))
            {   
                return this.Where(an => propy.GetValue(an) == @enum).ToArray();
            }
            else
            {
                var parentProp = flattenedProps.First(x => x.PropertyType == propy.ReflectedType);
                return this.Where(an => propy.GetValue(parentProp.GetValue(an)) == @enum).ToArray();
            }
            
        }

        public IEnumerator<Animal> GetEnumerator() => ((IEnumerable<Animal>)_animals).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_animals).GetEnumerator();
    }
}
