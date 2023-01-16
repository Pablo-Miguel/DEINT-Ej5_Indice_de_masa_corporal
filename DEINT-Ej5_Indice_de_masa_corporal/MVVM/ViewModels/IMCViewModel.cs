using DEINT_Ej5_Indice_de_masa_corporal.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ej5_Indice_de_masa_corporal.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class IMCViewModel
    {
        public IMCModel Imc { get; set; }
        public IMCViewModel()
        {
            Imc = new IMCModel { 
                Altura = 25,
                Peso = 50
            };
        }



    }
}
