using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Diagnostics;
using System.Windows;

namespace euroPlus4_1.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public string VersaoAtual { get; private set; }
        
        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            
            VersaoAtual = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            RaiseChange("VersaoAtual");
            
        }


        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //Fim raise Change ------------------------------------------------------------------------------------------------------------------------
    }
}
