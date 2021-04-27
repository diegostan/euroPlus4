using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ControlzEx.Theming;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Comm;
using euroPlus4_1.Properties;

namespace euroPlus4_1.ViewModels
{
    class BombaHidraulicaViewModel: INotifyPropertyChanged
    {
        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }

        public BombaHidraulicaModel BombaHidraulica { get; set; }
     
        public ICommand ApresentarMensagem { get; set; }

        public ICommand EnviarPercentualVazao { get; set; }
        
        public ICommand EnviarConfiguracaoBomba { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        MainWindow _window;
        List<object> _leiturasBombaHidraulica;

        Task _taskLeitura;
        
        bool _recuperacaoDeDadosOk;

        public BombaHidraulicaViewModel(MainWindow main)
        {
            BombaHidraulica = new BombaHidraulicaModel();   
            _window = main;
            //
            _recuperacaoDeDadosOk = false;
            RecuperaDadosControlador();

            ApresentarMensagem = new RelayCommand(ApresentaMensagem);
            EnviarPercentualVazao = new RelayCommand(EnviaPercentualVazao);
            EnviarConfiguracaoBomba = new RelayCommand(EnviaConfiguracaoBomba);

            _taskLeitura = new Task(Timer_Elapsed1);
            _taskLeitura.Start();
                               
        }
      
        
            private void Timer_Elapsed1()
            {

            while (true)
            {
                try
                {
                    if (EtherCAT.CommOK)
                    {
                        _leiturasBombaHidraulica = EtherCAT.ListaLeituras;
                        BombaHidraulica.LeituraFrequenciaAtual = ((int)_leiturasBombaHidraulica[0] + " Hz").ToString();
                        BombaHidraulica.LeituraVazaoAtual = ((int)_leiturasBombaHidraulica[1] + " L/Min").ToString();
                        BombaHidraulica.LeituraTensaoControleAtual = ((int)_leiturasBombaHidraulica[2] + " mV").ToString();                        
                        if (_recuperacaoDeDadosOk == false || EtherCAT.CarregamentoDeDados == true) RecuperaDadosControlador();
                        VisaoGeralStaticModel.AjusteVazao = BombaHidraulica.PercentualDeVazão.ToString() + " %";
                        VisaoGeralStaticModel.AjusteMaximoVazao = BombaHidraulica.VazaoMaximaBomba.ToString();
                        VisaoGeralStaticModel.FrequenciaMaxima = BombaHidraulica.FrequenciaMaximaBomba.ToString();
                        VisaoGeralStaticModel.FrequenciaAtual = _leiturasBombaHidraulica[0].ToString();

                        RaiseChange("BombaHidraulica");
                        
                        
                        
                        
                        
                    }
                    else
                    {
                        _leiturasBombaHidraulica = EtherCAT.ListaLeituras;
                        BombaHidraulica.LeituraFrequenciaAtual = "0 Hz";
                        BombaHidraulica.LeituraVazaoAtual = "0 L/Min";
                        BombaHidraulica.LeituraTensaoControleAtual = "0 mV";
                        _recuperacaoDeDadosOk = false;
                        RaiseChange("BombaHidraulica");
                    }
                }
                catch
                {
                    _leiturasBombaHidraulica = EtherCAT.ListaLeituras;
                    BombaHidraulica.LeituraFrequenciaAtual = "-- Hz";
                    BombaHidraulica.LeituraVazaoAtual = "-- L/Min";
                    BombaHidraulica.LeituraTensaoControleAtual = "-- mV";
                    RaiseChange("BombaHidraulica");
                    _recuperacaoDeDadosOk = false;
                }
                System.Threading.Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
            }
        }

          public void RecuperaDadosControlador()
        {
            if (EtherCAT.CommOK)
            {
                List<object> listValues = EtherCAT.InicializarVariaveisBombaHidraulica();
                BombaHidraulica.VazaoMaximaBomba = (int)listValues[0];
                BombaHidraulica.FrequenciaMaximaBomba = (int)listValues[1];
                BombaHidraulica.TensaoControleMinima = (int)listValues[2];
                BombaHidraulica.TensaoControleMaxima = (int)listValues[3];
                BombaHidraulica.PercentualDeVazão = (int)listValues[4];
                RaiseChange("BombaHidraulica");
                _recuperacaoDeDadosOk = true;
            }
        }

        //Metodos--------------------------------------------------------------------------------------------------------------------------------
        void EnviaPercentualVazao(object obj)
        {
            Task.Run(() => EnviaPercentualVazaoTask());     
        }

        void EnviaConfiguracaoBomba(object obj)
        {
            Task.Run(() => EnviaConfiguracaoBombaTask());
        }
        
        //Fim metodos----------------------------------------------------------------------------------------------------------------------------
        
        //Metodos task---------------------------------------------------------------------------------------------------------------------------
        void EnviaPercentualVazaoTask()
        {
            if (EtherCAT.EnviarPercentualVazao(BombaHidraulica.PercentualDeVazão))
            {
                ConteudoMensagem = "Valores enviados.";                
                ApresentaMensagem(null);                
            }
            else
            {
                ConteudoMensagem = "Falha no envio de dados, não existe comunicação disponível ou dados incorretos.";
                ApresentaMensagem(null);
            }
        }

        void EnviaConfiguracaoBombaTask()
        {
            List<object> listValues = new List<object>();
            listValues.Add((int)BombaHidraulica.VazaoMaximaBomba);
            listValues.Add((int)BombaHidraulica.FrequenciaMaximaBomba);
            listValues.Add((int)BombaHidraulica.TensaoControleMinima);
            listValues.Add((int)BombaHidraulica.TensaoControleMaxima);

            if (EtherCAT.EnviarConfiguracoesBomba(listValues))
            {
                ConteudoMensagem = "Valores enviados.";
                ApresentaMensagem(null);
            }
            else
            {
                ConteudoMensagem = "Falha no envio de dados, não existe comunicação disponível ou dados incorretos.";
                ApresentaMensagem(null);
            }
        }
        //Fim metodos task

        //Apresentação de Mensagem de pop-up-----------------------------------------------------------------------------------------------------
        void ApresentaMensagem(object obj)
        {
            
            MostrarMensagem = true;
            RaiseChange("ConteudoMensagem");
            RaiseChange("MostrarMensagem");

        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            
        }

        //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
    
        
    }
}

