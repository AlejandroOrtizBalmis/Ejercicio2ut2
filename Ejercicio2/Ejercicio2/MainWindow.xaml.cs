using System.Windows;

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operadorTextBox.Text = "";
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            resultadoTextBox.Text = "";
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            switch (operadorTextBox.Text)
            {
                case "+":
                    resultadoTextBox.Text = (double.Parse(operando1TextBox.Text) + double.Parse(operando2TextBox.Text)).ToString();
                    break;
                case "-":
                    resultadoTextBox.Text = (double.Parse(operando1TextBox.Text) - double.Parse(operando2TextBox.Text)).ToString();
                    break;
                case "*":
                    resultadoTextBox.Text = (double.Parse(operando1TextBox.Text) * double.Parse(operando2TextBox.Text)).ToString();
                    break;
                case "/":
                    resultadoTextBox.Text = (double.Parse(operando1TextBox.Text) / double.Parse(operando2TextBox.Text)).ToString();
                    break;
                default:
                    resultadoTextBox.Text = "ERROR";
                    break;
            }
        }
    }
}
