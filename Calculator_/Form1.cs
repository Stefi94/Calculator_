using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            textBoxNumber.Text = "";
            textBoxNumber.Focus();
        }
        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            Calc.SetSymbolAndA('*', textBoxNumber.Text);
            ResetTextBox();
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            Calc.SetSymbolAndA('/', textBoxNumber.Text);
            ResetTextBox();
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            Calc.SetSymbolAndA('+', textBoxNumber.Text);
            ResetTextBox();
        }

        private void ButtonSubstraction_Click(object sender, EventArgs e)
        {
            Calc.SetSymbolAndA('-', textBoxNumber.Text);
            ResetTextBox();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Calc.Reset();
            ResetTextBox();
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = Convert.ToString(Calc.Result(textBoxNumber.Text));
        }
    }
}
