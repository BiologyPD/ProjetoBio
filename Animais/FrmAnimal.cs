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
            CarregarCB<Filo>(cbFilo);
            CarregarCB<Tipo>(cbTipo);
            CarregarCB<Respiracao>(cbRespiracao);
            CarregarCB<EAlimentacao>(cbEAlimentacao);
            CarregarCB<EMetodoAlimentacao>(cbEMetodoAlimentacao);
            CarregarCB<EReproducao>(cbEReproducao);
            CarregarCB<EDevEmbrionario>(cbEDevEmbrionario);
            CarregarChkLst<EDefesa>(chkLstEDefesa);
            CarregarChkLst<ELocomocao>(chkLstELocomocao);
            // CarregarChkLst<EDefesa>(checkedListBox1);   
        }

        private T[] GetValuesFromChkLst<T>(CheckedListBox chkLst) where T : Enum
        {
            var values = new List<T>();
            var enumValues = Enum.GetValues<T>();
            foreach (int value in chkLst.CheckedIndices.Cast<int>())
                values.Add(enumValues[value]);
            return values.ToArray();
        }

        private void CarregarChkLst<T>(CheckedListBox checkList) where T : Enum
        {
            checkList.CheckOnClick = true;
            checkList.Items.Clear();
            foreach (var value in Enum.GetValues<T>())
                checkList.Items.Add(value.Text);
        }

        private void CarregarCB<T>(ComboBox cb) where T : Enum
        {
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
            cb.DataSource = KeyPair.GetKeyPairs<T>();
        }

        private void checkCampoPersonagem_CheckedChanged(object sender, EventArgs e) =>
            txtPersonagem.Enabled = checkCampoPersonagem.Checked;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabDesenvolvimentoEmbrionario_Click(object sender, EventArgs e)
        {

        }

        private void chkReproducaoHasCorte_CheckedChanged(object sender, EventArgs e) =>
            txtReproducaoDescricaoCorte.Visible = chkReproducaoHasCorte.Checked;

        private void SetChkLst<T>(CheckedListBox checkedList, T[] values) where T : Enum
        {
            var enumValues = Enum.GetValues<T>().ToList();
            foreach (var value in values)
                checkedList.SetItemChecked(enumValues.IndexOf(value), true);
        }

        public Animal GetAnimal()
        {
            return new Animal()
            {
                Nome = txtNome.Text.Trim(),
                Filo = (Filo)cbFilo.SelectedValue,
                Tipo = (Tipo)cbTipo.SelectedValue,
                Respiracao = (Respiracao)cbRespiracao.SelectedValue,
                Adaptacoes = txtAdaptacoes.Text.Trim(),
                Bioma = txtBioma.Text.Trim(),
                Alimentacao = new Alimentacao((Filo)cbFilo.SelectedValue)
                {
                    Tipo = (EAlimentacao)cbEAlimentacao.SelectedValue,
                    Meio = (EMetodoAlimentacao)cbEMetodoAlimentacao.SelectedValue,
                    Descricao = txtAlimentacaoDescricao.Text.Trim()
                },
                RegulacaoAgua = txtRegulacaoAgua.Text.Trim(),
                Locomocao = new Locomocao()
                {
                    Meio = GetValuesFromChkLst<ELocomocao>(chkLstELocomocao),
                    Descricao = txtDescricaoLocomocao.Text.Trim()
                },
                Defesa = new Defesa()
                {
                    Meios = GetValuesFromChkLst<EDefesa>(chkLstEDefesa),
                    Descricao = txtDefesaDescricao.Text.Trim()
                },
                DevEmbrionario = new DevEmbrionario()
                {
                    TipoReproducao = (EReproducao)cbEReproducao.SelectedValue,
                    Meio = (EDevEmbrionario)cbEDevEmbrionario.SelectedValue,
                    Descricao = txtReproducaoDescricao.Text.Trim(),
                    DescricaoCorte = chkReproducaoHasCorte.Checked ? txtReproducaoDescricaoCorte.Text.Trim() : String.Empty
                },
                Personagem = checkCampoPersonagem.Checked ? txtPersonagem.Text.Trim() : String.Empty
            };
        }

        public void SetAnimal(Animal animal)
        {
            bool hasCorte = animal.DevEmbrionario.DescricaoCorte != String.Empty;
            bool hasPersonagem = animal.Personagem != String.Empty;

            txtNome.Text = animal.Nome;
            cbFilo.SelectedValue = animal.Filo;
            cbTipo.SelectedValue = animal.Tipo;
            cbRespiracao.SelectedValue = animal.Respiracao;
            txtAdaptacoes.Text = animal.Adaptacoes;
            txtBioma.Text = animal.Bioma;
            
            cbEAlimentacao.SelectedValue = animal.Alimentacao.Tipo;
            cbEMetodoAlimentacao.SelectedValue = animal.Alimentacao.Meio;
            txtAlimentacaoDescricao.Text = animal.Alimentacao.Descricao;
            txtAlimentacaoTipoBoca.Text = animal.Alimentacao.TipoBoca;
            
            txtRegulacaoAgua.Text = animal.RegulacaoAgua;
            
            SetChkLst(chkLstELocomocao, animal.Locomocao.Meio);
            txtDescricaoLocomocao.Text = animal.Locomocao.Descricao;
            
            SetChkLst(chkLstEDefesa, animal.Defesa.Meios);
            txtDefesaDescricao.Text = animal.Defesa.Descricao;

            cbEReproducao.SelectedValue = animal.DevEmbrionario.TipoReproducao;
            cbEDevEmbrionario.SelectedValue = animal.DevEmbrionario.Meio;
            txtReproducaoDescricao.Text = animal.DevEmbrionario.Descricao;
            chkReproducaoHasCorte.Checked = hasCorte;
            txtReproducaoDescricaoCorte.Text = hasCorte ? animal.DevEmbrionario.DescricaoCorte : String.Empty;

            checkCampoPersonagem.Checked = hasPersonagem;
            txtPersonagem.Text = hasPersonagem ? animal.Personagem : String.Empty;
        }
    }
}
