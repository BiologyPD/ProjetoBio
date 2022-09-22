using ProjetoBio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBio.Animais
{
    class Parasita : Animal
    {
        public string Hospedeiro { get; set; }
        public string HospedeiroIntermediario { get; set; }
        public string Contaminacao { get; set; }
        public string Prevencao { get; set; }
        public bool HasHospedeiroIntermediario => !HospedeiroIntermediario.IsBlank();

        public Parasita(Animal an)
        {
            var parasiteProprieties = typeof(Parasita).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            var animalProprieties = typeof(Animal).GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly);
            
            var animalPropsString = new StringBuilder();
            foreach (var prop in animalProprieties)
                animalPropsString.AppendLine(prop.Name);
            MessageBox.Show(animalPropsString.ToString());

            var parasitePropsString = new StringBuilder();
            foreach (var prop in parasiteProprieties)
                parasitePropsString.AppendLine(prop.Name);
            MessageBox.Show(parasitePropsString.ToString());

            foreach (var propriety in animalProprieties)
            {
                try {
                    parasiteProprieties.First(x => x.Name == propriety.Name).SetValue(this, propriety.GetValue(an));
                } catch { }
            }
        }

        public override string ToString()
        {
            var toText = new StringBuilder(base.ToString());
            toText
                .AppendLine()
                .AppendLine("PARASITA")
                .Append("Hospedeiro:  ").AppendLine(Hospedeiro);

            if (HasHospedeiroIntermediario)
                toText.Append("Hospedeiro intermediário:  ").AppendLine(HospedeiroIntermediario);

            toText.Append("Prevenção:  ").AppendLine(Prevencao);

            return toText.ToString();
        }
    }
}
