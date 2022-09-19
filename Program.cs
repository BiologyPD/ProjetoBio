
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBio    
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var smilinguido = Animais.Animal.smilinguido();
            // MessageBox.Show(smilinguido.IsNotNull().ToString(), "Smilinguido tem algo nulo?");
            var texto = new StringBuilder();
            foreach (var a in typeof(string).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance))
            {
                texto.Append(a.Name);
            }

            MessageBox.Show(texto.ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(smilinguido.ToFrmAnimal());
        }
    }
}
