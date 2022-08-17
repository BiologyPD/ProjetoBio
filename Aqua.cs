using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio
{
    public class Aqua
    {
        public List<Aqua> _lstAqua = new List<Aqua>();

        public int Num { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }

        public Aqua (int num, string nome, string classe)
        {
            Num = num;
            Nome = nome;
            Classe = classe;
        }

        public Aqua()
        {
        }

        public void AddToList(int num, string nome, string classe)
        {
            _lstAqua.Add(new Aqua(num, nome, classe));
        }

        public List<Aqua> ToList()
        {
            return _lstAqua;
        }

        public List<Aqua> GeraAnimaisAqua()
        {
            AddToList(1, "Niphates alba Van Soest", "Porifero");
            AddToList(2, "Polvo Dumbo", "Molusco");
            AddToList(3, "Sanguessuga", "Anelideo");
            return _lstAqua;
        }
    }
}
