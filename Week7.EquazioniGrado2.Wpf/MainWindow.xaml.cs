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
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double valueA;
        private double valueB;
        private double valueC;
        private double?[] risultato;
        Equation equation = new Equation();
        public MainWindow()
        {
            InitializeComponent();
        }
        private double SetValueA()
        {
            return double.Parse(txtValueA.Text);
        }
        private double SetValueB()
        {
            return double.Parse(txtValueB.Text);
        }
        private double SetValueC()
        {
            return double.Parse(txtValueC.Text);
        }
        private void btnVai_Click(object sender, EventArgs e)
        {
            valueA = SetValueA();
            valueB = SetValueB();
            valueC = SetValueC();
            risultato = equation.Risolvi(valueA, valueB, valueC);
            if (risultato == null)
            {
                txtValueSolutions.Text = "Non esistono soluzioni!";
            }
            else if (risultato.Length == 1)
            {
                txtValueSolutions.Text = $"L'unica soluzione è x={risultato[0]}";
            }
            else
            {
                txtValueSolutions.Text = $"Le due soluzioni sono x1={risultato[0]} e x2={risultato[1]}";
            }

        }
        private void menuExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
