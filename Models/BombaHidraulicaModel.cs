using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    class BombaHidraulicaModel
    {
        public int PercentualDeVazão { get; set; }

        public string VazaoAtualBomba { get; set; }

        public int VazaoMaximaBomba { get; set; }

        public int FrequenciaMaximaBomba { get; set; }

        public int TensaoControleMaxima { get; set; }
        public int TensaoControleMinima { get; set; }

        public string LeituraVazaoAtual { get; set; }

        public string LeituraFrequenciaAtual { get; set; }
        public string LeituraTensaoControleAtual { get; set;}

    }
}
