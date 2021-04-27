using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using euroPlus4_1.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Threading;
using System.Timers;
using euroPlus4_1.Models.Comm;

namespace euroPlus4_1.ViewModels
{
    class AlarmeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public List<AlarmeModel> ListaDeAlarmes { get; private set; }
        public ObservableCollection<AlarmeModel> ListaDeAlarmesAtivos { get; private set; }        
        int _alarmesAtivos;
        MainWindowViewModel _windowViewModel;
        public ICommand LimpaListaAlarmes { get; set; }

        Thread _atualizarAlarmes;
        public AlarmeViewModel(MainWindowViewModel windowViewModel)
        {
            ListaDeAlarmes = new List<AlarmeModel>();
            ListaDeAlarmesAtivos = new ObservableCollection<AlarmeModel>();
            CriarListaDeAlarmes();
            _windowViewModel = windowViewModel;            

            LimpaListaAlarmes = new RelayCommand(LimparAlarmes);
            _atualizarAlarmes = new Thread(AtualizarAlarmesAtivos);
            _atualizarAlarmes.IsBackground = true;            
            _atualizarAlarmes.Start();
            
        }

        private void _atualizarAlarmes_Elapsed()
        {
            throw new NotImplementedException();
        }


        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
        
        void CriarListaDeAlarmes()
        {
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 7000, Mensagem = "Não existe comunicação com nenhum sistema controlador, o sistema está off-line", DataHora = DateTime.Now.ToString(), Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 1, Mensagem = "Parada de emergência", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 2, Mensagem = "Nenhum modo de ciclo selecionado", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 3, Mensagem = "Tentativa de ultrapassar valor de controle do inversor", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 4, Mensagem = "Temperatura do fluido alta", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 5, Mensagem = "Temperatura do fluido baixa", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 6, Mensagem = "Temperatura da câmara inferior alta", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 7, Mensagem = "Temperatura da câmara inferior baixa", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 8, Mensagem = "Temperatura da câmara superior alta", DataHora = "", Ativo = false });
            ListaDeAlarmes.Add(new AlarmeModel() { Codigo = 9, Mensagem = "Temperatura da câmara superior baixa", DataHora = "", Ativo = false });

        }

        void AtualizarAlarmesAtivos()
        {
            while (true) { 
            if (EtherCAT.CommOK) { 
            
                ListaDeAlarmes[1].Ativo = (bool)EtherCAT.ListaAlarmes[0];
                ListaDeAlarmes[2].Ativo = (bool)EtherCAT.ListaAlarmes[1];
                ListaDeAlarmes[3].Ativo = (bool)EtherCAT.ListaAlarmes[2];
                ListaDeAlarmes[4].Ativo = (bool)EtherCAT.ListaAlarmes[3];
                ListaDeAlarmes[5].Ativo = (bool)EtherCAT.ListaAlarmes[4];
                ListaDeAlarmes[6].Ativo = (bool)EtherCAT.ListaAlarmes[5];
                ListaDeAlarmes[7].Ativo = (bool)EtherCAT.ListaAlarmes[6];
                ListaDeAlarmes[8].Ativo = (bool)EtherCAT.ListaAlarmes[7];
                ListaDeAlarmes[9].Ativo = (bool)EtherCAT.ListaAlarmes[8];


            }
            App.Current.Dispatcher.Invoke((Action)delegate
            {
            ListaDeAlarmesAtivos.Clear();
            foreach (AlarmeModel alarme in ListaDeAlarmes)
            {
                if (alarme.Ativo)
                {
                        if (alarme.DataHora == "") alarme.DataHora = DateTime.Now.ToString();
                        ListaDeAlarmesAtivos.Add(alarme);
                }
                                       
            }
            });
            Thread.Sleep(3000);
                RaiseChange("ListaDeAlarmesAtivos");
                _alarmesAtivos = ListaDeAlarmesAtivos.Count;
                _windowViewModel.AtualizarNumeroAlarmes(_alarmesAtivos);


            }
        }

        void LimparAlarmes(object obj)
        {
            if (EtherCAT.CommOK)
            {
                EtherCAT.ReiniciaAlarmes();
            }

            foreach (var item in ListaDeAlarmesAtivos)
            {
                item.DataHora = "";
            }
                                     
            ListaDeAlarmesAtivos.Clear();
            _alarmesAtivos = ListaDeAlarmesAtivos.Count;
            _windowViewModel.AtualizarNumeroAlarmes(_alarmesAtivos);
            RaiseChange("ListaDeAlarmesAtivos");
        }
    }
}
