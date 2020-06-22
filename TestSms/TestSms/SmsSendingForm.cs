using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestSms
{
    public partial class SmsSendingForm : Form
    {
      public static SerialPort myport = new SerialPort();
        public SmsSendingForm()
        {
            InitializeComponent();
        }
        public static void setComPort()
        {

            string t = "";
            if (ValidationForm.Caption!=null)
            {
              //  myport.PortName = ValidationForm.gg;
                int timeout = 10000; //t: response msg
                myport.NewLine = "\r\n";
                myport.BaudRate = 9600;
                myport.Parity = Parity.None;
                myport.DataBits = 8;
                myport.StopBits = StopBits.One;
                myport.Handshake = Handshake.None;
                myport.DtrEnable = true;
                myport.WriteBufferSize = 1024;
                myport.Open();
                myport.BaseStream.Flush();     
            }
           

        }





        private void Sendmsg_Button_Click(object sender, EventArgs e)
        {   

            myport.Write("AT\r");
            myport.Write("AT+CMGF=1\r");
            System.Threading.Thread.Sleep(1500);
            myport.Write("AT+CMGS=\"" + reciver_textbox.Text + "\"\r\n");
            System.Threading.Thread.Sleep(1500);
            myport.Write(message_textbox.Text + "\x1A");
            if (message_textbox.TextLength == 0)
            {
                MessageBox.Show("You just Send an Empty Message");
            }
            else
            {
                MessageBox.Show("Message Send Sucessfully!", "Meassage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  myport.Close();
            }
          
        }

        private void SmsSendingForm_Load(object sender, EventArgs e)
        {

            myport.PortName = ValidationForm.comPortInfo;
            setComPort();
            int timeout = 10000;
            string t = "";
            myport.WriteLine("AT+CIMI");       //Get sim imsi number
            // sp.WriteLine("AT+CGMM");      // Get USB Model
            // sp.WriteLine("AT+CGMI");      // Manufacturer 
            System.Threading.Thread.Sleep(200);

            while (!((t = myport.ReadExisting()).Contains("OK")) && timeout > 0)
            {

                timeout--;
            }

            if (!(t.Equals(""))
             && !(t.Equals(null)))
            {

                char[] z = new char[2];
                z[0] = '\r';
                z[1] = '\n';
                string[] f = new string[100];
                string[] c = t.Split(z);
                int m = 0;

                for (int i = 0; i < c.Length; i++)
                {
                    if (!(c[i].Equals("")))
                    {
                        f[m] = c[i];
                        m++;
                    }
                }


                for (int i = 0; i < m; i++)
                {
                    if ((f[i].Equals("AT+CIMI")))
                    {
                        Sim_textbox.Text = f[i + 1]; // Get Model of USB 3G
                    }
                    //   if ((f[i].Equals("AT+CGMI")))
                    //   {
                    //       label2.Text = f[i + 1]; // Manufacturer
                    //   }
                }
            }
            else
            {
                MessageBox.Show("SimFailure");
            }
            myport.BaseStream.Flush();

            Deviceinfo_textbox.Text = ValidationForm.Caption;
            if (Deviceinfo_textbox.TextLength == 0 || Sim_textbox.TextLength == 0)
            {
                MessageBox.Show("Sim Failure");
            }   
          


        }
    }
}