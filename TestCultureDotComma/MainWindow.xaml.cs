using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestCultureDotComma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



       


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {

            MainWindowViewModel mwvm = (MainWindowViewModel)DataContext;
            MessageBox.Show($"{mwvm.Numero}", "Numero:");
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemComma || e.Key == Key.OemPeriod)
            {
                var caretPosition = t3.SelectionStart;
                string s = t3.Text;
                s=s.Insert(caretPosition, ".");
                t3.Text=s;
                t3.SelectionStart = caretPosition + 1;
                t3.SelectionLength = 0;
                e.Handled = true;
            }
            base.OnKeyDown(new KeyEventArgs(e.KeyboardDevice, e.InputSource, e.Timestamp, e.Key));

        }

    }
}
