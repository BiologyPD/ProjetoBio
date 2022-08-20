using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio.Animais
{
    public enum Filo
    {
        Porifera,
        Cnidario,
        Platelminto,
        Nematelminto,
        Molusco,
        Anelideo,
        Artropode,
        Equinoderma,
        Cordado
    }
    public static class FiloExtensions
    {
        public static string[] Values { get; private set; } =
        {
            "Porífera",
            "Cnidário",
            "Platelminto",
            "Nematelminto",
            "Molusco",
            "Anelídeo",
            "Artrópode",
            "Equinoderma",
            "Cordado",
        };
        public static string ToString(this Filo filo)
        {
            return Values[(int) filo];
        }
    }

    public struct Locomocao
    {
        public List<ELocomocao> Meio { get; set; }
        public string Descricao { get; set; }

        public Locomocao(List<ELocomocao> meio, string descricao)
        {
            Meio = meio;
            Descricao = descricao;
        }

        public override string ToString()
        {
            string _string;
            if (Meio.Count == 0)
                { _string = "Não se locomove.\n"; }
            else if (Meio.Count == 1) 
                { _string = "Meio de locomoção:  " + Meio[0]; }
            else if (Meio.Count >= 2)
            {
                _string = "Meios de locomoção:  | ";
                foreach (ELocomocao me in Meio)
                {
                    _string += ELocomocaoExtensions.ToString(me) + " | ";
                }
            }
            return _string + "\nDescrição:  " + Descricao;
        }
    }

    public enum ELocomocao
    {
        Saltando,
        Rastejando,
        Voando,
        Andar,
        Nadando,
        Escalando,
    }

    public static class ELocomocaoExtensions
    {
        public static string[] Values { get; private set; } =
        {
            "Saltando",
            "Rastejando",
            "Voando",
            "Andar",
            "Nadando",
            "Escalando",
        };

        public static string ToString(this ELocomocao eLocomocao)
        {
            return Values[(int)eLocomocao];
        } 
    }

    public enum Respiracao
    {
        Cutanea,
        Branquial,
        Pulmonar,
        Traqueal,
    }

    public struct Alimentacao
    {
        public EAlimentacao Tipo { get; set; }
        public EMetodoAlimentacao Meio { get; set; }
        public string Descricao { get; set; }
        public string TipoBoca { get; set; }
        public bool HasAnus { get; set; }
        public bool HasBoca { get; set; }

        public Alimentacao(EAlimentacao tipo, EMetodoAlimentacao meio, string descricao, Filo filo, string tipoBoca)
        {
            Tipo = tipo;
            Meio = meio;
            Descricao = descricao;
            TipoBoca = tipoBoca;

            switch (filo)
            {
                case Filo.Porifera:
                    HasAnus = false;
                    HasBoca = false;
                    break;

                case Filo.Cnidario:
                    HasAnus = false;
                    HasBoca = true;
                    break;

                case Filo.Platelminto:
                    HasAnus = false;
                    HasBoca = true;
                    break;

                default:
                    HasAnus = true;
                    HasBoca = true;
                    break;
            }
        }

        public override string ToString()
        {
            string toText = "Tipo de alimentação:  "
                + Tipo.ToString()
                + "\nMétodo de alimentação:  "
                + Meio.ToString()
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

    public enum EAlimentacao
    {
        Particulas,
        Herbivoro,
        Carnivoro,
        Onivoro
    }

    public enum EMetodoAlimentacao
    {
        Filtrador,
        Caçador,
        Herbivoro
    }

    public enum EDefesa
    {
        Espinhos,
        Camuflagem,
        Veneno,
        Ataque,
        Mobilidade,
        ResistênciaFisica,
        Bando,
        Nenhum
    }

    public struct Defesa
    {
        public List<EDefesa> Meio { get; set; }
        public string Descricao { get; set; }

        public Defesa(List<EDefesa> meio, string descricao)
        {
            Meio = meio;
            Descricao = descricao;
        }

        public override string ToString()
        {
            bool moreThan1 = Meio.Count > 1;
            string toText = moreThan1 ? "Meios:  " : "Meio:  ";

            foreach (EDefesa eDef in Meio)
            {
                toText += eDef.ToString() + (moreThan1 ? " | " : "");
            }

            return toText;
        }
    }

    public enum EReproducao
    {
        Sexuada,
        Assexuada,
        Ambos
    }

    public struct DevEmbrionario
    {
        public EReproducao TipoReproducao { get; set; }
        public EDevEmbrionario Meio { get; set; }
        public string Descricao { get; set; }
        public bool HasCorte { get; set; }
        public string DescricaoCorte { get; set; }

        public DevEmbrionario(EReproducao tipoReproducao, EDevEmbrionario meio, string descricao)
        {
            TipoReproducao = tipoReproducao;
            Meio = meio;
            Descricao = descricao;
            HasCorte = false;
            DescricaoCorte = "Não há";
        }

        public DevEmbrionario(EReproducao tipoReproducao, EDevEmbrionario meio, string descricao, string descricaoCorte)
        {
            TipoReproducao = tipoReproducao;
            Meio = meio;
            Descricao = descricao;
            HasCorte = true;
            DescricaoCorte = descricaoCorte;
        }

        public override string ToString()
        {
            return "Tipo de reprodução:  " + TipoReproducao.ToString()
                + "\nMeio:  " + Meio.ToString()
                + "\nDescrição:  " + Descricao
                + "\n"
                + (HasCorte
                ? "Descrição da corte:  " + DescricaoCorte
                : "Não há comportamento de corte");
        }
    }

    public enum EDevEmbrionario
    {
        Ovo,
        OvoCalcificado,
        Placenta,
        Larva,
        Ninfa,
        Monotremado
    }
}
