using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.labelKeyboard.Text = "按了";
            this.labelKeyboard.Text += e.KeyCode;
            this.labelKeyboard.Text += "鍵，鍵碼：";
            this.labelKeyboard.Text += e.KeyValue;

            if (e.KeyCode == Keys.Left) labelKeyboard.Location = Point.Add(labelKeyboard.Location, new Size(-10, 0));
            else if (e.KeyCode == Keys.Right) labelKeyboard.Location = Point.Add(labelKeyboard.Location, new Size(10, 0));
            else if (e.KeyCode == Keys.Up) labelKeyboard.Location = Point.Add(labelKeyboard.Location, new Size(0, -10));
            else if (e.KeyCode == Keys.Down) labelKeyboard.Location = Point.Add(labelKeyboard.Location, new Size(0, 10));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.labelPress.Text = "按了";
            if (e.Button == MouseButtons.Left) this.labelPress.Text += "左鍵";
            else if (e.Button == MouseButtons.Middle) this.labelPress.Text += "中鍵";
            else if (e.Button == MouseButtons.Right) this.labelPress.Text += "右鍵";
            this.labelPress.Text += "於X：" + e.X + ", Y：" + e.Y;
        }
    }
}
