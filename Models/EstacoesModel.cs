using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    class EstacoesModel
    {
        public double PressaoMaxima { get; set; }
        public double PressaoMinima { get; set; }
        public int NumeroDeCiclos { get; set; }        
        public bool LigarMaximo { get; set; }
        public bool DesligarMinimo { get; set; }        
        public int EscalaMaxima { get; set; }
        public int EscalaMinima { get; set; }
        public double PressaoMaximaTransmissor { get; set; }
        public double PressaoMinimaTransmissor { get; set; }
        public int UnidadeDePressao { get; set; }

        public ObservableCollection<string> UnidadePressaoDisponivel { get; private set; }

        public EstacoesModel()
        {
            UnidadePressaoDisponivel = new ObservableCollection<string>();
            UnidadePressaoDisponivel.Add("MPa");
            UnidadePressaoDisponivel.Add("Kgf/cm²");
            UnidadePressaoDisponivel.Add("Lb/pol²");
        }
    }
}
