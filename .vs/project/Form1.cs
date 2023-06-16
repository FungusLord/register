using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Yellow, 25);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            g.TranslateTransform(300, 200);
            g.RotateTransform(135);
            g.Clear(Color.Red);
            g.FillRectangle(drawBrush, 0, 0, 40, 20);
            g.FillRectangle(drawBrush, -60, -80, 20, 100);
            g.FillRectangle(drawBrush, -75, 20, 50, 20);
            drawBrush.Color = Color.Red;
            g.FillEllipse(drawBrush, -85, 30, 20, 20);
            g.DrawArc(drawPen, -100, -40, 90, 100, 150, 220);
        }
    }
}
