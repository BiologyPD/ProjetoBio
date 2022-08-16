using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio
{
    public class Parasite
    {
        public List<Parasite> _lstParasite = new List<Parasite>();

        public int Num { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }

        public Parasite(int num, string nome, string classe)
        {
            Num = num;
            Nome = nome;
            Classe = classe;
        }

        public Parasite()
        {
        }

        public void AddToList(int num, string nome, string classe)
        {
            _lstParasite.Add(new Parasite(num, nome, classe));
        }

        public List<Parasite> ToList()
        {
            return _lstParasite;
        }

        public List<Parasite> GeraAnimais()
        {
            AddToList(1, "Niphates alba Van Soest", "Porifero");
            AddToList(2, "Polvo Dumbo", "Molusco");
            return _lstParasite;
        }
    }
}
