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




        public MenuPrincipal()
        {
            InitializeComponent();
            lstAqua = aqua.GeraAnimais();
        }

        private void carregaGridAnimais()
        {
            bsAqua = new BindingSource();
            bsAqua.DataSource = lstAqua;

            dgAqua.DataSource = bsAqua;
            dgAqua.Refresh();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
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
            grpDg.Enabled = false;
            carregaGridAnimais();
           
        
      
        }


        private void pbAqua_Hover(object sender, EventArgs e)
        {
           
          


        }

        private void pbAqua_Click(object sender, EventArgs e)
        {
            Porifero pori = new Porifero();
            pori.Show();
            this.Hide();
        }

        private void dgAqua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
