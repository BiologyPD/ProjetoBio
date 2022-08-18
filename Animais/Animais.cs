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
        Anelídeo,
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
        public EAlimentacao Tipo { get; set; }
        public EMetodoAlimentacao Meio { get; set; }
        public string Descricao { get; set; }

        // TODO string DescricaoBoca

        public Alimentacao(EAlimentacao tipo, EMetodoAlimentacao meio, string descricao, Filo filo) 
        {
            Tipo = tipo;
            Meio = meio;
            Descricao = descricao;

            // TODO Decidir se tem boca/anûs a partir do filo
            // TODO Atribuir DescricaoBoca
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
        public bool HasCorte { get; }
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
        public string ObtencaoAlimento { get; set; }
        public string RegulacaoAgua { get; set; }
        public string Locomocao { get; set; }
        public string Defesa { get; set; }
        public Reproducao Reproducao { get; set; }
        public string? Personagem { get; set; }

    }
}
