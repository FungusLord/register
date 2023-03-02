using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //declare variables
                double hours = Convert.ToDouble(hoursIn.Text);
                double rate = Convert.ToDouble(payIn.Text);

                //do calculations
                double taxRate = 0.20;
                double preTax = hours * rate;
                double afterTax = preTax - taxRate * preTax;

                //output
                preTaxOut.Text = $"{preTax.ToString("$.00")}";
                afterTaxOut.Text = $"{afterTax.ToString("$.00")}";
            }
            catch
            {
                preTaxOut.Text = "ERROR";
                hoursIn.Text = "";
                payIn.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void afterTaxLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
