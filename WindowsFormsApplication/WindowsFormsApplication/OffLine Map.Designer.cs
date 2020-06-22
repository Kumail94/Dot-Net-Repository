namespace WindowsFormsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.BookingTabPage = new System.Windows.Forms.TabPage();
            this.MPC = new AxMapPoint.AxMappointControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.spiliter = new System.Windows.Forms.Splitter();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.ManualFare = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.secondLatLng = new System.Windows.Forms.Label();
            this.UML = new System.Windows.Forms.Label();
            this.firstLatLng = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.latlng = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.CategoryCarComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.FromTextBox = new WindowsFormsApplication.AutoCompleteTextBox();
            this.ToTextBox = new WindowsFormsApplication.AutoCompleteTextBox();
            this.tabControl.SuspendLayout();
            this.BookingTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPC)).BeginInit();
            this.panel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BookingTabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1156, 639);
            this.tabControl.TabIndex = 1;
            // 
            // BookingTabPage
            // 
            this.BookingTabPage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BookingTabPage.Controls.Add(this.MPC);
            this.BookingTabPage.Controls.Add(this.label4);
            this.BookingTabPage.Controls.Add(this.label5);
            this.BookingTabPage.Controls.Add(this.label3);
            this.BookingTabPage.Controls.Add(this.label2);
            this.BookingTabPage.Controls.Add(this.label1);
            this.BookingTabPage.Controls.Add(this.distance);
            this.BookingTabPage.Controls.Add(this.label29);
            this.BookingTabPage.Controls.Add(this.dateTimePicker);
            this.BookingTabPage.Controls.Add(this.listBox);
            this.BookingTabPage.Controls.Add(this.label35);
            this.BookingTabPage.Controls.Add(this.label32);
            this.BookingTabPage.Controls.Add(this.label33);
            this.BookingTabPage.Controls.Add(this.checkBox1);
            this.BookingTabPage.Controls.Add(this.panel);
            this.BookingTabPage.Controls.Add(this.label31);
            this.BookingTabPage.Controls.Add(this.label25);
            this.BookingTabPage.Controls.Add(this.label24);
            this.BookingTabPage.Controls.Add(this.label23);
            this.BookingTabPage.Controls.Add(this.label22);
            this.BookingTabPage.Controls.Add(this.label21);
            this.BookingTabPage.Controls.Add(this.label20);
            this.BookingTabPage.Controls.Add(this.label14);
            this.BookingTabPage.Controls.Add(this.spiliter);
            this.BookingTabPage.Controls.Add(this.checkBox);
            this.BookingTabPage.Controls.Add(this.ManualFare);
            this.BookingTabPage.Controls.Add(this.panel11);
            this.BookingTabPage.Controls.Add(this.textBox2);
            this.BookingTabPage.Controls.Add(this.TimePicker);
            this.BookingTabPage.Controls.Add(this.PaymentComboBox);
            this.BookingTabPage.Controls.Add(this.panel1);
            this.BookingTabPage.Controls.Add(this.comboBox3);
            this.BookingTabPage.Controls.Add(this.CategoryCarComboBox);
            this.BookingTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BookingTabPage.Location = new System.Drawing.Point(4, 22);
            this.BookingTabPage.Name = "BookingTabPage";
            this.BookingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookingTabPage.Size = new System.Drawing.Size(1148, 613);
            this.BookingTabPage.TabIndex = 0;
            this.BookingTabPage.Text = "Booking";
            // 
            // MPC
            // 
            this.MPC.Enabled = true;
            this.MPC.Location = new System.Drawing.Point(8, 4);
            this.MPC.Name = "MPC";
            this.MPC.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MPC.OcxState")));
            this.MPC.Size = new System.Drawing.Size(485, 603);
            this.MPC.TabIndex = 265;
            // 
            // label4
            // 
            this.label4.Image = global::WindowsFormsApplication.Properties.Resources.if_Calendar01_928424__1_;
            this.label4.Location = new System.Drawing.Point(501, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 26);
            this.label4.TabIndex = 260;
            // 
            // label5
            // 
            this.label5.Image = global::WindowsFormsApplication.Properties.Resources.if_editor_alarm_timer_clock_outline_stroke_763369;
            this.label5.Location = new System.Drawing.Point(501, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 261;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Image = global::WindowsFormsApplication.Properties.Resources.if_BT_c3behind_905666;
            this.label3.Location = new System.Drawing.Point(490, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 262;
            this.label3.Text = "#";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(499, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 26);
            this.label2.TabIndex = 263;
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApplication.Properties.Resources.if___Eye_Show_View_Watch_See_Disable_Inactive_Unavailable_Off_3844443;
            this.label1.Location = new System.Drawing.Point(501, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 264;
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.ForeColor = System.Drawing.Color.Black;
            this.distance.Location = new System.Drawing.Point(1007, 401);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(11, 16);
            this.distance.TabIndex = 259;
            this.distance.Text = ".";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(933, 400);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 258;
            this.label29.Text = "Distance:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = " ";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(537, 80);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker.TabIndex = 257;
            this.dateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dated);
            this.dateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.date);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(707, 28);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(141, 95);
            this.listBox.TabIndex = 256;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(915, 583);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(12, 16);
            this.label35.TabIndex = 44;
            this.label35.Text = "|";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(915, 565);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(12, 16);
            this.label32.TabIndex = 44;
            this.label32.Text = "|";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(915, 547);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(12, 16);
            this.label33.TabIndex = 43;
            this.label33.Text = "|";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(1080, 543);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 42;
            this.checkBox1.Text = "Status";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.label26);
            this.panel.Controls.Add(this.panel9);
            this.panel.Controls.Add(this.panel7);
            this.panel.Controls.Add(this.panel6);
            this.panel.Controls.Add(this.panel5);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.panel2);
            this.panel.Location = new System.Drawing.Point(502, 382);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(407, 228);
            this.panel.TabIndex = 41;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label26.Image = global::WindowsFormsApplication.Properties.Resources.if_icon_3_high_five_329409;
            this.label26.Location = new System.Drawing.Point(354, 182);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 30);
            this.label26.TabIndex = 37;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.textBox13);
            this.panel9.Controls.Add(this.textBox14);
            this.panel9.Location = new System.Drawing.Point(9, 178);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(327, 36);
            this.panel9.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Image = global::WindowsFormsApplication.Properties.Resources.if_BT_c3behind_9056661;
            this.label19.Location = new System.Drawing.Point(31, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 18);
            this.label19.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label17.Image = global::WindowsFormsApplication.Properties.Resources.if_header_account_image_line_1540176;
            this.label17.Location = new System.Drawing.Point(4, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 26);
            this.label17.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(56, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 19);
            this.label15.TabIndex = 27;
            this.label15.Text = "Reqd.";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(108, 9);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(88, 20);
            this.textBox13.TabIndex = 17;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(202, 9);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(115, 20);
            this.textBox14.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.textBox8);
            this.panel7.Location = new System.Drawing.Point(196, 138);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(204, 34);
            this.panel7.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Image = global::WindowsFormsApplication.Properties.Resources.if_big_dipper_2981828;
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 26;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(38, 7);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(157, 20);
            this.textBox8.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.textBox6);
            this.panel6.Location = new System.Drawing.Point(233, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 42);
            this.panel6.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Image = global::WindowsFormsApplication.Properties.Resources.if_at_118740;
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 30);
            this.label11.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(37, 10);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 20);
            this.textBox6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Location = new System.Drawing.Point(9, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 42);
            this.panel5.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(7, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Order  #";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 10);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 20);
            this.textBox5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(9, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 34);
            this.panel4.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Image = global::WindowsFormsApplication.Properties.Resources.if_265_Keyboard_2124171;
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 19);
            this.label7.TabIndex = 25;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(342, 20);
            this.textBox4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Location = new System.Drawing.Point(200, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 36);
            this.panel3.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label16.Image = global::WindowsFormsApplication.Properties.Resources.if_search_298865;
            this.label16.Location = new System.Drawing.Point(174, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 23);
            this.label16.TabIndex = 27;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(6, 8);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(162, 20);
            this.textBox11.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(9, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 36);
            this.panel2.TabIndex = 30;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.Location = new System.Drawing.Point(5, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(22, 28);
            this.label30.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(7, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 31);
            this.label8.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(915, 526);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(12, 16);
            this.label31.TabIndex = 40;
            this.label31.Text = "|";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(915, 486);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 16);
            this.label25.TabIndex = 33;
            this.label25.Text = "|";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(915, 508);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 16);
            this.label24.TabIndex = 34;
            this.label24.Text = "|";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(915, 467);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 16);
            this.label23.TabIndex = 35;
            this.label23.Text = "|";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(915, 447);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 16);
            this.label22.TabIndex = 36;
            this.label22.Text = "|";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(915, 424);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "|";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(915, 405);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "|";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(915, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "|";
            // 
            // spiliter
            // 
            this.spiliter.Location = new System.Drawing.Point(3, 3);
            this.spiliter.Name = "spiliter";
            this.spiliter.Size = new System.Drawing.Size(490, 607);
            this.spiliter.TabIndex = 31;
            this.spiliter.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.ForeColor = System.Drawing.Color.Black;
            this.checkBox.Location = new System.Drawing.Point(948, 566);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(196, 17);
            this.checkBox.TabIndex = 27;
            this.checkBox.Text = "Manual despatch this booking";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // ManualFare
            // 
            this.ManualFare.BackColor = System.Drawing.Color.DarkOrange;
            this.ManualFare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManualFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualFare.ForeColor = System.Drawing.Color.White;
            this.ManualFare.Location = new System.Drawing.Point(997, 499);
            this.ManualFare.Name = "ManualFare";
            this.ManualFare.Size = new System.Drawing.Size(103, 36);
            this.ManualFare.TabIndex = 19;
            this.ManualFare.Text = "Manual Fare";
            this.ManualFare.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel11.Controls.Add(this.label28);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.label27);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(854, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 126);
            this.panel11.TabIndex = 24;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label28.Location = new System.Drawing.Point(61, 33);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 20);
            this.label28.TabIndex = 31;
            this.label28.Text = "Ref";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(61, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Ref";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(126, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 16);
            this.label27.TabIndex = 27;
            this.label27.Text = "UML6100151";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Last";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(126, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 16);
            this.label18.TabIndex = 29;
            this.label18.Text = "UML7254816";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Curr";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(707, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 5;
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = " ";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.Location = new System.Drawing.Point(537, 106);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(162, 20);
            this.TimePicker.TabIndex = 4;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            this.TimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimePicker_KeyDown);
            this.TimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time);
            // 
            // PaymentComboBox
            // 
            this.PaymentComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentComboBox.FormattingEnabled = true;
            this.PaymentComboBox.Items.AddRange(new object[] {
            "CASH",
            "CC",
            "MINICABIT",
            "JENNIFER",
            "10076",
            "NBT"});
            this.PaymentComboBox.Location = new System.Drawing.Point(537, 3);
            this.PaymentComboBox.Name = "PaymentComboBox";
            this.PaymentComboBox.Size = new System.Drawing.Size(162, 21);
            this.PaymentComboBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.FromTextBox);
            this.panel1.Controls.Add(this.secondLatLng);
            this.panel1.Controls.Add(this.UML);
            this.panel1.Controls.Add(this.firstLatLng);
            this.panel1.Controls.Add(this.ToTextBox);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.latlng);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(502, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 244);
            this.panel1.TabIndex = 255;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox9.Location = new System.Drawing.Point(44, 9);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 25);
            this.textBox9.TabIndex = 31;
            this.textBox9.Text = "UML";
            // 
            // secondLatLng
            // 
            this.secondLatLng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLatLng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.secondLatLng.Image = global::WindowsFormsApplication.Properties.Resources.if_ic_view_module_48px_3669149;
            this.secondLatLng.Location = new System.Drawing.Point(6, 76);
            this.secondLatLng.Name = "secondLatLng";
            this.secondLatLng.Size = new System.Drawing.Size(23, 20);
            this.secondLatLng.TabIndex = 30;
            // 
            // UML
            // 
            this.UML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.UML.Image = global::WindowsFormsApplication.Properties.Resources.if_play_arrow_326577;
            this.UML.Location = new System.Drawing.Point(8, 46);
            this.UML.Name = "UML";
            this.UML.Size = new System.Drawing.Size(23, 27);
            this.UML.TabIndex = 30;
            // 
            // firstLatLng
            // 
            this.firstLatLng.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLatLng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.firstLatLng.Image = global::WindowsFormsApplication.Properties.Resources.if_Server_858733;
            this.firstLatLng.Location = new System.Drawing.Point(3, 7);
            this.firstLatLng.Name = "firstLatLng";
            this.firstLatLng.Size = new System.Drawing.Size(32, 33);
            this.firstLatLng.TabIndex = 30;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox10.Location = new System.Drawing.Point(43, 75);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(135, 20);
            this.textBox10.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox7.Location = new System.Drawing.Point(43, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(135, 20);
            this.textBox7.TabIndex = 7;
            // 
            // latlng
            // 
            this.latlng.BackColor = System.Drawing.Color.DarkOrange;
            this.latlng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.latlng.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latlng.ForeColor = System.Drawing.Color.White;
            this.latlng.Location = new System.Drawing.Point(376, 3);
            this.latlng.Name = "latlng";
            this.latlng.Size = new System.Drawing.Size(32, 37);
            this.latlng.TabIndex = 20;
            this.latlng.Text = "+";
            this.latlng.UseVisualStyleBackColor = false;
            this.latlng.Click += new System.EventHandler(this.latlng_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(316, 9);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(54, 25);
            this.textBox.TabIndex = 20;
            this.textBox.Text = "VIAS";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(336, 225);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 13);
            this.label.TabIndex = 0;
            this.label.Text = "STATS!!!";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(537, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // CategoryCarComboBox
            // 
            this.CategoryCarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCarComboBox.FormattingEnabled = true;
            this.CategoryCarComboBox.Items.AddRange(new object[] {
            "Salon",
            "Estate\t",
            "6 Passenger",
            "7 Passenger",
            "Low Car",
            "8 Passenger",
            "Executive",
            "5 Seater"});
            this.CategoryCarComboBox.Location = new System.Drawing.Point(537, 29);
            this.CategoryCarComboBox.Name = "CategoryCarComboBox";
            this.CategoryCarComboBox.Size = new System.Drawing.Size(162, 21);
            this.CategoryCarComboBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1148, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Despatch";
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1148, 613);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Active";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FromTextBox
            // 
            this.FromTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FromTextBox.Location = new System.Drawing.Point(185, 46);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(440, 20);
            this.FromTextBox.TabIndex = 8;
            this.FromTextBox.Values = null;
            this.FromTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            this.FromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatLong);
            // 
            // ToTextBox
            // 
            this.ToTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToTextBox.Location = new System.Drawing.Point(185, 75);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(440, 20);
            this.ToTextBox.TabIndex = 10;
            this.ToTextBox.Values = null;
            this.ToTextBox.TextChanged += new System.EventHandler(this.ToTextBox_TextChanged);
            this.ToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatLong);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 644);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OffLine Map";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.BookingTabPage.ResumeLayout(false);
            this.BookingTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPC)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage BookingTabPage;
      //  private AxMapPoint.AxMappointControl MPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Splitter spiliter;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button ManualFare;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.ComboBox PaymentComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox9;
        private AutoCompleteTextBox FromTextBox;
        private System.Windows.Forms.Label secondLatLng;
        private System.Windows.Forms.Label UML;
        private System.Windows.Forms.Label firstLatLng;
        private AutoCompleteTextBox ToTextBox;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button latlng;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox CategoryCarComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private AxMapPoint.AxMappointControl MPC;
        private System.Windows.Forms.Label label30;

    }
}

