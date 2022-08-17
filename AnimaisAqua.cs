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
    public partial class AnimaisAqua : Form
    {
        public AnimaisAqua()
        {
            InitializeComponent();
        }

        private void pbNiphates_Click(object sender, EventArgs e)
        {
            Porifero pori = new Porifero();
            pori.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Alerta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbSanguessuga_Click(object sender, EventArgs e)
        {
            Sanguessugas sang = new Sanguessugas();
            sang.Show();
            this.Hide();
        }
    }
}
