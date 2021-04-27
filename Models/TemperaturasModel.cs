using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1
{
    class TemperaturasModel
    {
        public double TemperaturaFluido { get; set; }
        public double TemperaturaCamara { get; set; }
        public double MaxTemperaturaFluido { get; set; }
        public double MinTemperaturaFluido { get; set; }
        public double MaxTemperaturaCamara { get; set; }
        public double MinTemperaturaCamara { get; set; }
        public double OffSetTemperaturaFluido { get; set; }
        public double OffSetTemperaturaCamara { get; set; }
        public double PercentualCoeficienteIntegral { get; set; }
        public int NumeroAmostras { get; set; }
        public double IntervaloAmostras { get; set; }
        public string LeituraTemperaturaFluido { get; set; }
        public string LeituraTemperaturaFluidoAuxiliar { get; set; }
        public string LeituraTemperaturaCamaraSuperior { get; set; }
        public string LeituraTemperaturaCamaraInferior { get; set; }
        public string SaidaControleFluido { get; set; }
        public string SaidaControleCamara { get; set; }

    }
}
