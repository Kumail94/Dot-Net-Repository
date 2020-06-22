using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Management;

namespace TestSms
{
    public partial class ValidationForm : Form
    {
        public static string Caption;
        public static string comPortInfo;
        public ValidationForm()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM%'");  

            foreach (ManagementObject queryObj in searcher.Get())
            {
                if ((string)queryObj["Status"] == "OK" && (string)queryObj["Description"] == "Vodafone Mobile Broadband Secondary Port Modem (Huawei)")
                {

                    Caption = ((string)(queryObj["Caption"]));
                    if (Caption.Contains("(COM"))
                    {

                        comPortInfo = Caption.Substring(Caption.LastIndexOf("(COM")).Replace("(", string.Empty).Replace(")", string.Empty);
                      



                        SmsSendingForm obj = new SmsSendingForm();
                        obj.Show();
                        this.Hide();

                    }
                }
            }

            if (Caption == null)
            {
                MessageBox.Show("Vodafone Mobile Broadband Modem (Huawei) is NOT CONNECTED!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}