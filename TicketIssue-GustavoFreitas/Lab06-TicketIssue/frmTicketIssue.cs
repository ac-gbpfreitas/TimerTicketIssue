using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_TicketIssue{
    public partial class frmTicketIssue : Form {


        //Get data from Option Form
        private frmOptions optionForm = new frmOptions();

        private int nextTicket = 0;

        //Create a collection of TimeSlot
        private List<TimeSlot> timeSlotCollection = new List<TimeSlot>();
        //Create a collection of Tickets
        private Queue<Ticket> ticketsCollection = new Queue<Ticket>();

        private int counterSlots = 0;
        private string stringOpenClose = "(Closed)";

        int first = 0, last = 0;
        


        private void generateSlots() {
            
            for (
                DateTime i = optionForm.startTime;//The timeStart
                i <= optionForm.endTime; //The timeEnd
                i = i.AddMinutes(optionForm.minutesPerWindow) //The time Length
                )
            {
                //Create a new TimeSlot object
                TimeSlot newSlot = new TimeSlot();
                newSlot.timeSlotLength = optionForm.minutesPerWindow; // Set the attributes
                newSlot.ticketsIssued = 0; //As there are not issued tickets, they are 0
                newSlot.timeStart = i; //The timeStart added 5 minutes

                //Add that time slot into a collection
                timeSlotCollection.Add(newSlot);
            }
            
        }

        public frmTicketIssue() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmTicketIssue_Load(object sender, EventArgs e) {

            this.Hide();
            optionForm.ShowDialog();
            
            if (optionForm.DialogResult == DialogResult.Cancel) {
                this.Show();
                nextTicket = optionForm.firstTicket;
                timerChange();
                lbNextEntry.Text = "0";
                lbTicketsLeft.Text = "0";
                setFollowingLabel();
                generateSlots();
            }
            
        }

        private void setFollowingLabel() {
            
            
            if (ticketsCollection.Count > 0) {

                foreach (Ticket nTicket in ticketsCollection) {
                    if (timeSlotCollection[0].timeStart == nTicket.timeSlot) {
                        first = nTicket.ticketNumber;
                        break;
                    }
                }

                foreach (Ticket nTicket in ticketsCollection) {
                    if (timeSlotCollection[0].timeStart == nTicket.timeSlot) {
                        last = nTicket.ticketNumber;
                    }
                }

            }

            lbNumberGuests.Text =  first + " - " + last;
        }

        private void timerChange() {
            timerControl.Interval = 1000;
            timerControl.Tick += new EventHandler(refreshTimer_Tick);
            timerControl.Start();

            DateTime currentTime = DateTime.Now;
            this.Text = String.Format("{0:hh:mm:ss tt}", currentTime) + " "+ stringOpenClose;
        }

        private void unQueue() {

            if (ticketsCollection.Count > 0) {
                ticketsCollection = new Queue<Ticket>(
                    ticketsCollection.Where(x => x.timeSlot != timeSlotCollection[0].timeStart)
                );
            }
        }


        private void refreshTimer_Tick(object sender, EventArgs e) {


            DateTime currentTime = DateTime.Now;
            this.Text = String.Format("{0:hh:mm:ss tt}", currentTime) + " " + stringOpenClose;
            lbNextEntry.Text = String.Format("{0:hh:mm tt}", timeSlotCollection[0].timeStart);

            if (
                String.Format("{0:hh:mm tt}", timeSlotCollection[0].timeStart) ==
                String.Format("{0:hh:mm tt}", currentTime)
            ) {
                stringOpenClose = "(Open)";
                unQueue();
                timeSlotCollection.RemoveAt(0);
                fillTicketList();
                setFollowingLabel();
                this.Text = String.Format("{0:hh:mm:ss tt}", currentTime) + " " + stringOpenClose;
            }
        }


        private void btnTicketIssue_Click(object sender, EventArgs e)        {

            //Clean the List Box
            lstBoxTickets.DataSource = null;
            lstBoxTickets.Items.Clear();

            addNewTicket();
            
            lbNextEntry.Text = String.Format("{0:hh:mm tt}", timeSlotCollection[1].timeStart);
            fillTicketList();
            setFollowingLabel();
        }

        private void fillTicketList() {

            lstBoxTickets.Items.Clear();

            if (ticketsCollection != null) {

                foreach (Ticket nTicket in ticketsCollection) {
                    lstBoxTickets.Items.Add(
                            "Ticket " + nTicket.ticketNumber + ": " +
                            nTicket.timeSlot.ToString("hh:mm tt")
                        );
                }
            }
            lbTicketsLeft.Text = lstBoxTickets.Items.Count.ToString();
        }

        private void btnOptions_Click(object sender, EventArgs e)        {
            
            lstBoxTickets.Items.Clear();
            lbNumberGuests.Text = "0 - 0";
            lbNextEntry.Text = "0";
            lbTicketsLeft.Text = "0";
            this.Hide();
            optionForm.ShowDialog();

            if (optionForm.DialogResult == DialogResult.Cancel) {
                this.Show();
                nextTicket = optionForm.firstTicket;

                ticketsCollection.Clear();
                timeSlotCollection.Clear();
                setFollowingLabel();
                timerChange();
                generateSlots();
                setFollowingLabel();
            }
        }

        private void addNewTicket() {

            try { 
                    //Create a new Ticket
                    Ticket newTicket = new Ticket();

                    //Check if the ticket list is empty
                    if (ticketsCollection.Count > 0) {

                        
                        newTicket.ticketNumber = nextTicket;
                                                
                        newTicket.timeSlot = timeSlotCollection[counterSlots].timeStart;

                        //Check if the slot is with guests limit
                        if (
                            timeSlotCollection[counterSlots].ticketsIssued < 
                            optionForm.guestsPerWindow-1
                        ){
                            //if the number of tickets for that time slot is in the guests limit
                            timeSlotCollection[counterSlots].ticketsIssued++;
                            
                        } else {
                            //Check if there is time slot available
                            if (counterSlots <= timeSlotCollection.Count()) {
                                //If yes, goes to the next slotTime available
                                counterSlots++;
                            } else {
                                throw new Exception("There are no more time slots available");
                            }
                        }
                    
                    } else {
                        newTicket.ticketNumber = nextTicket;
                        newTicket.timeSlot = timeSlotCollection[counterSlots].timeStart;
                        timeSlotCollection[counterSlots].ticketsIssued++;
                    }

                    ticketsCollection.Enqueue(newTicket);
                    nextTicket++;

            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }
       
    }
}
