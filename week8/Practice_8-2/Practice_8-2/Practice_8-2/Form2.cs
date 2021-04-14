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
    public partial class Form2 : Form
    {
        Random ran = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        public void imageSmaller()
        {
            if (pictureBox.Size.Height > 30)
            {
                pictureBox.Width = pictureBox.Size.Width - 30;
                pictureBox.Height = pictureBox.Size.Height - 30;
                pictureBox.Location = new Point((this.ClientSize.Width - pictureBox.Width) / 2, (this.ClientSize.Height - pictureBox.Height) / 2);
            }
        }

        public void setInitialImage()
        {
            pictureBox.Image = null;
            pictureBox.Size = new Size(370, 370);
            pictureBox.Location = new Point((this.ClientSize.Width - pictureBox.Width) / 2, (this.ClientSize.Height - pictureBox.Height) / 2);
        }


        public int changeImage()
        {
            int x = ran.Next() % 4;
            if (x == 0) pictureBox.Image = Image.FromFile(@"pic\eyechart-1.jpg");
            else if (x == 1) pictureBox.Image = Image.FromFile(@"pic\eyechart-2.jpg");
            else if (x == 2) pictureBox.Image = Image.FromFile(@"pic\eyechart-3.jpg");
            else if (x == 3) pictureBox.Image = Image.FromFile(@"pic\eyechart-4.jpg");

            return x;
        }

        private void msi_Click(object sender, EventArgs e)
        {
            if (sender == msiStart)
            {
                Form1.f1.msi_start();
            }
            else if (sender == msiPause)
            {
                Form1.f1.msi_pause();
            }
            else if (sender == msiRestart)
            {
                Form1.f1.msi_restart();
            }
        }
    }
}
