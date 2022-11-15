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

namespace lommeregner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void minus_knap(object sender, RoutedEventArgs e) {
            CalculateWithOperator("0");
        }
        private void plus_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("1");        
        }
        private void division_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("2");
        }
        private void gange_knap(object sender, RoutedEventArgs e)
        {
            CalculateWithOperator("3");
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void secondinput_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
        private void CalculateWithOperator(string operatorString)
        {
            int firstinput = int.Parse(firstinputTextbox.Text);
            int secondinput = int.Parse(secondinputTextbox.Text);
            int resultat = 0;
            switch(operatorString) {
                case "0":
                    resultat = firstinput - secondinput;
                    break;
                case "1":
                    resultat = firstinput + secondinput;
                    break;
                case "2":
                    resultat = firstinput / secondinput;
                    break;
                case "3":
                    resultat = firstinput * secondinput;
                    break;
            }
                resultatBox.Text = resultat + "";
            { 
            }
        }
    }
}
