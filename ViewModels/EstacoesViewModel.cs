using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Comm;
using System.Windows.Input;
using System.Timers;
using euroPlus4_1.Properties;
using System.Threading;

namespace euroPlus4_1.ViewModels
{
    class EstacoesViewModel : INotifyPropertyChanged
    {
        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }
        public EstacoesModel Estacoes { get; set; }

        public string LeituraPressao { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand EnviarValoresAjuste { get; set; }
        public ICommand EnviarValoresTolerancia { get; set; }
        public ICommand EnviarValoresConfiguracao { get; set; }

        List<object> _listaEstacoes;
        bool _recuperacaoDeDadosOk;

        Thread _tLeitura;

        public EstacoesViewModel()
        {
            Estacoes = new EstacoesModel();
            EnviarValoresAjuste = new RelayCommand(EnviaValoresAjuste);
            EnviarValoresTolerancia = new RelayCommand(EnviaValoresTolerancia);
            EnviarValoresConfiguracao = new RelayCommand(EnviaValoresConfiguracao);
            _recuperacaoDeDadosOk = false;
            RecuperaDadosControlador();

            _tLeitura = new Thread(_timer_Elapsed);
            _tLeitura.IsBackground = true;
            _tLeitura.Start();
        }

        private void _timer_Elapsed()
        {
           
            while (true)
            {
                try
                {

                    if (EtherCAT.CommOK)
                    {
                        _listaEstacoes = EtherCAT.ListaLeituras;
                        LeituraPressao = ((string)_listaEstacoes[3]) + " " + Estacoes.UnidadePressaoDisponivel[Estacoes.UnidadeDePressao].ToString();
                        RaiseChange("LeituraPressao");                        
                        if (_recuperacaoDeDadosOk == false || EtherCAT.CarregamentoDeDados == true) RecuperaDadosControlador();
                        VisaoGeralStaticModel.AjusteMaximoPressao = Estacoes.PressaoMaximaTransmissor.ToString();
                        VisaoGeralStaticModel.QuantidadeCiclos = Estacoes.NumeroDeCiclos.ToString();
                        VisaoGeralStaticModel.PressaoMaximaSelecionada = Estacoes.PressaoMaxima.ToString();
                        VisaoGeralStaticModel.PressaoMinimaSelecionada = Estacoes.PressaoMinima.ToString();
                        VisaoGeralStaticModel.UnidadeDePressao = Estacoes.UnidadePressaoDisponivel[Estacoes.UnidadeDePressao].ToString();
                    }
                    else
                    {
                        _listaEstacoes = EtherCAT.ListaLeituras;
                        LeituraPressao = "0" + " " + Estacoes.UnidadePressaoDisponivel[Estacoes.UnidadeDePressao].ToString();
                        RaiseChange("LeituraPressao");
                        _recuperacaoDeDadosOk = false;
                    }
                }

                  catch
                   {
                   _listaEstacoes = EtherCAT.ListaLeituras;
                   LeituraPressao = "-- " + Estacoes.UnidadePressaoDisponivel[Estacoes.UnidadeDePressao].ToString(); 
                   RaiseChange("LeituraPressao");
                    _recuperacaoDeDadosOk = false;
                }
                System.Threading.Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
            }
        }

            //Inicio dos comandos-------------------------------------------------------------------------------------------------------------------
            void EnviaValoresAjuste(object obj)
            {
                Task.Run(() => EnviaValoresAjusteTask());
            }
            void EnviaValoresTolerancia(object obj)
            {
                Task.Run(() => EnviaValoresToleranciaTask());
            }
            void EnviaValoresConfiguracao(object obj)
            {
                Task.Run(() => EnviaValoresConfiguracaoTask());
            }
            //--------------------------------------------------------------------------------------------------------------------------------------

            //Inicio dos comandos task---------------------------------------------------------------------------------------------------------------
            void EnviaValoresAjusteTask()
            {
                List<object> listValues = new List<object>();
                listValues.Add((double)Estacoes.PressaoMaxima);
                listValues.Add((double)Estacoes.PressaoMinima);
                listValues.Add((int)Estacoes.NumeroDeCiclos);

                if (EtherCAT.EnviarAjusteEstacoes(listValues))
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
            void EnviaValoresToleranciaTask()
            {
                List<object> listValues = new List<object>();
                listValues.Add((bool)Estacoes.LigarMaximo);
                listValues.Add((bool)Estacoes.DesligarMinimo);

                if (EtherCAT.EnviarToleranciaEstacoes(listValues))
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
            void EnviaValoresConfiguracaoTask()
            {
                List<object> listValues = new List<object>();
                listValues.Add((Estacoes.EscalaMaxima));
                listValues.Add((Estacoes.EscalaMinima));
                listValues.Add(Estacoes.PressaoMaximaTransmissor);
                listValues.Add(Estacoes.PressaoMinimaTransmissor);
                listValues.Add(Estacoes.UnidadeDePressao);
                Settings.Default.C_UnidadePressao = Estacoes.UnidadePressaoDisponivel[Estacoes.UnidadeDePressao];
                Settings.Default.Save();
                if (EtherCAT.EnviarConfiguracoesEstacoes(listValues))
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

            //Inicio dos metodos---------------------------------------------------------------------------------------------------------------------
            public void RecuperaDadosControlador()
            {
                if (EtherCAT.CommOK)
                {
                    List<object> listValues = EtherCAT.InicializarVariaveisEstacoes();
                    Estacoes.PressaoMaxima = (double)listValues[0];
                    Estacoes.PressaoMinima = (double)listValues[1];
                    Estacoes.NumeroDeCiclos = (int)listValues[2];
                    Estacoes.LigarMaximo = (bool)listValues[3];
                    Estacoes.DesligarMinimo = (bool)listValues[4];
                    Estacoes.EscalaMaxima = (int)listValues[5];
                    Estacoes.EscalaMinima = (int)listValues[6];
                    Estacoes.PressaoMaximaTransmissor = (double)listValues[7];
                    Estacoes.PressaoMinimaTransmissor = (double)listValues[8];
                    Estacoes.UnidadeDePressao = (int)listValues[9];
                    _recuperacaoDeDadosOk = true;
                    RaiseChange("Estacoes");
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

            //Raise Change --------------------------------------------------------------------------------------------------------------------------
            void RaiseChange(string property)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }

            //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
        
    }
}
