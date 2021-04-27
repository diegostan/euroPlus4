using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Comm;
using euroPlus4_1.Properties;
using MahApps.Metro.Controls.Dialogs;

namespace euroPlus4_1.ViewModels
{

    class MainWindowViewModel : INotifyPropertyChanged
    {
        public string DataAtual { get; private set; }
        public string HoraAtual { get; private set; }

        public string VazaoAtual { get; private set; }

        public string PressaoAtual { get; private set; }

        public string AquecimentoFluido { get; private set; }
        public string AquecimentoCamara { get; private set; }
        public string EstadoDaMaquina { get; private set; }
        public string EstadoDaMaquinaIcone { get; private set; }
        public string ModoDeOperacao { get; private set; }
        public string ModoDeOperacaoIcone { get; private set; }
        public string StatusConexao { get; private set; }

        public object AlarmesAtivos { get; set; }

        public Visibility Alarme { get; set; }

        int _tempoReconexao=0;
        public TelasModel Telas { get; set; }

        MainWindow _window;

        Thread tLeituras;
        Thread tReconectar;

        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();    


        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowViewModel(MainWindow main)
        {
            _window = main;
            Telas = new TelasModel();
            tLeituras = new Thread(Timer_Elapsed);
            Alarme = new Visibility();
            tReconectar = new Thread(Timer_Reconectar);            
            tReconectar.IsBackground = true;
            tReconectar.Start();
            tLeituras.IsBackground = true;
            tLeituras.Start();
            Task.Run(()=>Conectar());
            

        }
        private void Timer_Reconectar()
        {
            while (true)
            {
            
                if (_tempoReconexao >= 30) _tempoReconexao = 0;
                _tempoReconexao++;
            
                if (EtherCAT.CommOK) 
                {
                    StatusConexao = "Comunicaç" +
                           "ão estabelecida";
                    RaiseChange("StatusConexao");                    
                }
                else
                {                                                    
                    StatusConexao = string.Format("Falha de conexão ({0})", (30 - _tempoReconexao) / 2);
                    RaiseChange("StatusConexao");
                }

                if (_tempoReconexao>=30 && EtherCAT.CommOK==false)
                {
                    EtherCAT.ConectarAMS();
                    Thread.Sleep(1000);
                }
                Thread.Sleep(500);
            }
        }

        private  void Timer_Elapsed()
        {
            while (true)
            {
            
                DataAtual = DateTime.Now.ToShortDateString();
                HoraAtual = DateTime.Now.ToShortTimeString();
                try
                {
                    if (EtherCAT.CommOK && EtherCAT.ListaLeituras.Count >= 2) VazaoAtual = (string)(EtherCAT.ListaLeituras[1] + " L/Min");
                    if (EtherCAT.CommOK && EtherCAT.ListaLeituras.Count >= 3) PressaoAtual = (string)(EtherCAT.ListaLeituras[3] + " " + Settings.Default.C_UnidadePressao);
                    if (EtherCAT.CommOK == false)
                    {
                        VazaoAtual = "0 L/Min";
                        PressaoAtual = "0 " + Settings.Default.C_UnidadePressao;
                    }
                    ModoDeOperacao = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[10]) ? " Modo automático" : "Modo manual";
                    ModoDeOperacaoIcone = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[10]) ? "Refresh" : "Hand";
                    EstadoDaMaquina = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[11]) ? "Teste de repetição iniciado" : "Aguardando inicio de ciclo";
                    EstadoDaMaquinaIcone = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[11]) ? "Pulse" : "AlarmCheck";
                    AquecimentoFluido = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[12]) ? "Fluido: ligado" : "Fluido: desligado";
                    AquecimentoCamara = (EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[13]) ? "Câmara: ligado" : "Câmara: desligado";
                }
                catch
                {
                    VazaoAtual = "0 L/Min";
                    PressaoAtual = "0 " + Settings.Default.C_UnidadePressao;
                    ModoDeOperacao = "Modo manual";
                    EstadoDaMaquina = "Aguardando inicio de ciclo";
                    AquecimentoFluido = "Fluido: desligado";
                    AquecimentoCamara = "Câmara: desligado";
                    ModoDeOperacaoIcone = "Hand";
                    EstadoDaMaquinaIcone = "AlarmCheck";
                }
                RaiseChange("DataAtual");
                RaiseChange("HoraAtual");
                RaiseChange("VazaoAtual");
                RaiseChange("PressaoAtual");
                RaiseChange("ModoDeoperacao");
                RaiseChange("ModoDeoperacaoIcone");
                RaiseChange("EstadoDaMaquina");
                RaiseChange("EstadoDaMaquinaIcone");
                RaiseChange("AquecimentoFluido");
                RaiseChange("AquecimentoCamara");
                Thread.Sleep(500);
            }

        }

         async void Conectar()
        {

            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

           
                if (EtherCAT.ConectarAMS())
                {
                    StatusConexao = "Comunicaç" +
                    "ão estabelecida";
                    RaiseChange("StatusConexao");
                
                    return;
                }            
                else
                {                   
                    StatusConexao = "Falha de comunicação";
                    RaiseChange("StatusConexao");
                }
            
        }
        

        public void AtualizarNumeroAlarmes(int i)
        {
            if (i == 0)
            {
                AlarmesAtivos = null;
                RaiseChange("Alarme");
                RaiseChange("AlarmesAtivos");
            }
            else
            {
                Alarme = Visibility.Visible;
                AlarmesAtivos = (int)i;
                RaiseChange("Alarme");
                RaiseChange("AlarmesAtivos");
            }
            
        }


        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public async Task<ObservableCollection<TelasModel>> AtualizaTelas()
        {

            ObservableCollection<TelasModel> _listaTelas = new ObservableCollection<TelasModel>();
            try
            {
                _listaTelas = await Telas.RetornaTelas();
                return _listaTelas;
            }
            catch
            {
                return null;
            }
            
        }

    }
}
