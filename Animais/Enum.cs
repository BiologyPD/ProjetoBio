using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProjetoBio.Animais
{
    public abstract class Enum
    {
        public readonly string Text;
        public readonly int Id;
        // public static readonly Enum[] Values = null;

        protected Enum(string text, int id)
        {
            Text = text;
            Id = id;
        }

        public static T[] GetValues<T>() where T : Enum => (T[]) typeof(T).GetField("Values").GetValue(null);
    }

    public class KeyPair<T> where T : Enum
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public KeyPair(T e)
        {
            Key = e.Text;
            Value = e;
        }

        public static KeyPair<T>[] GetKeyPairs() => KeyPair.GetKeyPairs<T>();
    }

    public static class KeyPair
    {
        public static KeyPair<T>[] ToKeyPairs<T>(T[] Values) where T : Enum 
            => Values.Select(e => new KeyPair<T>(e)).ToArray();

        public static KeyPair<T>[] GetKeyPairs<T>() where T : Enum
            => ToKeyPairs<T>(Enum.GetValues<T>());
    }

    public class Tipo : Enum
    {
        private Tipo(string text, int id) : base(text, id) { }

        public static readonly Tipo Aereo = new Tipo("Aéreo", 0);
        public static readonly Tipo Terrestre = new Tipo("Terrestre", 1);
        public static readonly Tipo Parasita = new Tipo("Parasita", 2);
        public static readonly Tipo Aquatico = new Tipo("Aquático", 3);

        public static readonly Tipo[] Values = { Aereo, Terrestre, Parasita, Aquatico };
    }

    public class Filo : Enum
    {
        private Filo(string text, int id) : base(text, id) {}

        public static readonly Filo Porifera = new Filo("Porífera", 0);
        public static readonly Filo Cnidario = new Filo("Cnidário", 1);
        public static readonly Filo Platelminto = new Filo("Platelminto", 2);
        public static readonly Filo Nematelminto = new Filo("Nematelminto", 3);
        public static readonly Filo Molusco = new Filo("Molusco", 4);
        public static readonly Filo Anelideo = new Filo("Anelídeo", 5);
        public static readonly Filo Artropode = new Filo("Artrópode", 6);
        public static readonly Filo Equinoderma = new Filo("Equinoderma", 7);
        public static readonly Filo Cordado = new Filo("Cordado", 8);

        public static readonly Filo[] Values = {
            Porifera, Cnidario, Platelminto, Nematelminto, Molusco, Anelideo, Artropode, Equinoderma, Cordado
        };
    }

    public class Locomocao
    {
        public ELocomocao[] Meio { get; set; }
        public string Descricao { get; set; }

        public Locomocao(ELocomocao[] meio, string descricao)
        {
            Meio = meio;
            Descricao = descricao;
        }

        public Locomocao() { }

        public override string ToString()
        {
            string _string = "";
            if (Meio.Count() == 0)
                { _string = "Não se locomove.\n"; }
            else if (Meio.Count() == 1) 
                { _string = "Meio de locomoção:  " + Meio[0]; }
            else if (Meio.Count() >= 2)
            {
                _string = "Meios de locomoção:  | ";
                foreach (ELocomocao me in Meio)
                {
                    _string += me.Text + " | ";
                }
            }
            return _string + "\nDescrição:  " + Descricao;
        }
    }

    public class ELocomocao : Enum
    {
        private ELocomocao(string text, int id) : base(text, id) { }

        public static readonly ELocomocao Saltar = new ELocomocao("Saltando", 0);
        public static readonly ELocomocao Rastejar = new ELocomocao("Rastejando", 1);
        public static readonly ELocomocao Voar = new ELocomocao("Voando", 2);
        public static readonly ELocomocao Andar = new ELocomocao("Andar", 3);
        public static readonly ELocomocao Nadar = new ELocomocao("Nadando", 4);
        public static readonly ELocomocao Escalar = new ELocomocao("Escalando", 5);

        public static readonly ELocomocao[] Values = { Saltar, Rastejar, Voar, Andar, Nadar, Escalar };
    }

    public class Respiracao : Enum
    {
        private Respiracao(string text, int id) : base(text, id) { }

        public static readonly Respiracao Cutanea = new Respiracao("Cutânea", 0);
        public static readonly Respiracao Branquial = new Respiracao("Branquial", 1);
        public static readonly Respiracao Pulmonar = new Respiracao("Pulmonar", 2);
        public static readonly Respiracao Traqueal = new Respiracao("Traqueal", 3);

        public static readonly Respiracao[] Values = { Cutanea, Branquial, Pulmonar, Traqueal };
    }

    public class Alimentacao
    {
        public EAlimentacao Tipo { get; set; }
        public EMetodoAlimentacao Meio { get; set; }
        public string Descricao { get; set; }
        public string TipoBoca { get; set; }
        public bool HasAnus { get; private set; }
        public bool HasBoca { get; private set; }

        public void SetBocaAnus(Filo filo)
        {
            if (filo == Filo.Porifera)
            {
                HasAnus = false;
                HasBoca = false;
            }
            else if (filo == Filo.Cnidario)
            {
                HasAnus = false;
                HasBoca = true;
            }
            else if (filo == Filo.Platelminto)
            {
                HasAnus = false;
                HasBoca = true;
            }
            else
            {
                HasAnus = true;
                HasBoca = true;
            }
        }

        public Alimentacao(EAlimentacao tipo, EMetodoAlimentacao meio, string descricao, Filo filo, string tipoBoca)
        {
            Tipo = tipo;
            Meio = meio;
            Descricao = descricao;
            TipoBoca = tipoBoca;
            SetBocaAnus(filo);
        }

        public Alimentacao() { }

        public Alimentacao(Filo filo) { SetBocaAnus(filo); }

        public override string ToString()
        {
            string toText = "Tipo de alimentação:  "
                + Tipo.Text
                + "\nMétodo de alimentação:  "
                + Meio.Text
                + "\nDescrição:  "
                + Descricao;

            if (HasBoca && HasAnus)
                toText += "\nPossui boca e ânus.";
            else if (HasBoca && !HasAnus)
                toText += "\nPossui somente boca.";
            else if (!HasBoca && HasAnus)
                toText += "\nPossui somente ânus.";
            else if (!HasBoca && !HasAnus)
                toText += "\nNão possui boca ou ânus.";

            if (HasBoca)
            {
                toText += "\nDescrição da boca:  " + TipoBoca;
            }

            return toText;
        }
    }

    public class EAlimentacao : Enum
    {
        private EAlimentacao(string text, int id) : base(text, id) { }

        public static readonly EAlimentacao Particulas = new EAlimentacao("Partículas", 0);
        public static readonly EAlimentacao Herbivoro = new EAlimentacao("Herbívoro", 1);
        public static readonly EAlimentacao Carnivoro = new EAlimentacao("Carnívoro", 2);
        public static readonly EAlimentacao Onivoro = new EAlimentacao("Onívoro", 3);

        public static readonly EAlimentacao[] Values = { Particulas, Herbivoro, Carnivoro, Onivoro };
    }

    public class EMetodoAlimentacao : Enum
    {
        private EMetodoAlimentacao(string text, int id) : base(text, id) { }

        public static readonly EMetodoAlimentacao Filtrador = new EMetodoAlimentacao("Filtrador", 0);
        public static readonly EMetodoAlimentacao Cacador = new EMetodoAlimentacao("Caçador", 1);
        public static readonly EMetodoAlimentacao Herbivoro = new EMetodoAlimentacao("Herbívoro", 2);

        public static readonly EMetodoAlimentacao[] Values = { Filtrador, Cacador, Herbivoro };
    }

    public class EDefesa : Enum
    {
        private EDefesa(string text, int id) : base(text, id) { }

        public static readonly EDefesa Espinhos = new EDefesa("Espinhos", 0);
        public static readonly EDefesa Camuflagem = new EDefesa("Camuflagem", 1);
        public static readonly EDefesa Veneno = new EDefesa("Veneno", 2);
        public static readonly EDefesa Ataque = new EDefesa("Ataque", 3);
        public static readonly EDefesa Mobilidade = new EDefesa("Mobilidade", 4);
        public static readonly EDefesa ResistênciaFisica = new EDefesa("Resistência física", 5);
        public static readonly EDefesa Bando = new EDefesa("Bando", 6);
        public static readonly EDefesa Nenhum = new EDefesa("Nenhum", 7);

        public static readonly EDefesa[] Values = { 
            Espinhos, Camuflagem, Veneno, Ataque, Mobilidade, ResistênciaFisica, Bando, Nenhum 
        };
    }

    public class Defesa
    {
        public EDefesa[] Meios { get; set; }
        public string Descricao { get; set; }

        public Defesa() { }
        public Defesa(EDefesa[] meios, string descricao)
        {
            Meios = meios;
            Descricao = descricao;
        }

        public override string ToString()
        {
            bool moreThan1 = Meios.Count() > 1;
            string toText = moreThan1 ? "Meios:  " : "Meio:  ";

            foreach (EDefesa eDef in Meios)
            {
                toText += eDef.Text + (moreThan1 ? " | " : "");
            }

            return toText;
        }
    }

    public class EReproducao : Enum
    {
        private EReproducao(string text, int id) : base(text, id) { }

        public static readonly EReproducao Sexuada = new EReproducao("Sexuada", 0);
        public static readonly EReproducao Assexuada = new EReproducao("Assexuada", 1);
        public static readonly EReproducao Ambos = new EReproducao("Ambos", 2);

        public static readonly EReproducao[] Values = { Sexuada, Assexuada, Ambos };
    }

    public class EDevEmbrionario : Enum
    {
        private EDevEmbrionario(string text, int id) : base(text, id) { }

        public static readonly EDevEmbrionario Ovo = new EDevEmbrionario("Ovo", 0);
        public static readonly EDevEmbrionario OvoCalcificado = new EDevEmbrionario("Ovo calficicado", 1);
        public static readonly EDevEmbrionario Placenta = new EDevEmbrionario("Placentário", 2);
        public static readonly EDevEmbrionario Larva = new EDevEmbrionario("Larval", 3);
        public static readonly EDevEmbrionario Ninfa = new EDevEmbrionario("Ninfa", 4);
        public static readonly EDevEmbrionario Monotremado = new EDevEmbrionario("Monotremado", 5);

        public static readonly EDevEmbrionario[] Values = { Ovo, OvoCalcificado, Placenta, Larva, Ninfa, Monotremado };
    }

    public class DevEmbrionario
    {
        public EReproducao TipoReproducao { get; set; }
        public EDevEmbrionario Meio { get; set; }
        public string Descricao { get; set; }
        public string DescricaoCorte { get; set; }

        public DevEmbrionario(EReproducao tipoReproducao, EDevEmbrionario meio, string descricao)
        {
            TipoReproducao = tipoReproducao;
            Meio = meio;
            Descricao = descricao;
            DescricaoCorte = String.Empty;
        }

        public DevEmbrionario(EReproducao tipoReproducao, EDevEmbrionario meio, string descricao, string descricaoCorte)
        {
            TipoReproducao = tipoReproducao;
            Meio = meio;
            Descricao = descricao.Trim();
            DescricaoCorte = descricaoCorte.Trim();
        }

        public DevEmbrionario() { }

        public override string ToString()
        {
            return "Tipo de reprodução:  " + TipoReproducao.Text
                + "\nMeio:  " + Meio.Text
                + "\nDescrição:  " + Descricao
                + "\n"
                + (DescricaoCorte != String.Empty
                ? "Descrição da corte:  " + DescricaoCorte
                : "Não há comportamento de corte");
        }
    }
}
