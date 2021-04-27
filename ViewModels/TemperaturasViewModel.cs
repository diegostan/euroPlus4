using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Comm;
using System.Threading;
using euroPlus4_1.Properties;
using System.Windows.Input;

namespace euroPlus4_1.ViewModels
{
    class TemperaturasViewModel : INotifyPropertyChanged
    {
        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }
        public TemperaturasModel Temperaturas { get; set; }

        public ICommand EnviarValoresAjuste { get; set; }
        public ICommand EnviarValoresTolerancia { get; set; }
        public ICommand EnviarValoresConfiguracao { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        List<object> _listLeiturasTemperatura;

        bool _recuperacaoDeDadosOk;

        Thread _tLeituras;
        public TemperaturasViewModel()
        {
            Temperaturas = new TemperaturasModel();
            EnviarValoresAjuste = new RelayCommand(EnviaValoresAjuste);
            EnviarValoresTolerancia = new RelayCommand(EnviaValoresTolerancia);
            EnviarValoresConfiguracao = new RelayCommand(EnviaValoresConfiguracao);

            _recuperacaoDeDadosOk = false;
            RecuperaDadosControlador();

            _tLeituras = new Thread(LerTemperaturas);
            _tLeituras.IsBackground = true;
            _tLeituras.Start();
            
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
            listValues.Add((double)Temperaturas.TemperaturaFluido);
            listValues.Add((double)Temperaturas.TemperaturaCamara);            

            if (EtherCAT.EnviarAjusteTemperaturas(listValues))
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
            listValues.Add((double)Temperaturas.MaxTemperaturaFluido);
            listValues.Add((double)Temperaturas.MaxTemperaturaCamara);
            listValues.Add((double)Temperaturas.MinTemperaturaFluido);
            listValues.Add((double)Temperaturas.MinTemperaturaCamara);


            if (EtherCAT.EnviarToleranciaTemperaturas(listValues))
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
            listValues.Add((Temperaturas.OffSetTemperaturaFluido));
            listValues.Add((Temperaturas.OffSetTemperaturaCamara));
            listValues.Add((Temperaturas.PercentualCoeficienteIntegral));
            listValues.Add((Temperaturas.NumeroAmostras));
            listValues.Add((Temperaturas.IntervaloAmostras));


            if (EtherCAT.EnviarConfiguracaoTemperaturas(listValues))
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

        private void LerTemperaturas()
        {
            while (true)
            {
                try
                {
                    if (EtherCAT.CommOK)
                    {
                        _listLeiturasTemperatura= EtherCAT.ListaLeituras;
                        Temperaturas.LeituraTemperaturaFluido = _listLeiturasTemperatura[4].ToString() + " °C";
                        Temperaturas.LeituraTemperaturaFluidoAuxiliar = _listLeiturasTemperatura[5].ToString() + " °C";
                        Temperaturas.LeituraTemperaturaCamaraInferior = _listLeiturasTemperatura[6].ToString() + " °C";
                        Temperaturas.LeituraTemperaturaCamaraSuperior = _listLeiturasTemperatura[7].ToString() + " °C";
                        Temperaturas.SaidaControleFluido = ((bool)_listLeiturasTemperatura[8]==true)? "Ligado":"Desligado";
                        Temperaturas.SaidaControleCamara = ((bool)_listLeiturasTemperatura[9] == true) ? "Ligado" : "Desligado";
                        RaiseChange("Temperaturas");
                        if (_recuperacaoDeDadosOk == false || EtherCAT.CarregamentoDeDados == true) RecuperaDadosControlador();
                        VisaoGeralStaticModel.AjusteParaCamara = Temperaturas.TemperaturaCamara.ToString();
                        VisaoGeralStaticModel.AjusteParaFluido = Temperaturas.TemperaturaFluido.ToString();
                    }
                    else
                    {
                        Temperaturas.LeituraTemperaturaFluido = "0" + " °C";
                        Temperaturas.LeituraTemperaturaFluidoAuxiliar = "0" + " °C";
                        Temperaturas.LeituraTemperaturaCamaraInferior = "0" + " °C";
                        Temperaturas.LeituraTemperaturaCamaraSuperior = "0" + " °C";
                        Temperaturas.SaidaControleFluido = "Desligado";
                        Temperaturas.SaidaControleCamara = "Desligado";
                        RaiseChange("Temperaturas");
                        _recuperacaoDeDadosOk = false;
                    }
                }
                catch
                {
                    Temperaturas.LeituraTemperaturaFluido = "--" + " °C";
                    Temperaturas.LeituraTemperaturaFluidoAuxiliar = "--" + " °C";
                    Temperaturas.LeituraTemperaturaCamaraInferior = "--" + " °C";
                    Temperaturas.LeituraTemperaturaCamaraSuperior = "--" + " °C";
                    Temperaturas.SaidaControleFluido = "--";
                    Temperaturas.SaidaControleCamara = "--";
                    _recuperacaoDeDadosOk = false;
                    RaiseChange("Temperaturas");
                }
                System.Threading.Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
            }
        }

        public void RecuperaDadosControlador()
        {
            if (EtherCAT.CommOK)
            {
                List<object> listValues = EtherCAT.InicializarVariaveisTemperaturas();
                Temperaturas.TemperaturaFluido = (double)listValues[0];
                Temperaturas.TemperaturaCamara = (double)listValues[1];
                Temperaturas.MaxTemperaturaFluido = (double)listValues[2];
                Temperaturas.MaxTemperaturaCamara = (double)listValues[3];
                Temperaturas.MinTemperaturaFluido = (double)listValues[4];
                Temperaturas.MinTemperaturaCamara = (double)listValues[5];
                Temperaturas.OffSetTemperaturaFluido = (double)listValues[6];
                Temperaturas.OffSetTemperaturaCamara = (double)listValues[7];
                Temperaturas.PercentualCoeficienteIntegral = (double)listValues[8];
                Temperaturas.NumeroAmostras = (int)listValues[9];
                Temperaturas.IntervaloAmostras = (double)listValues[10];
                _recuperacaoDeDadosOk = true;
                RaiseChange("Temperaturas");
            }
        }
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

        //Fim raise Change -----------------------------------------------------------------------------------------------------------------------
    }
}
