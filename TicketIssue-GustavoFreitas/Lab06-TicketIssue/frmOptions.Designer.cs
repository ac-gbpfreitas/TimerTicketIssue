
namespace Lab06_TicketIssue
{
    partial class frmOptions
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timePickerStart = new System.Windows.Forms.DateTimePicker();
            this.timePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.txtBoxMinutes = new System.Windows.Forms.TextBox();
            this.txtBoxGuests = new System.Windows.Forms.TextBox();
            this.txtBoxFirstTicket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(152, 247);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes per Window:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Guests per window:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "End time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "First ticket number:";
            // 
            // timePickerStart
            // 
            this.timePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerStart.Location = new System.Drawing.Point(152, 106);
            this.timePickerStart.Name = "timePickerStart";
            this.timePickerStart.ShowUpDown = true;
            this.timePickerStart.Size = new System.Drawing.Size(100, 23);
            this.timePickerStart.TabIndex = 11;
            // 
            // timePickerEnd
            // 
            this.timePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerEnd.Location = new System.Drawing.Point(152, 151);
            this.timePickerEnd.Name = "timePickerEnd";
            this.timePickerEnd.ShowUpDown = true;
            this.timePickerEnd.Size = new System.Drawing.Size(100, 23);
            this.timePickerEnd.TabIndex = 12;
            // 
            // txtBoxMinutes
            // 
            this.txtBoxMinutes.Location = new System.Drawing.Point(152, 19);
            this.txtBoxMinutes.Name = "txtBoxMinutes";
            this.txtBoxMinutes.Size = new System.Drawing.Size(100, 23);
            this.txtBoxMinutes.TabIndex = 13;
            // 
            // txtBoxGuests
            // 
            this.txtBoxGuests.Location = new System.Drawing.Point(152, 60);
            this.txtBoxGuests.Name = "txtBoxGuests";
            this.txtBoxGuests.Size = new System.Drawing.Size(100, 23);
            this.txtBoxGuests.TabIndex = 14;
            // 
            // txtBoxFirstTicket
            // 
            this.txtBoxFirstTicket.Location = new System.Drawing.Point(152, 193);
            this.txtBoxFirstTicket.Name = "txtBoxFirstTicket";
            this.txtBoxFirstTicket.Size = new System.Drawing.Size(100, 23);
            this.txtBoxFirstTicket.TabIndex = 15;
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 286);
            this.Controls.Add(this.txtBoxFirstTicket);
            this.Controls.Add(this.txtBoxGuests);
            this.Controls.Add(this.txtBoxMinutes);
            this.Controls.Add(this.timePickerEnd);
            this.Controls.Add(this.timePickerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Name = "frmOptions";
            this.Text = "frmOptions";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker timePickerStart;
        private System.Windows.Forms.DateTimePicker timePickerEnd;
        private System.Windows.Forms.TextBox txtBoxMinutes;
        private System.Windows.Forms.TextBox txtBoxGuests;
        private System.Windows.Forms.TextBox txtBoxFirstTicket;
    }
}