using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models.Config
{
    [TypeConverter(typeof(ConfigMaquina))]
    [SettingsSerializeAs(SettingsSerializeAs.String)]
    class ConfigMaquina
    {
        public string NomeDaMaquina { get; set; }
        public string PosicaoNaPlanta { get; set; }
        public string NumeroDeSerie { get; set; }        
        public ObservableCollection<string> TensaoDeEntrada { get; set; }                
        public string Fabricante { get; set; }
        public DateTime AnoDeFabricacao { get; set; }
        public ObservableCollection<string> TipoDeAplicacao { get; set; }
        public int TensaoDeEntradaSelecionado { get; set; }
        public int TipoDeAplicacaoSelecionado { get; set; }

        public ConfigMaquina()
        {            
            TensaoDeEntrada = new ObservableCollection<string>();
            TensaoDeEntrada.Add("12V");
            TensaoDeEntrada.Add("24V");
            TensaoDeEntrada.Add("48V");
            TensaoDeEntrada.Add("110V");
            TensaoDeEntrada.Add("127V");
            TensaoDeEntrada.Add("220V");
            TensaoDeEntrada.Add("230V");
            TensaoDeEntrada.Add("380V");
            TensaoDeEntrada.Add("440V");
            TensaoDeEntrada.Add("760V");

            TipoDeAplicacao = new ObservableCollection<string>();
            TipoDeAplicacao.Add("Máquina standard");
            TipoDeAplicacao.Add("Máquina de teste");
            TipoDeAplicacao.Add("Máquina de injeção");
            TipoDeAplicacao.Add("Máquina de extrusão");
            TipoDeAplicacao.Add("Prensa");
            TipoDeAplicacao.Add("Sistema de monitoramento");
            TipoDeAplicacao.Add("Sistema de replicação");
            TipoDeAplicacao.Add("Sistema de escalonagem");
        }

       
    }
    
}
