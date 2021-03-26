using GalaSoft.MvvmLight;
using System.Globalization;

namespace TestCultureDotComma
{
    public class MainWindowViewModel : ViewModelBase
    {
        private double _numero; public double Numero { get => _numero; set { Set(() => Numero, ref _numero, value); } }
        private string _stringa2; public string Stringa2
        {
            get => _stringa2;
            set
            {
                Set(() => Stringa2, ref _stringa2, value);
                string normalized = Stringa2.Replace(",", ".");
                try
                {
                    Numero2= double.Parse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture);
                }
                catch (System.Exception)
                {
                }
            }
        }
        private double _numero2; public double Numero2
        {
            get => _numero2; set { Set(() => Numero2, ref _numero2, value); }
        }


        private double _numero3; public double Numero3 { get => _numero3; set { Set(() => Numero3, ref _numero3, value); }}
        public MainWindowViewModel()
        {
            Numero = 1;
            Numero2 = 2;
        }

    }


}
