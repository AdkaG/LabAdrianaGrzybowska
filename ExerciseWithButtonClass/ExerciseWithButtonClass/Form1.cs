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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button { Height = 100, Width = 100,  Top = 100, Left= 100, Visible = true, BackColor = Color.HotPink};
            Controls.Add(button);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
