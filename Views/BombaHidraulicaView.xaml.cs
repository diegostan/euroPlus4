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
using euroPlus4_1.Models.Comm;

namespace euroPlus4_1.Views
{
    /// <summary>
    /// Interação lógica para BombaHidraulicaView.xam
    /// </summary>
    public partial class BombaHidraulicaView : Page
    {
        MainWindow _window;
        
        public BombaHidraulicaView(MainWindow window)
        {
            InitializeComponent();            
            _window = window;
            
            DataContext = new BombaHidraulicaViewModel(_window);
        }

        private void NumericUpDown_GotFocus(object sender, RoutedEventArgs e)
        {
            _window.MostrarTeclado(true);
        }

        private void NumericUpDown_LostFocus(object sender, RoutedEventArgs e)
        {
            _window.EsconnderTeclado();
        }

        public void RetornaMenu()
        {
            menu.SelectedIndex = 0;
        }
    }
}
