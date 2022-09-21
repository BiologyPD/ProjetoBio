using ProjetoBio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBio.Animais
{
    public partial class FrmAnimal : Form
    {
        public FrmAnimal()
        {
            InitializeComponent();

            cbFilo.SetFrom<Filo>();
            cbTipo.SetFrom<Tipo>();
            cbRespiracao.SetFrom<Respiracao>();
            cbEAlimentacao.SetFrom<EAlimentacao>();
            cbEMetodoAlimentacao.SetFrom<EMetodoAlimentacao>();
            cbEReproducao.SetFrom<EReproducao>();
            cbEDevEmbrionario.SetFrom<EDevEmbrionario>();
            chkLstEDefesa.SetFrom<EDefesa>();
            chkLstELocomocao.SetFrom<ELocomocao>();

            txtNome.AddToolTip("hello world from the 7th ring of hell");
        }

        public FrmAnimal(Animal animal) : this() => SetAnimal(animal);

        private void checkCampoPersonagem_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtPersonagem.Enabled = checkCampoPersonagem.Checked;

        private void chkReproducaoHasCorte_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtReproducaoDescricaoCorte.Enabled = chkReproducaoHasCorte.Checked;

        public Animal GetAnimal()
        {
            this.TrimAll();

            var tool = new ToolTip();

            return new Animal()
            {
                Nome = txtNome.Text,
                NomeCientifico = txtNomeCientifico.Text,
                Filo = (Filo)cbFilo.SelectedValue,
                Tipo = (Tipo)cbTipo.SelectedValue,
                Respiracao = (Respiracao)cbRespiracao.SelectedValue,
                Adaptacoes = txtAdaptacoes.Text,
                Bioma = txtBioma.Text,
                Habitat = txtHabitat.Text,
                Aparencia = txtAparencia.Text,
                DescricaoMembros = txtDescMembros.Text,
                Alimentacao = new Alimentacao((Filo)cbFilo.SelectedValue)
                {
                    Tipo = (EAlimentacao)cbEAlimentacao.SelectedValue,
                    Meio = (EMetodoAlimentacao)cbEMetodoAlimentacao.SelectedValue,
                    Descricao = txtAlimentacaoDescricao.Text,
                    DescricaoBoca = txtDescBoca.Text,
                    DescricaoAnus = txtDescAnus.Text,
                },
                RegulacaoAgua = txtRegulacaoAgua.Text,
                Locomocao = new Locomocao()
                {
                    Meio = chkLstELocomocao.CheckedValues<ELocomocao>(),
                    Descricao = txtDescricaoLocomocao.Text,
                },
                Defesa = new Defesa()
                {
                    Meios = chkLstEDefesa.CheckedValues<EDefesa>(),
                    Descricao = txtDefesaDescricao.Text,
                },
                DevEmbrionario = new DevEmbrionario()
                {
                    TipoReproducao = (EReproducao)cbEReproducao.SelectedValue,
                    Meio = (EDevEmbrionario)cbEDevEmbrionario.SelectedValue,
                    Descricao = txtReproducaoDescricao.Text,
                    DescricaoCorte = chkReproducaoHasCorte.Checked ? txtReproducaoDescricaoCorte.Text : string.Empty,
                },
                Personagem = checkCampoPersonagem.Checked ? txtPersonagem.Text : string.Empty,
            };
        }

        public void SetAnimal(Animal animal)
        {
            txtNome.Text = animal.Nome;
            txtNomeCientifico.Text = animal.NomeCientifico;
            cbFilo.SelectedValue = animal.Filo;
            cbTipo.SelectedValue = animal.Tipo;
            cbRespiracao.SelectedValue = animal.Respiracao;
            txtAdaptacoes.Text = animal.Adaptacoes;
            txtBioma.Text = animal.Bioma;
            txtHabitat.Text = animal.Habitat;
            txtAparencia.Text = animal.Aparencia;
            txtDescMembros.Text = animal.DescricaoMembros;
            
            cbEAlimentacao.SelectedValue = animal.Alimentacao.Tipo;
            cbEMetodoAlimentacao.SelectedValue = animal.Alimentacao.Meio;
            txtAlimentacaoDescricao.Text = animal.Alimentacao.Descricao;
            txtDescBoca.Text = animal.Alimentacao.DescricaoBoca;
            txtDescAnus.Text = animal.Alimentacao.DescricaoAnus;
            
            txtRegulacaoAgua.Text = animal.RegulacaoAgua;

            chkLstELocomocao.CheckFrom(animal.Locomocao.Meio);
            txtDescricaoLocomocao.Text = animal.Locomocao.Descricao;

            chkLstEDefesa.CheckFrom(animal.Defesa.Meios);
            txtDefesaDescricao.Text = animal.Defesa.Descricao;

            cbEReproducao.SelectedValue = animal.DevEmbrionario.TipoReproducao;
            cbEDevEmbrionario.SelectedValue = animal.DevEmbrionario.Meio;
            txtReproducaoDescricao.Text = animal.DevEmbrionario.Descricao;
            chkReproducaoHasCorte.Checked = animal.DevEmbrionario.HasCorte;
            txtReproducaoDescricaoCorte.Text = animal.DevEmbrionario.DescricaoCorte;
            chkHasEpocaSexo.Checked = animal.DevEmbrionario.HasEpocaReproducao;
            txtEpocaReproducao.Text = animal.DevEmbrionario.EpocaReproducao;

            checkCampoPersonagem.Checked = animal.HasPersonagem;
            txtPersonagem.Text = animal.Personagem;

            chkHasBoca_CheckedChanged();
            chkHasAnus_CheckedChanged();
            chkReproducaoHasCorte_CheckedChanged();
            chkHasEpocaSexo_CheckedChanged();
            cbFilo_SelectedIndexChanged();
        }

        private void button1_Click(object sender = null, EventArgs e = null) =>
            new FrmAnimal(GetAnimal()).Show();

        private void chkHasEpocaSexo_CheckedChanged(object sender = null, EventArgs e = null) => 
            txtEpocaReproducao.Enabled = chkHasEpocaSexo.Checked;

        private void cbFilo_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            chkHasBoca.Checked = ((Filo)cbFilo.SelectedValue).HasBoca;
            chkHasAnus.Checked = ((Filo)cbFilo.SelectedValue).HasAnus;
        }

        private void chkHasBoca_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtDescBoca.Enabled = chkHasBoca.Checked;

        private void chkHasAnus_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtDescAnus.Enabled = chkHasAnus.Checked;

        private string TextAnimal()
        {
            var animal = GetAnimal();
            var toText = new StringBuilder("new Animal()");
            toText.AppendLine().AppendLine("{");


            toText.Append("Nome = ").AppendQuote(animal.Nome)
                .Append("NomeCientifico = ").AppendQuote(animal.NomeCientifico)
                .Append("Personagem = ").AppendQuote(animal.Personagem)
                .Append("InformacoesInuteis = ").AppendQuote(animal.InformacoesInuteis)
                .Append("Bioma = ").AppendQuote(animal.Bioma)
                .Append("Personagem = ").AppendQuote(animal.Personagem)
                .Append("Adaptacoes = ").AppendQuote(animal.Adaptacoes)
                .Append("DescricaoMmberos = ").AppendQuote(animal.DescricaoMembros)
                .Append("Apar�ncia = ").AppendQuote(animal.Aparencia)
            ;

            /*
            "InformacoesInuteis =" "tem uma baita lenda sobre como se ela passar na sua casa algu�m vai morrer, e corujas n�o tem penas a prova d'�gua, como a maioria das aves, pois isso as permite voar silenciosamente e atacar despercebidas. Por causa disso, corujas molhadas s�o um tanto engra�adas. Al�m disso, corujas N�O s�o p�ssaros. Corujas s�o aves.",
            "Bioma =" "Amaz�nico/Equatorial.",
            "Habitat =" "Margem sul do rio Amazonas at� a Terra do Fogo (arquip�lago na extremidade sul da Am�rica do Sul) e nas Ilhas Maldivas.",
            "RegulacaoAgua =" "Para economia de �gua no organismo, excretam �cido �rico, j� que n�o possuem bexiga.",
            "Tipo =" Tipo.Aereo,
            "Filo =" Filo.Cordado,
            Respiracao = Respiracao.Pulmonar,
            Alimentacao = new Alimentacao(Filo.Cordado)
            {
                Descricao = "Se alimentam de insetos, pequenos marsupiais, morcegos, roedores, anf�bios, r�pteis e aves.",
                Meio = EMetodoAlimentacao.Cacador,
                Tipo = EAlimentacao.Carnivoro,
                DescricaoAnus = "Cloaca",
                DescricaoBoca = "Bico",
            },
            Defesa = new Defesa()
            {
                Meios = new EDefesa[] { EDefesa.Camuflagem },
                Descricao = "Costumam se esconder muito bem durante o dia, valendo-se da camuflagem que lhes proporcionam suas penas mescladas, de v�rios tons de marrom, cinza, branco e preto, em meio aos galhos e troncos de �rvores."
                                + "\nSe perturbadas, balan�am o corpo lateralmente. Se encurraladas, jogam-se de barriga para cima, enfrentando o perigo com as poderosas garras que lan�am para frente.",
            },
            Locomocao = new Locomocao()
            {
                Meio = new ELocomocao[] { ELocomocao.Voar, ELocomocao.Andar, ELocomocao.Escalar },
                Descricao = "ela... voa? e eu acho que ela escala", // MISSING
            },
            DevEmbrionario = new DevEmbrionario()
            {
                Meio = EDevEmbrionario.OvoCalcificado,
                TipoReproducao = EReproducao.Sexuada,
                Descricao = "Desenvolvimento direto e fecunda��o interna. Dentro do ovo haver� um zigoto que se desenvolver� em uma pequena ave a partir da incuba��o de ambos os pais.",
                DescricaoCorte = "Um roncar � emitido no per�odo de acasalamento, entoado em dueto pelo casal, a f�mea responde nos intervalos que o macho intercala.",
                EpocaReproducao = "At� 22/04/2018, somente entre os meses de janeiro e mar�o, n�o houveram registros de ninhos ativos, o que talvez indique que o per�odo reprodutivo da esp�cie seja bastante prolongado.",
            },
            */

            return toText.ToString();
        }
    }
}
