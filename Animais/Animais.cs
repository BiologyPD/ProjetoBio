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
    public class Animal
    {
        // * textBox
        public string Nome { get; set; }

        // * comboBox
        public Filo Filo { get; set; }

        // * comboBox
        public Tipo Tipo { get; set; }

        // * comboBox
        public Respiracao Respiracao { get; set; }

        // * textBox multiline
        public string Adaptacoes { get; set; }

        // * textBox
        public string Bioma { get; set; }

        // * comboBox
        // * comboBox
        // * textBox
        // * textBox multiline
        public Alimentacao Alimentacao { get; set; }

        // * textBox multiline
        public string RegulacaoAgua { get; set; }

        // * checkedListBox
        // * textBox multiline
        public Locomocao Locomocao { get; set; }

        // * checkedListBox
        // * textBox multiline
        public Defesa Defesa { get; set; }

        // * comboBox
        // * comboBox
        // * textBox multiline
        // optional textBox multiline
        public DevEmbrionario DevEmbrionario { get; set; }

        // * optional textBox
        public string Personagem { get; set; }

        public Animal(string nome, Filo filo, Tipo tipo, Respiracao respiracao, string adaptacoes, string bioma, Alimentacao alimentacao, string regulacaoAgua, Locomocao locomocao, Defesa defesa, DevEmbrionario devEmbrionario, string personagem)
        {
            Nome = nome.Trim() ?? throw new ArgumentNullException(nameof(nome));
            Filo = filo ?? throw new ArgumentNullException(nameof(filo));
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Respiracao = respiracao ?? throw new ArgumentNullException(nameof(respiracao));
            Adaptacoes = adaptacoes.Trim() ?? throw new ArgumentNullException(nameof(adaptacoes));
            Bioma = bioma.Trim() ?? throw new ArgumentNullException(nameof(bioma));
            Alimentacao = alimentacao ?? throw new ArgumentNullException(nameof(alimentacao));
            RegulacaoAgua = regulacaoAgua.Trim() ?? throw new ArgumentNullException(nameof(regulacaoAgua));
            Locomocao = locomocao ?? throw new ArgumentNullException(nameof(locomocao));
            Defesa = defesa ?? throw new ArgumentNullException(nameof(defesa));
            DevEmbrionario = devEmbrionario ?? throw new ArgumentNullException(nameof(devEmbrionario));
            Personagem = personagem.Trim() ?? throw new ArgumentNullException(nameof(personagem));
        }

        public Animal() { }

        public static Animal smilinguido()
        {
            Animal animal1 = new Animal()
            {
                Nome = "Formiga",
                Filo = Filo.Artropode,
                Tipo = Tipo.Terrestre,
                Respiracao = Respiracao.Traqueal,
                Adaptacoes = "Comportamento social, divisão de trabalho e ocasionalmente agricultura/pecuária",
                Bioma = "Todos",
                Alimentacao = new Alimentacao(Filo.Artropode)
                {
                    Tipo = EAlimentacao.Herbivoro,
                    Descricao = "Colhe folhas encontradas, as come ou as usa como compostagem para cultivar um fungo, que é seu alimento. Tem grande interesse em carboidratos simples.",
                    Meio = EMetodoAlimentacao.Herbivoro,
                    TipoBoca = "Composta por duas garras adjacentes as laterais de uma cavidade.",

                },
                Defesa = new Defesa()
                {
                    Meios = new EDefesa[]
                    {
                        EDefesa.Mobilidade,
                        EDefesa.Bando
                    },
                    Descricao = "Seu pequeno tamanho e alta mobilidade permitem que escape facilmente da maioria dos ataques.",
                },
                DevEmbrionario = new DevEmbrionario()
                {
                    TipoReproducao = EReproducao.Sexuada,
                    Meio = EDevEmbrionario.Ovo,
                    Descricao = "Possui um berçário em sua colônia, onde os ovos produzidos pela rainha são armazenados e protegidos.",
                    DescricaoCorte = String.Empty,
                },
                Locomocao = new Locomocao()
                {
                    Meio = new ELocomocao[]
                    {
                        ELocomocao.Escalar,
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

        public FrmAnimal ToFrmAnimal()
        {
            var frm = new FrmAnimal();
            frm.SetAnimal(this);
            return frm;
        }
    }
}
