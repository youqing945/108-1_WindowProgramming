using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pictureBoxBread.Image = Image.FromFile(@"../../img/BREAD.png");
            this.pictureBoxBread.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBread.Controls.Add(pictureBoxSauce);
            this.pictureBoxSauce.Image = Image.FromFile(@"../../img/SAUCE_NONE.png");
            this.pictureBoxSauce.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxSauce.BackColor = Color.Transparent;
            
        }

        private void make_Click(object sender, EventArgs e)
        {
            if (BLUE.Checked == true) pictureBoxSauce.Image = Image.FromFile(@"../../img/SAUCE_BLUE.png");
            else if (GREEN.Checked == true) pictureBoxSauce.Image = Image.FromFile(@"../../img/SAUCE_GREEN.png");
            else if (RED.Checked == true) pictureBoxSauce.Image = Image.FromFile(@"../../img/SAUCE_RED.png");
            else if (NONE.Checked == true) pictureBoxSauce.Image = Image.FromFile(@"../../img/SAUCE_NONE.png");

            Random ran = new Random();
            

            if (PINEAPPLE.Checked == true)
            {
                try
                {
                    int.Parse(PINEAPPLETEXT.Text);
                }               
                catch(ArgumentNullException)
                {
                    PINEAPPLETEXT.Text = "0";
                }
                catch (FormatException)
                {
                    PINEAPPLETEXT.Text = "0";
                }
                if (int.Parse(PINEAPPLETEXT.Text) < 0) PINEAPPLETEXT.Text = "0";
                for (int i = 0; i < int.Parse(PINEAPPLETEXT.Text); i++)
                {
                    PictureBox ingpine = new PictureBox();
                    ingpine.Image = Image.FromFile(@"../../img/PINEAPPLE.png");
                    ingpine.Size = new Size(30, 20);
                    ingpine.SizeMode = PictureBoxSizeMode.StretchImage;
                    int x = ran.Next() % 260;
                    int y = ran.Next() % 260;
                    while (Math.Sqrt(Math.Pow((x - 130), 2) + Math.Pow(y - 130, 2)) > 130)
                    {
                        x = ran.Next() % 260;
                        y = ran.Next() % 260;
                    }
                    ingpine.Location = new Point(x, y);
                    pictureBoxSauce.Controls.Add(ingpine);
                }
            }

            if (HAM.Checked == true)
            {
                try
                {
                    int.Parse(HAMTEXT.Text);
                }
                catch (ArgumentNullException)
                {
                    HAMTEXT.Text = "0";
                }
                catch (FormatException)
                {
                    HAMTEXT.Text = "0";
                }
                if (int.Parse(HAMTEXT.Text) < 0) HAMTEXT.Text = "0";
                for (int i = 0; i < int.Parse(HAMTEXT.Text); i++)
                {
                    PictureBox ingham = new PictureBox();
                    ingham.Image = Image.FromFile(@"../../img/HAM.png");
                    ingham.Size = new Size(30, 40);
                    ingham.SizeMode = PictureBoxSizeMode.StretchImage;
                    int x = ran.Next() % 260;
                    int y = ran.Next() % 260;
                    while (Math.Sqrt(Math.Pow((x - 130), 2) + Math.Pow(y - 130, 2)) > 130)
                    {
                        x = ran.Next() % 260;
                        y = ran.Next() % 260;
                    }
                    ingham.Location = new Point(x, y);
                    pictureBoxSauce.Controls.Add(ingham);
                }
            }

        }

        private void PINEAPPLE_CheckedChanged(object sender, EventArgs e)
        {
            if (PINEAPPLE.Checked == true) PINEAPPLETEXT.Enabled = true;
            else PINEAPPLETEXT.Enabled = false;
        }
        private void HAM_CheckedChanged(object sender, EventArgs e)
        {
            if (HAM.Checked == true) HAMTEXT.Enabled = true;
            else HAMTEXT.Enabled = false;
        }
    }
}
