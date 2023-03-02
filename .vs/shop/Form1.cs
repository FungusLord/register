using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace shop
{
    public partial class ItemShop : Form
    {
        //Define variables
        double taxRate;
        double preTax;
        double postTax;
        double pay;
        double crates;
        double hats;
        double keys;
        double change;
        //Prices
        const double cratePrice = 3.00;
        const double hatPrice = 1.50;
        const double keyPrice = 5.00;

        public ItemShop()
        {
            InitializeComponent();
        }

        private void ItemShop_Load(object sender, EventArgs e)
        {
            payButton.Enabled = false;
            printButton.Enabled = false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Reset labels
                preTaxLabel.Text = "Pre Tax:";
                postTaxLabel.Text = "After Tax:";
                //Define # of items
                crates = Convert.ToDouble(crateIn.Text);
                hats = Convert.ToDouble(hatIn.Text);
                keys = Convert.ToDouble(keyIn.Text);
                //Calculate totals
                taxRate = 0.13;
                preTax = crates * cratePrice + hats * hatPrice + keys * keyPrice;
                postTax = preTax + preTax * taxRate;
                //Output totals
                preTaxLabel.Text = preTaxLabel.Text + preTax.ToString("C");
                postTaxLabel.Text += postTax;
                //Enable pay button //
                payButton.Enabled = true;
            }
            catch
            {
                //Reset Input
                crateIn.Text = "";
                hatIn.Text = "";
                keyIn.Text = "";
                //Output error
                preTaxLabel.Text = preTaxLabel.Text + " INPUT ERROR :(";
            }
        }

        private void preTaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Reset Labels
                payInLabel.Text = "Amount Paid: $";
                changeLabel.Text = "Change: $";
                //Define amount paid
                pay = Convert.ToDouble(payIn.Text);
                //Check if full amount is paid
                if (pay >= postTax)
                {
                    //Give change
                    //Output amount paid
                    payInLabel.Text = payInLabel.Text + pay;
                    //Calculate change
                    change = pay - postTax;
                    //Output change
                    changeLabel.Text = changeLabel.Text + change;
                    //Enable print button
                    printButton.Enabled = true;

                }
                else
                {
                    //Need more money
                    //Reset Input
                    payIn.Text = "";
                    //Output error
                    payInLabel.Text = payInLabel.Text + " Pay More!";
                }
            }
            catch
            {
                //Reset Input
                payIn.Text = "";
                //Output error
                payInLabel.Text = payInLabel.Text + " INPUT ERROR :(";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //Reset input
            crateIn.Text = "";
            hatIn.Text = "";
            keyIn.Text = "";
            payIn.Text = "";
            //Reset labels
            preTaxLabel.Text = "Pre Tax: $";
            postTaxLabel.Text = "After Tax: $";
            payInLabel.Text = "Amount Paid: $";
            changeLabel.Text = "Change: $";
            //Reset Receipt
            receipt.Text = "";
            receipt.Visible = false;
            //Reset Buttons
            payButton.Enabled = false;
            printButton.Enabled = false;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            receipt.Visible = true;

            receipt.Text = $@"MANN. CO ITEM SHOP";
            Refresh();
            Thread.Sleep(400);

            receipt.Text += $"\nCRATE X {crates} - ${crates * cratePrice}";
            Refresh();
            Thread.Sleep(400);

            //CRATE X {crateIn.Text} - ${crates * cratePrice}
            //HAT X {hatIn.Text} - ${hats * hatPrice}
            //KEY X {keyIn.Text} - ${keys * keyPrice}

            //PRE TAX: ${preTax}
            //TAX: {taxRate}%
            //AFTER TAX: ${postTax}

            //PAID: ${pay}
            //CHANGE: ${change}

            //MANN.CO THANKS YOU!
            //:)";
        }
    }
}
