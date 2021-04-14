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

namespace Practice_8_1
{
    public partial class Form1 : Form
    {
        Color initialWindowColor, initialPicColor;
        ColorDialog colorDialogWindow, colorDialogPic;
        DirectoryInfo di;

        public Form1()
        {
            InitializeComponent();
            start();
        }

        public void start()
        {
            initialWindowColor = this.BackColor;
            initialPicColor = pictureBox.BackColor;
            colorDialogWindow = new ColorDialog();
            colorDialogPic = new ColorDialog();
            di = new DirectoryInfo(@"pic");
            DirectoryInfo[] a =  di.GetDirectories();
            for (int i = 0; i < a.Length; i++) cbDirection.Items.Add(a[i]);
            cbDirection.SelectedItem = cbDirection.Items[0];
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo allPics = new DirectoryInfo(@"pic\"+cbDirection.SelectedItem);
            FileInfo[] all = allPics.GetFiles();
            lbPics.Items.Clear();
            for (int i = 0; i < all.Length; i++) lbPics.Items.Add(all[i]);
        }
        
        private void lbPics_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbPics.SelectedItem != null) pictureBox.Image = Image.FromFile(@"pic\" + cbDirection.SelectedItem + @"\" + lbPics.SelectedItem);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(sender == btnChangeColor)
            {
                if (colorDialogWindow.ShowDialog() == DialogResult.OK) this.BackColor = colorDialogWindow.Color;
            }
            else if(sender == btnResetColor)
                this.BackColor = initialWindowColor;
            else if(sender == btnChangePicColor)
            {
                if (colorDialogPic.ShowDialog() == DialogResult.OK) pictureBox.BackColor = colorDialogPic.Color;
            }
            else if(sender == btnResetPicColor)
                pictureBox.BackColor = initialPicColor;
        }
    }
}
