using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using euroPlus4_1.ViewModels;

namespace euroPlus4_1.Views
{
    /// <summary>
    /// Interação lógica para UsuariosView.xam
    /// </summary>
    public partial class UsuariosView : Page
    {

        MainWindow _window;
        UsuariosViewModel usuariosViewModel;
        public UsuariosView(MainWindow window)
        {
            InitializeComponent();
            _window = window;

            usuariosViewModel = new UsuariosViewModel(_window);
            
            DataContext = usuariosViewModel;
        }

        private void Page_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        public void AtualizaUsuarios()
        {
            usuariosViewModel.AtualizaListaDeUsuarios();
        }

        public void AtualizarTelas()
        {
            usuariosViewModel.AtualizaListaDeTelas();
        }

        public void RetornaMenu()
        {
            menu.SelectedIndex = 0;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            _window.MostrarTeclado(false);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            _window.EsconnderTeclado();
        }

        private void NumericUpDown_GotFocus(object sender, RoutedEventArgs e)
        {
            _window.MostrarTeclado(true);
        }

        private void NumericUpDown_LostFocus(object sender, RoutedEventArgs e)
        {
            _window.EsconnderTeclado();
        }
    }
}
