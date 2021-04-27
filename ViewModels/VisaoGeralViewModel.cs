using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using System.ComponentModel;
using euroPlus4_1.Models;
using System.Threading;
using euroPlus4_1.Properties;
using System.Windows.Input;
using euroPlus4_1.Models.Comm;
using LiveCharts.Charts;
using LiveCharts.Defaults;
using System.Runtime.InteropServices;
using LiveCharts.Configurations;

namespace euroPlus4_1.ViewModels
{
    class VisaoGeralViewModel : INotifyPropertyChanged
    {
        
        public VisaoGeralModel VisaoGeral { get; set; }

        public string IniciadoPor { get; set; }
        public string HoraPartida { get; set; }
        public string CiclosEstipulados { get; set; }
        public string EstadoAtual { get; set; }

        public int VazaoGaugeStep { get; set; }
        public int PressaoGaugeStep { get; set; }
        public ICommand InicioDeCiclo { get; set; }

        public ChartValues<double> GraficoPressao { get; set; }
        public ChartValues<double> GraficoEstacao { get; set; }
        public ChartValues<double> GraficoCamara { get; set; }
        double _valoresPressao;
        double _valoresEstacoes;
        double _valoresCamara;


        LineSeries lineSeriesPressao = new LineSeries();
        Task _leiturasTask;
        Task _graficosTask;
        MainWindow _window;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public VisaoGeralViewModel(MainWindow main)
        {
            _window = main;
            VisaoGeral = new VisaoGeralModel();
            GraficoPressao = new ChartValues<double>();
            GraficoEstacao = new ChartValues<double>();
            GraficoCamara = new ChartValues<double>();
            InicioDeCiclo = new RelayCommand(IniciaCiclo);            
             
            VisaoGeral.PressaoMaximaGauge = 5;
            VisaoGeral.VazaoMaximaGauge = 10;
            VisaoGeral.FrequenciaMaxima = 50;
            RaiseChange("VisaoGeral");
            
            lineSeriesPressao.PointGeometrySize = 2;
            lineSeriesPressao.AreaLimit = -10;
            lineSeriesPressao.LineSmoothness = 1;
            lineSeriesPressao.Title = "Pressão";
          

            _leiturasTask = new Task(LerVariaveis);
            _graficosTask = new Task(AtualizaGraficos);
                    
            _leiturasTask.Start();            
            _graficosTask.Start();
        }

      
        //Inicio de ciclo
        void IniciaCiclo(object obj)
        {
            if (EtherCAT.EnviarInicioDeCiclo())
            {
                IniciadoPor = _window.UsuarioCorrente;
                HoraPartida = DateTime.Now.ToString();
                EstadoAtual = "Iniciado";
                CiclosEstipulados = VisaoGeralStaticModel.QuantidadeCiclos;
                RaiseChange("IniciadoPor");
                RaiseChange("HoraPartida");
                RaiseChange("EstadoAtual");
                RaiseChange("CiclosEstipulados");
            }
        }

        //Graficos
        void AtualizaGraficos()
        {            
            ChartValues<double> Valor = new ChartValues<double>();
            Random r = new Random();
            Random r1 = new Random();
            Random r2 = new Random();
            while (true)
            {
                App.Current.Dispatcher.Invoke((Action)delegate
                {
                    if ((EtherCAT.CommOK && (bool)EtherCAT.ListaLeituras[11]))
                    {
                        _valoresPressao = r.Next(50, 100);
                        GraficoPressao.Add(_valoresPressao);
                        if (GraficoPressao.Count > 50) GraficoPressao.RemoveAt(0);
                        Thread.Sleep(100);
                        _valoresEstacoes = r1.Next(118, 125);
                        GraficoEstacao.Add(_valoresEstacoes);
                        if (GraficoEstacao.Count > 50) GraficoEstacao.RemoveAt(0);
                        Thread.Sleep(100);
                        _valoresCamara = r1.Next(50, 60);
                        GraficoCamara.Add(_valoresCamara);
                        if (GraficoCamara.Count > 50) GraficoCamara.RemoveAt(0);
                    }
                });

                RaiseChange("GraficoPressao");
                RaiseChange("GraficoEstacao");

                Thread.Sleep(2000);
            }
            
        }

        //Leituras
        void LerVariaveis()
        {
            while (true)
            {
                if (EtherCAT.CommOK) { 
                try
                {
                    VisaoGeral.AjusteFrequencia = VisaoGeralStaticModel.AjusteFrequencia + " Hz";
                    VisaoGeral.AjusteMaximoPressao = VisaoGeralStaticModel.AjusteMaximoPressao + " " + VisaoGeralStaticModel.UnidadeDePressao;
                    VisaoGeral.AjusteParaCamara = VisaoGeralStaticModel.AjusteParaCamara + " °C";
                    VisaoGeral.AjusteParaFluido = VisaoGeralStaticModel.AjusteParaFluido + " °C";
                    VisaoGeral.AjusteVazao = VisaoGeralStaticModel.AjusteVazao;
                    VisaoGeral.CiclosDeRepeticao = VisaoGeralStaticModel.CiclosDeRepeticao;
                    VisaoGeral.PressaoAtualEstacoes = VisaoGeralStaticModel.PressaoAtualEstacoes + " " + VisaoGeralStaticModel.UnidadeDePressao;
                    VisaoGeral.EstadoDaBomba = VisaoGeralStaticModel.VazaoBomba + " L/min";
                    VisaoGeral.PressaoMaximaSelecionada = VisaoGeralStaticModel.PressaoMaximaSelecionada + " " + VisaoGeralStaticModel.UnidadeDePressao;
                    VisaoGeral.PressaoMinimaSelecionada = VisaoGeralStaticModel.PressaoMinimaSelecionada + " " + VisaoGeralStaticModel.UnidadeDePressao;
                    VisaoGeral.QuantidadeCiclos = VisaoGeralStaticModel.QuantidadeCiclos;
                    VisaoGeral.Temperaturas = VisaoGeralStaticModel.TemperaturaFluido + " °C - " + VisaoGeralStaticModel.TemperaturaCamara + " °C";
                    VisaoGeral.QuantidadeCiclosRealizados = VisaoGeralStaticModel.QuantidadeCiclosRealizados;
                    VisaoGeral.Vazao = Convert.ToDouble(VisaoGeralStaticModel.VazaoBomba);
                    VisaoGeral.Pressao = Convert.ToDouble(VisaoGeralStaticModel.PressaoAtualEstacoes);
                    VisaoGeral.PressaoMaximaGauge = Convert.ToDouble(VisaoGeralStaticModel.PressaoMaximaSelecionada);
                    VisaoGeral.VazaoMaximaGauge = Convert.ToDouble(VisaoGeralStaticModel.AjusteMaximoVazao);
                    VisaoGeral.FrequenciaMaxima = Convert.ToDouble(VisaoGeralStaticModel.FrequenciaMaxima);
                    VisaoGeral.FrequenciaAtual = Convert.ToDouble(VisaoGeralStaticModel.FrequenciaAtual);
                    VazaoGaugeStep = (int)((VisaoGeral.VazaoMaximaGauge / 5));
                    PressaoGaugeStep = 5;


                }
                catch
                {
                    VisaoGeral = null;
                }

                }

                Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
                RaiseChange("VisaoGeral");

            }
            

        }

        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
    }
}
