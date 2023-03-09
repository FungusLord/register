using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ballShaker3000
{
    public partial class BallShaker3000 : Form
    {
        Random random = new Random();
        public BallShaker3000()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = random.Next(1, 8);
            switch(answer)
            {
                case 1:
                    outLabel.Text = "No way!";
                    break;
                case 2:
                    outLabel.Text = "Totally!";
                    break;
                case 3:
                    outLabel.Text = "Try again, bro.";
                    break;
                case 4:
                    outLabel.Text = "I dunno, dude.";
                    break;
                case 5:
                    outLabel.Text = "Huh? Repeat that.";
                    break;
                case 6:
                    outLabel.Text = "For sure man, that's radical!";
                    break;
                case 7:
                    outLabel.Text = "";
                    break;
                case 8:
                    outLabel.Text = "";
                    break;
            }
        }

        private void outLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
