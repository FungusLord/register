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
        int sleepTime = 350;
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
                preTaxOut.Text = "";
                postTaxOut.Text = "";
                //Define # of items
                crates = Convert.ToDouble(crateIn.Text);
                hats = Convert.ToDouble(hatIn.Text);
                keys = Convert.ToDouble(keyIn.Text);
                //Calculate totals
                taxRate = 0.13;
                preTax = crates * cratePrice + hats * hatPrice + keys * keyPrice;
                postTax = preTax + preTax * taxRate;
                //Output totals
                preTaxOut.Text = preTax.ToString("C");
                postTaxOut.Text = postTax.ToString("C");
                //Enable pay button
                payButton.Enabled = true;
            }
            catch
            {
                //Reset Input
                crateIn.Text = "";
                hatIn.Text = "";
                keyIn.Text = "";
                //Output error
                preTaxOut.Text = "ERROR";
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
                payOut.Text = "";
                changeOut.Text = "";
                //Define amount paid
                pay = Convert.ToDouble(payIn.Text);
                //Check if full amount is paid
                if (pay >= postTax)
                {
                    //Give change
                    //Output amount paid
                    payOut.Text = pay.ToString("C");
                    //Calculate change
                    change = pay - postTax;
                    //Output change
                    changeOut.Text = change.ToString("C");
                    //Enable print button
                    printButton.Enabled = true;

                }
                else
                {
                    //Need more money
                    //Reset Input
                    payIn.Text = "";
                    //Output error
                    payOut.Text = "Pay More!";
                }
            }
            catch
            {
                //Reset Input
                payIn.Text = "";
                //Output error
                payOut.Text = "ERROR";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //Reset input
            crateIn.Text = "";
            hatIn.Text = "";
            keyIn.Text = "";
            payIn.Text = "";
            //Reset Output
            preTaxOut.Text = "";
            postTaxOut.Text = "";
            payOut.Text = "";
            changeOut.Text = "";
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

            receipt.Text = $"MANN. CO ITEM SHOP";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\n";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nCRATE X {crates} - ${crates * cratePrice}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nHAT X {hats} - ${hats * hatPrice}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nKEY X {keys} - ${keys * keyPrice}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\n";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nPRE TAX - {preTaxOut.Text}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nTAX RATE - 13%";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nPOST TAX - {postTaxOut.Text}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nPAID - {payOut.Text}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nCHANGE - {changeOut.Text}";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\n";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nMANN. CO THANKS";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\nYOU!";
            Refresh();
            Thread.Sleep(sleepTime);

            receipt.Text += $"\n:)";
            Refresh();
            Thread.Sleep(sleepTime);
        }

        private void preTaxOut_Click(object sender, EventArgs e)
        {

        }
    }
}