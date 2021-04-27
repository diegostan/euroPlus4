using ControlzEx.Theming;
using euroPlus4_1.ViewModels;
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

namespace euroPlus4_1.Views
{
    /// <summary>
    /// Interação lógica para ConfigView.xam
    /// </summary>
    public partial class ConfigView : Page
    {
        MainWindow _window;
        public ConfigView(MainWindow window)
        {
            InitializeComponent();
            _window = window;
            DataContext = new ConfigViewModel(_window);
            
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
