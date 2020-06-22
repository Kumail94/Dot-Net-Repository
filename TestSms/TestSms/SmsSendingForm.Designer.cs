namespace TestSms
{
    partial class SmsSendingForm
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
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.Sendmsg_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Deviceinfo_textbox = new System.Windows.Forms.TextBox();
            this.Sim_textbox = new System.Windows.Forms.TextBox();
            this.reciver_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(164, 103);
            this.message_textbox.MaxLength = 160;
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(350, 193);
            this.message_textbox.TabIndex = 1;
            // 
            // Sendmsg_Button
            // 
            this.Sendmsg_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sendmsg_Button.Location = new System.Drawing.Point(276, 329);
            this.Sendmsg_Button.Name = "Sendmsg_Button";
            this.Sendmsg_Button.Size = new System.Drawing.Size(98, 31);
            this.Sendmsg_Button.TabIndex = 2;
            this.Sendmsg_Button.Text = "Send SMS";
            this.Sendmsg_Button.UseVisualStyleBackColor = true;
            this.Sendmsg_Button.Click += new System.EventHandler(this.Sendmsg_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Device Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SIM IMEI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reciver #";
            // 
            // Deviceinfo_textbox
            // 
            this.Deviceinfo_textbox.Location = new System.Drawing.Point(164, 19);
            this.Deviceinfo_textbox.Multiline = true;
            this.Deviceinfo_textbox.Name = "Deviceinfo_textbox";
            this.Deviceinfo_textbox.ReadOnly = true;
            this.Deviceinfo_textbox.Size = new System.Drawing.Size(361, 20);
            this.Deviceinfo_textbox.TabIndex = 8;
            // 
            // Sim_textbox
            // 
            this.Sim_textbox.Location = new System.Drawing.Point(164, 45);
            this.Sim_textbox.Multiline = true;
            this.Sim_textbox.Name = "Sim_textbox";
            this.Sim_textbox.ReadOnly = true;
            this.Sim_textbox.Size = new System.Drawing.Size(158, 20);
            this.Sim_textbox.TabIndex = 9;

            // 
            // reciver_textbox
            // 
            this.reciver_textbox.Location = new System.Drawing.Point(164, 71);
            this.reciver_textbox.MaxLength = 12;
            this.reciver_textbox.Multiline = true;
            this.reciver_textbox.Name = "reciver_textbox";
            this.reciver_textbox.Size = new System.Drawing.Size(158, 20);
            this.reciver_textbox.TabIndex = 0;
            // 
            // SmsSendingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 458);
            this.Controls.Add(this.reciver_textbox);
            this.Controls.Add(this.Sim_textbox);
            this.Controls.Add(this.Deviceinfo_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sendmsg_Button);
            this.Controls.Add(this.message_textbox);
            this.Name = "SmsSendingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.SmsSendingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Button Sendmsg_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Deviceinfo_textbox;
        public System.Windows.Forms.TextBox Sim_textbox;
        private System.Windows.Forms.TextBox reciver_textbox;
    }
}