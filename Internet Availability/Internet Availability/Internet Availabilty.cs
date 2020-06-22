using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Availability
{
    public partial class Internet_Availabilty : Form
    {
        [DllImport("wininet.dll")]
        public extern static bool InternetGetConnectedState(out int Description, int ResrvedValue);
        public Internet_Availabilty()
        {
            InitializeComponent();
        }
        private void Power_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Internet_Availabilty_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // in One Second:
            timer.Tick += new EventHandler(this.t_tick);
            //Strat timer when form load
            timer.Start();
        }
        private void t_tick(object sender, EventArgs e)
        {

            if (ISInternetAvailable())
            {
                Checking.ForeColor = Color.Green;
                Checking.Text = "Internet is Connected!";
            }
            else
            {
                Checking.ForeColor = Color.Red;
                Checking.Text = "Internet is Disconnected";
            }
        }
        private static bool ISInternetAvailable()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
    }
}

