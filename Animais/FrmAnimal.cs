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
    public enum FrmModes
    {
        Display,
        DisplayLocked,
        Edit,
        Create,
    }

    public partial class FrmAnimal : Form
    {
        private bool IsParasita => !gbParasita.Visible;
        private IEnumerable<Control> TabControls => tabControl.TabPages.Cast<TabPage>().SelectMany(x => x.Controls.Cast<Control>());

        private FrmModes _mode;
        public FrmModes Mode
        {
            get => _mode;

            set
            {
                _mode = value;
                ModeSelector();
            }
        }

        private static FrmAnimal _instance = null;
        private static object @lock = new object();
        private AnimalControl control = AnimalControl.Instance;
        private int EditedAnimal = -1;

        public static FrmAnimal GetInstance(Animal animal = null, FrmModes mode = FrmModes.Create)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                lock (@lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FrmAnimal();
                        _instance.FormClosed += delegate { _instance = null; };
                    }
                }
            }

            if (animal != null)
                _instance.SetAnimal(animal);
            else
                _instance.Mode = mode;

            _instance.Show();
            _instance.WindowState = FormWindowState.Normal;
            _instance.Focus();
            return _instance;
        }

        private FrmAnimal()
        {
            InitializeComponent();

            cbTipo.SetFromEmpty<Tipo>();
            cbFilo.SetFromEmpty<Filo>(); // ProjetoBio.Utils.KeyPair`1[ProjetoBio.Animais.Filo] // ProjetoBio.Utils.KeyPair`1[ProjetoBio.Animais.Tipo]
            cbRespiracao.SetFromEmpty<Respiracao>();
            cbEAlimentacao.SetFromEmpty<EAlimentacao>();
            cbEMetodoAlimentacao.SetFromEmpty<EMetodoAlimentacao>();
            cbEReproducao.SetFromEmpty<EReproducao>();
            cbEDevEmbrionario.SetFromEmpty<EDevEmbrionario>();
            chkLstEDefesa.EmptySetFrom<EDefesa>();
            chkLstELocomocao.EmptySetFrom<ELocomocao>();
        }

        private void SetControls(bool state = true)
        {
            foreach (Control ctrl in TabControls)
                ctrl.Enabled = state;
        }

        private void Clear()
        {
            foreach(Control ctrl in TabControls)
            {
                if (ctrl is TextBox txt)
                    txt.Text = "";
                else if (ctrl is CheckBox chk)
                    chk.Checked = false;
                else if (ctrl is CheckedListBox chkLst)
                    chkLst.UncheckAll();
                else if (ctrl is ComboBox cmb)
                    cmb.SelectedIndex = 0;
            }
        }

        private void ModeSelector()
        {
            switch (Mode)
            {
                case FrmModes.Display:
                    SetControls(true);
                    btnSaveFrm.Enabled = false;
                    btnSaveFrm.Visible = true;
                    EditedAnimal = -1;
                    break;

                case FrmModes.DisplayLocked:
                    SetControls(false);
                    btnSaveFrm.Visible = false;
                    btnSaveFrm.Enabled = false;
                    btnSaveFrm.Text = "Salvar";
                    EditedAnimal = -1;
                    break;

                case FrmModes.Edit:
                    SetControls(true);
                    btnSaveFrm.Visible = true;
                    btnSaveFrm.Text = "Salvar";
                    break;

                case FrmModes.Create:
                    SetControls(true);
                    Clear();
                    btnSaveFrm.Visible = true;
                    btnSaveFrm.Text = "Cadastrar";
                    EditedAnimal = -1;
                    break;
            }
        }

        private void btnSaveFrm_Click(object sender = null, EventArgs e = null)
        {
            switch (Mode)
            {
                case FrmModes.Edit:
                    control.First(x => x.GetHashCode() == EditedAnimal).Update(GetAnimal());
                    break;

                case FrmModes.Create:
                    control.Add(GetAnimal());
                    break;
            }
        }

       private void chkHasPersonagem_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtPersonagem.Enabled = chkHasPersonagem.Checked;

        private void chkReproducaoHasCorte_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtReproducaoDescricaoCorte.Enabled = chkReproducaoHasCorte.Checked;

        public Animal GetAnimal()
        {
            this.TrimAll();

            var an = new Animal()
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
                Personagem = chkHasPersonagem.Checked ? txtPersonagem.Text : string.Empty,
            };

            if (IsParasita)
            {
                an = new Parasita(an)
                {
                    Hospedeiro = txtParasitaHospedeiro.Text,
                    HospedeiroIntermediario = chkParasitaHospedeiroSecundario.Checked ? txtParasitaHospedeiroSecundario.Text : string.Empty,
                    Prevencao = txtParasitaPrevencao.Text,
                    Contaminacao = txtParasitaContaminacao.Text,
                };
            }

            return an;
        }

        public void SetAnimal(Animal animal)
        {
            Mode = FrmModes.Edit;
            EditedAnimal = animal.GetHashCode();

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

            if (animal is Parasita)
            {
                var pr = (Parasita)animal;

                txtParasitaHospedeiro.Text = pr.Hospedeiro;
                txtParasitaContaminacao.Text = pr.Contaminacao;
                txtParasitaPrevencao.Text = pr.Prevencao;
                
                chkParasitaHospedeiroSecundario.Checked = pr.HasHospedeiroIntermediario;
                txtParasitaHospedeiroSecundario.Text = pr.HospedeiroIntermediario;
            }
            
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

            chkHasPersonagem.Checked = animal.HasPersonagem;
            txtPersonagem.Text = animal.Personagem;
        }

        private void chkHasEpocaSexo_CheckedChanged(object sender = null, EventArgs e = null) => 
            txtEpocaReproducao.Enabled = chkHasEpocaSexo.Checked;

        private void cbFilo_SelectedIndexChanged(object sender = null, EventArgs e = null)
        {
            var filo = cbFilo.SelectedValue as Filo;

            chkHasBoca.Checked = filo != null && filo.HasBoca;
            chkHasAnus.Checked = filo != null && filo.HasAnus;
        }

        private void chkHasBoca_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtDescBoca.Enabled = chkHasBoca.Checked;

        private void chkHasAnus_CheckedChanged(object sender = null, EventArgs e = null) =>
            txtDescAnus.Enabled = chkHasAnus.Checked;

        private string TextAnimal()
        {
            var animal = GetAnimal();
            var toText = new StringBuilder("new ");

            if (IsParasita)
                toText.AppendLine("Parasita()");
            else
                toText.AppendLine("Animal()");

            toText.AppendLine("{");

            toText
                .Append("Nome = ").AppendQuote(animal.Nome)
                .Append("NomeCientifico = ").AppendQuote(animal.NomeCientifico)
                .Append("Personagem = ").AppendQuote(animal.Personagem)
                .Append("InformacoesInuteis = ").AppendQuote(animal.InformacoesInuteis)
                .Append("Bioma = ").AppendQuote(animal.Bioma)
                .Append("Adaptacoes = ").AppendQuote(animal.Adaptacoes)
                .Append("DescricaoMembros = ").AppendQuote(animal.DescricaoMembros)
                .Append("Aparencia = ").AppendQuote(animal.Aparencia)
                .Append("Habitat = ").AppendQuote(animal.Habitat)
                .Append("RegulacaoAgua = ").AppendQuote(animal.RegulacaoAgua)
                .Append("Tipo = ").AppendComma(animal.Tipo.FullName)
                .Append("Filo = ").AppendComma(animal.Filo.FullName)
                .Append("Respiracao = ").AppendComma(animal.Respiracao.FullName);

            if (IsParasita)
            {
                var pr = (Parasita)animal;

                toText
                    .Append("Hospedeiro = ").AppendQuote(pr.Hospedeiro)
                    .Append("HospedeiroIntermediario = ").AppendQuote(pr.HospedeiroIntermediario)
                    .Append("Prevencao = ").AppendQuote(pr.Prevencao)
                    .Append("Contaminacao = ").AppendQuote(pr.Contaminacao);
            }

            toText
                .Append("Alimentacao = ").Append("new Alimentacao(").AppendLine(animal.Filo.FullName + ")")
                .AppendLine("{")
                    .Append("Descricao = ").AppendQuote(animal.Alimentacao.Descricao)
                    .Append("Meio = ").AppendComma(animal.Alimentacao.Meio.FullName)
                    .Append("Tipo = ").AppendComma(animal.Alimentacao.Tipo.FullName)
                    .Append("DescricaoAnus = ").AppendQuote(animal.Alimentacao.DescricaoAnus)
                    .Append("DescricaoBoca = ").AppendQuote(animal.Alimentacao.DescricaoBoca)
                .AppendComma("}")
                .AppendLine("Defesa = new Defesa()")
                .AppendLine("{")
                .Append("Meios = new EDefesa[] { ");

            foreach (var defesa in animal.Defesa.Meios)
                toText.Append(defesa.FullName + ", ");

            toText
                .AppendComma("}")
                .Append("Descricao = ").AppendQuote(animal.Defesa.Descricao)
                .AppendComma("}")
                .AppendLine("Locomocao = new Locomocao()")
                .AppendLine("{")
                .Append("Meio = new ELocomocao[] { ");

            foreach (var locomocao in animal.Locomocao.Meio)
                toText.Append(locomocao.FullName + ", ");

            toText
                .AppendComma("}")
                .Append("Descricao = ").AppendQuote(animal.Locomocao.Descricao)
                .AppendComma("}")
                .AppendLine("DevEmbrionario = new DevEmbrionario()")
                .AppendLine("{")
                    .Append("Meio = ").AppendComma(animal.DevEmbrionario.Meio.FullName)
                    .Append("TipoReproducao = ").AppendComma(animal.DevEmbrionario.TipoReproducao.FullName)
                    .Append("Descricao = ").AppendQuote(animal.DevEmbrionario.Descricao)
                    .Append("DescricaoCorte = ").AppendQuote(animal.DevEmbrionario.DescricaoCorte)
                    .Append("EpocaReproducao = ").AppendQuote(animal.DevEmbrionario.EpocaReproducao)
                .AppendComma("}")
                .AppendLine("};");

            return toText.ToString();
        }

        private void btnCopiarAnimal_Click(object sender = null, EventArgs e = null)
            => Clipboard.SetText(TextAnimal());

        private void cbEMetodoAlimentacao_SelectedIndexChanged(object sender = null, EventArgs e = null)
            => gbParasita.Visible = cbEMetodoAlimentacao.SelectedValue as EMetodoAlimentacao == EMetodoAlimentacao.Parasita;

        private void chkParasitaHospedeiroSecundario_CheckedChanged(object sender = null, EventArgs e = null)
            => txtParasitaHospedeiroSecundario.Enabled = chkParasitaHospedeiroSecundario.Checked;

        private void tabDesenvolvimentoEmbrionario_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e) => Mode = FrmModes.Create;
    }
}
