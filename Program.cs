
using ProjetoBio.Animais;
using ProjetoBio.Utils;
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
            /*
            var smilinguido = Animais.Animal.smilinguido();
            MessageBox.Show(smilinguido.IsNotNull().ToString(), "Smilinguido tem algo nulo?");
            AnimalModels.Suindara.ShowJson();
            MessageBox.Show(nameof(AnimalModels.Suindara.Tipo));
            MessageBox.Show(EnumExtensions.NameOf(AnimalModels.Suindara.Filo));
            MessageBox.Show(AnimalModels.Suindara.ToString(), "Informações do animalzinho:");
            MessageBox.Show(((Tipo.Parasita as object).GetType() == typeof(Tipo)).ToString());
            MessageBox.Show(AnimalModels.Suindara.Tipo.GetFullName());
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
