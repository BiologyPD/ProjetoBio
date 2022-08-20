using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace ProjetoBio.Animais
{


    class Animais
    {
        public string Nome { get; set; }
        public Filo Filo { get; set; }
        public Respiracao Respiracao { get; set; }
        public string Adaptacoes { get; set; }
        public string Bioma { get; set; }
        public Alimentacao Alimentacao { get; set; }
        public string RegulacaoAgua { get; set; }
        public Locomocao Locomocao { get; set; }
        public Defesa Defesa { get; set; }
        public DevEmbrionario DevEmbrionario { get; set;}
        public string Personagem { get; set; }


        public static Animais smilinguido()
        {
            Animais animal1 = new Animais()
            {
                Nome = "Formiga",
                Filo = Filo.Artropode,
                Respiracao = Respiracao.Traqueal,
                Adaptacoes = "Comportamento social, divisão de trabalho e ocasionalmente agricultura/pecuária",
                Bioma = "Todos",
                Alimentacao = new Alimentacao()
                {
                    Tipo = EAlimentacao.Herbivoro,
                    Descricao = "Colhe folhas encontradas, as come ou as usa como compostagem para cultivar um fungo, que é seu alimento. Tem grande interesse em carboidratos simples.",
                    Meio = EMetodoAlimentacao.Herbivoro,
                    TipoFilo = Filo.Artropode,
                    TipoBoca = "Composta por duas garras adjacentes as laterais de uma cavidade.",
                },
                Defesa = new Defesa()
                {
                    Meio = new List<EDefesa>()
                    {
                        EDefesa.Mobilidade,
                        EDefesa.Bando,
                    },
                    Descricao = "Seu pequeno tamanho e alta mobilidade permitem que escape facilmente da maioria dos ataques.",
                },
                DevEmbrionario = new DevEmbrionario()
                {
                    TipoReproducao = EReproducao.Sexuada,
                    Meio = EDevEmbrionario.Ovo,
                    Descricao = "Possui um berçário em sua colônia, onde os ovos produzidos pela rainha são armazenados e protegidos.",
                    HasCorte = false,
                    DescricaoCorte = "",
                },
                Locomocao = new Locomocao()
                {
                    Meio = new List<ELocomocao>
                    {
                        ELocomocao.Escalando,
                        ELocomocao.Andar,
                    },
                    Descricao = "Anda com seus seis membros articulados, além de ser capaz de escalar.",
                },
                RegulacaoAgua = "Sem meio de regulação ativa de água, pele impermeável.",
                Personagem = "Smilinguido",
            };
            return animal1;
        }

        public static string GetJson()
        {
            return JsonSerializer.Serialize(smilinguido());
        }

        public static void ShowJson()
        {
            MessageBox.Show(GetJson(), "Json: ", MessageBoxButtons.OK);
        }
    }
}
