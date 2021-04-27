using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    static class VisaoGeralStaticModel
    {
        public static string PressaoAtualEstacoes { get; set; } //
        public static string PressaoMaximaSelecionada { get; set; } //
        public static string PressaoMinimaSelecionada { get; set; } //
        public static string TemperaturaFluido { get; set; } //
        public static string TemperaturaCamara { get; set; } //
        public static string AjusteParaFluido { get; set; }
        public static string AjusteParaCamara { get; set; }
        public static string VazaoBomba { get; set; } //
        public static string PressaoBomba { get; set; }//
        public static string AjusteVazao { get; set; }
        public static string AjusteMaximoPressao { get; set; }
        public static string AjusteMaximoVazao { get; set; }
        public static string CiclosDeRepeticao { get; set; }
        public static string AjusteFrequencia { get; set; }
        public static string QuantidadeCiclos { get; set; } //
        public static string QuantidadeCiclosRealizados { get; set; } //
        public static string UnidadeDePressao { get; set; } //
        public static string FrequenciaMaxima { get; set; } //
        public static string FrequenciaAtual { get; set; } //

        public static int Vazao { get; set; }
        public static double Pressao { get; set; }

    }
}
