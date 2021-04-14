using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Practice_7_2
{
    public partial class Form1 : Form
    {
        public class Schedule
        {
            public int time { get; set; }
            public String element { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            String strTime = "" + nudHour.Value + "時" + nudMinute.Value + "分";
            String path = @"Schedule\" + nudMonth.Value + @"_" + nudDate.Value + @".txt";

            if (!File.Exists(path))
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(strTime);
                    sw.WriteLine(textBox.Text);
                    sw.WriteLine("----------");
                    sw.Flush();
                    sw.Close();
                }
            else
                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(strTime);
                    sw.WriteLine(textBox.Text);
                    sw.WriteLine("----------");
                    sw.Flush();
                    sw.Close();
                }
            textBox.Clear();
            suceed.Show();
            timer1.Start();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String path = @"Schedule\" + nudMonth.Value + @"_" + nudDate.Value + @".txt";
            if (!File.Exists(path)) MessageBox.Show("查無此日行程","無此檔案",MessageBoxButtons.OK);
            else
            {
                List<Schedule> schedule = new List<Schedule>();

                using (StreamReader sr = new StreamReader(path))
                {
                    int t_time = 0;
                    String t_element = "";
                    String line;
                    bool nextSchedule = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        t_element += line;
                        t_element += "\r\n";

                        if (nextSchedule == true)
                        {
                            String[] split = line.Split(new char[2] { '時', '分' });
                            t_time = int.Parse(split[0]) * 100 + int.Parse(split[1]);
                            nextSchedule = false;
                        }

                        else
                        {
                            if (line == "----------")
                            {
                                nextSchedule = true;
                                schedule.Add(new Schedule() { time = t_time, element = t_element });
                                t_element = "";
                            }
                        }
                    }

                    schedule.Sort(delegate(Schedule x,Schedule y)
                    {
                        return x.time.CompareTo(y.time);
                    });

                    textBox.Text = "";
                    foreach(Schedule nowSchedule in schedule)
                    {
                        textBox.Text += nowSchedule.element;
                    }

                }
            }
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            suceed.Hide();
            timer1.Stop();
        }

        private void nudMonth_ValueChanged(object sender, EventArgs e)
        {
            if (nudMonth.Value == 2) nudDate.Maximum = 29;
            else if (nudMonth.Value == 4 || nudMonth.Value == 6 || nudMonth.Value == 9 || nudMonth.Value == 11) nudDate.Maximum = 30;
            else nudDate.Maximum = 31;
        }
    }
}
