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
    public partial class DataReported : Form
    {
        public DataReported()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Despatched");
        static IMongoCollection<Records> collection = db.GetCollection<Records>("Data");
       
        private void Add_Click(object sender, EventArgs e)
        {
            Records records = new Records(DateTime.Parse(dateTimePicker1.Text), TimeSpan.Parse(dateTimePicker2.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text);
            collection.InsertOne(records);
            MessageBox.Show("Record has been added successfully!!");
            this.Hide();
            Despatch des = new Despatch();
            des.Show();
        }
     
        private void dateVALUE(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void DATE(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }

    
      private void TimeKeyDown(object sender, MouseEventArgs e)
        {
            DateTimePicker dt = (DateTimePicker)sender;
            dt.CustomFormat = "HH:mm";
        }


        private void timeDOWN(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                DateTimePicker dt = (DateTimePicker)sender;
                dt.CustomFormat = " ";
            }
        }

        private void DataReported_Load(object sender, EventArgs e)
        {

        }
    }
}
