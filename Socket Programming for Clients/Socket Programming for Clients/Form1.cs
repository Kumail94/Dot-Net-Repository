using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Programming_for_Clients
{
    public partial class Form1 : Form
    {
        TcpClient client = null;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 8888);
            NetworkStream ns = client.GetStream();
            StreamReader reader = new StreamReader(ns);
            textBoxMessage.Text = "Server >> " + reader.Read();      
        }
          private void Send_Click(object sender, EventArgs e)
        {
            if (textBoxSendMessage.Text != "")
            {
                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(textBoxSendMessage.Text);
                sw.Flush();
                sw.Close();
                ns.Close();
            }
        }
    }
}
