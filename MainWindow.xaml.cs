using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using euroPlus4_1.Views;
using euroPlus4_1.ViewModels;
using euroPlus4_1.Models;
using LoginView = euroPlus4_1.Views.LoginView;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using euroPlus4_1.Models.Comm;
using System.Threading;

namespace euroPlus4_1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        DoubleAnimation doubleAnimationKeyboard;
        Storyboard storyboardKeyboard = new Storyboard() { };
        bool virtualKeyboardActive = false;

        public DateTime NowDate { get; set; }



        UsuariosView usuariosView;
        InicioView inicioView;
        ConfigView configView;        
        BombaHidraulicaView bombaHidraulica;
        TemperaturasView temperaturasView;
        EstacoesView estacoesView;
        TemposFrequenciasView temposFrequenciasView;
        VisaoGeralView visaoGeralView;
        LoginView loginView;
        AlarmeView alarmeView;
        GerenciarDados gerenciarDados;
        InformacoesView informacoesView;
        CentralDeAjudaView centralDeAjudaView;

        public string UsuarioCorrente { get; set; }
        public int NivelCorrente { get; set; }
        public string PossuiRFID { get; set; }
        public DateTime UltimoLogin { get; set; }
        
        public bool UsuarioLogado { get; set; }
        
        MainWindowViewModel mainWindowViewModel;

        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();
        
        int _tempoCarregamento;

        public MainWindow()
        {
            InitializeComponent();
            try { 
                mainWindowViewModel = new MainWindowViewModel(this);
                usuariosView = new UsuariosView(this);
                loginView = new LoginView(usuariosView, this);            
                this.DataContext = mainWindowViewModel;                      
                this.mainContent.Content = loginView;

                inicioView = new InicioView();
                bombaHidraulica = new BombaHidraulicaView(this);
                configView = new ConfigView(this);
                temperaturasView = new TemperaturasView(this);
                estacoesView = new EstacoesView(this);
                temposFrequenciasView = new TemposFrequenciasView(this);
                visaoGeralView = new VisaoGeralView(this);
                alarmeView = new AlarmeView(this);
                gerenciarDados = new GerenciarDados(this);
                informacoesView = new InformacoesView();
                centralDeAjudaView = new CentralDeAjudaView();
            }
            catch(Exception ex)
            {
                this.ShowMessageAsync("Falha no carregamento do sistema", "Houve uma falha ao carregar o euroPlus 4, segue o código de erro:\n" + ex.Message.ToString());
            }
            RegisterName(virtualKeyboardGrid.Name, virtualKeyboardGrid);
            doubleAnimationKeyboard = new DoubleAnimation() { To = 1.0, From = 0.1, Duration = new Duration(TimeSpan.FromMilliseconds(300)) };
            
            Storyboard.SetTarget(doubleAnimationKeyboard, virtualKeyboardGrid);
            Storyboard.SetTargetProperty(doubleAnimationKeyboard, new PropertyPath(Grid.OpacityProperty));

            storyboardKeyboard.Children.Add(doubleAnimationKeyboard);
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;
            EsconnderTeclado();
            //this.mainContent.Content = new LoginView(this).Content;
            
            loginView.progressRing.IsActive = false;
            loginView.btLogin.IsEnabled = true;
            

        }
      


        public async Task<MessageDialogResult> PromptAsync(string title, string message, MessageDialogStyle style = MessageDialogStyle.Affirmative, MetroDialogSettings settings = null)
        {
            return await this.ShowMessageAsync(title, message, style, settings);
        }

        private async void ListViewItem_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (NivelCorrente < 11) { 
            ObservableCollection<TelasModel> _telas = new ObservableCollection<TelasModel>();
            _telas = await mainWindowViewModel.AtualizaTelas();                        
            int _estacoes =0;
            int _temperaturas=0;
            int _bombaHidraulica=0;
            int _tempoFrequencias=0;
            int _gerenciarDados = 0;

                foreach (var item in _telas)
                {
                    if (item.Descricao == "Estacoes") _estacoes = item.Nivel;
                    if (item.Descricao == "Temperaturas") _temperaturas = item.Nivel;
                    if (item.Descricao == "BombaHidraulica") _bombaHidraulica = item.Nivel;
                    if (item.Descricao == "TemposFrequencias") _tempoFrequencias = item.Nivel;
                    if (item.Descricao == "GerenciarDados") _gerenciarDados = item.Nivel;
                }


            if (listViewLeft.SelectedIndex == 0) { menuContent.Content = inicioView; return; }
            if (listViewLeft.SelectedIndex == 1) {menuContent.Content = visaoGeralView; return; }
            if (listViewLeft.SelectedIndex == 3 && _estacoes <= NivelCorrente) {menuContent.Content = estacoesView; estacoesView.RetornaMenu(); return; }
            if (listViewLeft.SelectedIndex == 4 && _temperaturas <= NivelCorrente) { menuContent.Content = temperaturasView; temperaturasView.RetornaMenu(); return; }
            if (listViewLeft.SelectedIndex == 5 && _bombaHidraulica <= NivelCorrente) { menuContent.Content = bombaHidraulica; bombaHidraulica.RetornaMenu(); return; }
            if (listViewLeft.SelectedIndex == 6 && _tempoFrequencias <= NivelCorrente) { menuContent.Content = temposFrequenciasView; temposFrequenciasView.RetornaMenu(); return; }
                if (listViewLeft.SelectedIndex == 8 && _gerenciarDados <= NivelCorrente) { menuContent.Content = gerenciarDados; return; }
                if (listViewLeft.SelectedIndex == 9) { Sair(); return; }
            MensagemNivel();
            }
            else
            {
                if (listViewLeft.SelectedIndex == 0) { menuContent.Content = inicioView; return; }
                if (listViewLeft.SelectedIndex == 1) { menuContent.Content = visaoGeralView; return; }
                if (listViewLeft.SelectedIndex == 3) { menuContent.Content = estacoesView; estacoesView.RetornaMenu(); return; }
                if (listViewLeft.SelectedIndex == 4) { menuContent.Content = temperaturasView; temperaturasView.RetornaMenu(); return; }
                if (listViewLeft.SelectedIndex == 5) { menuContent.Content = bombaHidraulica; bombaHidraulica.RetornaMenu(); return; }
                if (listViewLeft.SelectedIndex == 6) { menuContent.Content = temposFrequenciasView; temposFrequenciasView.RetornaMenu(); return; }
                if (listViewLeft.SelectedIndex == 8) { menuContent.Content = gerenciarDados; return; }
                if (listViewLeft.SelectedIndex == 9) { Sair(); return; }
            }


        }

        async void MensagemNivel()
        {            
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;
            if(await this.ShowMessageAsync("Acesso não permitido", "O seu nível de usuário não permite acesso a essa tela.", MessageDialogStyle.Affirmative, metroDialogSettings)== MessageDialogResult.Affirmative)
            {
                ClearContent();
            }
            
        }
        async void Sair()
        {

          
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Sim";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;
            if (await this.ShowMessageAsync("Sair", "Deseja sair do sistema e encerrar sua sessão de trabalho ?", MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings)==MessageDialogResult.Affirmative)
            { 
                listViewLeft.UnselectAll();
                this.mainContent.Content = null;
                this.mainContent.Content = loginView;
                this.UsuarioLogado = false;
            }
            else
            {
                ClearContent();
            }
        }
        public void ClearContent()
        {
            this.mainContent.Content = null;
            listViewLeft.SelectedIndex = 0;
            menuContent.Content = inicioView;
        }

        private void ConfigButton_Click(object sender, RoutedEventArgs e)
        {

            menuContent.Content = configView;
            configView.RetornaMenu();
            listViewLeft.UnselectAll();
        }

        public void SelecionarTema()
        {

        }

        private void StackPanel_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListViewItem_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
           
        }

        public void MostrarTeclado(bool numeric)
        {
            if (virtualKeyboardActive == false)
            {
                virtualKeyboardGrid.Visibility = Visibility.Visible;
                virtualKeyboardActive = true;
                if (numeric) 
                { 
                    Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.Numeric;
                }
                else
                {
                    Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.AlphaNumeric;
                }
                doubleAnimationKeyboard.To = 1;
                doubleAnimationKeyboard.From = 0;
                storyboardKeyboard.Begin();
            }
        }
        public void EsconnderTeclado()
        {
            virtualKeyboardActive = false;
            doubleAnimationKeyboard.To = 0;
            doubleAnimationKeyboard.From = 1;
            storyboardKeyboard.Begin();
            while (virtualKeyboardGrid.Opacity != 0)
            {
                virtualKeyboardGrid.Visibility = Visibility.Hidden;
                return;
            }
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;
        }

        private void alarmButton_Click(object sender, RoutedEventArgs e)
        {
            menuContent.Content = alarmeView;
            listViewLeft.UnselectAll();
        }

        private void userButton_Click(object sender, RoutedEventArgs e)
        {
            menuContent.Content = usuariosView;
            usuariosView.RetornaMenu();
            listViewLeft.UnselectAll();
            usuariosView.AtualizarTelas();
            usuariosView.AtualizaUsuarios();
        }

        public void HabilitaParametrosSysEP()
        {
            configView.txtNomeBancoEuroPlus.IsEnabled = NivelCorrente >= 11 ? true : false;
        }

        private void btInformacoes_Click(object sender, RoutedEventArgs e)
        {
            menuContent.Content = informacoesView;
            listViewLeft.UnselectAll();
        }

        private void btAjuda_Click(object sender, RoutedEventArgs e)
        {
            menuContent.Content = centralDeAjudaView;
            listViewLeft.UnselectAll();
        }
    }
}
