using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euroPlus4_1.Models.Config
{
    class ConfigComunicacao
    {
        //Declarações de propriedades protocolo ethernet
        public ObservableCollection<string> ProtocoloEthernet { get; set; }
        public string EnderecoIP { get; set; }
        public int Porta { get; set;}

        public int TempoLeituraEthernet { get; set; }

        //Declarações de propriedades protocolo serial
        public ObservableCollection<string> ProtocoloSerial { get; set; }
        public ObservableCollection<string> BaudRate { get; set; }
        public ObservableCollection<string> StopBit { get; set; }
        public ObservableCollection<string> Paridade { get; set; }

        public int NumeroEstacao { get; set; }


        public int ProtocoloEthernetSelecionado { get; set; }

        public int ProtocoloSerialSelecionado { get; set; }
        public int BaudRateSelecionado { get; set; }
        public int StopBitSelecionado { get; set; }
        public int ParidadeSelecionado { get; set; }
        public ConfigComunicacao()
        {
            ProtocoloEthernet = new ObservableCollection<string>();
            ProtocoloEthernet.Add("EtherCat ADS");
            ProtocoloEthernet.Add("ModBus TCP");

            ProtocoloSerial = new ObservableCollection<string>();
            ProtocoloSerial.Add("ModBus RTU");

            BaudRate = new ObservableCollection<string>();
            BaudRate.Add("75");
            BaudRate.Add("110");
            BaudRate.Add("134");
            BaudRate.Add("150");
            BaudRate.Add("300");
            BaudRate.Add("600");
            BaudRate.Add("1200");
            BaudRate.Add("1800");
            BaudRate.Add("4800");
            BaudRate.Add("7200");
            BaudRate.Add("9600");
            BaudRate.Add("14400");
            BaudRate.Add("19200");
            BaudRate.Add("38400");
            BaudRate.Add("57600");
            BaudRate.Add("115200");
            BaudRate.Add("128000");

            StopBit = new ObservableCollection<string>();
            StopBit.Add("7");
            StopBit.Add("8");

            Paridade = new ObservableCollection<string>();
            Paridade.Add("Nenhuma");
            Paridade.Add("ímpar");
            Paridade.Add("Par");
        }
    }
}
