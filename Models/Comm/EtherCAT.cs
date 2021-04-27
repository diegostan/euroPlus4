using euroPlus4_1.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TwinCAT.Ads;

namespace euroPlus4_1.Models.Comm
{
    static class EtherCAT
    {
        
        public static string AmsID { get; set; }
        public static int AmsPort { get; set; }
        public static bool CommOK { get; set; }

        public static bool CarregamentoDeDados { get; set; }

        public static List<object> ListaInicializavelBombaHidraulica;
        public static List<object> ListaInicializavelEstacoes;
        public static List<object> ListaInicializavelTemperaturas;
        public static List<object> ListaInicializavelTemposFrequencias;

        public static List<object> ListaAlarmes;

        public static List<object> ListaLeituras { get; internal set; }
        

        //Definicao das variaveis de entrada e saida
        static List<object> _listaLeituras = new List<object>();
        //Programa bomba hidraulica
        static int  _maxPumpFlow;
        static int _maxFrequency;
        static int _minVoltage;
        static int _maxVoltage;
        static int _outputVoltage;
        static int _presetPumpFLow;
        static int _currentVoltage;
        static int _currentFrequency;
        static int _currentPumpFlow;
        
        //Programa teste de repeticao
        static int _maxPressure;
        static int _minPressure;
        static int _cycleNumber;
        static int _maxAlarmDisable;
        static int _minAlarmDisable;
        static int _frequencyValue;
        static int _presetTimeCirculation;
        static int _maxScale;
        static int _minScale;
        static int _maxPressureTransmiter;
        static int _minPressureTransmiter;
        static int _pressureUnit;        
        static int _pressureValueFloat;
        static int _frequencyCurrentCicle;
        static int _hvar0;
        //Programa temperaturas
        static int _presetTemperatureFluid;
        static int _presetOffSetFluid;
        static int _presetMaxToleranceFluid;
        static int _presetMinToleranceFluid;
        static int _presetTemperatureStation;
        static int _presetTemperatureAmbientDown;
        static int _presetOffSetAmbientDown;
        static int _presetMaxToleranceAmbientDown;
        static int _presetMinToleranceAmbientDown;
        static int _presetTemperatureAmbientUp;
        static int _presetOffSetAmbientUp;
        static int _presetMaxToleranceAmbientUp;
        static int _presetMinToleranceAmbientUp;
        static int _integralCoeficient;
        static int _rateNumberFluid;
        static int _intervalSampleFluid;
        static int _realTemperatureFluid;
        static int _realTemperatureFluidAux;        
        static int _realTemperatureAmbientDown;
        static int _realTemperatureAmbientUp;
        static int _outputControlFluid;
        static int _outputControlAmbientDown;
        //Alarmes
        static int _al0;
        static int _al1;
        static int _al2;
        static int _al3;
        static int _al4;
        static int _al5;
        static int _al6;
        static int _al7;
        static int _al8;
        static int _hmi10;
        //Comandos
        static int _cm2;
        static int _cm3;
        static int _cm10;
        static int _cm11;

        
        //Variavel de verificação da comunicação
        static int _communicationOk;

        //Definição do temporizador de leitura
        static System.Timers.Timer timerDeLeitura;


        static Thread _tVerificador;
        static Thread _tLeitura;

        static TcAdsSymbolInfoLoader symbolInfoLoader;
        static TcAdsClient adsClient = new TcAdsClient();        

        static EtherCAT()
        {
            timerDeLeitura = new System.Timers.Timer();
            CarregamentoDeDados = false;
            CommOK = false;
            ListaLeituras = new List<object>();

            _tVerificador = new Thread(TimerDeVerificacao_Elapsed);
            _tVerificador.IsBackground = true;
            _tVerificador.Start();

            _tLeitura = new Thread(LerVariaveis);
            _tLeitura.IsBackground = true;
            _tLeitura.Start();

        }

   

        private static void TimerDeVerificacao_Elapsed()
        {
            while (true)
            {

            
            try
            {
                if ((int)adsClient.ReadAny(_communicationOk, typeof(int)) == 3024)
                {
                    CommOK = true;                    
                }
                else
                {
                    CommOK = false;
                    

                }
            }
            catch
            {
                CommOK = false;
                
            }
                Thread.Sleep(500);
            }
        }

        public static bool ConectarAMS()
        {
            AmsID = Settings.Default.C_EnderecoIp;
            AmsPort = Settings.Default.C_Porta;
            try 
            {                  
                 adsClient.Connect(AmsID, AmsPort);
                if (adsClient.IsConnected)
                {
                    //Verificador de comunicação
                    _communicationOk = adsClient.CreateVariableHandle("MAIN.CommOK");
                    //Programa bomba hidraulica
                    _maxPumpFlow = adsClient.CreateVariableHandle("MAIN.maxPumpFlow");
                    _maxFrequency = adsClient.CreateVariableHandle("MAIN.maxFrequency");
                    _minVoltage = adsClient.CreateVariableHandle("MAIN.minVoltage");
                    _maxVoltage = adsClient.CreateVariableHandle("MAIN.maxVoltage");
                    _outputVoltage = adsClient.CreateVariableHandle("MAIN.outputVoltage");
                    _presetPumpFLow = adsClient.CreateVariableHandle("MAIN.presetPumpFlow");
                    _currentFrequency = adsClient.CreateVariableHandle("MAIN.currentFrequency");
                    _currentPumpFlow = adsClient.CreateVariableHandle("MAIN.currentPumpFlow");
                    _currentVoltage = adsClient.CreateVariableHandle("MAIN.currentVoltage");

                    //Programa teste de repeticao
                    _maxPressure = adsClient.CreateVariableHandle("MAIN.maxPressure");
                    _minPressure = adsClient.CreateVariableHandle("MAIN.minPressure");
                    _cycleNumber = adsClient.CreateVariableHandle("MAIN.cycleNumber");
                    _frequencyValue = adsClient.CreateVariableHandle("MAIN.frequencyValue");
                    _presetTimeCirculation = adsClient.CreateVariableHandle("MAIN.presetTimeCirculation");
                    _maxAlarmDisable = adsClient.CreateVariableHandle("MAIN.maxAlarmDisable");
                    _minAlarmDisable = adsClient.CreateVariableHandle("MAIN.minAlarmDisable");
                    _maxScale = adsClient.CreateVariableHandle("MAIN.maxScale[0]");
                    _minScale = adsClient.CreateVariableHandle("MAIN.minScale[0]");
                    _maxPressureTransmiter = adsClient.CreateVariableHandle("MAIN.maxPressureTransmiter[0]");
                    _minPressureTransmiter = adsClient.CreateVariableHandle("MAIN.minPressureTransmiter[0]");
                    _pressureUnit = adsClient.CreateVariableHandle("MAIN.pressureUnit");
                    _pressureValueFloat = adsClient.CreateVariableHandle("MAIN.pressureValueFloat");
                    _frequencyCurrentCicle = adsClient.CreateVariableHandle("MAIN.frequencyCurrentCicle");
                    _hvar0 = adsClient.CreateVariableHandle("MAIN.HVar0");
                    //Programa temperaturas
                    _presetTemperatureFluid = adsClient.CreateVariableHandle("MAIN.presetTemperatureFluid");
                    _presetOffSetFluid = adsClient.CreateVariableHandle("MAIN.presetOffSetFluid");
                    _presetMaxToleranceFluid = adsClient.CreateVariableHandle("MAIN.presetMaxToleranceFluid");
                    _presetMinToleranceFluid = adsClient.CreateVariableHandle("MAIN.presetMinToleranceFluid");
                    _presetTemperatureStation = adsClient.CreateVariableHandle("MAIN.presetTemperatureStation");
                    _presetTemperatureAmbientDown = adsClient.CreateVariableHandle("MAIN.presetTemperatureAmbientDown");
                    _presetOffSetAmbientDown = adsClient.CreateVariableHandle("MAIN.presetOffSetAmbientDown");
                    _presetMaxToleranceAmbientDown = adsClient.CreateVariableHandle("MAIN.presetMaxToleranceAmbientDown");
                    _presetMinToleranceAmbientDown = adsClient.CreateVariableHandle("MAIN.presetMinToleranceAmbientDown");
                    _presetTemperatureAmbientUp = adsClient.CreateVariableHandle("MAIN.presetTemperatureAmbientUp");
                    _presetOffSetAmbientUp = adsClient.CreateVariableHandle("MAIN.presetOffSetAmbientUp");
                    _presetMaxToleranceAmbientUp = adsClient.CreateVariableHandle("MAIN.presetMaxToleranceAmbientUp");
                    _presetMinToleranceAmbientUp = adsClient.CreateVariableHandle("MAIN.presetMinToleranceAmbientUp");
                    _integralCoeficient = adsClient.CreateVariableHandle("MAIN.integralCoeficient");
                    _rateNumberFluid = adsClient.CreateVariableHandle("MAIN.rateNumberFluid");
                    _intervalSampleFluid = adsClient.CreateVariableHandle("MAIN.intervalSampleFluid");
                    _realTemperatureFluid = adsClient.CreateVariableHandle("MAIN.realTemperatureFluid2");
                    _realTemperatureFluidAux = adsClient.CreateVariableHandle("MAIN.realTemperatureFluidAux");
                    _realTemperatureAmbientDown = adsClient.CreateVariableHandle("MAIN.realTemperatureAmbientDown");
                    _realTemperatureAmbientUp = adsClient.CreateVariableHandle("MAIN.realTemperatureAmbientUp");
                    _outputControlFluid = adsClient.CreateVariableHandle("MAIN.outputControlFLuid");
                    _outputControlAmbientDown = adsClient.CreateVariableHandle("MAIN.outputControlAmbientDown");
                    //Alarmes
                    _al0 = adsClient.CreateVariableHandle("MAIN.AL0");
                    _al1 = adsClient.CreateVariableHandle("MAIN.AL1");
                    _al2 = adsClient.CreateVariableHandle("MAIN.AL2");
                    _al3 = adsClient.CreateVariableHandle("MAIN.AL3");
                    _al4 = adsClient.CreateVariableHandle("MAIN.AL4");
                    _al5 = adsClient.CreateVariableHandle("MAIN.AL5");
                    _al6 = adsClient.CreateVariableHandle("MAIN.AL6");
                    _al7 = adsClient.CreateVariableHandle("MAIN.AL7");
                    _al8 = adsClient.CreateVariableHandle("MAIN.AL8");
                    _hmi10 = adsClient.CreateVariableHandle("MAIN.HMI10");
                    //Comandos
                    _cm2 = adsClient.CreateVariableHandle("MAIN.CM2");
                    _cm3 = adsClient.CreateVariableHandle("MAIN.CM3");
                    _cm10 = adsClient.CreateVariableHandle("MAIN.CM10");
                    _cm11 = adsClient.CreateVariableHandle("MAIN.CM11");

                    symbolInfoLoader = adsClient.CreateSymbolInfoLoader();
                    CommOK = true;                    
                }
                return  adsClient.IsConnected;
            }
            catch
            {
                CommOK = false;
                return false;
            }
        }       

        public static void DesconectarAMS()
        {
            if (adsClient.IsConnected)
            {                
                adsClient.Disconnect();
                adsClient.Dispose();
            }
        }

        //Leituras-------------------------------------------------------------------
        public  static void LerVariaveis()
        {
            ListaAlarmes = new List<object>();

            for (int i = 0; i < 9; i++)
            {
                ListaAlarmes.Add(false);
            }
            for (int i = 0; i < 15; i++)
            {
                _listaLeituras.Add("");
            }            
           while (true) 
            { 
                try
                {
                    
                    if (CommOK)
                    {
                        _listaLeituras[0]=(adsClient.ReadAny(_currentFrequency, typeof(int)));
                        _listaLeituras[1]=(adsClient.ReadAny(_currentPumpFlow, typeof(int)));
                        _listaLeituras[2]=(adsClient.ReadAny(_currentVoltage, typeof(int)));
                        _listaLeituras[3]= string.Format("{0:###.#}" ,(adsClient.ReadAny(_pressureValueFloat, typeof(double))));
                        _listaLeituras[4] = string.Format("{0:###.#}", (adsClient.ReadAny(_realTemperatureFluid, typeof(double))));
                        _listaLeituras[5] = string.Format("{0:###.#}", (adsClient.ReadAny(_realTemperatureFluidAux, typeof(double))));
                        _listaLeituras[6] = string.Format("{0:###.#}", (adsClient.ReadAny(_realTemperatureAmbientDown, typeof(double))));
                        _listaLeituras[7] = string.Format("{0:###.#}", (adsClient.ReadAny(_realTemperatureAmbientUp, typeof(double))));
                        _listaLeituras[8] = (adsClient.ReadAny(_outputControlFluid, typeof(bool)));
                        _listaLeituras[9] = (adsClient.ReadAny(_outputControlAmbientDown, typeof(bool)));
                        _listaLeituras[10] = (adsClient.ReadAny(_cm2, typeof(bool)));
                        _listaLeituras[11] = (adsClient.ReadAny(_cm3, typeof(bool)));
                        _listaLeituras[12] = (adsClient.ReadAny(_cm10, typeof(bool)));
                        _listaLeituras[13] = (adsClient.ReadAny(_cm11, typeof(bool)));
                        _listaLeituras[14] = (adsClient.ReadAny(_frequencyCurrentCicle, typeof(int)));
                        ListaAlarmes[0] = (adsClient.ReadAny(_al0, typeof(bool)));
                        ListaAlarmes[1] = (adsClient.ReadAny(_al1, typeof(bool)));
                        ListaAlarmes[2] = (adsClient.ReadAny(_al2, typeof(bool)));
                        ListaAlarmes[3] = (adsClient.ReadAny(_al3, typeof(bool)));
                        ListaAlarmes[4] = (adsClient.ReadAny(_al4, typeof(bool)));
                        ListaAlarmes[5] = (adsClient.ReadAny(_al5, typeof(bool)));
                        ListaAlarmes[6] = (adsClient.ReadAny(_al6, typeof(bool)));
                        ListaAlarmes[7] = (adsClient.ReadAny(_al7, typeof(bool)));
                        ListaAlarmes[8] = (adsClient.ReadAny(_al8, typeof(bool)));
                        ListaLeituras = _listaLeituras;
                        VisaoGeralStaticModel.PressaoAtualEstacoes = _listaLeituras[3].ToString();
                        VisaoGeralStaticModel.TemperaturaFluido = _listaLeituras[4].ToString();
                        VisaoGeralStaticModel.TemperaturaCamara = _listaLeituras[6].ToString();
                        VisaoGeralStaticModel.VazaoBomba = _listaLeituras[1].ToString();
                        VisaoGeralStaticModel.QuantidadeCiclosRealizados = _listaLeituras[14].ToString();
                        


                    }
                    else
                    {
                        ListaLeituras.Clear();
                        for (int i = 0; i < 15; i++)
                        {
                            ListaLeituras.Add("0");
                        }
                    }
                   
                }
                catch
                {
                    ListaLeituras.Clear();
                    for (int i = 0; i < 4; i++)
                    {
                        ListaLeituras.Add("0");
                    }
                }
                System.Threading.Thread.Sleep(Settings.Default.C_TempoLeituraEthernet);
            }
            

        }

        //Bomba hidraulica-------------------------------------------------------------------
        public static List<object> InicializarVariaveisBombaHidraulica()
        {
            try { 
            if (CommOK) { 
            ListaInicializavelBombaHidraulica = new List<object>();
            ListaInicializavelBombaHidraulica.Clear();
            ListaInicializavelBombaHidraulica.Add(adsClient.ReadAny(_maxPumpFlow, typeof(int)));
            ListaInicializavelBombaHidraulica.Add(adsClient.ReadAny(_maxFrequency, typeof(int)));
            ListaInicializavelBombaHidraulica.Add(adsClient.ReadAny(_minVoltage, typeof(int)));
            ListaInicializavelBombaHidraulica.Add(adsClient.ReadAny(_maxVoltage, typeof(int)));            
            ListaInicializavelBombaHidraulica.Add(adsClient.ReadAny(_presetPumpFLow, typeof(int)));                    

            return ListaInicializavelBombaHidraulica;
            }
            else
            {
                return null;
            }
            }
            catch
            {
                return null;
            }
        }
        public static bool EnviarPercentualVazao(int value)
        {
            try
            {

            
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_presetPumpFLow, Convert.ToInt16(value));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            }
            catch
            {
                return false;
            }
        }
        //Inicio de ciclo
        public static bool EnviarInicioDeCiclo()
        {
            try
            {


                if (CommOK)
                {
                    try
                    {
                        adsClient.WriteAny(_hvar0, Convert.ToInt16(1));
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool EnviarConfiguracoesBomba(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_maxPumpFlow, Int16.Parse(values[0].ToString()));
                    adsClient.WriteAny(_maxFrequency, Int16.Parse(values[1].ToString()));
                    adsClient.WriteAny(_minVoltage, Int16.Parse(values[2].ToString()));
                    adsClient.WriteAny(_maxVoltage, Int16.Parse(values[3].ToString()));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //-------------------------------------------------------------------------------------

        //Transmissor de pressão e estações----------------------------------------------------
        public static List<object> InicializarVariaveisEstacoes()
        {
            try
            {

                if (CommOK)
                {
                    ListaInicializavelEstacoes = new List<object>();
                    ListaInicializavelEstacoes.Clear();
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_maxPressure, typeof(double)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_minPressure, typeof(double))) ;
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_cycleNumber, typeof(int)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_maxAlarmDisable, typeof(bool)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_minAlarmDisable, typeof(bool)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_maxScale, typeof(int)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_minScale, typeof(int)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_maxPressureTransmiter, typeof(double)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_minPressureTransmiter, typeof(double)));
                    ListaInicializavelEstacoes.Add(adsClient.ReadAny(_pressureUnit, typeof(int)));

                    return ListaInicializavelEstacoes;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool EnviarAjusteEstacoes(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_maxPressure, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_minPressure, Double.Parse(values[1].ToString()));
                    adsClient.WriteAny(_cycleNumber, Int32.Parse(values[2].ToString()));
                    
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool EnviarToleranciaEstacoes(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_maxAlarmDisable, Boolean.Parse(values[0].ToString()));
                    adsClient.WriteAny(_minAlarmDisable, Boolean.Parse(values[1].ToString()));

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool EnviarConfiguracoesEstacoes(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    
                    adsClient.WriteAny(_maxScale, Int16.Parse(values[0].ToString()));
                    adsClient.WriteAny(_minScale, Int16.Parse(values[1].ToString()));
                    adsClient.WriteAny(_maxPressureTransmiter, Double.Parse(values[2].ToString()));
                    adsClient.WriteAny(_minPressureTransmiter, Double.Parse(values[3].ToString()));
                    adsClient.WriteAny(_pressureUnit, Int16.Parse(values[4].ToString()));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //-------------------------------------------------------------------------------------

        //Temperaturas-------------------------------------------------------------------------
        public static List<object> InicializarVariaveisTemperaturas()
        {
            try
            {

                if (CommOK)
                {
                    ListaInicializavelTemperaturas = new List<object>();
                    ListaInicializavelTemperaturas.Clear();
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetTemperatureFluid, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetTemperatureAmbientDown, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetMaxToleranceFluid, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetMaxToleranceAmbientDown, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetMinToleranceFluid, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetMinToleranceAmbientDown, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetOffSetFluid, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_presetOffSetAmbientDown, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_integralCoeficient, typeof(double)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_rateNumberFluid, typeof(int)));
                    ListaInicializavelTemperaturas.Add(adsClient.ReadAny(_intervalSampleFluid, typeof(double)));

                    return ListaInicializavelTemperaturas;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool EnviarAjusteTemperaturas(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_presetTemperatureFluid, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_presetTemperatureAmbientDown, Double.Parse(values[1].ToString()));                    
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool EnviarToleranciaTemperaturas(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_presetMaxToleranceFluid, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_presetMaxToleranceAmbientDown, Double.Parse(values[1].ToString()));
                    adsClient.WriteAny(_presetMinToleranceFluid, Double.Parse(values[2].ToString()));
                    adsClient.WriteAny(_presetMinToleranceAmbientDown, Double.Parse(values[3].ToString()));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool EnviarConfiguracaoTemperaturas(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_presetOffSetFluid, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_presetOffSetAmbientDown, Double.Parse(values[1].ToString()));
                    adsClient.WriteAny(_integralCoeficient, Double.Parse(values[2].ToString()));
                    adsClient.WriteAny(_rateNumberFluid, Int16.Parse(values[3].ToString()));
                    adsClient.WriteAny(_intervalSampleFluid, Double.Parse(values[4].ToString()));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //-------------------------------------------------------------------------------------


        //Tempos e frequencias
        public static List<object> InicializarVariaveisTemposFrequencias()
        {
            try
            {
                if (CommOK)
                {
                    ListaInicializavelTemposFrequencias = new List<object>();
                    ListaInicializavelTemposFrequencias.Clear();
                    ListaInicializavelTemposFrequencias.Add(adsClient.ReadAny(_frequencyValue, typeof(double)));
                    ListaInicializavelTemposFrequencias.Add(adsClient.ReadAny(_presetTimeCirculation, typeof(double)));                    

                    return ListaInicializavelTemposFrequencias;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public static bool EnviarAjusteTemposFrequencias(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_frequencyValue, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_presetTimeCirculation, Double.Parse(values[1].ToString()));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //-------------------------------------------------------------------------------------

        //Envia arquivo de parametros

        public static bool EnviarArquivoParametros(List<object> values)
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_maxPressure, Double.Parse(values[0].ToString()));
                    adsClient.WriteAny(_minPressure, Double.Parse(values[1].ToString()));
                    adsClient.WriteAny(_cycleNumber, Int32.Parse(values[2].ToString()));
                    adsClient.WriteAny(_presetTemperatureFluid, Double.Parse(values[3].ToString()));
                    adsClient.WriteAny(_presetTemperatureAmbientDown, Double.Parse(values[4].ToString()));
                    adsClient.WriteAny(_presetPumpFLow, Convert.ToInt16(values[5].ToString()));
                    adsClient.WriteAny(_frequencyValue, Double.Parse(values[6].ToString()));
                    adsClient.WriteAny(_presetTimeCirculation, Double.Parse(values[7].ToString()));
                    Thread.Sleep(1000);
                    EtherCAT.CarregamentoDeDados = false;

                    return true;

                }
                catch
                {
                    EtherCAT.CarregamentoDeDados = false;
                    return false;
                }
            }
            else
            {
                EtherCAT.CarregamentoDeDados = false;
                return false;
            }
            
        }
        //-------------------------------------------------------------------------------------

        public static bool ReiniciaAlarmes()
        {
            if (CommOK)
            {
                try
                {
                    adsClient.WriteAny(_hmi10, Boolean.Parse(true.ToString()));
                    Thread.Sleep(100);
                    adsClient.WriteAny(_hmi10, Boolean.Parse(false.ToString()));

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool TesteDeComunicacao()
        {
            AmsID = Settings.Default.C_EnderecoIp;
            AmsPort = Settings.Default.C_Porta;
            try
            {                  
                return ConectarAMS();
            }
            catch
            {
                return false;

            }
            finally
            {
                adsClient.Disconnect();
            }
            
        }

        public static void IniciarLeiturasAMS()
        {
            timerDeLeitura.Interval = Settings.Default.C_TempoLeituraEthernet;
            timerDeLeitura.Start();
        }
        public static void PararLeiturasAMS()
        {
            timerDeLeitura.Stop();
        }

    }
}

