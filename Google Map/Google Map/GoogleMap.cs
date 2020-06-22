using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
//using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Map
{
    public partial class GoogleMap : Form
    {
        public GoogleMap()
        {
            InitializeComponent();
        }

        private void GoogleMap_Load(object sender, EventArgs e)
        {
            gMap.ShowCenter = false;
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            gMap.DragButton = System.Windows.Forms.MouseButtons.Right;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            gMap.MinZoom = 5;
            gMap.MaxZoom = 100;
            gMap.Zoom = 14;
            PointLatLng point = new PointLatLng(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMap.Overlays.Add(markers);
        }
    }
}
