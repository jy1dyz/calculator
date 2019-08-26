using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

                

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            textBox2.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;

        private void Button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (sign)
            {
                case '+':  c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    break;
                       
            }
            textBox1.Text = c.ToString();
            textBox2.Text = c.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        char sign = '+';

        private void Button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            sign = (sender as Button).Text[0];
            textBox1.Clear();
        }

        
    }
}
