using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    class VisaoGeralModel
    {
        public string PressaoAtualEstacoes { get; set; }
        public string PressaoMaximaSelecionada { get; set; }
        public string PressaoMinimaSelecionada { get; set; }        
        public string Temperaturas { get; set; }
        public string AjusteParaFluido { get; set; }
        public string AjusteParaCamara { get; set; }
        public string EstadoDaBomba { get; set; }       
        public string AjusteVazao { get; set; }
        public string AjusteMaximoPressao { get; set; }
        public string CiclosDeRepeticao { get; set; }
        public string AjusteFrequencia { get; set; }
        public string QuantidadeCiclos { get; set; }
        public string QuantidadeCiclosRealizados { get; set; }
        public string UnidadeDePressao { get; set; }

        public double Vazao { get; set; }
        public double Pressao { get; set; }

        public double VazaoMaximaGauge { get; set; }
        public double PressaoMaximaGauge { get; set; }
        public double FrequenciaMaxima { get; set; }
        public double FrequenciaAtual { get; set; }

    }
}
