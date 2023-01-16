using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej5_Indice_de_masa_corporal.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class IMCModel
    {

        private int altura = 25;
        private int peso = 50;

        public int Altura { get => altura; set {
                altura = value;
                calculateIMC(value, Peso);
            }
        }
        public int Peso { get => peso; set {
                peso = value;
                calculateIMC(Altura, value);
            }
        }
        public double ImcResultado { get; set; } = 3.5;
        public string ImcDescrp { get; set; } = "Delgadez Severa";

        public void calculateIMC(int altura, int peso) { 
            ImcResultado = peso / Math.Pow(altura, 2);

            if (ImcResultado < 16) ImcDescrp = "Delgadez Severa";
            else if (16 <= ImcResultado && ImcResultado < 17) ImcDescrp = "Delgadez Moderada";
            else if (17 <= ImcResultado && ImcResultado < 18.5) ImcDescrp = "Delgadez Ligera";
            else if (18.5 <= ImcResultado && ImcResultado < 25) ImcDescrp = "Normal";
            else if (25 <= ImcResultado && ImcResultado < 30) ImcDescrp = "Sobrepeso";
            else if (30 <= ImcResultado && ImcResultado < 35) ImcDescrp = "Obesidad Clase I";
            else if (35 <= ImcResultado && ImcResultado < 40) ImcDescrp = "Obesidad Clase II";
            else if (ImcResultado >= 40) ImcDescrp = "Obesidad Clase III";

        }
        
    }
}
