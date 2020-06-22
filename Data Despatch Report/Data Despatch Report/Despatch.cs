using Microsoft.Reporting.WinForms;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Despatch_Report
{
    public partial class Despatch : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Despatched");
        static IMongoCollection<Records> collection = db.GetCollection<Records>("Data");
        public Despatch()
        {
            InitializeComponent();
        }
        private void Despatch_Load(object sender, EventArgs e)
        {
            List<Records> records = collection.AsQueryable().ToList<Records>();
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportEmbeddedResource = "Data_Despatch_Report.Despatching.rdlc";
            ReportDataSource source = new ReportDataSource("DataSets",records);
            reportViewer.LocalReport.DataSources.Add(source);
            source.Value = records;
            reportViewer.LocalReport.Refresh();
            this.reportViewer.RefreshReport();
        }
    }
}
