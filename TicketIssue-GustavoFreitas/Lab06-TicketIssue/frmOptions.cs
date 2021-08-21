using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab06_TicketIssue
{
    public partial class frmOptions : Form    {
        public frmOptions()        {
            InitializeComponent();
        }

        public int minutesPerWindow = 5, firstTicket = 1, guestsPerWindow = 5;
        public DateTime startTime = DateTime.Now.AddMinutes(1);
        public DateTime endTime = DateTime.Now.AddHours(4);

        private void btnOk_Click(object sender, EventArgs e)        {

            try {
                startTime = timePickerStart.Value;
                endTime = timePickerEnd.Value;

                if (!checkPeriod(startTime, endTime, minutesPerWindow)) {
                    throw new Exception("End time is shorter than Start time!");
                } else if ( (checkGuests() && checkMinutes() && checkFirstTicket()) ) {
                    this.Hide();
                }
                
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            
        }

         private bool checkMinutes() {

            bool valid = false;
            try {

                if (!txtBoxMinutes.Text.Equals("")) {
                    if (Int32.TryParse(txtBoxMinutes.Text, out minutesPerWindow)) {
                        if (minutesPerWindow <= 0) {
                            throw new Exception("Fill a number higher than 0");
                        } else {
                            valid = true;
                        }
                    } else {
                        throw new Exception("This is not a valid number!");
                    }
                } else {
                    throw new Exception("Please, fill the minimum minutes!");
                }
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            return valid;
        }

        private bool checkFirstTicket() {
            bool valid = false;
            try {
                if (!txtBoxFirstTicket.Text.Equals("")) {
                    if (Int32.TryParse(txtBoxFirstTicket.Text, out firstTicket))                    {
                        if (firstTicket <= 0) {
                            throw new Exception("Fill a number higher than 0");
                        } else {
                            valid = true;
                        }
                    } else {
                        throw new Exception("This is not a valid number!");
                    }
                } else {
                    throw new Exception("Please, fill the minimum minutes!");
                }
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            return valid;
        }

        private void frmOptions_Load(object sender, EventArgs e) {
            timePickerStart.Text = String.Format("{0:hh:mm:ss tt}", startTime);
            timePickerEnd.Text = String.Format("{0:hh:mm:ss tt}", endTime);
        }

        private bool checkGuests() {

            bool valid = false;
            try {

                if (!txtBoxGuests.Text.Equals("")) { 
                    if (Int32.TryParse(txtBoxGuests.Text, out guestsPerWindow)) {
                        if (guestsPerWindow <= 0) {
                            throw new Exception("Fill a number higher than 0");
                        } else {
                            valid = true;
                        }
                    } else {
                        throw new Exception("This is not a valid number!");
                    }
                } else {
                    throw new Exception("Please, fill the minimum minutes!");
                }
                
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
            return valid;
        }

        private bool checkPeriod(DateTime start, DateTime end, int minutes) {
            bool valid = false;
            int count = 0;
            if ( start < end) {
                valid = true;
            }

            for (DateTime i = start; i <= end; i.AddMinutes(minutes) ) {
                count++;
                if ( count < 2) {
                    valid = false;

                } else {
                    valid = true;
                    break;
                }
            }
            
            return valid;
        }

    }
}
