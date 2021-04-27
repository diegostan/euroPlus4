using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace euroPlus4_1.Models.Config
{
    class ConfigSistema
    {
       
        public int TemaSelecionado { get; set; }

        public int CorDeDestaqueSelecionado { get; set; }

        public bool AplicarModoEscuroAutomaticamente { get; set; }

        public DateTime HoraInicial { get; set; }

        public DateTime HoraFinal { get; set; }
        public ObservableCollection<ComboBoxItem> CoresDisponiveis { get; set; }
        public ObservableCollection<ComboBoxItem> TemasDisponiveis { get; set; }


        public ConfigSistema()
        {
            CoresDisponiveis = new ObservableCollection<ComboBoxItem>();
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Blue, FontWeight =  FontWeights.Bold , Foreground = Brushes.White, Height = 40, Content = "Blue" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Magenta, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Magenta" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Violet, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Violet" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Green, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Green" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Red, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Red" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Indigo, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Indigo" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Teal, FontWeight = FontWeights.Bold, Foreground = Brushes.White, Height = 40, Content = "Teal" });
            CoresDisponiveis.Add(new ComboBoxItem { Background = Brushes.Cyan, FontWeight = FontWeights.Bold, Foreground = Brushes.Black, Height = 40, Content = "Cyan" });

            TemasDisponiveis = new ObservableCollection<ComboBoxItem>();
            TemasDisponiveis.Add(new ComboBoxItem { Content = "Light", Height = 40 });
            TemasDisponiveis.Add(new ComboBoxItem { Content = "Dark", Height = 40 });
        }
    }

    
}
