using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio
{
    public class Air
    {
        public List<Air> _lstAir = new List<Air>();

        public int Num { get; set; }
        public string Nome { get; set; }
        public string Classe { get; set; }

        public Air(int num, string nome, string classe)
        {
            Num = num;
            Nome = nome;
            Classe = classe;
        }

        public Air()
        {
        }

        public void AddToList(int num, string nome, string classe)
        {
            _lstAir.Add(new Air(num, nome, classe));
        }

        public List<Air> ToList()
        {
            return _lstAir;
        }

        public List<Air> GeraAnimaisAir()
        {
            AddToList(1, "Suindara", "Ave");
            AddToList(2, "Nacrai", "Morcego");
            return _lstAir;
        }
    }
}

