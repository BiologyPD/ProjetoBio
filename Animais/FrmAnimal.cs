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
            cbFilo.DataSource(Filo);
        }

        private void cbFilo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
