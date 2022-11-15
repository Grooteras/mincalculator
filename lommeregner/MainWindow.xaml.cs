using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lommeregner
{
    public partial class MainWindow : Window
    {
        public object Label { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        //button info
        private void minus_knap(object sender, RoutedEventArgs e) {
            CalculateWithOperator("-");
        }
        private void plus_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("+");        
        }
        private void division_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("/");
        }
        private void gange_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("*");
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void secondinput_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void CalculateWithOperator(string operatorString)
        {
            //buttons funktion
            int firstinput = int.Parse(firstinputTextbox.Text);
            int secondinput = int.Parse(secondinputTextbox.Text);
            int resultat = 0;
            switch(operatorString) {
                case "-":
                    resultat = firstinput - secondinput;
                    break;
                case "+":
                    resultat = firstinput + secondinput;
                    break;
                case "/":
                    resultat = firstinput / secondinput;
                    break;
                case "*":
                    resultat = firstinput * secondinput;
                    break;
            }
                resultatBox.Text = resultat + "";
            sign.Text = operatorString;
            {
            }
        }
    }
}