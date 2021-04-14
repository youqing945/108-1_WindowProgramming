using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_5_2
{
    public partial class Form1 : Form
    {
        double _1band = 0;
        double _2band = 0;
        double _3band = 1;
        int _3bandText = 0;
        string _4band = "1%";
        TextBox[] risT = new TextBox[10];
        Label[] risL = new Label[10];
        int risN = 0;

        public Form1()
        {
            InitializeComponent();
            //====================
            for (int i = 0; i < 10; i++)
            {
                risT[i] = new TextBox();
                risT[i].Text = "0";
                risL[i] = new Label();
                risL[i].Text = "Ω";
            }
            for (int i = 0; i < 10; i++)
            {
                risT[i].Location = new Point(10, 40 * i + 45);
                calculateValue.Controls.Add(risT[i]);
                risL[i].Location = new Point(115, 40 * i + 50);
                calculateValue.Controls.Add(risL[i]);
            }
            for(int i = 3; i < 10; i++)
            {
                risT[i].Hide();
                risL[i].Hide();
            }
            risN = 3;
            //====================
        }

        //=======================================
        void setResistence()
        {
            double total = (10 * _1band + _2band) * _3band;
            int temp = _3bandText;
            if (total == 0) temp = 0;
            else
            {
                while (total >= 1000)
                {
                    total = total / 1000;
                    temp++;
                }
            }
            string result = "";
            result += total;
            if (temp == 1) result += "K";
            else if (temp == 2) result += "M";
            else if (temp == 3) result += "G";
            result += " ± " + _4band;
            resistanceValue.Text = result;
        }

        private void _1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.ForeColor == Color.Black) _1band = 0;
            else if (rb.ForeColor == Color.Brown) _1band = 1;
            else if (rb.ForeColor == Color.Red) _1band = 2;
            else if (rb.ForeColor == Color.Orange) _1band = 3;
            else if (rb.ForeColor == Color.Yellow) _1band = 4;
            else if (rb.ForeColor == Color.Green) _1band = 5;
            else if (rb.ForeColor == Color.Blue) _1band = 6;
            else if (rb.ForeColor == Color.Purple) _1band = 7;
            else if (rb.ForeColor == Color.Gray) _1band = 8;
            else if (rb.ForeColor == Color.White) _1band = 9;
            setResistence();
        }

        private void _2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.ForeColor == Color.Black) _2band = 0;
            else if (rb.ForeColor == Color.Brown) _2band = 1;
            else if (rb.ForeColor == Color.Red) _2band = 2;
            else if (rb.ForeColor == Color.Orange) _2band = 3;
            else if (rb.ForeColor == Color.Yellow) _2band = 4;
            else if (rb.ForeColor == Color.Green) _2band = 5;
            else if (rb.ForeColor == Color.Blue) _2band = 6;
            else if (rb.ForeColor == Color.Purple) _2band = 7;
            else if (rb.ForeColor == Color.Gray) _2band = 8;
            else if (rb.ForeColor == Color.White) _2band = 9;
            setResistence();
        }

        private void _3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.ForeColor == Color.Black)
            {
                _3band = 1;
                _3bandText = 0;
            }
            else if (rb.ForeColor == Color.Brown)
            {
                _3band = 10;
                _3bandText = 0;
            }
            else if (rb.ForeColor == Color.Red)
            {
                _3band = 100;
                _3bandText = 0;
            }
            else if (rb.ForeColor == Color.Orange)
            {
                _3band = 1;
                _3bandText = 1;
            }
            else if (rb.ForeColor == Color.Yellow)
            {
                _3band = 10;
                _3bandText = 1;
            }
            else if (rb.ForeColor == Color.Green)
            {
                _3band = 100;
                _3bandText = 1;
            }
            else if (rb.ForeColor == Color.Blue)
            {
                _3band = 1;
                _3bandText = 2;
            }
            else if (rb.ForeColor == Color.Purple)
            {
                _3band = 10;
                _3bandText = 2;
            }
            else if (rb.ForeColor == Color.Gray)
            {
                _3band = 100;
                _3bandText = 2;
            }
            else if (rb.ForeColor == Color.White)
            {
                _3band = 1;
                _3bandText = 3;
            }
            else if (rb.ForeColor == Color.Gold)
            {
                _3band = 0.1;
                _3bandText = 0;
            }
            else if (rb.ForeColor == Color.Silver)
            {
                _3band = 0.01;
                _3bandText = 0;
            }
            setResistence();
        }

        private void _4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.ForeColor == Color.Brown) _4band = "1%";
            else if (rb.ForeColor == Color.Red) _4band = "2%";
            else if (rb.ForeColor == Color.Green) _4band = "0.5%";
            else if (rb.ForeColor == Color.Blue) _4band = "0.25%";
            else if (rb.ForeColor == Color.Purple) _4band = "0.10%";
            else if (rb.ForeColor == Color.Gray) _4band = "0.05%";
            else if (rb.ForeColor == Color.Gold) _4band = "5%";
            else if (rb.ForeColor == Color.Silver) _4band = "10%";
            setResistence();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            risT[risN].Show();
            risL[risN].Show();
            risN++;
            if (risN >= 10) btnAdd.Enabled = false;
            else btnAdd.Enabled = true;
            if (risN <= 2) btnDelete.Enabled = false;
            else btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            risT[risN - 1].Hide();
            risL[risN - 1].Hide();
            risN--;
            if (risN >= 10) btnAdd.Enabled = false;
            else btnAdd.Enabled = true;
            if (risN <= 2) btnDelete.Enabled = false;
            else btnDelete.Enabled = true;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double Serial = 0, Parallel = 0, temp = 0;
            int flag = 0;
            for(int i = 0; i < risN; i++)
            {
                try
                {
                    double.Parse(risT[i].Text);
                }
                catch (ArgumentNullException)
                {
                    flag = 1;
                    txbSerial.Text = "輸入有誤，請檢查";
                    txbParallel.Text = "輸入有誤，請檢查";
                    break;
                }
                catch (FormatException)
                {
                    flag = 1;
                    txbSerial.Text = "輸入有誤，請檢查";
                    txbParallel.Text = "輸入有誤，請檢查";
                    break;
                }
                if (double.Parse(risT[i].Text) <= 0)
                {
                    flag = 1;
                    txbSerial.Text = "輸入有誤，請檢查";
                    txbParallel.Text = "輸入有誤，請檢查";
                    break;
                }
                Serial += double.Parse(risT[i].Text);
                Parallel += Math.Pow(double.Parse(risT[i].Text), -1);
            }
            if (flag != 1)
            {
                Parallel = Math.Pow(Parallel, -1);
                txbSerial.Text = Serial.ToString("F2");
                txbParallel.Text = Parallel.ToString("F2");
            }
            
        }
    }
}

