using System;
using System.Management;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ControlzEx.Theming;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Data;
using euroPlus4_1.Models.Config;
using euroPlus4_1.Models.Comm;
using System.Windows;
using euroPlus4_1.Properties;
using System.Collections.Generic;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;

namespace euroPlus4_1.ViewModels
{
    class ConfigViewModel : INotifyPropertyChanged
    {
        //Declaração de variaveis da máquina

        public ConfigMaquina ConfigMaquinaModel { get; set; }
        public ConfigSistema ConfigSistemaModel { get; set; }

        public ConfigComunicacao ConfigComunicacaoModel { get; set; }

        public ConfigDados ConfigDadosModel { get; set; }

        //Declaração de variaveis do sistema
        public string NumeroSerieEuroPlus { get; set; }
        public string FirmwarePLC { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public string FabricantePLC { get; set; }
        public string NomeDispositivo { get; set; }
        public string Processador { get; set; }
        public string MemoriaInstalada { get; set; }
        public string NomeBIOS { get; set; }
        public string IDdoProduto { get; set; }
        public string TipoSistema { get; set; }
        public string TamanhoDisco { get; set; }

        public string CorDeDestaque { get; set; }
        public string ModoEscuro { get; set; }


        public ICommand SelecionarTema { get; set; }
        public ICommand AdicionarVariavel { get; set; }
        public ICommand RemoverVariavel { get; set; }

        public ICommand SalvarDadosDaMaquina { get; set; }

        public ICommand TestarConexaoBancoDeDados { get; set; }

        public ICommand CriarEstruraDeDados { get; set; }

        public ICommand TestarConexaoEtherCAT { get; set; }

        public ObservableCollection<Variaveis> TabelaVariaveis { get; set; }

        public string ConteudoMensagem { get; set; }
        public bool MostrarMensagem { get; set; }
        public ICommand ApresentarMensagem { get; set; }

        readonly ManagementObjectSearcher consultaProcessador = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        ManagementObjectSearcher consultaDispositivo = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
        ManagementObjectSearcher consultaMemoria = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
        ManagementObjectSearcher consultaDisco = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");

        System.Timers.Timer timer;
        string _temaAtual;
        
        CriarBaseDados baseDados;
    
    

        MainWindow _window;
        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        //Construtor ----------------------------------------------------------------------------------------
        public ConfigViewModel(MainWindow main)
        {
            _window = main;

            //Publicação de comandos-------------------------------------------------------------------------
            SelecionarTema = new RelayCommand(SelecionaTema);
            AdicionarVariavel = new RelayCommand(AdicionaVariavel);
            RemoverVariavel = new RelayCommand(RemoveVariavel);
            SalvarDadosDaMaquina = new RelayCommand(SalvaDadosDaMaquina);
            ApresentarMensagem = new RelayCommand(ApresentaMensagem);
            TestarConexaoBancoDeDados = new RelayCommand(TestaConexao);
            CriarEstruraDeDados = new RelayCommand(CriaEstruturaDeDados);
            TestarConexaoEtherCAT = new RelayCommand(TestaConexaoEtherCAT);

            //------------------------------------------------------------------------------------------------

            ObterInformacoesDoPC();
            TabelaVariaveis = new ObservableCollection<Variaveis>();
            
            //Modelos gerenciados-----------------------------------------------------------------------------
            ConfigMaquinaModel = new ConfigMaquina();
            ConfigSistemaModel = new ConfigSistema();
            ConfigComunicacaoModel = new ConfigComunicacao();
            ConfigDadosModel = new ConfigDados();
            
            //------------------------------------------------------------------------------------------------
            RecuperarDadosMaquina();            

            RaiseChange("TabelaVariaveis");

            timer = new System.Timers.Timer() { Enabled = true, Interval = 200 };
            timer.Elapsed += Timer_Elapsed;

            baseDados = new CriarBaseDados();

            if (baseDados.BaseOK ==false) 
            {
                _window.ShowMessageAsync("Nenhuma base de dados encontrada", "O sistema não localizou uma base de dados instalada, verifique as " +
                    "configurações com uma senha de administrador", MessageDialogStyle.Affirmative);
            }

            TestaConexao(null);

            //Instancia de comunicação EtherCAT
            

        }

        //Fim construtor ----------------------------------------------------------------------------------------

        //Temporizador geral-------------------------------------------------------------------------------------
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            var _horaAtual = DateTime.Now.ToShortTimeString();
            
             if (ConfigSistemaModel.AplicarModoEscuroAutomaticamente) {

                 if (ConfigSistemaModel.HoraInicial.ToShortTimeString() == _horaAtual &&  _temaAtual != "Dark") 
                 {
                  SelecionaTema("Dark");
                 }

                 if (ConfigSistemaModel.HoraFinal.ToShortTimeString() == _horaAtual && _temaAtual != "Light")
                 {
                  SelecionaTema("Light");
                 }
            
        }
            
        }
        //Fim temporizador----------------------------------------------------------------------------------------------------------------------

        //Comandos -----------------------------------------------------------------------------------------------------------------------------
        void SelecionaTema(object obj)
        {
            string cor;
            if (obj == null) { 
                cor = ConfigSistemaModel.TemasDisponiveis[ConfigSistemaModel.TemaSelecionado].Content + "." + ConfigSistemaModel.CoresDisponiveis[ConfigSistemaModel.CorDeDestaqueSelecionado].Content;
                try
                {
                    if (ConfigSistemaModel.TemasDisponiveis[ConfigSistemaModel.TemaSelecionado].Content != null && ConfigSistemaModel.CoresDisponiveis[ConfigSistemaModel.CorDeDestaqueSelecionado].Content != null) ThemeManager.Current.ChangeTheme(App.Current, cor);
                    ApresentaMensagem(new MensagemPop { Mensagem = "Tema aplicado." });
                    _temaAtual = ConfigSistemaModel.TemasDisponiveis[ConfigSistemaModel.TemaSelecionado].Content.ToString();
                }
                catch
                {
                    ThemeManager.Current.ChangeTheme(App.Current, "Light." + "Blue");
                }
            }

            if ((string)obj == "Dark")
            {
                cor = "Dark";
                try
                {
                    Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => ThemeManager.Current.ChangeThemeBaseColor(App.Current, cor)));                    
                    ApresentaMensagem(new MensagemPop { Mensagem = "Tema aplicado." });
                    _temaAtual = "Dark";
                }
                catch
                {
                    Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => ThemeManager.Current.ChangeTheme(App.Current, "Light." + "Blue")));
                    _temaAtual = "Light";

                }
            }

            if ((string)obj == "Light")
            {
                cor = "Light";
                try
                {
                    Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => ThemeManager.Current.ChangeThemeBaseColor(App.Current, cor)));  
                    ApresentaMensagem(new MensagemPop { Mensagem = "Tema aplicado." });
                    _temaAtual = "Light";
                }
                catch
                {
                    Application.Current.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, new Action(() => ThemeManager.Current.ChangeTheme(App.Current, "Light." + "Blue")));
                    _temaAtual = "Light";
                }
            }
        }
       
        void SalvaDadosDaMaquina(object obj)
        {  
            try
            {
                //Salvar dados de configuração da maquina--------------------------------------------
                try
                {
                    //Salvar dados de configuração da maquina--------------------------------------------
                    var prop = Properties.Settings.Default;
                    prop.C_NomeDaMaquina = ConfigMaquinaModel.NomeDaMaquina;
                    prop.C_PosicaoNaPlanta = ConfigMaquinaModel.PosicaoNaPlanta;
                    prop.C_NumeroDeSerie = ConfigMaquinaModel.NumeroDeSerie;
                    prop.C_TensaoDeEntrada = ConfigMaquinaModel.TensaoDeEntradaSelecionado;
                    prop.C_Fabricante = ConfigMaquinaModel.Fabricante;
                    prop.C_AnoDeFabricacao = ConfigMaquinaModel.AnoDeFabricacao.ToString();
                    prop.C_TipoDeAplicacao = ConfigMaquinaModel.TipoDeAplicacaoSelecionado;
                    //Salvar dados de configuração do sistema---------------------------------------------
                    prop.C_Tema = ConfigSistemaModel.TemaSelecionado;
                    prop.C_CorDeDestaque = ConfigSistemaModel.CorDeDestaqueSelecionado;
                    prop.C_AplicarModo = ConfigSistemaModel.AplicarModoEscuroAutomaticamente;
                    prop.C_HoraInicial = ConfigSistemaModel.HoraInicial.ToString();
                    prop.C_HoraFinal = ConfigSistemaModel.HoraFinal.ToString();
                    //Salvar dados de configuração de comunicação-----------------------------------------
                    prop.C_ProtocoloEthernet = ConfigComunicacaoModel.ProtocoloEthernetSelecionado;
                    prop.C_EnderecoIp = ConfigComunicacaoModel.EnderecoIP;
                    prop.C_Porta = ConfigComunicacaoModel.Porta;
                    prop.C_TempoLeituraEthernet = ConfigComunicacaoModel.TempoLeituraEthernet;
                    prop.C_ProtocoloSerial = ConfigComunicacaoModel.ProtocoloSerialSelecionado;
                    prop.C_BaudRate = ConfigComunicacaoModel.BaudRateSelecionado;
                    prop.C_StopBit = ConfigComunicacaoModel.StopBitSelecionado;
                    prop.C_Paridade = ConfigComunicacaoModel.ParidadeSelecionado;
                    prop.C_NumeroEstacao = ConfigComunicacaoModel.NumeroEstacao;
                    //Salvar dados de configuração de banco de dados---------------------------------------
                    prop.sqlDataBase = ConfigDadosModel.NomeBaseDeDados;
                    prop.sqlPortConfig = ConfigDadosModel.Porta;
                    prop.sqlPasswordConfig = ConfigDadosModel.Senha;
                    prop.sqlUserIdConfig = ConfigDadosModel.Usuario;
                    prop.sqlServerConfig = ConfigDadosModel.EnderecoProvedor;
                    prop.sqlTipoBancoSelecionado = ConfigDadosModel.TipoBancoDeDadosSelecionado;

                    prop.Save();
                    ApresentaMensagem(new MensagemPop { Mensagem = "Valores salvos com sucesso." });
                }
                catch
                {
                    ApresentaMensagem(new MensagemPop { Mensagem = "Erro ao salvar dados, verifique os campos e tente novamente." });
                }
                ApresentaMensagem(new MensagemPop {Mensagem= "Valores salvos com sucesso." });
    }
            catch
            {
                ApresentaMensagem(new MensagemPop { Mensagem= "Erro ao salvar dados, verifique os campos e tente novamente."});
            }
            
        }
        
        async void TestaConexao(object obj)
        {
            SalvaDadosDaMaquina(obj);
            SQLDataModel dados = new SQLDataModel();
            var teste = await dados.TestarConexao();
            if (dados.TestarConexao().IsCompleted) { 
            if (teste)
            {
                ApresentaMensagem(new MensagemPop() { Mensagem = "Conexão com banco de dados realizada." });
            }
            else
            {
                ApresentaMensagem(new MensagemPop() { Mensagem = "Falha de conexão com a instância SQL Server." });
                ConfigDadosModel.BancoEuroPlus = false;
                RaiseChange("ConfigDadosModel");
                }                
                ConfigDadosModel.BancosDisponiveis = dados.ListaBancoDados;
                ConfigDadosModel.BancoEuroPlus = dados.BancoEuroPlusPresente;
            RaiseChange("ConfigDadosModel");
            }
            else
            {
                ApresentaMensagem(new MensagemPop() { Mensagem = "Aguarde a solicitação anterior." });
            }
        }

         void CriaEstruturaDeDados(object obj)
        {
            ConfigDadosModel.BancoEuroPlusProcessando = Visibility.Visible;
            ConfigDadosModel.BancoEuroPlus = false;
            RaiseChange("ConfigDadosModel");
            Task.Run(() => { 
            SQLDataModel dados = new SQLDataModel();
                if (dados.CriarEstruturaDados().Result)
                {
                    ApresentaMensagem(new MensagemPop() { Mensagem = "Estrutura de dados criada na instância selecionada." });
                    ConfigDadosModel.BancoEuroPlus = false;
                    ConfigDadosModel.BancoEuroPlusProcessando = Visibility.Hidden;
                    RaiseChange("ConfigDadosModel");
                }
                else
                {
                    ApresentaMensagem(new MensagemPop() { Mensagem = "Falha ao criar estrutura de dados na instância SQL Server. Você verificou a conexão ?" });
                    ConfigDadosModel.BancoEuroPlusProcessando = Visibility.Hidden;
                    ConfigDadosModel.BancoEuroPlus = true;
                    RaiseChange("ConfigDadosModel");
                }            
            RaiseChange("ConfigDadosModel");
            });


        }

        async void  TestaConexaoEtherCAT(object obj)
        {

            SalvaDadosDaMaquina(obj);
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;



            EtherCAT.AmsID = Settings.Default.C_EnderecoIp;
            EtherCAT.AmsPort = Settings.Default.C_Porta;
                        
            if (EtherCAT.TesteDeComunicacao()) 
            {
                await _window.ShowMessageAsync("Comunicação realizada", string.Format("A comunicação foi estabelecida no endereço {0} pela porta {1}", EtherCAT.AmsID.ToString(), EtherCAT.AmsPort.ToString()),
                    MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            else
            {
                await _window.ShowMessageAsync("Falha de comunicação", string.Format("Não foi possível estabelecer uma comunicação com {0} pela porta {1}, você verificou os parâmetros ?",
                    EtherCAT.AmsID.ToString(), EtherCAT.AmsPort.ToString()),
                   MessageDialogStyle.Affirmative, metroDialogSettings);
            }
        }


        //Fim comandos --------------------------------------------------------------------------------------------------------------------------

        //Inicio dos metodos --------------------------------------------------------------------------------------------------------------------
        void AdicionaVariavel(object obj)
        {
            RaiseChange("TabelaVariaveis");
        }

        void RemoveVariavel(object obj)
        {
            RaiseChange("TabelaVariaveis");
        }

        void ObterInformacoesDoPC()
        {
            ManagementObjectCollection processador = consultaProcessador.Get();
            ManagementObjectCollection device = consultaDispositivo.Get();
            ManagementObjectCollection memory = consultaMemoria.Get();
            ManagementObjectCollection disk = consultaDisco.Get();

            foreach (ManagementObject obj in processador)
            {
                Processador = obj["Name"].ToString();
            }

            foreach (ManagementObject obj in device)
            {

                NomeBIOS = obj["Manufacturer"].ToString();

            }


            foreach (ManagementObject obj in memory)
            {
                MemoriaInstalada = ((Convert.ToUInt64(obj["Capacity"]) / 1024) / 1000000).ToString() + " GB";
            }

            foreach (ManagementObject obj in disk)
            {
                TamanhoDisco = ((Convert.ToUInt64(obj["Size"]) / 1024) / 1000000).ToString() + " GB";
            }

            NomeDispositivo = Environment.MachineName;
            IDdoProduto = Environment.OSVersion.ToString();
            TipoSistema = Environment.Is64BitOperatingSystem ? "Sistema operacional de 64 Bits" : "Sistema operacional de 32 Bits";

        }


        void RecuperarDadosMaquina()
        {
            //Recupera dados de configuração da maquina------------------------------------------------------------------------------------------
            var prop = Properties.Settings.Default;
            ConfigMaquinaModel.NomeDaMaquina = prop.C_NomeDaMaquina;
            ConfigMaquinaModel.PosicaoNaPlanta = prop.C_PosicaoNaPlanta;
            ConfigMaquinaModel.NumeroDeSerie = prop.C_NumeroDeSerie;
            ConfigMaquinaModel.TensaoDeEntradaSelecionado = prop.C_TensaoDeEntrada;
            ConfigMaquinaModel.Fabricante = prop.C_Fabricante;
            ConfigMaquinaModel.AnoDeFabricacao = Convert.ToDateTime(prop.C_AnoDeFabricacao);
            ConfigMaquinaModel.TipoDeAplicacaoSelecionado = prop.C_TipoDeAplicacao;
            //Recupera dados de configuração do sistema-------------------------------------------------------------------------------------------
            ConfigSistemaModel.AplicarModoEscuroAutomaticamente = prop.C_AplicarModo;
            ConfigSistemaModel.CorDeDestaqueSelecionado = prop.C_CorDeDestaque;
            ConfigSistemaModel.TemaSelecionado = prop.C_Tema;
            ConfigSistemaModel.HoraInicial = Convert.ToDateTime(prop.C_HoraInicial);
            ConfigSistemaModel.HoraFinal = Convert.ToDateTime(prop.C_HoraFinal);
            //Recupera dados de configuração de comunicação---------------------------------------------------------------------------------------

            ConfigComunicacaoModel.ProtocoloEthernetSelecionado = prop.C_ProtocoloEthernet;
            ConfigComunicacaoModel.EnderecoIP = prop.C_EnderecoIp;
            ConfigComunicacaoModel.Porta = prop.C_Porta;
            ConfigComunicacaoModel.TempoLeituraEthernet = prop.C_TempoLeituraEthernet;
            ConfigComunicacaoModel.ProtocoloSerialSelecionado = prop.C_ProtocoloSerial;
            ConfigComunicacaoModel.BaudRateSelecionado = prop.C_BaudRate;
            ConfigComunicacaoModel.StopBitSelecionado = prop.C_StopBit;
            ConfigComunicacaoModel.ParidadeSelecionado = prop.C_Paridade;
            ConfigComunicacaoModel.NumeroEstacao = prop.C_NumeroEstacao;
            //Recupera dados de configuração de banco de dados---------------------------------------------------------------------------------------

            ConfigDadosModel.NomeBaseDeDados = prop.sqlDataBase;
            ConfigDadosModel.Porta = prop.sqlPortConfig;
            ConfigDadosModel.Senha = prop.sqlPasswordConfig;
            ConfigDadosModel.Usuario = prop.sqlUserIdConfig;
            ConfigDadosModel.EnderecoProvedor = prop.sqlServerConfig;
            ConfigDadosModel.TipoBancoDeDadosSelecionado = prop.sqlTipoBancoSelecionado;

            RaiseChange("ConfigMaquinaModel");
            RaiseChange("ConfigSistemaModel");
            RaiseChange("ConfigComunicacaoModel");
            RaiseChange("ConfigDadosModel");

            SelecionaTema(null);
            
        }

        //Fim Metodos ---------------------------------------------------------------------------------------------------------------------------
        
        //Apresentação de Mensagem de pop-up-----------------------------------------------------------------------------------------------------
        void ApresentaMensagem(object obj)
        {
            ConteudoMensagem = ((MensagemPop)obj).Mensagem.ToString();
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
