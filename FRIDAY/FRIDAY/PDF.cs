using FRIDAY.Properties;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRIDAY
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("FRIDAY");
        static IMongoCollection<Entries> collection = db.GetCollection<Entries>("Entries");
        List<Entries> lists = new List<Entries>();
        private void INSERT_Click(object sender, EventArgs e)
        {
            //Entries records = new Entries(textBox1.Text, textBox2.Text, textBox3.Text);
            //collection.InsertOne(records);
            //MessageBox.Show("Record has been added successfully!");
            //lists.Add(records);
            
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Convert to pdf";
            ofd.FileName = "Pdf";
            ofd.Filter = "Save pdf (*.pdf | pdf)";

            try
            {
                string path = ofd.FileName;
                //MessageBox.Show("Do you show this conervsion in to pdf.?", "Sure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    Document doc = new Document(PageSize.A4, 15, 15, 0, 0);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                    doc.Open();
                    
                    Paragraph title1;
                    BaseFont bfTimes1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font1 = new iTextSharp.text.Font(bfTimes1, 26, iTextSharp.text.Font.BOLD);
                    title1 = new Paragraph("Booking", font1);
                    title1.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title1);

                    Paragraph title2;
                    BaseFont bfTimes2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font2 = new iTextSharp.text.Font(bfTimes2, 12, iTextSharp.text.Font.ITALIC);
                    title2 = new Paragraph("Station Cars Crystal Palace Limited, 1-3 Lendrington Road, Crystal Palace, London, SE19 2BF", font2);
                    title2.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title2);

                    Paragraph titleMid;
                    BaseFont bfTimesMid = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font fontMid = new iTextSharp.text.Font(bfTimesMid, 10, iTextSharp.text.Font.ITALIC);
                    titleMid = new Paragraph("Tel No. +44(0) 208778888888, Fax No. +44(0)208666591614", fontMid);
                    titleMid.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titleMid);

                    Paragraph title;
                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bfTimes, 14, iTextSharp.text.Font.NORMAL);
                    title = new Paragraph("________________________________________________________________________________", font);
                    title.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title);

                    Paragraph title3;
                    BaseFont bfTimes3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font3 = new iTextSharp.text.Font(bfTimes3, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontCMP = new iTextSharp.text.Font(bfTimes3, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title3 = new Paragraph("Barnet", font3);
                    title3.Add(new Chunk("                                                     CMP5245552", fontCMP));
                    title3.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title3);
                    var date = DateTime.Now.ToShortDateString();
                    var time = DateTime.Now.ToLongTimeString();

                    Paragraph title4;
                    BaseFont bfTimes4 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font4 = new iTextSharp.text.Font(bfTimes4, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontBk = new iTextSharp.text.Font(bfTimes4, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title4 = new Paragraph("Booking Date Time:", font4);
                    title4.Add(new Chunk("                               " + date + "  " + time , fontBk));
                    title4.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title4);
                  
                    Paragraph title5;
                    BaseFont bfTimes5 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font5 = new iTextSharp.text.Font(bfTimes5, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontCA = new iTextSharp.text.Font(bfTimes5, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title5 = new Paragraph("Account", font5);
                    title5.Add(new Chunk("                                                   CASH", fontCA));
                    title5.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title5);
                   
                    Paragraph title6;
                    BaseFont bfTimes6 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font6 = new iTextSharp.text.Font(bfTimes6, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontS = new iTextSharp.text.Font(bfTimes6, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title6 = new Paragraph("Vechile", font6);
                    title6.Add(new Chunk("                                                    S", fontS));
                    title6.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title6);
                    
                    Paragraph title7;
                    BaseFont bfTimes7 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font7 = new iTextSharp.text.Font(bfTimes7, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontTy = new iTextSharp.text.Font(bfTimes7, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title7 = new Paragraph("Customer Name:", font7);
                    title7.Add(new Chunk("                                     TERRY", fontTy));
                    title7.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title7);
                    
                    Paragraph title8;
                    BaseFont bfTimes8 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font8 = new iTextSharp.text.Font(bfTimes8, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontFL = new iTextSharp.text.Font(bfTimes8, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title8 = new Paragraph("Origin", font8);
                    title8.Add(new Chunk("                                                      FLAT 1 TEFFLER HOUSE,KINGWOOD ESTATE,SE21,SE21", fontFL));
                    title8.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title8);

                    Paragraph title9;
                    BaseFont bfTimes9 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font9 = new iTextSharp.text.Font(bfTimes9, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontICE = new iTextSharp.text.Font(bfTimes9, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title9 = new Paragraph("Destination:", font9);
                    title9.Add(new Chunk("                                             ICELAND,WESTOW STREET,SE19 , SE19", fontICE));
                    title9.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title9);
                    
                    Paragraph title10;
                    BaseFont bfTimes10 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font10 = new iTextSharp.text.Font(bfTimes10, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    //iTextSharp.text.Font fontCmt = new iTextSharp.text.Font(bfTimes10, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title10 = new Paragraph("Comment:", font10);
                    title10.Add(new Chunk("                \n", font10));
                    title10.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title10);
                    
                    Paragraph title11;
                    BaseFont bfTimes11 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font11 = new iTextSharp.text.Font(bfTimes11, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontfive = new iTextSharp.text.Font(bfTimes11, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title11 = new Paragraph("Fare:", font11);
                    title11.Add(new Chunk("                                                        # 5", fontfive));
                    title11.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title11);

                    Paragraph title12;
                    BaseFont bfTimes12 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font12 = new iTextSharp.text.Font(bfTimes12, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    iTextSharp.text.Font fontMiles = new iTextSharp.text.Font(bfTimes12, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    title12 = new Paragraph("Distance:", font12);
                    title12.Add(new Chunk("                                                 1.5 Miles", fontMiles));
                    title12.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title12);

                    Paragraph title13;
                    BaseFont bfTimes13 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font font13 = new iTextSharp.text.Font(bfTimes13, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    //iTextSharp.text.Font font13 = new iTextSharp.text.Font(bfTimes13, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.RED);
                    title13 = new Paragraph("Driver:", font13);
                    title13.Add(new Chunk("                             \n", font13));
                    title13.Alignment = Element.ALIGN_LEFT;
                    doc.Add(title13);

                 //   Paragraph titlez;
                 //   BaseFont bfTimez = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                 //   iTextSharp.text.Font fontz = new iTextSharp.text.Font(bfTimes1, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK, iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();
                 //   titlez = new Paragraph("______________________________________________________________________________________________________________________________", fontz);
                 //   titlez.Alignment = Element.SECTION;
                 //   doc.Add(titlez);
                    //float curlX;
                    //float curlY;

                   


                    Paragraph titleEnd;
                    BaseFont bfTimesEnd = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font fontEnd = new iTextSharp.text.Font(bfTimesEnd, 14, iTextSharp.text.Font.NORMAL);
                    titleEnd = new Paragraph("________________________________________________________________________________", fontEnd);
                    titleEnd.Alignment = Element.ALIGN_LEFT;
                    doc.Add(titleEnd);
                    var dated = DateTime.Now.ToShortDateString();
                    var timing = DateTime.Now.ToLongTimeString();
                    Paragraph titleAt;
                    BaseFont bfTimesAt = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font fontAt = new iTextSharp.text.Font(bfTimesAt, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    titleAt = new Paragraph("Generate At: " + dated + "   " + timing, fontAt);
                    titleAt.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(titleAt);

                    Paragraph titleBy;
                    BaseFont bfTimesBy = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    iTextSharp.text.Font fontBy = new iTextSharp.text.Font(bfTimesBy, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                    titleBy = new Paragraph("Generate By: Kumail7861994@gmail.com", fontBy);
                    titleBy.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(titleBy);
                    //string s1 = "Name";
                    //p1.Add(new Paragraph(s1, font1));
                    //Paragraph p2 = new Paragraph();
                    //BaseFont bfTimes2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    //iTextSharp.text.Font font2 = new iTextSharp.text.Font(bfTimes2);
                    //string s2 = "Age";
                    //p2.Add(new Paragraph(s2, font2));
                    //Paragraph p3 = new Paragraph();
                    //BaseFont bfTimes3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    //iTextSharp.text.Font font3 = new iTextSharp.text.Font(bfTimes3);
                    //string s3 = "Department";
                    //p3.Add(new Paragraph(s3, font3));
                    doc.Close();
                    ofd.ShowDialog();
                    //Document doc = new Document();
                    //PdfWriter.GetInstance(doc, new FileStream(" ", FileMode.Create));
                    //doc.Open();
                    //Paragraph p = new Paragraph();
                    //PdfPTable table = new PdfPTable(3);
                    //table.TotalWidth = 510f;//table size
                    //table.LockedWidth = true;
                    //table.SpacingBefore = 18f;//both are used to mention the space from heading
                    //table.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    //table.DefaultCell.Border = PdfPCell.LEFT_BORDER | PdfPCell.RIGHT_BORDER;
                    //table.AddCell(new Phrase("    Name"));
                    //table.AddCell(new Phrase("   Age"));
                    //table.AddCell(new Phrase("   Department"));
                    //doc.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message.ToString());
            }
        }
        private void Get_Click(object sender, EventArgs e)
        {
            //printPreviewDialog.Document = printDocument;
            //ToolStripButton b = new ToolStripButton();
            //b.Text = "pdf";
            //b.Image = Properties.Resources.iconfinder_pdf_01_3079290;
            //b.DisplayStyle = ToolStripItemDisplayStyle.Image;
            //b.Click += printPreview_PrintClick;
            //((ToolStrip)(printPreviewDialog.Controls[1])).Items.RemoveAt(0);
            //((ToolStrip)(printPreviewDialog.Controls[1])).Items.Insert(0, b);
            //printPreviewDialog.ShowDialog(this);
        }
        private void printPreview_PrintClick(object sender, EventArgs e)
        {

        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Image image = Resources.Barnet;
            //e.Graphics.DrawImage(image, 0, 0, image.Width, image.Height);
            //e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------ ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 155));
            //e.Graphics.DrawString("Name ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            //e.Graphics.DrawString("Age ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(255, 200));
            //e.Graphics.DrawString("Department ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 200));
            //e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------- ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 225));
            //int y = 270;
            //foreach (var item in lists)
            //{
            //    e.Graphics.DrawString("" + item.SName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, y));
            //    e.Graphics.DrawString("" + item.Age, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(255, y));
            //    e.Graphics.DrawString("" + item.Department, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, y));
            //    y += 40;
            //}
        }
        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
        }
    }
}
