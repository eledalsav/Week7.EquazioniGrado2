using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2.WindForm
{
    public partial class EquationSolver : Form
    {
        private double a, b, c;
        private double?[] risultato;
        private Equation equation = new Equation();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public EquationSolver()
        {
            InitializeComponent();
        }

        private double SetValueA()
        {
            return double.Parse(textBoxA.Text);
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            a = SetValueA();
            b = SetValueB();
            c = SetValueC();
            risultato = equation.Risolvi(a, b, c);
            if (risultato == null)
            {
                textRisultato.Text = "Non esistono soluzioni!";
            }else if(risultato.Length == 1)
            {
                textRisultato.Text = $"L'unica soluzione è x={risultato[0]}";
            }
            else
            {
                textRisultato.Text = $"Le due soluzioni sono x1={risultato[0]} e x2={risultato[1]}";
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private double SetValueB()
        {
            return double.Parse(textBoxB.Text);
        }
        private double SetValueC()
        {
            return double.Parse(textBoxC.Text);
        }

    }
}
