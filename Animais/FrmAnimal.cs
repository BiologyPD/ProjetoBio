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
            MessageBox.Show(Enum.GetValuesOf<Filo>().ToString());
            InitializeComponent();
            CarregarCB<Respiracao>(cbRespiracao);
            CarregarCB<Filo>(cbFilo);
        }

        private void CarregarCB<T>(ComboBox cb) where T : Enum
        {
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
            cb.DataSource = KeyPair<T>.GetKeyPairs();
            cb.DataSource = Enum.GetValuesOf<T>().Select(e => new { Key = e.Text, Value = e }).ToList();
            cb.DataSource = KeyPair<T>.GetKeyPairs();
            cb.DataSource = KeyPair<Filo>.GetKeyPairs();
            cb.DataSource = KeyPair<T>.GetKeyPairs(Enum.GetValuesOf<T>());
        }

        private void cbFilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(((Enum) cbFilo.SelectedValue).Text);
        }
    }
}
