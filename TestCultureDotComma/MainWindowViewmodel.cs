using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestCultureDotComma
{
    public class MainWindowViewModel : ViewModelBase
    {
        private double _numero; public double Numero { get => _numero; set {  Set(() => Numero, ref _numero, value); }}

       
        public MainWindowViewModel()
        {
            Numero = 1;
        }

    }


}
