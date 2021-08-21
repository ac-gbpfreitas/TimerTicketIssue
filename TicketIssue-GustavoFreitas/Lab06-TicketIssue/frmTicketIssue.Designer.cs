
namespace Lab06_TicketIssue
{
    partial class frmTicketIssue
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumberGuests = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTicketIssue = new System.Windows.Forms.Button();
            this.lbNextEntry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTicketsLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxTickets = new System.Windows.Forms.ListBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timerControl = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNumberGuests);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // lbNumberGuests
            // 
            this.lbNumberGuests.AutoSize = true;
            this.lbNumberGuests.Location = new System.Drawing.Point(16, 30);
            this.lbNumberGuests.Name = "lbNumberGuests";
            this.lbNumberGuests.Size = new System.Drawing.Size(0, 15);
            this.lbNumberGuests.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTicketIssue);
            this.groupBox2.Controls.Add(this.lbNextEntry);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTicketsLeft);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // btnTicketIssue
            // 
            this.btnTicketIssue.Location = new System.Drawing.Point(29, 110);
            this.btnTicketIssue.Name = "btnTicketIssue";
            this.btnTicketIssue.Size = new System.Drawing.Size(98, 22);
            this.btnTicketIssue.TabIndex = 2;
            this.btnTicketIssue.Text = "Issue Ticket";
            this.btnTicketIssue.UseVisualStyleBackColor = true;
            this.btnTicketIssue.Click += new System.EventHandler(this.btnTicketIssue_Click);
            // 
            // lbNextEntry
            // 
            this.lbNextEntry.AutoSize = true;
            this.lbNextEntry.Location = new System.Drawing.Point(202, 81);
            this.lbNextEntry.Name = "lbNextEntry";
            this.lbNextEntry.Size = new System.Drawing.Size(38, 15);
            this.lbNextEntry.TabIndex = 6;
            this.lbNextEntry.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Next available entry:";
            // 
            // lbTicketsLeft
            // 
            this.lbTicketsLeft.AutoSize = true;
            this.lbTicketsLeft.Location = new System.Drawing.Point(202, 40);
            this.lbTicketsLeft.Name = "lbTicketsLeft";
            this.lbTicketsLeft.Size = new System.Drawing.Size(13, 15);
            this.lbTicketsLeft.TabIndex = 4;
            this.lbTicketsLeft.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // lstBoxTickets
            // 
            this.lstBoxTickets.FormattingEnabled = true;
            this.lstBoxTickets.ItemHeight = 15;
            this.lstBoxTickets.Location = new System.Drawing.Point(23, 271);
            this.lstBoxTickets.Name = "lstBoxTickets";
            this.lstBoxTickets.Size = new System.Drawing.Size(327, 94);
            this.lstBoxTickets.TabIndex = 2;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(23, 383);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(98, 22);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 22);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerControl
            // 
            this.timerControl.Enabled = true;
            this.timerControl.Interval = 1000;
            // 
            // frmTicketIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 426);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstBoxTickets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTicketIssue";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTicketIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNumberGuests;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTicketIssue;
        private System.Windows.Forms.Label lbNextEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTicketsLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxTickets;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerControl;
    }
}

