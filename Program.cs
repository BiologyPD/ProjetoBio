
using ProjetoBio.Animais;
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
            //AnimalModels.Suindara.ShowJson();
            MessageBox.Show(AnimalModels.Suindara.ToString(), "Informações do animalzinho:");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(AnimalModels.Suindara.ToFrmAnimal());
        }
    }
}
