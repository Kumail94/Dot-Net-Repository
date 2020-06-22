namespace Internet_Availability
{
    partial class Internet_Availabilty
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
            this.Power = new System.Windows.Forms.Label();
            this.Checking = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Power
            // 
            this.Power.Image = global::Internet_Availability.Properties.Resources.if_060_Off_183189;
            this.Power.Location = new System.Drawing.Point(351, 9);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(23, 30);
            this.Power.TabIndex = 2;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Checking
            // 
            this.Checking.AutoSize = true;
            this.Checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checking.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Checking.Location = new System.Drawing.Point(67, 61);
            this.Checking.Name = "Checking";
            this.Checking.Size = new System.Drawing.Size(79, 29);
            this.Checking.TabIndex = 0;
            this.Checking.Text = "label1";
            // 
            // Internet_Availabilty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(386, 147);
            this.Controls.Add(this.Checking);
            this.Controls.Add(this.Power);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Internet_Availabilty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet_Availabilty";
            this.Load += new System.EventHandler(this.Internet_Availabilty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Power;
        private System.Windows.Forms.Label Checking;
    }
}