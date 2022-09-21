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
                    EpocaReproducao = chkHasEpocaSexo.Checked ? txtEpocaReproducao.Text : string.Empty,
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
           // chkHasBoca.Checked = ((KeyPair<FilocbFilo.SelectedValue).HasBoca;
           // chkHasAnus.Checked = ((KeyPair<Filo>)cbFilo.SelectedValue).HasAnus;
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


            toText
                .Append("Nome = ").AppendQuote(animal.Nome)
                .Append("NomeCientifico = ").AppendQuote(animal.NomeCientifico)
                .Append("Personagem = ").AppendQuote(animal.Personagem)
                .Append("InformacoesInuteis = ").AppendQuote(animal.InformacoesInuteis)
                .Append("Bioma = ").AppendQuote(animal.Bioma)
                .Append("Personagem = ").AppendQuote(animal.Personagem)
                .Append("Adaptacoes = ").AppendQuote(animal.Adaptacoes)
                .Append("DescricaoMmberos = ").AppendQuote(animal.DescricaoMembros)
                .Append("Aparência = ").AppendQuote(animal.Aparencia)
                .Append("Bioma = ").AppendQuote(animal.Bioma)
                .Append("Habitat = ").AppendQuote(animal.Habitat)
                .Append("RegulacaoAgua = ").AppendQuote(animal.RegulacaoAgua)
                .Append("Tipo = ").AppendComma(EnumExtensions.NameOf(animal.Tipo))
                .Append("Filo = ").AppendComma(EnumExtensions.NameOf(animal.Filo))
                .Append("Respiracao = ").AppendComma(EnumExtensions.NameOf(animal.Respiracao))
                .Append("Alimentacao = ").Append("new Alimentacao(").AppendLine(EnumExtensions.NameOf(animal.Filo) + ")")
                .AppendLine("{")
                    .Append("Descricao = ").AppendQuote(animal.Alimentacao.Descricao)
                    .Append("Meio = ").AppendComma(EnumExtensions.NameOf(animal.Alimentacao.Meio))
                    .Append("Tipo = ").AppendComma(EnumExtensions.NameOf(animal.Alimentacao.Tipo))
                    .Append("DescricaoAnus = ").AppendQuote(animal.Alimentacao.DescricaoAnus)
                    .Append("DescricaoBoca = ").AppendQuote(animal.Alimentacao.DescricaoBoca)
                .AppendComma("}")
                .AppendLine("Defesa = new Defesa()")
                .AppendLine("{")
                .Append("Meios = new ELocomocao[] { ");

            foreach (var defesa in animal.Defesa.Meios)
                toText.Append(EnumExtensions.NameOf(defesa) + ", ");

            toText
                .AppendComma("}")
                .Append("Descricao = ").AppendQuote(animal.Defesa.Descricao)
                .AppendComma("}")
                .AppendLine("Locomocao = new Locomocao()")
                .AppendLine("{")
                .Append("Meio = new Locomocao[] { ");

            foreach (var locomocao in animal.Locomocao.Meio)
                toText.Append(EnumExtensions.NameOf(locomocao) + ", ");

            toText
                .AppendComma("}")
                .Append("Descricao = ").AppendQuote(animal.Locomocao.Descricao)
                .AppendComma("}")
                .AppendLine("DevEmbrionario = new DevEmbrionario()")
                .AppendLine("{")
                    .Append("Meio = ").AppendComma(EnumExtensions.NameOf(animal.DevEmbrionario.Meio))
                    .Append("TipoReproducao = ").AppendComma(EnumExtensions.NameOf(animal.DevEmbrionario.TipoReproducao))
                    .Append("Descricao = ").AppendQuote(animal.DevEmbrionario.Descricao)
                    .Append("DescricaoCorte = ").AppendQuote(animal.DevEmbrionario.DescricaoCorte)
                    .Append("EpocaReproducao = ").AppendQuote(animal.DevEmbrionario.EpocaReproducao)
                .AppendComma("}")
                .AppendLine("}");

            return toText.ToString();
        }

        private void FrmAnimal_Load(object sender, EventArgs e)
        {

        }

        private void btnCopiarAnimal_Click(object sender, EventArgs e) => Clipboard.SetText(TextAnimal());

        private void lblAdaptacoes_Click(object sender, EventArgs e)
        {

        }
    }
}
