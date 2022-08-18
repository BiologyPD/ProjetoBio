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

    public struct Locomocao 
    {
        public ELocomocao Meio { get; set; }
        public string Descricao { get; set; }

        public Locomocao(ELocomocao meio, string descricao)
        {
            Meio = meio;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return "Meio de Locomoção:  " + Meio.ToString() + "\nDescrição:  " + Descricao;
        }
    }

    public enum ELocomocao 
    {
        Saltando,
        Rastejando,
        Voando,
        Andar,
        Nadando
    }

    public struct Alimentacao 
    { 
        private EAlimentacao _tipo;
        public EAlimentacao Tipo { get => _tipo; set 
            {
                _tipo = value;
                switch (value)
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
                }
            }; }
        public EMetodoAlimentacao Meio { get; set; }
        public string Descricao { get; set; }
        public bool HasBoca { get; private set; }
        public bool HasAnus { get; private set; }
        public string TipoBoca { get; set; }

        // TODO string DescricaoBoca

        public Alimentacao(EAlimentacao tipo, EMetodoAlimentacao meio, string descricao, Filo filo, string tipoBoca) 
        {
            Tipo = tipo;
            Meio = meio;
            Descricao = descricao;
            TipoBoca = tipoBoca;
            this.Filo = filo;
        }

        public override string ToString() 
        {
            string toText = "Tipo de alimentação:  "
                + Tipo.ToString()
                + "\nMétodo de alimentação:  "
                + Meio.ToString()
                + "\nDescrição:  "
                + Descricao;

            switch (HasBoca, HasAnus)
            {
                case (true, true):
                    toText += "\nPossui boca e ânus.";
                    break;

                case (true, false):
                    toText += "\nPossui somente boca.";
                    break;

                case (false, true):
                    toText += "\nPossui somente ânus.";
                    break;

                case (false, false):
                    toText += "\nNão possui boca ou ânus.";
                    break;
            }
            
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
            string toText = moreThan1 ? "Meios:  " :  "Meio:  ";

            foreach(EDefesa eDef in Meio)
            {
                toText += eDef.ToString() + moreThan1 ? " | ";
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
        public EDevEmbrionario Meio { get; set; }
        public string Descricao { get; set; }
        public bool HasCorte { get; private set; }
        public string DescricaoCorte { get; set; }

        public DevEmbrionario(EDevEmbrionario meio, string descricao) 
        {
            Meio = meio;
            Descricao = descricao;
            HasCorte = false;
            DescricaoCorte = "Não há";
        }

        public DevEmbrionario(EDevEmbrionario meio, string descricao, string descricaoCorte) 
        {
            Meio = meio;
            Descricao = descricao;
            HasCorte = true;
            DescricaoCorte = descricaoCorte;
        }

        public override string ToString()
        {
            return "Meio:  " + Meio.ToString()
                + "\nDescrição:  " + Descricao
                + "\n"
                + (HasCorte ?
                "Descrição da corte:  " + DescricaoCorte :
                "Não há comportamento de corte");
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

    class Animais
    {
        public string Nome { get; set; }
        public Filo Filo { get; set; }
        public string Adaptacoes { get; set; }
        public string Bioma { get; set; }
        public Alimentacao Alimentacao { get; set; }
        public string RegulacaoAgua { get; set; }
        public Locomocao Locomocao { get; set; }
        public Defesa Defesa { get; set; }
        public Reproducao Reproducao { get; set; }
        public DevEmbrionario DevEmbrionario { get; set;}
        public string? Personagem { get; set; }

    }
}
