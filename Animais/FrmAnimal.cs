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
        }

        public FrmAnimal(Animal animal) : this() => SetAnimal(animal);

        private void checkCampoPersonagem_CheckedChanged(object sender, EventArgs e) =>
            txtPersonagem.Enabled = checkCampoPersonagem.Checked;

        private void tabDesenvolvimentoEmbrionario_Click(object sender, EventArgs e)
        {

        }

        private void chkReproducaoHasCorte_CheckedChanged(object sender, EventArgs e) =>
            txtReproducaoDescricaoCorte.Visible = chkReproducaoHasCorte.Checked;

        public Animal GetAnimal()
        {
            this.TrimAll();

            return new Animal()
            {
                Nome = txtNome.Text,
                Filo = (Filo)cbFilo.SelectedValue,
                Tipo = (Tipo)cbTipo.SelectedValue,
                Respiracao = (Respiracao)cbRespiracao.SelectedValue,
                Adaptacoes = txtAdaptacoes.Text,
                Bioma = txtBioma.Text,
                Alimentacao = new Alimentacao((Filo)cbFilo.SelectedValue)
                {
                    Tipo = (EAlimentacao)cbEAlimentacao.SelectedValue,
                    Meio = (EMetodoAlimentacao)cbEMetodoAlimentacao.SelectedValue,
                    Descricao = txtAlimentacaoDescricao.Text,
                    DescricaoBoca = txtAlimentacaoDescricaoBoca.Text,
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
                Personagem = checkCampoPersonagem.Checked ? txtPersonagem.Text : string.Empty
            };
        }

        public void SetAnimal(Animal animal)
        {
            txtNome.Text = animal.Nome;
            cbFilo.SelectedValue = animal.Filo;
            cbTipo.SelectedValue = animal.Tipo;
            cbRespiracao.SelectedValue = animal.Respiracao;
            txtAdaptacoes.Text = animal.Adaptacoes;
            txtBioma.Text = animal.Bioma;
            
            cbEAlimentacao.SelectedValue = animal.Alimentacao.Tipo;
            cbEMetodoAlimentacao.SelectedValue = animal.Alimentacao.Meio;
            txtAlimentacaoDescricao.Text = animal.Alimentacao.Descricao;
            txtAlimentacaoDescricaoBoca.Text = animal.Alimentacao.DescricaoBoca;
            
            txtRegulacaoAgua.Text = animal.RegulacaoAgua;

            chkLstELocomocao.CheckFrom(animal.Locomocao.Meio);
            txtDescricaoLocomocao.Text = animal.Locomocao.Descricao;

            chkLstEDefesa.CheckFrom(animal.Defesa.Meios);
            txtDefesaDescricao.Text = animal.Defesa.Descricao;

            cbEReproducao.SelectedValue = animal.DevEmbrionario.TipoReproducao;
            cbEDevEmbrionario.SelectedValue = animal.DevEmbrionario.Meio;
            txtReproducaoDescricao.Text = animal.DevEmbrionario.Descricao;
            chkReproducaoHasCorte.Checked = animal.DevEmbrionario.DescricaoCorte != string.Empty;
            txtReproducaoDescricaoCorte.Text = animal.DevEmbrionario.DescricaoCorte ?? string.Empty;

            checkCampoPersonagem.Checked = animal.Personagem != string.Empty;
            txtPersonagem.Text = animal.Personagem ?? string.Empty;
        }

        private void tabGeral_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmAnimal(GetAnimal()).Show();
        }
    }
}
