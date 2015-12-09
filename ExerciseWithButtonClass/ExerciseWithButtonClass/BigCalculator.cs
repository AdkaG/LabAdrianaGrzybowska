using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseWithButtonClass
{
    public partial class BigCalculator : Form
    {
        public BigCalculator()
        {
            InitializeComponent();
        }
        
        private void AddNumberToTextBox(object sender, EventArgs e)
        {
            Button numberButton = (Button)sender;
            textBoxMonitor.Clear();
            textBoxMonitor.Text += numberButton.Text;
            
      
        }

        decimal total = 0;
        string myOperator;
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button buttonPlus = (Button)sender;
            decimal number = decimal.Parse(textBoxMonitor.Text);
            total += number;
            myOperator = "+";
            textBoxMonitor.Clear();
            //textBoxMonitor.Text = $"{total}" ;
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Button buttonPlus = (Button)sender;
            decimal number = decimal.Parse(textBoxMonitor.Text);
            total += number;
            myOperator = "-";

        }


        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            Button buttonClearAll = (Button)sender;
            textBoxMonitor.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
        }
        //private void btnEquals_Click(object sender, EventArgs e)
        //{
        //    double num2;
        //    double answer;

        //    num2 = double.Parse(txtDisplay.Text);

        //    switch (theOperator)
        //    {
        //        case "+":
        //            answer = total1 + num2;
        //            txtDisplay.Text = answer.ToString();
        //            total1 = 0;
        //            break;
        //        case "-":
        //            answer = total1 - num2;
        //            txtDisplay.Text = answer.ToString();
        //            total1 = 0;
        //            break;
        //        case "*":
        //            answer = total1 * num2;
        //            txtDisplay.Text = answer.ToString();
        //            total1 = 0;
        //            break;
        //        case "/":
        //            answer = total1 / num2;
        //            txtDisplay.Text = answer.ToString();
        //            total1 = 0;
        //            break;
        //        default:
        //            answer = 0;
        //            break;
        //    }
        }

        //private void buttonClearLast_Click(object sender, EventArgs e)
        //{

        //}
    }
