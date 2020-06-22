using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.t_Tick);
            timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string time = "";

            if (hour < 10)
            {
                time += "0" + hour;
            }
            else
            {
                time += hour;
            }
            time += ":";

   /*------------------------------------*/

            if (minute < 10)
            {
                time += "0" + minute;
            }
            else
            {
                time += minute;
            }
            time += ":";

            if (second < 10)
            {
                time += "0" + second;
            }
            else
            {
                time += second;
            }
            DigitalClock.Text = time;

        }

    }
}
