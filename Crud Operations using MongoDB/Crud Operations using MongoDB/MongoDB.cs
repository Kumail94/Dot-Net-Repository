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

namespace Crud_Operations_using_MongoDB
{
    public partial class MongoDB : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("InfoDB");
        static IMongoCollection<Student> collections = db.GetCollection<Student>("Data");
         public void ReadAllDocument()
        {
            List<Student> lists = collections.AsQueryable().ToList<Student>();
            DataGridView.DataSource = lists;
            DataGridView.MultiSelect = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //textBox1.Text = DataGridView.Rows[0].Cells[0].Value.ToString();
            //textBox2.Text = DataGridView.Rows[0].Cells[1].Value.ToString();
            //textBox3.Text = DataGridView.Rows[0].Cells[2].Value.ToString();
            //textBox4.Text = DataGridView.Rows[0].Cells[3].Value.ToString();
            //textBox5.Text = DataGridView.Rows[0].Cells[4].Value.ToString();
        }
        public MongoDB()
        {
            InitializeComponent();
            ReadAllDocument();
        }
        private void MongoDB_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Insert_Click(object sender, EventArgs e)
        {
            Student students = new Student(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            collections.InsertOne(students);
            MessageBox.Show("Record has been added successfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadAllDocument();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            var updateRecord = Builders<Student>.Update.Set("Name", textBox2.Text).Set("Email", textBox3.Text).Set("Contact", textBox4.Text).Set("Department", textBox5.Text);
            collections.UpdateOne(s => s.Id == ObjectId.Parse(textBox1.Text), updateRecord);
            MessageBox.Show("Record has been updated successfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadAllDocument();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            collections.DeleteOne(s => s.Id == ObjectId.Parse(textBox1.Text));
            MessageBox.Show("Record has been deleted successfully!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReadAllDocument();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox5.Text = DataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void printPreviewDialog_Load(object sender, EventArgs e)
        {

        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
        private void PrintButton_Click(object sender, EventArgs e)
        {
            ////printPreviewDialog.Document = printDocument;
            ////printPreviewDialog.ShowDialog();
        }
         private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             //e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------"
             //    , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 60));
             //e.Graphics.DrawString("Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 80));
             //e.Graphics.DrawString("Email", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(260, 80));
             //e.Graphics.DrawString("Contacts", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(490, 80));
             //e.Graphics.DrawString("Department", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(720, 80));
             //e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------"
             //    , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));

             //Student s = new Student(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
             //e.Graphics.DrawString("" + s.Name, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 125));
             //e.Graphics.DrawString("" + s.Email, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(220, 150));
             //e.Graphics.DrawString("" + s.Contact, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(460, 175));
             //e.Graphics.DrawString("" + s.Department, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 200));
             //e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
         }
         private void printPreviewDialog_Load_1(object sender, EventArgs e)
         {

         }
   }
}
