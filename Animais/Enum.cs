using ProjetoBio.Utils;
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
        public bool HasLocomocao => Meio.Count() > 0;

        public Locomocao(ELocomocao[] meio, string descricao)
        {
            Meio = meio;
            Descricao = descricao;
        }

        public Locomocao() { }

        public override string ToString()
        {
            var toText = new StringBuilder();
            toText.AppendLine("LOCOMOÇÃO:");

            switch (Meio.Count()) {
                case 0:
                    toText.AppendLine("Não se locomove.");
                    break;

                case 1:
                    toText.AppendLine("Meio de locomoção:  " + Meio[0]);
                    break;

                default:
                    toText.Append("Meios de locomoção:  | ");
                    foreach (ELocomocao me in Meio)
                        toText.Append(me.Text).Append(" | ");
                    toText.AppendLine();
                    break;
            }

            toText.Append("Descrição:  ").AppendLine(Descricao);
            return toText.ToString();
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
        public string DescricaoBoca { get; set; }
        public string DescricaoAnus { get; set; }
        public bool HasAnus => !DescricaoAnus.IsBlank();
        public bool HasBoca => !DescricaoBoca.IsBlank();

        public void CheckAnusBoca(Filo filo)
        {
            if (filo == Filo.Porifera)
            {
                if (HasAnus && HasBoca)
                    throw new ArgumentException(filo.Text + " não tem cu nem boca.");
                else if (HasAnus)
                    throw new ArgumentException(filo.Text + " não tem cu.");
                else if (HasBoca)
                    throw new ArgumentException(filo.Text + " não tem boca.");
            }
            else if (filo == Filo.Cnidario || filo == Filo.Platelminto)
            {
                if (HasAnus && !HasBoca)
                    throw new ArgumentException(filo.Text + " não tem cu mas deve ter boca.");
                else if (HasAnus)
                    throw new ArgumentException(filo.Text + " não tem cu.");
                else if (!HasBoca)
                    throw new ArgumentException(filo.Text + " deve ter boca.");
            }
            else
            {
                if (!HasBoca && !HasAnus)
                    throw new ArgumentException(filo.Text + " deve ter cu e boca.");
                else if (!HasBoca)
                    throw new ArgumentException(filo.Text + " deve ter boca.");
                else if (!HasAnus)
                    throw new ArgumentException(filo.Text + " deve ter cu.");
            }
        }

        public Alimentacao(Filo filo, EAlimentacao tipo, EMetodoAlimentacao meio, string descricao, string descricaoBoca, string descricaoAnus)
        {
            Tipo = tipo;
            Meio = meio;
            Descricao = descricao.Check();
            DescricaoBoca = descricaoBoca.ToTrimmed();
            DescricaoAnus = descricaoAnus.ToTrimmed();
            CheckAnusBoca(filo);
        }

        public Alimentacao() { }

        public Alimentacao(Filo filo) { /* CheckAnusBoca(filo); */ }

        public override string ToString()
        {
            var toText = new StringBuilder("ALIMENTAÇÃO:");
            toText.AppendLine();

            toText.Append("Tipo de alimentação:  ").AppendLine(Tipo.Text);
            toText.Append("Método de alimentação:  ").AppendLine(Meio.Text);
            toText.Append("Descrição:  ").AppendLine(Descricao);

            if (HasBoca && HasAnus)
                toText.AppendLine("Possui boca e ânus.");
            else if (HasBoca && !HasAnus)
                toText.AppendLine("Possui somente boca.");
            else if (!HasBoca && HasAnus)
                toText.AppendLine("Possui somente ânus.");
            else if (!HasBoca && !HasAnus)
                toText.AppendLine("Não possui boca ou ânus.");

            if (HasBoca)
                toText.Append("\tDescrição da boca:  ").AppendLine(DescricaoBoca);

            if (HasAnus)
                toText.Append("\tDescrição do ânus:  ").AppendLine(DescricaoAnus);

            return toText.ToString();
        }
    }

    public class EAlimentacao : Enum
    {
        private EAlimentacao(string text, int id) : base(text, id) { }

        public static readonly EAlimentacao Particulas = new EAlimentacao("Partículas", 0);
        public static readonly EAlimentacao Herbivoro = new EAlimentacao("Herbívoro", 1);
        public static readonly EAlimentacao Carnivoro = new EAlimentacao("Carnívoro", 2);
        public static readonly EAlimentacao Onivoro = new EAlimentacao("Onívoro", 3);
        public static readonly EAlimentacao Hematofago = new EAlimentacao("Hematófago", 4);

        public static readonly EAlimentacao[] Values = { Particulas, Herbivoro, Carnivoro, Onivoro, Hematofago };
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

        public static readonly EDefesa[] Values = { 
            Espinhos, Camuflagem, Veneno, Ataque, Mobilidade, ResistênciaFisica, Bando
        };
    }

    public class Defesa
    {
        public EDefesa[] Meios { get; set; }
        public string Descricao { get; set; }
        public int QntMeios => Meios.Count();
        public bool HasDefesa => Meios.Count() > 0;
        public string[] Text => Meios.Select(x => x.Text).ToArray();

        public Defesa() { }
        public Defesa(EDefesa[] meios, string descricao)
        {
            Meios = meios;
            Descricao = descricao;
        }

        public override string ToString()
        {
            var toText = new StringBuilder("DEFESA:");
            toText.AppendLine();

            switch (QntMeios) {
                case 0:
                    toText.AppendLine("Este animal não possui meio de defesa.");
                    break;

                case 1:
                    toText.Append("Meio de defesa:  ").AppendLine(Meios[0].Text);
                    break;

                default:
                    toText.Append("Meios de defesa:  | ");
                    foreach(var meio in Meios)
                        toText.Append(meio.Text).Append(" | ");
                    toText.AppendLine();
                    break;
            }

            toText.Append("Descrição:  ").AppendLine(Descricao);
            return toText.ToString();
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
        public static readonly EDevEmbrionario OvoCalcificado = new EDevEmbrionario("Ovo calcificado", 1);
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
        public string EpocaReproducao { get; set; }
        public bool HasCorte => !DescricaoCorte.IsBlank();
        public bool HasEpocaReproducao => !EpocaReproducao.IsBlank();

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
            var toText = new StringBuilder("REPRODUÇÃO E DESENVOLVIMENTO EMBRIONÁRIO:");
            toText.AppendLine();

            toText.Append("Tipo de reprodução:  ").AppendLine(TipoReproducao.Text);
            toText.Append("Meio:  ").AppendLine(Meio.Text);
            toText.Append("Descrição:  ").AppendLine(Descricao);

            if (HasCorte)
                toText.Append("Descrição da corte:  ").AppendLine(DescricaoCorte);
            else
                toText.AppendLine("Não possui comportamento de corte.");

            if (HasEpocaReproducao)
                toText.Append("Época de reprodução:  ").AppendLine(EpocaReproducao);
            else
                toText.AppendLine("Não possui época de reprodução.");

            return toText.ToString();
        }
    }
}
