using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;



namespace euroPlus4_1.Models.Config
{
    class ConfigDados
    {        
        public ObservableCollection<string> TipoBancoDeDados { get; set; }

        public int TipoBancoDeDadosSelecionado { get; set; }
        public string EnderecoProvedor { get; set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public ObservableCollection<string> BancosDisponiveis { get; set; }

        public string NomeBaseDeDados { get; set; }
        public int Porta { get; set; }

        public bool BancoEuroPlus { get; set; }
        public Visibility BancoEuroPlusProcessando { get; set; }

        public ConfigDados()
        {            
            TipoBancoDeDados = new ObservableCollection<string>();
            TipoBancoDeDados.Add("Microsoft SQL Server");
            BancoEuroPlusProcessando = new Visibility();
            BancoEuroPlusProcessando = Visibility.Hidden;
        }
    }
}
