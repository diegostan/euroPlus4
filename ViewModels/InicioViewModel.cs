using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using euroPlus4_1.Models;

namespace euroPlus4_1.ViewModels
{
    class InicioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
      
      
        public InicioViewModel()
        {
                       
        }
        //Metodos--------------------------------------------------------------------------------------------------------------------------------
       
        //Fim metodos----------------------------------------------------------------------------------------------------------------------------

        //Raise Change --------------------------------------------------------------------------------------------------------------------------
        void RaiseChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        //Fim raise Change --------------------------------------------------------------------------------------------------------------------------
    }
}
