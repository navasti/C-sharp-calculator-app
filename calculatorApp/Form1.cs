using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class Form1 : Form
    {

        string first;
        string second;
        char operation;
        double result;
        public Form1()
        {
            InitializeComponent();
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {

        }
        private void oneButton_Click(object sender, EventArgs e)
        {

        }

        private void twoButton_Click(object sender, EventArgs e)
        {

        }

        private void threeButton_Click(object sender, EventArgs e)
        {

        }

        private void fourButton_Click(object sender, EventArgs e)
        {

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {

        }

        private void sixButton_Click(object sender, EventArgs e)
        {

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {

        }

        private void eightButton_Click(object sender, EventArgs e)
        {

        }

        private void nineButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.operation = 'C';
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            this.operation = '/';
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            this.operation = 'x';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            this.operation = '+';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            this.operation = '-';
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            this.operation = '=';
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            this.operation = '.';
        }

        private void resultDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
