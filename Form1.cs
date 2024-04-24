using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String value1 = textBox1.Text;
            String value2 = textBox2.Text;

            int val1;
            int val2;

            val1 = int.Parse(value1);
            val2 = int.Parse(value2);

            int sum = val1 + val2;

            MessageBox.Show(sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String value3 = textBox3.Text;
            String value4 = textBox4.Text;

            int val3;
            int val4;

            val3 = int.Parse(value3);
            val4 = int.Parse(value4);

            int diff = val3 - val4;
            if (diff >= 0)
            {
                MessageBox.Show(diff.ToString());
            }

            else
            {
                MessageBox.Show(diff.ToString(), "The result gotten was not a real number! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String value5 = textBox5.Text;
            String value6 = textBox6.Text;

            int val5 = int.Parse(value5);
            int val6 = int.Parse(value6);

            int multiply = val5 * val6;

            MessageBox.Show(multiply.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String value7 = textBox7.Text;
            String value8 = textBox8.Text;

            float val7 = float.Parse(value7);
            float val8 = float.Parse(value8);

            float division = val7 / val8;

            if (val8 > 0)
            {
                MessageBox.Show(division.ToString());
            }

            else
            {
                MessageBox.Show("Cannot divide with 0 as denominator");
            }
        }
    }
}
