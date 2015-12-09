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
    public partial class MiniCalculator : Form
    {
        public MiniCalculator()
        {
            InitializeComponent();
        }

        private void MiniCalculator_Load(object sender, EventArgs e)
        {
            
            //TextBox firstNumber = new TextBox
            //{
            //    Height = 40,
            //    Width = 300,
            //    Top = 10,
            //    Left = 10,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false
            //};
            //TextBox secondNumber = new TextBox
            //{
            //    Height = 40,
            //    Width = 300,
            //    Top = 60,
            //    Left = 10,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false
            //};
            //Label equal = new Label
            //{
            //    Height = 40,
            //    Width = 300,
            //    Top = 110,
            //    Left = 10,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false,
            //    Text = "=",
            //    Font = new Font("Arial", 18),
            //    TextAlign = ContentAlignment.MiddleCenter

            //};
            //TextBox result = new TextBox
            //{
            //    Height = 40,
            //    Width = 300,
            //    Top = 160,
            //    Left = 10,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false
            //};
            //Button divide = new Button
            //{
            //    Height = 50,
            //    Width = 70,
            //    Top = 210,
            //    Left = 10,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false,
            //    Text = "/",
            //    Font = new Font("Arial", 18)
            //};

            //Button multi = new Button
            //{
            //    Height = 50,
            //    Width = 70,
            //    Top = 210,
            //    Left = 85,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false,
            //    Text = "*",
            //    Font = new Font("Arial", 18)
            //};
            //Button minus = new Button
            //{
            //    Height = 50,
            //    Width = 70,
            //    Top = 210,
            //    Left = 160,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false,
            //    Text = "-",
            //    Font = new Font("Arial", 18),
            //};
            //Button plus = new Button
            //{
            //    Height = 50,
            //    Width = 70,
            //    Top = 210,
            //    Left = 235,
            //    Anchor = AnchorStyles.Left | AnchorStyles.Top,
            //    AutoSize = false,
            //    Text = "+",
            //    Font = new Font("Arial", 18)
            //};

            //Controls.Add(firstNumber);
            //Controls.Add(secondNumber);
            //Controls.Add(equal);
            //Controls.Add(result);
            //Controls.Add(divide);
            //Controls.Add(multi);
            //Controls.Add(minus);
            //Controls.Add(plus);



        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button buttonDivide = (Button)sender;
            int firstNumber = int.Parse(textBoxFirstNumber.Text);
            int secondNumber = int.Parse(textBoxSecondNumber.Text);
            int result = firstNumber / secondNumber;
            textBoxResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBoxFirstNumber.Text);
            int secondNumber = int.Parse(textBoxSecondNumber.Text);
            int result = firstNumber * secondNumber;
            textBoxResult.Text = result.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBoxFirstNumber.Text);
            int secondNumber = int.Parse(textBoxSecondNumber.Text);
            int result = firstNumber - secondNumber;
            textBoxResult.Text = result.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(textBoxFirstNumber.Text);
            int secondNumber = int.Parse(textBoxSecondNumber.Text);
            int result = firstNumber + secondNumber;
            textBoxResult.Text = result.ToString();
        }
    }
    }

