namespace Liver_Wall_Board
{
    partial class Live_Wall_Board
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Analyze = new System.Windows.Forms.Button();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DespatchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Today = new MaterialSkin.Controls.MaterialFlatButton();
            this.TotalJobs = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.LoginDrivers = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DespatchChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Analyze
            // 
            this.Analyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Analyze.Location = new System.Drawing.Point(1098, 516);
            this.Analyze.Name = "Analyze";
            this.Analyze.Size = new System.Drawing.Size(101, 26);
            this.Analyze.TabIndex = 40;
            this.Analyze.Text = "Get Analysis";
            this.Analyze.UseVisualStyleBackColor = true;
            this.Analyze.Click += new System.EventHandler(this.Analyze_Click);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.CustomFormat = " ";
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromdateTimePicker.Location = new System.Drawing.Point(57, 78);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.FromdateTimePicker.TabIndex = 38;
            this.FromdateTimePicker.ValueChanged += new System.EventHandler(this.FromdateTimePicker_ValueChanged);
            this.FromdateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromdateTimePicker_KeyDown);
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CustomFormat = " ";
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TodateTimePicker.Location = new System.Drawing.Point(1009, 77);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.TodateTimePicker.TabIndex = 39;
            this.TodateTimePicker.ValueChanged += new System.EventHandler(this.TodateTimePicker_ValueChanged);
            this.TodateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TodateTimePicker_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(980, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "To";
            // 
            // DespatchChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DespatchChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.DespatchChart.Legends.Add(legend1);
            this.DespatchChart.Location = new System.Drawing.Point(34, 160);
            this.DespatchChart.Name = "DespatchChart";
            this.DespatchChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.LabelFormat = "#.##";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.DespatchChart.Series.Add(series1);
            this.DespatchChart.Size = new System.Drawing.Size(1130, 350);
            this.DespatchChart.TabIndex = 41;
            this.DespatchChart.Text = "WallBoardChart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            title1.Name = "Title1";
            title1.Text = "Business Analysis";
            this.DespatchChart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(690, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(587, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(506, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(403, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "label1";
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Today.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Today.Depth = 0;
            this.Today.Location = new System.Drawing.Point(13, 520);
            this.Today.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Today.MouseState = MaterialSkin.MouseState.HOVER;
            this.Today.Name = "Today";
            this.Today.Primary = false;
            this.Today.Size = new System.Drawing.Size(94, 36);
            this.Today.TabIndex = 43;
            this.Today.Text = "Today Jobs";
            this.Today.UseVisualStyleBackColor = false;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // TotalJobs
            // 
            this.TotalJobs.AutoSize = true;
            this.TotalJobs.Depth = 0;
            this.TotalJobs.Font = new System.Drawing.Font("Roboto", 11F);
            this.TotalJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalJobs.Location = new System.Drawing.Point(403, 121);
            this.TotalJobs.MouseState = MaterialSkin.MouseState.HOVER;
            this.TotalJobs.Name = "TotalJobs";
            this.TotalJobs.Size = new System.Drawing.Size(0, 19);
            this.TotalJobs.TabIndex = 44;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "manager@wcp.sc",
            "manager@cyp.sc",
            "manager@sur.sc",
            "manager@nba.sc",
            "manager@nbt.sc",
            "BT",
            "CustomerOnline",
            "website"});
            this.comboBox.Location = new System.Drawing.Point(747, 75);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(168, 21);
            this.comboBox.TabIndex = 45;
            // 
            // LoginDrivers
            // 
            this.LoginDrivers.AutoSize = true;
            this.LoginDrivers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LoginDrivers.Depth = 0;
            this.LoginDrivers.Location = new System.Drawing.Point(501, 66);
            this.LoginDrivers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginDrivers.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginDrivers.Name = "LoginDrivers";
            this.LoginDrivers.Primary = false;
            this.LoginDrivers.Size = new System.Drawing.Size(102, 36);
            this.LoginDrivers.TabIndex = 46;
            this.LoginDrivers.Text = "Driver Login";
            this.LoginDrivers.UseVisualStyleBackColor = false;
            this.LoginDrivers.Click += new System.EventHandler(this.LoginDrivers_Click);
            // 
            // Live_Wall_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 562);
            this.Controls.Add(this.LoginDrivers);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.TotalJobs);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DespatchChart);
            this.Controls.Add(this.Analyze);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Live_Wall_Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Live_Wall_Board";
            ((System.ComponentModel.ISupportInitialize)(this.DespatchChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Analyze;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart DespatchChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton Today;
        private MaterialSkin.Controls.MaterialLabel TotalJobs;
        private System.Windows.Forms.ComboBox comboBox;
        private MaterialSkin.Controls.MaterialFlatButton LoginDrivers;
    }
}