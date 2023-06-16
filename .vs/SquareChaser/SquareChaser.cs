using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareChaser
{
    public partial class squareChaser : Form
    {
        Random random = new Random();
        Rectangle p1 = new Rectangle(50, 200, 25, 25);
        Rectangle p2 = new Rectangle(525, 200, 25, 25);
        Rectangle boost = new Rectangle(0, 0, 10, 10);
        Rectangle point = new Rectangle(0, 0, 10, 10);
        int p1Score = 0;
        int p2Score = 0;
        int p1Speed = 2;
        int p2Speed = 2;
        bool wDown = false;
        bool aDown = false;
        bool sDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool leftArrowDown = false;
        bool downArrowDown = false;
        bool rightArrowDown = false;
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush yellowBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        public squareChaser()
        {
            InitializeComponent();
            boost.X = random.Next(0, 591);
            boost.Y = random.Next(100, 391);
            point.X = random.Next(0, 591);
            point.Y = random.Next(100, 391);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //move p1
            if (wDown == true && p1.Y > 100)
            {
                p1.Y -= p1Speed;
            }
            if (aDown == true && p1.X > 0)
            {
                p1.X -= p1Speed;
            }
            if (sDown == true && p1.Y < this.Height - p1.Height)
            {
                p1.Y += p1Speed;
            }
            if (dDown == true && p1.X < this.Width - p1.Width)
            {
                p1.X += p1Speed;
            }
            //move p2
            if (upArrowDown == true && p2.Y > 100)
            {
                p2.Y -= p2Speed;
            }
            if (leftArrowDown == true && p2.X > 0)
            {
                p2.X -= p2Speed;
            }
            if (downArrowDown == true && p2.Y < this.Height - p2.Height)
            {
                p2.Y += p2Speed;
            }
            if (rightArrowDown == true && p2.X < this.Width - p2.Width)
            {
                p2.X += p2Speed;
            }
            //check for p1 intersects
            if(p1.IntersectsWith(boost))
            {
                p1Speed += 1;
                boost.X = random.Next(0, 591);
                boost.Y = random.Next(100, 391);

            }
            if(p1.IntersectsWith(point))
            {
                p1Score += 1;
                point.X = random.Next(0, 591);
                point.Y = random.Next(100, 391);
            }
            //check for p2 intersects
            if (p2.IntersectsWith(boost))
            {
                p2Speed += 1;
                boost.X = random.Next(0, 591);
                boost.Y = random.Next(100, 391);
            }
            if (p2.IntersectsWith(point))
            {
                p2Score += 1;
                point.X = random.Next(0, 591);
                point.Y = random.Next(100, 391);
            }
            //update score labels
            p1ScoreLabel.Text = Convert.ToString(p1Score);
            p2ScoreLabel.Text = Convert.ToString(p2Score);
            //win condition
            if(p1Score >= 10)
            {
                winLabel.Text = "Player 1 Wins!";
                gameTimer.Stop();
            }
            if(p2Score >= 10)
            {
                winLabel.Text = "Player 2 Wins!";
                gameTimer.Stop();
            }
            //refresh
            Refresh(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, p1);
            e.Graphics.FillRectangle(blueBrush, p2);
            e.Graphics.FillRectangle(yellowBrush, boost);
            e.Graphics.FillRectangle(greenBrush, point);
        }
    }
}