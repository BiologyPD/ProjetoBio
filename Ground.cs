using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio
{
    public class Ground
    {
        public List<Ground> _lstGround = new List<Ground>();

        public int Num { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }

        public Ground(int num, string nome, string classe)
        {
            Num = num;
            Nome = nome;
            Classe = classe;
        }
    
        public Ground()
        {
        }

        public void AddToList(int num, string nome, string classe)
        {
            _lstGround.Add(new Ground(num, nome, classe));
        }

        public List<Ground> ToList()
        {
            return _lstGround;
        }

        public List<Ground> GeraAnimaisGround()
        {
            AddToList(1, "Lagarto-agama", "Réptil");
            AddToList(2, "Sapo de Vidro", "Anfíbio");
            AddToList(3, "Quokka", "Mamífero");
            return _lstGround;
        }
    }
}
