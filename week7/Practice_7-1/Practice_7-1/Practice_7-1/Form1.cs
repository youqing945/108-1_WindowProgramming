using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_7_1
{
    public partial class Form1 : Form
    {
        TrackBar[] sound = new TrackBar[10];
        Button play;
        Button stop;
        static int volumeNum = 15;
        PictureBox[,] volume = new PictureBox[10,volumeNum];
        String filename = @"..\..\src\Night_Keepers-Fantasy_journey_veryshort.wav";
        FileStream fin;
        SoundPlayer player;
        int[] currentvolumenum = new int[10];
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(700, 450);
            tabControl.ClientSize = new Size(96*7, 435);
            start_equalizer();
            start_setting();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button input = sender as Button;
            if (input.Text == "播放")
            {
                timer1.Start();
                player.PlayLooping();
                btn_openfile.Enabled = false;
            }
            else
            {
                timer1.Stop();
                player.Stop();
                btn_openfile.Enabled = true;
            }
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "選擇.wav檔案";
                openFileDialog.InitialDirectory = @"..\..\src\";
                openFileDialog.Filter = "wav files(*.wav)|*.wav";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog.FileName;
                    labelFilepath.Text = filename;
                    fin = new FileStream(filename, FileMode.Open);
                    player = new SoundPlayer(fin);
                    player.Load();
                }
            }
        }

        private void TBScroll(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                if (sender == sound[i])
                {
                    currentvolumenum[i] = sound[i].Value;
                    if (timer1.Enabled == false)
                    {
                        for (int j = 0; j < currentvolumenum[i]; j++) volume[i, j].Show();
                        for (int j = currentvolumenum[i]; j < volumeNum; j++) volume[i, j].Hide();
                    }
                    break;
                }
            } 
        }

        private void SBScroll(object sender, ScrollEventArgs e)
        {
            picColor.BackColor = Color.FromArgb(SBR.Value, SBG.Value, SBB.Value);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < volumeNum; j++)
                {
                    volume[i, j].BackColor = Color.FromArgb(SBR.Value, SBG.Value, SBB.Value);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                if (currentvolumenum[i] == 0) for (int j = 0; j < volumeNum; j++) volume[i, j].Hide();
                else
                {
                    int x = ran.Next() % 5 - 2;
                    if (currentvolumenum[i] + x >= 0&& currentvolumenum[i] + x <= volumeNum)
                    {
                        for (int j = 0; j < currentvolumenum[i] + x; j++) volume[i, j].Show();
                        for (int j = currentvolumenum[i] + x; j < volumeNum; j++) volume[i, j].Hide();
                    }
                }
            }
        }

        void start_equalizer()
        {
            //Picture Box
            for(int i=0; i < 10; i++)
            {
                for(int j = 0; j < volumeNum; j++)
                {
                    volume[i, j] = new PictureBox();
                    volume[i, j].BackColor = Color.CornflowerBlue;
                    volume[i, j].Size = new Size(45, 8);
                    volume[i, j].Location = new Point(10 + 60 * i, 180 - 12 * j);
                    equalizer.Controls.Add(volume[i, j]);
                }
            }

            //==================
            //TrackBar
            for (int i = 0; i < 10; i++)
            {
                sound[i] = new TrackBar();
                sound[i].Orientation = Orientation.Vertical;
                sound[i].TickStyle = TickStyle.Both;
                sound[i].LargeChange = 1;
                sound[i].Maximum = 15;
                sound[i].Value = sound[i].Maximum;
                currentvolumenum[i] = sound[i].Maximum;
                sound[i].Size = new Size(90, 200);
                sound[i].Location = new Point(10+60 * i, 200);
                sound[i].Scroll += TBScroll;
                equalizer.Controls.Add(sound[i]);
            }
            //===================
            //Buttons
            play = new Button();
            play.Text = "播放";
            play.Size = new Size(45, 30);
            play.Location = new Point(610, 300);
            play.Click += Button_Click;
            equalizer.Controls.Add(play);

            stop = new Button();
            stop.Text = "停止";
            stop.Size = new Size(45, 30);
            stop.Location = new Point(610, 350);
            stop.Click += Button_Click;
            equalizer.Controls.Add(stop);

        }

        void start_setting()
        {
            picColor.BackColor = volume[0, 0].BackColor;
            SBR.Value = picColor.BackColor.R;
            SBG.Value = picColor.BackColor.G;
            SBB.Value = picColor.BackColor.B;
            labelFilepath.Text = filename;
            btn_openfile.Enabled = true;
            fin = new FileStream(filename, FileMode.Open);
            player = new SoundPlayer(fin);
            player.Load();
        }

    }
}
