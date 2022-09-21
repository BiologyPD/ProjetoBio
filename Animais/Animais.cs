using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// using System.Text.Json;
using System.Windows.Forms;
using ProjetoBio.Utils;

namespace ProjetoBio.Animais
{
    public class Animal
    {
        // public void @neon genesis<evangelion>(Hospital scene) class

        public bool HasPersonagem => !Personagem.IsBlank();

        // * textBox
        public string Nome { get; set; }

        // * textBox
        public string NomeCientifico { get; set; }
        
        // textBox
        public string Aparencia { get; set; }

        // textBox
        public string DescricaoMembros { get; set; }

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

        // * textBox multiline
        public string Habitat { get; set; }

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
        // * optional textBox multiline
        // * optional textBox multiline
        public DevEmbrionario DevEmbrionario { get; set; }

        // * optional textBox
        public string Personagem { get; set; }

        public string InformacoesInuteis { get; set; } // não, não vai ter cadastro disso.

        public override string ToString()
        {
            var toText = new StringBuilder("INFORMAÇÕES DO ANIMAL.");
            toText.AppendLine();

            toText
                .Append("Nome:  ").AppendLine(Nome)
                .Append("Nome científico:  ").AppendLine(NomeCientifico)
                .Append("Filo:  ").AppendLine(Filo.Text)
                .Append("Aparência:  ").AppendLine(Aparencia)
                .Append("Bioma:  ").AppendLine(Bioma)
                .Append("Habitat:  ").AppendLine(Habitat)
                .Append("Ambiente:  ").AppendLine(Tipo.Text)
                .Append("Adaptações:  ").AppendLine(Adaptacoes)
                .Append("Regulação de água:  ").AppendLine(RegulacaoAgua)
                .Append("Respiração:  ").AppendLine(Respiracao.Text)
                .Append("Personagem:  ").AppendLine(Personagem)
                .AppendLine()
                .AppendLine(Alimentacao.ToString())
                .AppendLine(Defesa.ToString())
                .AppendLine(Locomocao.ToString())
                .AppendLine(DevEmbrionario.ToString())                
            ;

            return toText.ToString();
        }

        public Animal(string nome, Filo filo, Tipo tipo, Respiracao respiracao, string adaptacoes, string bioma, Alimentacao alimentacao, string regulacaoAgua, Locomocao locomocao, Defesa defesa, DevEmbrionario devEmbrionario, string personagem)
        {
            Nome = nome.Check();
            Adaptacoes = adaptacoes.Check();
            Bioma = bioma.Check();
            RegulacaoAgua = regulacaoAgua.Check();
            Personagem = personagem.Check();
            Filo = filo ?? throw new ArgumentNullException(nameof(filo));
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Respiracao = respiracao ?? throw new ArgumentNullException(nameof(respiracao));
            Alimentacao = alimentacao ?? throw new ArgumentNullException(nameof(alimentacao));
            Locomocao = locomocao ?? throw new ArgumentNullException(nameof(locomocao));
            Defesa = defesa ?? throw new ArgumentNullException(nameof(defesa));
            DevEmbrionario = devEmbrionario ?? throw new ArgumentNullException(nameof(devEmbrionario));
        }

        public Animal() { }

        public static Animal smilinguido() {
            return new Animal()
            {
                Nome = "Formiga",
                Filo = Filo.Artropode,
                Aparencia = "Pequena, escura, corpo alongado segmentado e com antenas.",
                // Membros = "Possui 6 membros, 3 em cada lateral do corpo, e cada par adjacente a um dos seus três segmentos corporais.",
                Tipo = Tipo.Terrestre,
                Respiracao = Respiracao.Traqueal,
                Adaptacoes = "Comportamento social, divisão de trabalho e ocasionalmente agricultura/pecuária",
                Bioma = "Todos",
                Alimentacao = new Alimentacao( /* Filo.Artropode */ )
                {
                    Tipo = EAlimentacao.Herbivoro,
                    Descricao = "Colhe folhas encontradas, as come ou as usa como compostagem para cultivar um fungo, que é seu alimento. Tem grande interesse em carboidratos simples.",
                    Meio = EMetodoAlimentacao.Herbivoro,
                    DescricaoBoca = "Composta por duas garras adjacentes as laterais de uma cavidade.",
                    DescricaoAnus = "eu nao sei?",
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
        }

        //public string GetJson() => JsonSerializer.Serialize(AnimalModels.Suindara);

        //public void ShowJson() => MessageBox.Show(GetJson(), "Json: ", MessageBoxButtons.OK);

        public FrmAnimal ToFrmAnimal() => new FrmAnimal(this);
        public bool IsNotNull => GetType()
            .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public)
            .All(x => x.GetValue(this) != null);
    }
}
