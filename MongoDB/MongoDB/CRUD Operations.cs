using MongoDB.Bson;
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

namespace MongoDB
{
    public partial class CRUD_Operations : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("Tester");
        static IMongoCollection<FirstCollection> collection1 = db.GetCollection<FirstCollection>("first");
        // static IMongoCollection<SecondCollection> collection2 = db.GetCollection<SecondCollection>("second");
        public CRUD_Operations()
        {
            InitializeComponent();
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            if (textBoxDirector.Text.Trim() == string.Empty || textBoxManager.Text.Trim() == string.Empty || textBoxSupervisor.Text.Trim() == string.Empty || textBoxFirst.Text.Trim() == string.Empty || textBoxSecond.Text.Trim() == string.Empty || textBoxThird.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fields are required!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FirstCollection first = new FirstCollection(textBoxDirector.Text, textBoxManager.Text, textBoxSupervisor.Text, textBoxFirst.Text, textBoxSecond.Text, textBoxThird.Text);
                //SecondCollection second = new SecondCollection(textBoxFirst.Text, textBoxSecond.Text, textBoxThird.Text);
                collection1.InsertOne(first);
                //collection2.InsertOne(second);
                MessageBox.Show("Record has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataIntoDataGridView();
            }
        }
        private void LoadDataIntoDataGridView()
        {
            List<FirstCollection> first = collection1.AsQueryable().ToList<FirstCollection>();
            //List<SecondCollection> second = collection2.AsQueryable().ToList<SecondCollection>();
            dataGridView.DataSource = first;
            dataGridView.MultiSelect = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //  dataGridView.DataSource = second;

        }
        private void Update_Click(object sender, EventArgs e)
        {
            var updated1 = Builders<FirstCollection>.Update.Set("Director", textBoxDirector.Text).Set("Manager", textBoxManager.Text).Set("Supervisor", textBoxSupervisor.Text).Set("FirstEmployee", textBoxFirst.Text).Set("SecondEmployee", textBoxSecond.Text).Set("ThirdEmployee", textBoxThird.Text);
            collection1.UpdateOne(s => s.Id == ObjectId.Parse(textBoxID.Text), updated1);
            MessageBox.Show("Record has been updated successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            collection1.DeleteOne(s => s.Id == ObjectId.Parse(textBoxID.Text));
            MessageBox.Show("Record has been deleted successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxDirector.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxManager.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxSupervisor.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxFirst.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxSecond.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxThird.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
