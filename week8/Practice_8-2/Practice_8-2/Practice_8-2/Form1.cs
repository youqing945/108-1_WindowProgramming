using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_8_2
{
    public partial class Form1 : Form
    {
        public static Form1 f1;
        Form2 f2 = new Form2();
        int currentPic = 0;
        int score = 0;
        bool gamestart;

        public Form1()
        {
            InitializeComponent();
            initial();
            f2.Show();
        }

        public void initial()
        {
            currentPic = 0;
            score = 0;
            lbScore.Text = "分數: 0";
            timer1.Stop();
            f1 = this;
            f2.setInitialImage();
            gamestart = false;
        }

        private void msi_Click(object sender, EventArgs e)
        {
            if(sender == msiStart)
            {
                msi_start();
            }
            else if(sender == msiPause)
            {
                msi_pause();
            }
            else if(sender == msiRestart)
            {
                msi_restart();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentPic = f2.changeImage();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(gamestart == true)
            {
                if ((e.KeyCode == Keys.Up && currentPic == 2) || (e.KeyCode == Keys.Down && currentPic == 3) || (e.KeyCode == Keys.Left && currentPic == 1) || (e.KeyCode == Keys.Right && currentPic == 0))
                {
                    score++;
                    lbScore.Text = "分數: " + score;
                    if (score % 10 == 0)
                    {
                        f2.imageSmaller();
                    }
                }
                timer1.Stop();
                currentPic = f2.changeImage();
                timer1.Start();
            }
        }

        public void msi_start()
        {
            currentPic = f2.changeImage();
            timer1.Start();
            gamestart = true;
        }

        public void msi_pause()
        {
            timer1.Stop();
            gamestart = false;
        }

        public void msi_restart()
        {
            initial();
        }
    }
}
