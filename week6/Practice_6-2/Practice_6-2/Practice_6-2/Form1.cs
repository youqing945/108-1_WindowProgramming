using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6_2
{
    public partial class Form1 : Form
    {
        static int numOfInv = 12;
        PictureBox[] picInvaders = new PictureBox[numOfInv];
        int[] invadersInitialX = new int[numOfInv];
        int[] invadersSpeed = new int[numOfInv];
        double[] invadersHideTime = new double[numOfInv];
        int Score;
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
            gameStart();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*左*/if ((picShip.Location.X - 5 >= 0) && e.KeyCode == Keys.Left) picShip.Location = Point.Add(picShip.Location, new Size(-5, 0));
            /*右*/if ((picShip.Location.X + picShip.Width + 5) <= this.ClientSize.Width && e.KeyCode == Keys.Right) picShip.Location = Point.Add(picShip.Location, new Size(5, 0));
            /*上*/if ((picShip.Location.Y - 5 >= 0) && e.KeyCode == Keys.Up) picShip.Location = Point.Add(picShip.Location, new Size(0, -5));
            /*下*/if ((picShip.Location.Y + picShip.Height + 5) <= this.ClientSize.Height && e.KeyCode == Keys.Down) picShip.Location = Point.Add(picShip.Location, new Size(0, 5));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + Score;

            for (int i = 0; i < numOfInv; i++)
            {
                if (invadersHideTime[i] >= 0) invadersHideTime[i]--;
                else if (invadersHideTime[i] < 0 && picInvaders[i].Location.Y >= this.ClientSize.Height)
                {
                    invaderNewPos(i);
                    Score++;
                }
                else picInvaders[i].Location = new Point(picInvaders[i].Location.X, picInvaders[i].Location.Y + invadersSpeed[i]);

                if (picShip.Bounds.IntersectsWith(picInvaders[i].Bounds))
                {
                    timer1.Stop();
                    this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                    DialogResult result;
                    result = MessageBox.Show("Your Score: " + Score + "\n按下確定重新開始", "遊戲結束", MessageBoxButtons.OK);
                    if(result == System.Windows.Forms.DialogResult.OK)
                    {
                        Controls.Clear();
                        InitializeComponent();
                        gameStart();
                    }
                }
            }
        }

        public void invaderNewPos(int i)
        {
            invadersInitialX[i] = ran.Next() % (this.ClientSize.Width - picInvaders[i].Size.Width);
            invadersSpeed[i] = ran.Next()%7+3;
            invadersHideTime[i] = ran.Next(0,101);

            picInvaders[i].Location = new Point(invadersInitialX[i], 0-picInvaders[i].Height);
        }

        public void gameStart()
        {
            Score = 0;

            picShip.Location = new Point(this.ClientSize.Width / 2 - 45, this.ClientSize.Height - 90);

            for (int i = 0; i < numOfInv; i++)
            {
                picInvaders[i] = new PictureBox();
                picInvaders[i].Size = new Size(45, 45);
                picInvaders[i].Image = Image.FromFile(@"../../img/Invader.png");
                picInvaders[i].SizeMode = PictureBoxSizeMode.StretchImage;
                invaderNewPos(i);
                this.Controls.Add(picInvaders[i]);
            }

            timer1.Start();
        }
    }
}