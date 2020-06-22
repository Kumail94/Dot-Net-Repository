using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoogleApi.Entities.Common;
using GMap.NET.WindowsForms.Markers;

namespace Google_Api
{
    public partial class Form1 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("GoogleAPI");
        static IMongoCollection<MongoAPI> collections = db.GetCollection<MongoAPI>("Records");
        List<PointLatLng> points;
        public Form1()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
        private void ManualFare_Click(object sender, EventArgs e)
        {
        }
        private void GoogleMapApi(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Mouse hab been clicked!", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                //string places = 
                //autocompletesource.listitems = 
                //StringBuilder api = new StringBuilder();
                //api.Append(url);
                //if (postcode != string.Empty)
                //{
                //    api.Append(postcode + " , " + " + ");
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message.ToString());
            }
        }
        //private void TextFields(object sender, KeyPressEventArgs e)
        //{
        //    GMapAutoComplete();
        //}
        private void GMapAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                auto.Add(GMapProviders.GoogleMap.ApiKey = @"AIzaSyB7OjyZZr6U8I578A0po3zcOXiDVfpyjM8");
                FromTextBox.AutoCompleteCustomSource = auto;
               
                //Map.MapProvider = GMapProviders.GoogleMap;
                //Map.SetPositionByKeywords(FromTextBox.Text);
                //Map.MinZoom = 2;
                //Map.MaxZoom = 100;
                //Map.Zoom = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }
        //private void API()
        //{
        //    try
        //    {
        //        string url = "AIzaSyB7OjyZZr6U8I578A0po3zcOXiDVfpyjM8";
        //        string content = fileGetContents(url);
        //        JObject o = JObject.Parse(content);
        //        List<string> add = new List<string>();
        //        try
        //        {
        //            JObject jObj = (JObject)JsonConvert.DeserializeObject(content);
        //            int count = jObj.Count;
        //            for (int i = 0; i < count; i++)
        //            {
        //                add.Add((string)o.SelectToken("predictions[" + i + "].description"));
        //            }
        //            var collection = new AutoCompleteStringCollection();
        //            collection.AddRange(add.ToArray());
        //            PostCodeTextBox.AutoCompleteCustomSource = collection;
        //            PostCodeTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        //            PostCodeTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        Map.MapProvider = GMapProviders.GoogleMap;
        //        Map.SetPositionByKeywords(PostCodeTextBox.Text);
        //        Map.MinZoom = 2;
        //        Map.MaxZoom = 100;
        //        Map.Zoom = 3;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("" + ex.Message.ToString());
        //    }
        //}
        //private string fileGetContents(string fileName)
        //{
        //    string sContents = string.Empty;
        //    string me = string.Empty;
        //    try
        //    {
        //        if (fileName.ToLower().IndexOf("https:") > -1)
        //        {
        //            System.Net.WebClient wc = new System.Net.WebClient();
        //            byte[] response = wc.DownloadData(fileName);
        //            sContents = System.Text.Encoding.ASCII.GetString(response);
        //        }
        //        else
        //        {
        //            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
        //            sContents = sr.ReadToEnd();
        //            sr.Close();
        //        }
        //    }
        //    catch { sContents = "unable to connect to server "; }
        //    return sContents;
        //}
        private void PostCodeTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        protected string fileGetContents(string fileName)
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
        //private void TextFieldPress(object sender, KeyPressEventArgs e)
        //{
        //    GMapAutoComplete();

        //}
        private void spiliter_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }
        private void TimeFormat(object sender, EventArgs e)
        {
            CustomTime(sender, "HH:mm");
        }
        private void Format(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                CustomTime(sender, " ");
            }
        }
        private void CustomTime(object sender, string format)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            picker.CustomFormat = format;
        }
        private void Down(object sender, MouseEventArgs e)
        {
            CustomTime(sender, "HH:mm");
        }
        private void button_Click(object sender, EventArgs e)
        {
            //GMapRoute();
           // AddAnotherRoutePoints();
            MongoAPI api = new MongoAPI(PaymentComboBox.Text, CategoryCarComboBox.Text, dateTimePicker.Value, TimePicker.Value.TimeOfDay);
            collections.InsertOne(api);
            MessageBox.Show("Record has been added successfully!!");
            List<MongoAPI> lists = collections.AsQueryable().ToList<MongoAPI>();
            dataGridView.DataSource = lists;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void AddAnotherRoutePoints()
        {
            points.Add(new PointLatLng(Convert.ToDouble(FromTextBox.Text), Convert.ToDouble(ToTextBox.Text)));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Map.DragButton = System.Windows.Forms.MouseButtons.Left;
            Map.MapProvider = GMapProviders.GoogleMap;
            Map.MinZoom = 3;
            Map.MaxZoom = 18;
            Map.Zoom = 5;
            Map.ShowCenter = false;
            
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            CustomDate(sender, "dd/MM/yyyy");
        }
        private static void CustomDate(object sender, string format)
        {
            DateTimePicker date = (DateTimePicker)sender;
            date.CustomFormat = format;
        }
        private void dateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                CustomDate(sender, " ");
            }
        }
        private void Directions(object sender, KeyPressEventArgs e)
        {
           //GMapAutoComplete();
           //Location = @"AIzaSyB7OjyZZr6U8I578A0po3zcOXiDVfpyjM8";
           // Map.DragButton = System.Windows.Forms.MouseButtons.Left;
           // Map.CanDragMap = true;
           // Map.MapProvider = GMapProviders.GoogleMap;
           // Map.Position = new PointLatLng(37.983, -1.133);
           // Map.MinZoom = 0;
           // Map.MaxZoom = 24;
           // Map.Zoom = 9;
           // Map.AutoScroll = true;
        }
        private void GoogleMapRoute()
        {
            try
            {
                //string api = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=-33.8670522,151.1957362&radius=1500&type=restaurant&keyword=cruise&key='AIzaSyB7OjyZZr6U8I578A0po3zcOXiDVfpyjM8'";
                
                //points.Add(new PointLatLng(51.509865, -0.118092));
                
                Map.Position = new PointLatLng(Convert.ToDouble(FromTextBox.Text),Convert.ToDouble(ToTextBox.Text));
                var markers = new GMapOverlay("markers");
                //var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(FromTextBox.Text), Convert.ToDouble(ToTextBox.Text)));
                //GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
               // markers.Markers.Add(marker);
                Map.Overlays.Add(markers);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message.ToString());
            }
        }

        private void GetRouteDirection()
        {
            var route = GoogleMapProvider.Instance.GetRoute(points[0], points[1], false, false, 14);
            var r = new GMapRoute(route.Points, "My Route")
            {

                Stroke = new Pen(Color.Red , 5)
            };
            var direction = new GMapOverlay("direction");

            direction.Routes.Add(r);
            Map.Overlays.Add(direction);
            distance.ForeColor = Color.White;
            distance.Text = route.Distance + " Km";

        }
        private void firstLatLng_Click(object sender, EventArgs e)
        {
            GoogleMapRoute();
        }
        private void secondLatLng_Click(object sender, EventArgs e)
        {
            GetRouteDirection();
        }

        private void UML_Click(object sender, EventArgs e)
        {
            points.Clear();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

