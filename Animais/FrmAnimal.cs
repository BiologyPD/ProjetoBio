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
            CarregarCB<Respiracao>(cbRespiracao);
            CarregarCB<Filo>(cbFilo);
        }

        private void CarregarCB<T>(ComboBox cb) where T : Enum
        {
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
            cb.DataSource = KeyPair.GetKeyPairs<T>();
        }
    }
}
