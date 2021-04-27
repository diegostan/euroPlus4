using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using euroPlus4_1.Models;
using System.Windows.Input;
using euroPlus4_1.Models.Comm;
using euroPlus4_1.Properties;
using System.Windows.Data;

namespace euroPlus4_1.ViewModels
{
    class TemposFrequenciasViewModel : INotifyPropertyChanged
    {
        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }
        public TemposFrequenciasModel TemposFrequencias { get; set; }

        public ICommand EnviarAjsutesFrequencia { get; set; }

        MainWindow _window;
        Task _taskLeitura;
        bool _recuperacaoDeDadosOk;

        public event PropertyChangedEventHandler PropertyChanged;

        public TemposFrequenciasViewModel(MainWindow main)
        {
            _window = main;
            EnviarAjsutesFrequencia = new RelayCommand(EnviaAjustesFrequencia);
            TemposFrequencias = new TemposFrequenciasModel();
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
                      
                        if (_recuperacaoDeDadosOk == false || EtherCAT.CarregamentoDeDados == true) RecuperaDadosControlador();
                        RaiseChange("TemposFrequencias");
                        VisaoGeralStaticModel.AjusteFrequencia = TemposFrequencias.Frequencia.ToString();
                        

                    }
                 
                }
                catch
                {
                    _recuperacaoDeDadosOk = false;
                }
                System.Threading.Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
            }
        }

        public void RecuperaDadosControlador()
        {
            if (EtherCAT.CommOK)
            {
                List<object> listValues = EtherCAT.InicializarVariaveisTemposFrequencias();
                TemposFrequencias.Frequencia = (double)listValues[0];
                TemposFrequencias.TempoDeCirculacao = (double)listValues[1];
               
                RaiseChange("TemposFrequencias");
                _recuperacaoDeDadosOk = true;
            }
        }

        //Inicio metodos
        void EnviaAjustesFrequencia(object obj)
        {
            Task.Run(() => EnviaAjustesFrequenciaTask());
        }
        //--------------------------------------------------------------------------------------------------------------------------------------

        //Inicio metodos task
        void EnviaAjustesFrequenciaTask()
        {
            List<object> listValues = new List<object>();
            listValues.Add((double)TemposFrequencias.Frequencia);
            listValues.Add((double)TemposFrequencias.TempoDeCirculacao);
           

            if (EtherCAT.EnviarAjusteTemposFrequencias(listValues))
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
        //---------------------------------------------------------------------------------------------------------------------------------------

        //Apresentação de Mensagem de pop-up-----------------------------------------------------------------------------------------------------
        void ApresentaMensagem(object obj)
        {

            MostrarMensagem = true;
            RaiseChange("ConteudoMensagem");
            RaiseChange("MostrarMensagem");

        }
        //---------------------------------------------------------------------------------------------------------------------------------------

        //Raise Change 
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //Fim raise Change -----------------------------------------------------------------------------------------------------------------------
    }
}
