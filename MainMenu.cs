using ProjetoBio.Animais;
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
    public partial class MainMenu : Form
    {
        private int childFormNumber = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e) => FrmAnimal.GetInstance(AnimalModels.Suindara).MdiParent = this;

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var message = MessageBox.Show(
                "Davi Macedo"
                + "\nIsabela Silvestre"
                + "\nLuanna Sachinelli"
                + "\nPedro Augusto"
                + "\nRenato de Oliveira"
                , "Autores:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (message == DialogResult.Cancel)
                MessageBox.Show("uwu");
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e) => AnimalSearch.GetInstance().MdiParent = this;
    }
}
