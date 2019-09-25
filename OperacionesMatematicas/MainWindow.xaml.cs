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

namespace OperacionesMatematicas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            ResultadoTextBox.Text = "0";
            SumaCheckBox.IsChecked = true;
        }

        private void Suma()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) + double.Parse(Operando2TextBox.Text)).ToString();
        }

        private void Resta()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) - double.Parse(Operando2TextBox.Text)).ToString();
        }

        private void Multiplicacion()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
                ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) * double.Parse(Operando2TextBox.Text)).ToString();
        }

        private void Division()
        {
            if (Operando1TextBox.Text != "" && Operando2TextBox.Text != "")
            {
                if (Operando2TextBox.Text == "0")
                    ResultadoTextBox.Text = "Error";
                else
                    ResultadoTextBox.Text = (double.Parse(Operando1TextBox.Text) / double.Parse(Operando2TextBox.Text)).ToString();
            }
        }

        private void RadioButton_Checked_Suma(object sender, RoutedEventArgs e)
        {
            Suma();
        }

        private void RadioButton_Checked_Resta(object sender, RoutedEventArgs e)
        {
            Resta();
        }

        private void RadioButton_Checked_Multipliacion(object sender, RoutedEventArgs e)
        {
            Multiplicacion();
        }

        private void RadioButton_Checked_Division(object sender, RoutedEventArgs e)
        {
            Division();            
        }

        private void OperandoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SumaCheckBox.IsChecked == true)
            {
                Suma();
            }
            else if (RestaCheckBox.IsChecked == true)
            {
                Resta();
            }
            else if (MultiplicacionCheckBox.IsChecked == true)
            {
                Multiplicacion();
            }
            else if (DivisionCheckBox.IsChecked == true)
            {
                Division();
            }

        }
    }
}
