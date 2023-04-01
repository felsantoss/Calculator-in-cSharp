using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newCalculator
{
    public partial class Form1 : Form
    {
        decimal valueOne = 0, valueTwo = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            display.Text += "3";    
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

         private void button_9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                valueOne = Convert.ToDecimal(display.Text, CultureInfo.InvariantCulture);

                display.Text = "";

                operation = "plus";

                result.Text = "+";
            }
            else
            {
                MessageBox.Show("Digite um valor antes de prosseguir.");
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                valueOne = Convert.ToDecimal(display.Text, CultureInfo.InvariantCulture);

                display.Text = "";

                operation = "minus";

                result.Text = "-";
            }
            else
            {
                MessageBox.Show("Digite um valor antes de prosseguir.");
            }
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                valueOne = Convert.ToDecimal(display.Text, CultureInfo.InvariantCulture);

                display.Text = "";

                operation = "mult";

                result.Text = "x";
            }
            else
            {
                MessageBox.Show("Digite um valor antes de prosseguir.");
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if(display.Text != "")
            {
                valueOne = Convert.ToDecimal(display.Text, CultureInfo.InvariantCulture);

                display.Text = "";

                operation = "divide";

                result.Text = "/";
            }
            else
            {
                MessageBox.Show("Digite um valor antes de prosseguir.");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            display.Text = "";

            valueOne = 0;

            valueTwo = 0;

            result.Text = "";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();

            textBox.BorderStyle = BorderStyle.None;
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            valueTwo = Convert.ToDecimal(display.Text, CultureInfo.InvariantCulture);

            if (operation == "plus")
            {
                display.Text = Convert.ToString(valueOne + valueTwo);
            }
            else if(operation == "minus")
            {
                display.Text = Convert.ToString(valueOne - valueTwo);
            } 
            else if(operation == "mult")
            {
                display.Text = Convert.ToString(valueOne * valueTwo);
            }
            else
            {
                display.Text = Convert.ToString(valueOne / valueTwo);
            }

        }
    }
}
