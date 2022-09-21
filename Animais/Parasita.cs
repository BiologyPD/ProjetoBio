using ProjetoBio.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBio.Animais
{
    class Parasita : Animal
    {
        public string Hospedeiro { get; set; }
        public string HospedeiroIntermediario { get; set; }
        public string Contaminacao { get; set; }
        public string Prevencao { get; set; }
        public bool HasHospedeiroIntermediario => !HospedeiroIntermediario.IsBlank();

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
