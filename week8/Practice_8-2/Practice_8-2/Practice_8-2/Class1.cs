using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8_2
{
    class Class1
    {
        public Form1 MainForm;
        public void pause()
        {
            MainForm.msi_pause();
        }
        public void start()
        {
            MainForm.msi_start();
        }

        public void restart()
        {
            MainForm.msi_restart();
        }
    }
}
