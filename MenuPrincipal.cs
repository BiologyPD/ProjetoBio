using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBio
{
    public partial class MenuPrincipal : Form
    {
     

        private Aqua aqua = new Aqua();
        private List<Aqua> lstAqua = new List<Aqua>(); 
        private BindingSource bsAqua;

        private Air air = new Air();
        private List<Air> lstAir = new List<Air>();
        private BindingSource bsAir;

        private Ground ground = new Ground();
        private List<Ground> lstGround = new List<Ground>();
        private BindingSource bsGround;

        private Parasite parasite = new Parasite();
        private List<Parasite> lstParasite = new List<Parasite>();
        private BindingSource bsParasite;



        public MenuPrincipal()
        {
            InitializeComponent();
            lstAqua = aqua.GeraAnimaisAqua();
            lstAir = air.GeraAnimaisAir();
            lstGround = ground.GeraAnimaisGround();
            lstParasite = parasite.GeraAnimaisParasite();

           
        }

        private void carregaGridAqua()
        {
            bsAqua = new BindingSource();
            bsAqua.DataSource = lstAqua;

            dgAqua.DataSource = bsAqua;
            dgAqua.Refresh();
        }

        private void carregaGridAir()
        {
            bsAir = new BindingSource();
            bsAir.DataSource = lstAir;

            dgAir.DataSource = bsAir;
            dgAir.Refresh();
        }
        
        private void carregaGridGround()
        {
            bsGround = new BindingSource();
            bsGround.DataSource = lstGround;

            dgGround.DataSource = bsGround;
            dgGround.Refresh();
        }

        private void carregaGridParasite()
        {
            bsParasite = new BindingSource();
            bsParasite.DataSource = lstParasite;

            dgParasite.DataSource = bsParasite;
            dgParasite.Refresh();
        }

        private void preparaDgAqua()
        {
            dgAqua.ColumnCount = 4;
            dgAqua.AutoGenerateColumns = false;
            dgAqua.Columns[0].Width = 200;
            dgAqua.Columns[0].HeaderText = "NUMERAÇÃO";
            dgAqua.Columns[0].DataPropertyName = "Num";
            dgAqua.Columns[1].Width = 200;
            dgAqua.Columns[1].HeaderText = "NOME";
            dgAqua.Columns[1].DataPropertyName = "Nome";
            dgAqua.Columns[2].Width = 200;
            dgAqua.Columns[2].HeaderText = "CLASSE";
            dgAqua.Columns[2].DataPropertyName = "Classe";
            dgAqua.AllowUserToAddRows = false;
            dgAqua.AllowUserToDeleteRows = false;
            dgAqua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAqua.MultiSelect = false;
            dgAqua.AllowUserToResizeRows = false;
            carregaGridAqua();
        }

        private void preparaDgAir()
        {
            dgAir.ColumnCount = 4;
            dgAir.AutoGenerateColumns = false;
            dgAir.Columns[0].Width = 200;
            dgAir.Columns[0].HeaderText = "NUMERAÇÃO";
            dgAir.Columns[0].DataPropertyName = "Num";
            dgAir.Columns[1].Width = 200;
            dgAir.Columns[1].HeaderText = "NOME";
            dgAir.Columns[1].DataPropertyName = "Nome";
            dgAir.Columns[2].Width = 200;
            dgAir.Columns[2].HeaderText = "CLASSE";
            dgAir.Columns[2].DataPropertyName = "Classe";
            dgAir.AllowUserToAddRows = false;
            dgAir.AllowUserToDeleteRows = false;
            dgAir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgAir.MultiSelect = false;
            dgAir.AllowUserToResizeRows = false;
            carregaGridAir();
        }

        private void preparaDgGround()
        {
            dgGround.ColumnCount = 4;
            dgGround.AutoGenerateColumns = false;
            dgGround.Columns[0].Width = 200;
            dgGround.Columns[0].HeaderText = "NUMERAÇÃO";
            dgGround.Columns[0].DataPropertyName = "Num";
            dgGround.Columns[1].Width = 200;
            dgGround.Columns[1].HeaderText = "NOME";
            dgGround.Columns[1].DataPropertyName = "Nome";
            dgGround.Columns[2].Width = 200;
            dgGround.Columns[2].HeaderText = "CLASSE";
            dgGround.Columns[2].DataPropertyName = "Classe";
            dgGround.AllowUserToAddRows = false;
            dgGround.AllowUserToDeleteRows = false;
            dgGround.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgGround.MultiSelect = false;
            dgGround.AllowUserToResizeRows = false;
            carregaGridGround();
        }

        private void preparaDgParasite()
        {
            dgParasite.ColumnCount = 4;
            dgParasite.AutoGenerateColumns = false;
            dgParasite.Columns[0].Width = 200;
            dgParasite.Columns[0].HeaderText = "NUMERAÇÃO";
            dgParasite.Columns[0].DataPropertyName = "Num";
            dgParasite.Columns[1].Width = 200;
            dgParasite.Columns[1].HeaderText = "NOME";
            dgParasite.Columns[1].DataPropertyName = "Nome";
            dgParasite.Columns[2].Width = 200;
            dgParasite.Columns[2].HeaderText = "CLASSE";
            dgParasite.Columns[2].DataPropertyName = "Classe";
            dgParasite.AllowUserToAddRows = false;
            dgParasite.AllowUserToDeleteRows = false;
            dgParasite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgParasite.MultiSelect = false;
            dgParasite.AllowUserToResizeRows = false;
            carregaGridParasite();
        }

            private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            preparaDgAqua();
            preparaDgAir();
            preparaDgGround();
            preparaDgParasite();
            dgAir.Enabled = false;
            dgAqua.Enabled = false;
            dgGround.Enabled = false;
            dgParasite.Enabled = false;
        }


        private void pbAqua_Hover(object sender, EventArgs e)
        {
           
          


        }

        private void pbAqua_Click(object sender, EventArgs e)
        {
            AnimaisAqua anAqua = new AnimaisAqua();
            anAqua.Show();
            this.Hide();
        }

        private void dgAqua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?","Alerta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
