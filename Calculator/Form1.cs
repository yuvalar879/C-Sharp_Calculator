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
    public partial class Form1 : Form
    {
        private double result = 0;
        private String op = "";
        bool Op_performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            Op_label.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {

            switch(op)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "×":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "÷":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }

        }

        private void dot_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || Op_performed)
                textBox1.Clear();

            Op_performed = false;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            op = button.Text;
            result = double.Parse(textBox1.Text);
            Op_label.Text = result + " " + op;
            Op_performed = true;

        }
    }
}
