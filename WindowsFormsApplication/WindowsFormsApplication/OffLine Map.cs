using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //objMap.ObjectsFromPoint(24, 67);
        }
        private void MappointControl_Enter(object sender, EventArgs e)
        {
        }
        private void Loading_Click(object sender, EventArgs e)
        {
        }
        private void LatLong(object sender, KeyPressEventArgs e)
        {


        }
        private void latlng_Click(object sender, EventArgs e)
        {
            MapPoint.Map objMap = null;
            objMap = MPC.NewMap(MapPoint.GeoMapRegion.geoMapEurope);
            object obj1 = 1;
            objMap.ActiveRoute.Waypoints.Add(objMap.FindResults(FromTextBox.Text).get_Item(ref obj1) ,"");
            objMap.ActiveRoute.Waypoints.Add(objMap.FindResults(ToTextBox.Text).get_Item(ref obj1), "");
            objMap.ActiveRoute.Calculate();
            distance.Text = (objMap.ActiveRoute.Distance)*3600/10000  + "  meters";
   
        }
        protected string MakeRequest(string fileName)
        {
            string sContents = string.Empty;
            string me = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("https:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.ASCII.GetString(response);
                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch { sContents = "unable to connect to server "; }
            return sContents;
        }
        public static Task<string> MakeAsyncRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = WebRequestMethods.Http.Get;
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            try
            {
                Task<WebResponse> task = Task.Factory.FromAsync(
                    request.BeginGetResponse,
                    asyncResult => request.EndGetResponse(asyncResult),
                    (object)null);
                return task.ContinueWith(t => ReadStreamFromResponse(t.Result));
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private static string ReadStreamFromResponse(WebResponse response)
        {
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
       private void FromTextBox_TextChanged(object sender, EventArgs e)
        {
            //string uri = @"http://suggestqueries.google.com/complete/search?output=toolbar&hl=en&q=" + HttpUtility.UrlEncode(textBox1.Text);
            string uri = @"https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + FromTextBox.Text + "&types=geocode&key=AIzaSyBoo725a96P7rTXXpGEd-jdX_7zvYCal94";
            //string content = MakeRequest(uri);
            string content = MakeAsyncRequest(uri).Result;

            var jo = JObject.Parse(content);

            var jsonPath = "$..predictions[*].description";
            var result = jo.SelectTokens(jsonPath).Select(o => o.ToString()).ToArray();
            FromTextBox.Values = result;
        }
       private void ToTextBox_TextChanged(object sender, EventArgs e)
        {
            //string uri = @"http://suggestqueries.google.com/complete/search?output=toolbar&hl=en&q=" + HttpUtility.UrlEncode(textBox1.Text);
            string uri = @"https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + ToTextBox.Text + "&types=geocode&key=AIzaSyBoo725a96P7rTXXpGEd-jdX_7zvYCal94";
            //string content = MakeRequest(uri);
            string content = MakeAsyncRequest(uri).Result;

            var jo = JObject.Parse(content);

            var jsonPath = "$..predictions[*].description";
            var result = jo.SelectTokens(jsonPath).Select(o => o.ToString()).ToArray();
            ToTextBox.Values = result;
        }
        private void dated(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                CustomDate(sender, " ");
            }
        }
        private static void CustomDate(object sender, string format)
        {
            DateTimePicker date = (DateTimePicker)sender;
            date.CustomFormat = format;
        }
        private void date(object sender, MouseEventArgs e)
        {
            CustomDate(sender, "dd/MM/yyyy");
        }
        private void Time(object sender, MouseEventArgs e)
        {
        }
        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            CustomDate(sender, "HH:mm");
        }
        private void TimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            CustomDate(sender , "HH:mm");
        }
    }
}
