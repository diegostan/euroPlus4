using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models
{
    class AlarmeModel
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
        public string DataHora { get; set; }
        public bool Ativo { get; set; }
    }
}
