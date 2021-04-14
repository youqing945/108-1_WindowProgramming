using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6_1
{
    public partial class Form1 : Form
    {
        static int numOfBricks = 20;
        int CurrentBricks = numOfBricks;
        Label[] Bricks = new Label[numOfBricks];
        Label BoardPlayer;
        Label BoardEnemy;
        PictureBox Ball;
        Label ScoreLabel;
        int Score;
        int[] Speed = new int[2] {5, -5};

        int mdx = 0;

        public Form1()
        {
            InitializeComponent();
            gameStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Ball.Location += Direction();

            if (Ball.Bottom >= this.ClientSize.Height)
            {
                timer1.Stop();
                DialogResult result;
                result = MessageBox.Show("遊戲失敗！\n您的分數：" + Score + "\n按下確定以重新遊戲。", "遊戲結束", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Controls.Clear();
                    InitializeComponent();
                    gameStart();
                }
            }
            if (Ball.Right >= this.ClientSize.Width || Ball.Left <= 0) Speed[0] = -Speed[0];
            if (Ball.Top <= 0) Speed[1] = -Speed[1];

            //Player Board
            if (Ball.Bounds.IntersectsWith(BoardPlayer.Bounds))
            {
                if (Speed[0] > 0)
                {
                    if (Speed[1] < 0) //ru
                    {
                        if (Math.Abs(Ball.Top - BoardPlayer.Bottom) < Math.Abs(Ball.Right - BoardPlayer.Left)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                    else //rd
                    {
                        if (Math.Abs(Ball.Bottom - BoardPlayer.Top) < Math.Abs(Ball.Right - BoardPlayer.Left)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                }
                else
                {
                    if (Speed[1] > 0) //ld
                    {
                        if (Math.Abs(Ball.Bottom - BoardPlayer.Top) < Math.Abs(Ball.Left - BoardPlayer.Right)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                    else //lu
                    {
                        if (Math.Abs(Ball.Top - BoardPlayer.Bottom) < Math.Abs(Ball.Left - BoardPlayer.Right)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                }
            }

            //Enemy Board
            if (Ball.Bounds.IntersectsWith(BoardEnemy.Bounds))
            {
                if (Speed[0] > 0)
                {
                    if (Speed[1] < 0) //ru
                    {
                        if (Math.Abs(Ball.Top - BoardEnemy.Bottom) < Math.Abs(Ball.Right - BoardEnemy.Left)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                    else //rd
                    {
                        if (Math.Abs(Ball.Bottom - BoardEnemy.Top) < Math.Abs(Ball.Right - BoardEnemy.Left)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                }
                else
                {
                    if(Speed[1]>0) //ld
                    {
                        if (Math.Abs(Ball.Bottom - BoardEnemy.Top) < Math.Abs(Ball.Left - BoardEnemy.Right)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                    else //lu
                    {
                        if (Math.Abs(Ball.Top - BoardEnemy.Bottom) < Math.Abs(Ball.Left - BoardEnemy.Right)) Speed[1] = -Speed[1];
                        else Speed[0] = -Speed[0];
                    }
                }

            }

            if (Ball.Location.Y <= BoardEnemy.Location.Y) //ball above the board
            {
                if (Ball.Location.X + Ball.Width / 2 < BoardEnemy.Location.X + BoardEnemy.Width / 2)
                {
                    if (BoardEnemy.Location.X + BoardEnemy.Width + 1 <= this.ClientSize.Width) BoardEnemy.Location += new Size(1, 0);
                }
                else
                    if(BoardEnemy.Location.X - 1 >= 0) BoardEnemy.Location += new Size(-1, 0);
            }
            else //ball below the board
            {
                if (Ball.Location.X + Ball.Width / 2 < BoardEnemy.Location.X + BoardEnemy.Width / 2)
                {
                    if(BoardEnemy.Location.X - 1 >= 0) BoardEnemy.Location += new Size(-1, 0);
                } 
                else
                    if (BoardEnemy.Location.X + BoardEnemy.Width + 1 <= this.ClientSize.Width) BoardEnemy.Location += new Size(1, 0);
            }

            //Bricks
            for(int i = 0; i < numOfBricks; i++)
            {
                if(Bricks[i].Visible == true)
                {
                    if (Ball.Bounds.IntersectsWith(Bricks[i].Bounds))
                    {
                        if (Speed[0] > 0)
                        {
                            if (Speed[1] < 0) //ru
                            {
                                if (Math.Abs(Ball.Top - Bricks[i].Bottom) < Math.Abs(Ball.Right - Bricks[i].Left)) Speed[1] = -Speed[1];
                                else Speed[0] = -Speed[0];
                            }
                            else //rd
                            {
                                if (Math.Abs(Ball.Bottom - Bricks[i].Top) < Math.Abs(Ball.Right - Bricks[i].Left)) Speed[1] = -Speed[1];
                                else Speed[0] = -Speed[0];
                            }
                        }
                        else
                        {
                            if (Speed[1] > 0) //ld
                            {
                                if (Math.Abs(Ball.Bottom - Bricks[i].Top) < Math.Abs(Ball.Left - Bricks[i].Right)) Speed[1] = -Speed[1];
                                else Speed[0] = -Speed[0];
                            }
                            else //lu
                            {
                                if (Math.Abs(Ball.Top - Bricks[i].Bottom) < Math.Abs(Ball.Left - Bricks[i].Right)) Speed[1] = -Speed[1];
                                else Speed[0] = -Speed[0];
                            }
                        }
                        Bricks[i].Visible = false;
                        Score++;
                        ScoreLabel.Text = "Score: " + Score;
                        CurrentBricks--;
                        
                        
                    }
                }
                
            }

            if (CurrentBricks <= 0)
            {
                timer1.Stop();
                DialogResult result;
                result = MessageBox.Show("恭喜成功完成遊戲！\n您的分數：" + Score + "\n按下確定以重新遊戲。", "遊戲結束", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Controls.Clear();
                    InitializeComponent();
                    gameStart();
                }
            }

        }

        public void gameStart()
        {
            this.ClientSize = new Size(400, 500);
            //Bricks
            for (int i = 0; i < numOfBricks; i++)
            {
                Bricks[i] = new Label();
                Bricks[i].BackColor = Color.FromArgb(201, 71, 71);
                Bricks[i].BorderStyle = BorderStyle.FixedSingle;
                Bricks[i].Size = new Size(this.ClientSize.Width / 5, this.ClientSize.Height / 20);
                Bricks[i].Location = new Point((i % 5) * (this.ClientSize.Width / 5), this.ClientSize.Height / 20 * (i / 5));
                Bricks[i].Visible = true;
                Controls.Add(Bricks[i]);
            }

            //Board Player
            BoardPlayer = new Label();
            BoardPlayer.BackColor = Color.FromArgb(128, 200, 255);
            BoardPlayer.BorderStyle = BorderStyle.FixedSingle;
            BoardPlayer.Size = new Size(this.ClientSize.Width / 5 , this.ClientSize.Height / 30);
            BoardPlayer.Location = new Point(this.ClientSize.Width/2-BoardPlayer.Width/2,this.ClientSize.Height*9/10);
            Controls.Add(BoardPlayer);

            BoardPlayer.Click += BoardPlayer_ClickStart;

            //Board Enemy
            BoardEnemy = new Label();
            BoardEnemy.BackColor = Color.FromArgb(223, 128, 255);
            BoardEnemy.BorderStyle = BorderStyle.FixedSingle;
            BoardEnemy.Size = new Size(this.ClientSize.Width * 2 / 9, this.ClientSize.Height / 30);
            BoardEnemy.Location = new Point(this.ClientSize.Width / 2 - BoardEnemy.Width / 2, this.ClientSize.Height * 2 / 5);
            Controls.Add(BoardEnemy);

            //Ball
            Ball = new PictureBox();
            Ball.Size = new Size(20, 20);
            Ball.Image = Image.FromFile(@"../../img/pp.gif");
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.Location = new Point(this.ClientSize.Width/2-Ball.Width/2, BoardPlayer.Location.Y-Ball.Height);
            Controls.Add(Ball);

            //Score Label
            ScoreLabel = new Label();
            ScoreLabel.Text = "點擊板子以開始";
            ScoreLabel.Location = new Point(0, this.ClientSize.Height - ScoreLabel.Height);
            Controls.Add(ScoreLabel);

            Score = 0;
            CurrentBricks = numOfBricks;
            Speed[0] = 2;
            Speed[1] = -2;
        }

        private void BoardPlayer_ClickStart(object sender, EventArgs e)
        {
            timer1.Start();
            BoardPlayer.Click -= BoardPlayer_ClickStart;
            BoardPlayer.MouseDown += BoardPlayer_MouseDown;
            BoardPlayer.MouseMove += BoardPlayer_MouseMove;
            ScoreLabel.Text = "Score: 0";
        }

        private void BoardPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            mdx = e.X;
        }

        private void BoardPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int x = BoardPlayer.Left + (e.X - mdx);

                if (x < 0) x = 0;
                if (x > this.ClientSize.Width - BoardPlayer.Width) x = this.ClientSize.Width - BoardPlayer.Width;

                BoardPlayer.Left = x;
            }
        }

        Size Direction()
        {
            return new Size(Speed[0], Speed[1]);
        }
    }
}