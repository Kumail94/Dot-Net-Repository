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

namespace Liver_Wall_Board
{
    public partial class Live_Wall_Board : MaterialSkin.Controls.MaterialForm
    {
        MongoClient client;
        IMongoDatabase db;
        IMongoCollection<Booking> bookingCollection1;
        IMongoCollection<BookingClosed> bookingClosedCollection2;
        IMongoCollection<Driverloc> driver;
        public Live_Wall_Board()
        {
            InitializeComponent();
            string username = "test";
            string password = "test";
            int port = 27017;
            //int SocketPort = 6666;
            string ipAddress = "145.239.6.181";
            string dbName = "TestLive";
            string connectionstring = "mongodb://" + username + ":" + password + "@" + ipAddress + ":" + port + "/" + dbName;
             client = new MongoClient(connectionstring);
            db = client.GetDatabase(dbName);
        }
        double countBooked;
        double countJobDone;
        double countCancel;
        double countTotal;

        List<Booking> booking3;
        List<BookingClosed> bookingClosed4;
        List<Driverloc> driverloc;
        private void FromdateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                FromdateTimePicker.CustomFormat = " ";
            }
        }
        private void FromdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            FromdateTimePicker.CustomFormat = "dd/MM/yyyy";
        }
        private void TodateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            TodateTimePicker.CustomFormat = "dd/MM/yyyy";
        }
        private void TodateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                TodateTimePicker.CustomFormat = " ";
            }
        }
        private void Analyze_Click(object sender, EventArgs e)
        {
            LiveWallBoard();
        }
        private void LiveWallBoard()
        {
            try
            {
                string cancelled = "Cancelled";
                string Inprogress = "In Progress";
                string jobDone = "Completed";
                string bookedJob = "Booked";
                //string All = "All Jobs";

                double countB = 0;
                double countJ = 0;
                double countC = 0;
                double count1 = 0;

                double countBK = 0;
                double countJD = 0;
                double countCAN = 0;
                double count2 = 0;

                DateTime from = FromdateTimePicker.Value;
                DateTime to = TodateTimePicker.Value;

                DateTime stFrom = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime stTo = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                double resultFrom = Convert.ToInt32(from.ToUniversalTime().Subtract(stFrom).TotalSeconds);
                double resultTo = Convert.ToInt32(to.ToUniversalTime().Subtract(stTo).TotalSeconds);

                bookingCollection1 = db.GetCollection<Booking>("Booking");
                bookingClosedCollection2 = db.GetCollection<BookingClosed>("BookingClosed");
                 
                booking3 = bookingCollection1.AsQueryable().Where(x => x.datentime >= resultFrom && x.datentime <= resultTo && x.bookedby.Equals(comboBox.SelectedItem)).ToList<Booking>();
                bookingClosed4 = bookingClosedCollection2.AsQueryable().Where(x => x.datentime >= resultFrom && x.datentime <= resultTo && x.bookedby.Equals(comboBox.SelectedItem)).ToList<BookingClosed>();

                var book = booking3.ToList();
                var bookedClosed = bookingClosed4.ToList();

                foreach (var itemBooked in book)
                {
                    if (itemBooked.cstate.Equals("despatched") && itemBooked.jstate.Equals("allocated"))
                    {
                        countB++;
                    }
                    if (itemBooked.jstate.Equals("JobDone"))
                    {
                        countJ++;
                    }
                    if (itemBooked.cstate.Equals("cancelled"))
                    {
                        countC++;
                    }
                    if (itemBooked.cstate.Equals("booked") && itemBooked.jstate.Equals("unallocated"))
                    {
                        count1++;
                    }
                }
                foreach (var itemClosed in bookedClosed)
                {
                    if (itemClosed.cstate.Equals("despatched") && itemClosed.jstate.Equals("allocated"))
                    {
                        countBK++;
                    }
                    if (itemClosed.jstate.Equals("JobDone"))
                    {
                        countJD++;
                    }
                    if (itemClosed.cstate.Equals("cancelled"))
                    {
                        countCAN++;
                    }
                    if (itemClosed.cstate.Equals("booked") && itemClosed.jstate.Equals("unallocated"))
                    {
                        count2++;
                    }
                }
                double totBooking = booking3.Count();
                double totBookingClosed = bookingClosed4.Count();
                if (comboBox.SelectedItem.Equals("All"))
                {
                    var all1 = bookingCollection1.AsQueryable().Where(x => x.datentime >= resultFrom && x.datentime <= resultTo && x.bookedby.Equals(comboBox.SelectedItem.Equals("BT")) && x.bookedby.Equals(comboBox.SelectedItem.Equals("website")) && x.bookedby.Equals(comboBox.SelectedItem.Equals("CustomerOnline"))).ToList<Booking>();
                    var all2 = bookingClosedCollection2.AsQueryable().Where(x => x.datentime >= resultFrom && x.datentime <= resultTo && x.bookedby.Equals(comboBox.SelectedItem.Equals("BT")) && x.bookedby.Equals(comboBox.SelectedItem.Equals("website")) && x.bookedby.Equals(comboBox.SelectedItem.Equals("CustomerOnline"))).ToList<BookingClosed>();
                    var AllJobs = all1.Count() + all2.Count();
                    TotalJobs.Text = " Jobs by : " + comboBox.SelectedItem + " = " + AllJobs;
                }
                double totalResult = totBooking + totBookingClosed;

                TotalJobs.Text = "Total Jobs by : " + comboBox.SelectedItem + " = " + totalResult;

                countBooked = countB + countBK;
                double percentBooked = Convert.ToDouble(countBooked / totalResult) * 100;
                countJobDone = countJ + countJD;
                double percentJobDone = Convert.ToDouble(countJobDone / totalResult) * 100;
                countCancel = countC + countCAN;
                double percentCanceled = Convert.ToDouble(countCancel / totalResult) * 100;
                countTotal = count1 + count2;
                double percentTotal = Convert.ToDouble(countTotal / totalResult) * 100;

                DespatchChart.DataSource = booking3;
                DespatchChart.DataSource = bookingClosed4;
                DespatchChart.Series["Series1"].Points.Clear();
                DespatchChart.Series["Series1"].Points.AddXY(Inprogress, percentBooked);
                DespatchChart.Series["Series1"].Points.AddXY(jobDone, percentJobDone);
                DespatchChart.Series["Series1"].Points.AddXY(cancelled, percentCanceled);
                DespatchChart.Series["Series1"].Points.AddXY(bookedJob, percentTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected" + ex.Message.ToString());
            }
        }
        private void TodayJobs()
        {
            try
            {
                string cancelled = "Cancelled";
                string Inprogress = "In Progress";
                string jobDone = "Completed";
                string bookedJob = "Booked";
                // string All = "All Jobs";

                double countB = 0;
                double countJ = 0;
                double countC = 0;
                double count1 = 0;
                double countBK = 0;
                double countJD = 0;
                double countCAN = 0;
                double count2 = 0;

                DateTime date1 = DateTime.Now;
                DateTime date2 = DateTime.Now;

                date1 = new DateTime(2019, 04, 03, 00, 00, 00);
                date2 = new DateTime(2019, 04, 03, 23, 59, 59);

                DateTime unix1 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                double result1 = Convert.ToInt32(date1.ToUniversalTime().Subtract(unix1).TotalSeconds);

                DateTime unix2 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                double result2 = Convert.ToInt32(date2.ToUniversalTime().Subtract(unix2).TotalSeconds);

                bookingCollection1 = db.GetCollection<Booking>("Booking");
                bookingClosedCollection2 = db.GetCollection<BookingClosed>("BookingClosed");

                booking3 = bookingCollection1.AsQueryable().Where(x => x.datentime >= result1 && x.datentime <= result2 && x.bookedby.Equals(comboBox.SelectedItem)).ToList<Booking>();
                bookingClosed4 = bookingClosedCollection2.AsQueryable().Where(x => x.datentime >= result1 && x.datentime <= result2 && x.bookedby.Equals(comboBox.SelectedItem)).ToList<BookingClosed>();

                var book = booking3.ToList();
                var bookedClosed = bookingClosed4.ToList();

                foreach (var itemBooked in book)
                {
                    if (itemBooked.cstate.Equals("despatched") && itemBooked.jstate.Equals("allocated"))
                    {
                        countB++;
                    }
                    if (itemBooked.jstate.Equals("JobDone"))
                    {
                        countJ++;
                    }
                    if (itemBooked.cstate.Equals("cancelled"))
                    {
                        countC++;
                    }
                    if (itemBooked.cstate.Equals("booked") && itemBooked.jstate.Equals("unallocated"))
                    {
                        count1++;
                    }
                }
                foreach (var itemClosed in bookedClosed)
                {
                    if (itemClosed.cstate.Equals("despatched") && itemClosed.jstate.Equals("allocated"))
                    {
                        countBK++;
                    }
                    if (itemClosed.jstate.Equals("JobDone"))
                    {
                        countJD++;
                    }
                    if (itemClosed.cstate.Equals("cancelled"))
                    {
                        countCAN++;
                    }
                    if (itemClosed.cstate.Equals("booked") && itemClosed.jstate.Equals("unallocated"))
                    {
                        count2++;
                    }
                }
                double totBooking = booking3.Count();
                double totBookingClosed = bookingClosed4.Count();

                double totalResult = totBooking + totBookingClosed;
                TotalJobs.ForeColor = Color.Red;
                TotalJobs.Text = "Total Jobs by : " + comboBox.SelectedItem + " = " + totalResult;

                countBooked = countB + countBK;
                double percentBooked = Convert.ToDouble(countBooked / totalResult) * 100;
                countJobDone = countJ + countJD;
                double percentJobDone = Convert.ToDouble(countJobDone / totalResult) * 100;
                countCancel = countC + countCAN;
                double percentCanceled = Convert.ToDouble(countCancel / totalResult) * 100;
                countTotal = count1 + count2;
                double percentTotal = Convert.ToDouble(countTotal / totalResult) * 100;

                DespatchChart.DataSource = booking3;
                DespatchChart.DataSource = bookingClosed4;
                DespatchChart.Series["Series1"].Points.Clear();
                DespatchChart.Series["Series1"].Points.AddXY(Inprogress, percentBooked);
                DespatchChart.Series["Series1"].Points.AddXY(jobDone, percentJobDone);
                DespatchChart.Series["Series1"].Points.AddXY(cancelled, percentCanceled);
                DespatchChart.Series["Series1"].Points.AddXY(bookedJob, percentTotal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected" + ex.Message.ToString());
            }
        }
        private void Today_Click(object sender, EventArgs e)
        {
            TodayJobs();
        }

        private void LoginDrivers_Click(object sender, EventArgs e)
        {
            CurrentLoginDrivers();
        }

        private void CurrentLoginDrivers()
        {
            try
            {
                driver = db.GetCollection<Driverloc>("Driverloc");

                DateTime fromDate = FromdateTimePicker.Value;
                DateTime toDate = TodateTimePicker.Value;

                DateTime from = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime to = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

                double resultFrom = Convert.ToInt32(fromDate.ToUniversalTime().Subtract(from).TotalSeconds);
                double resultTo = Convert.ToInt32(toDate.ToUniversalTime().Subtract(to).TotalSeconds);

                driverloc = driver.AsQueryable().Where(x => x.timestamp >= resultFrom && x.timestamp <= resultTo).ToList();
                double drivers = 0;
                var loginDrivers = driverloc;
                foreach (var item in loginDrivers)
                {
                    if (item.lstate.Equals("ENG"))
                    {
                        drivers++;
                    }
                }
                double total = loginDrivers.Count();
                double totalLoginDrivers = drivers;
                double percentage = ((totalLoginDrivers / total) * 100);
                TotalJobs.Text = "Login Drivers = " + totalLoginDrivers;
                DespatchChart.DataSource = loginDrivers;
                DespatchChart.Series["Series1"].Points.Clear();
                DespatchChart.Series["Series1"].Points.AddXY("Login Drivers", percentage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message.ToString());
            }
        }
    }
}
