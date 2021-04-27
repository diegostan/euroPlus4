using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using euroPlus4_1.Models;
using euroPlus4_1.Models.Logs;
using System.IO;
using Rife.Keyboard;
using euroPlus4_1.ViewModels;
using euroPlus4_1.Properties;
using System.Threading;

namespace euroPlus4_1.Views
{
    /// <summary>
    /// Interação lógica para LoginView.xam
    /// </summary>
    public partial class LoginView : Page
    {
        
        DoubleAnimation doubleAnimationKeyboard;
        Storyboard storyboardKeyboard = new Storyboard() { };
        bool virtualKeyboardActive = false;
        TraversalRequest request;
        MainWindow _window;
        UsuariosView _usuarioView;
        MetroDialogSettings metroDialogSettings = new MetroDialogSettings();
        public bool ProcessandoRing { get; set; }
        Thread _verificarRFIDtask;
        RFID _rfid;

        public LoginView(UsuariosView usuariosView, MainWindow main)
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
            RegisterName(virtualKeyboardGrid.Name, virtualKeyboardGrid);
            doubleAnimationKeyboard = new DoubleAnimation() { To = 1.0, From = 0.1, Duration = new Duration(TimeSpan.FromMilliseconds(300)) };
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;            
            Storyboard.SetTarget(doubleAnimationKeyboard, virtualKeyboardGrid);
            Storyboard.SetTargetProperty(doubleAnimationKeyboard, new PropertyPath(Grid.OpacityProperty));
            progressRing.IsActive = false;
            storyboardKeyboard.Children.Add(doubleAnimationKeyboard);
            _window = main;
            _usuarioView = usuariosView;
            virtualKeyboardActive = false;
            doubleAnimationKeyboard.To = 0;
            doubleAnimationKeyboard.From = 1;
            storyboardKeyboard.Begin();

            _verificarRFIDtask = new Thread(VerificacaoRFID);
            _verificarRFIDtask.IsBackground = true;
            //_verificarRFIDtask.Start();
            
        }

     

        private void TxtUser_GotFocus(object sender, RoutedEventArgs e)
        {

            if (virtualKeyboardActive == false)
            {
                virtualKeyboardActive = true;
                Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.AlphaNumeric;
                doubleAnimationKeyboard.To = 1;
                doubleAnimationKeyboard.From = 0;
                storyboardKeyboard.Begin();
            }
        }

        private void TxtUser_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxtPassword_GotFocus(object sender, RoutedEventArgs e)
        {

            if (virtualKeyboardActive == false)
            {
                Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.AlphaNumeric;
            }

        }

        private void TxtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            virtualKeyboardActive = false;
            doubleAnimationKeyboard.To = 0;
            doubleAnimationKeyboard.From = 1;
            storyboardKeyboard.Begin();
            while (virtualKeyboardGrid.Opacity != 0)
            {
                return;
            }
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = txtUser.Text;
            usuario.Senha = txtPassword.Password;

            virtualKeyboardActive = false;
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;

            MetroDialogSettings metroDialogSettings = new MetroDialogSettings();
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            UsuarioModel _usuarioInfo = new UsuarioModel();
            var prop = Settings.Default;
            if(txtUser.Text == prop.UsuarioMaster && txtPassword.Password == prop.SenhaMaster)
            {
                _window.UsuarioCorrente = "euroPlus Master Control";
                _usuarioView.lblNome.Text = _window.UsuarioCorrente;
                _usuarioView.lblNivel.Text = "11";
                _window.NivelCorrente = 11;
                _usuarioView.lblRFID.Text = "Não";
                _usuarioView.lblData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
                _window.ClearContent();
                _window.HabilitaParametrosSysEP();
                _window.UsuarioLogado = true;
                return;
            }
           

            try
            {
                progressRing.IsActive = true;
                btLogin.IsEnabled = false;
                
            if (await usuario.VerificarUsuario(usuario, _usuarioInfo) && txtPassword.Password!="") 
            {
                    _usuarioView.lblNome.Text = usuario.Nome;
                    _usuarioView.lblNivel.Text = _usuarioInfo.Nivel.ToString();
                    _window.UsuarioCorrente = usuario.Nome;
                    _window.NivelCorrente = _usuarioInfo.Nivel;
                    _usuarioView.lblRFID.Text = (_usuarioInfo.RFID != "") ? "Sim" : "Não";
                    _usuarioView.lblData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
                    _window.ClearContent();                    
                    progressRing.IsActive = false;
                    btLogin.IsEnabled = true;
                    _window.UsuarioLogado = true;

                    if (_window.NivelCorrente >= 10) { _window.configButton.IsEnabled = true;  } else { _window.configButton.IsEnabled = false;  }
                }
            else
            {                             
                await _window.ShowMessageAsync("Falha de login", "Usuário e/ou senha não cadastrados ou incorretos. Você verificou os campos ?", MessageDialogStyle.Affirmative, metroDialogSettings);
                    progressRing.IsActive = false;
                    btLogin.IsEnabled = true;
                }

            }
            catch (Exception ex)
            {
                await _window.ShowMessageAsync("Falha de acesso", String.Format("O sistema não conseguiu acessar a base de dados de usuário, faça login com uma conta de administração para reparar a estrutura de dados." +
                    " Mais informaçoes: {0}", ex.ToString()), MessageDialogStyle.Affirmative, metroDialogSettings) ;
                progressRing.IsActive = false;
                btLogin.IsEnabled = true;
            }



        }

        async void VerificacaoRFID()
        {
            
            UsuarioModel usuarioRFID = new UsuarioModel();
            MetroDialogSettings metroDialogSettings = new MetroDialogSettings();
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            try
            {
                _rfid = new RFID();
                while (true)
                {
                    App.Current.Dispatcher.Invoke((Action)delegate
                    {
                        if (_window.UsuarioLogado == false)
                        {
                            if (_rfid.VerificaTagRFID(usuarioRFID).Result)
                            {
                                _usuarioView.lblNome.Text = usuarioRFID.Nome;
                                _usuarioView.lblNivel.Text = usuarioRFID.Nivel.ToString();
                                _window.UsuarioCorrente = usuarioRFID.Nome;
                                _window.NivelCorrente = usuarioRFID.Nivel;
                                _usuarioView.lblRFID.Text = (usuarioRFID.RFID != "") ? "Sim" : "Não";
                                _usuarioView.lblData.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
                                _window.ClearContent();
                                progressRing.IsActive = false;
                                btLogin.IsEnabled = true;
                                _window.UsuarioLogado = true;

                                if (_window.NivelCorrente >= 10) { _window.configButton.IsEnabled = true; } else { _window.configButton.IsEnabled = false; }

                                _window.ShowMessageAsync("Bem vindo " + usuarioRFID.Nome, "Login realizado utilizando RFID. ", MessageDialogStyle.Affirmative, metroDialogSettings);
                            }
                        }
                    });
                    Thread.Sleep(1000);

                }
                
                
            }
            catch
            {
               await _window.ShowMessageAsync("Falha no RFID ", "Houve uma falha no hardware de leitura do RFID, verifique as configurações.", MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            Thread.Sleep(1000);
        }

        private void TxtUser_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void MetroWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                UIElement elementWithFocus = System.Windows.Input.Keyboard.FocusedElement as UIElement;
                if (elementWithFocus != null)
                {

                    FocusNavigationDirection focusDirection = new FocusNavigationDirection();
                    focusDirection = FocusNavigationDirection.Next;
                    request = new TraversalRequest(focusDirection);
                    elementWithFocus.MoveFocus(request);

                }
            }
        }

        private void MetroWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.KeyboardState = Rife.Keyboard.KeyboardState.None;
            virtualKeyboardActive = false;
           
        }

        private async void lblEsqueceuSuaSenha_MouseUp(object sender, MouseButtonEventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();
            usuario.Nome = txtUser.Text;

           
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Ok";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;
            try
            {            
            if (await usuario.EsqueceuSenha(usuario) !="" && txtUser.Text != "")
            {
                
                await _window.ShowMessageAsync("Olá " + usuario.Nome, "Sua dica de senha é " + await usuario.EsqueceuSenha(usuario), MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            else
            {
                await _window.ShowMessageAsync("Usuário não encontrado","Não conseguimos identificar o nome de usuário especificado, o campo está correto e preenchido ?", MessageDialogStyle.Affirmative, metroDialogSettings);
            }
            }
            catch
            {
                await _window.ShowMessageAsync("Usuário não encontrado", "Sem uma uma base de dados instalada, não é possível recuperar as dicas de senha.", MessageDialogStyle.Affirmative);
            }


        }

         private async void btPower_Click(object sender, RoutedEventArgs e)
        {
            metroDialogSettings.ColorScheme = MetroDialogColorScheme.Accented;
            metroDialogSettings.AffirmativeButtonText = "Sim";
            metroDialogSettings.NegativeButtonText = "Não";
            metroDialogSettings.DialogTitleFontSize = 30;
            metroDialogSettings.DialogMessageFontSize = 24;

            if (await _window.ShowMessageAsync("Encerrar", "Deseja encerrar o sistema e desligar o computador ?", MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings)== MessageDialogResult.Affirmative)
            {
                App.Current.MainWindow.Close();                
            }

            
        }
    }
}
