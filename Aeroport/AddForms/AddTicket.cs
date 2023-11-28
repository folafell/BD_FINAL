using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroport
{
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
            using (var context = new AeroportContext())
            {
                var passengers = context.Passengers.ToList();

                fieldTicketPassengerId.DataSource = passengers;
                fieldTicketPassengerId.DisplayMember = "ID";
                fieldTicketPassengerId.ValueMember = "PassengerID";

                var flights = context.Flights.ToList();

                fieldTicketFlightId.DataSource = flights;
                fieldTicketFlightId.DisplayMember = "ID";
                fieldTicketFlightId.ValueMember = "FlightID";

            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldTicketPassengerId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldTicketFlightId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldPriceOf.Value.ToString()) ||
                string.IsNullOrEmpty(fieldDateOf.Value.ToString()) ||
                string.IsNullOrEmpty(fieldSeatLetter.Text) ||
                string.IsNullOrEmpty(fieldSeatNumber.Text) ||
                string.IsNullOrEmpty(fieldStatus.Text) ||
                string.IsNullOrEmpty(fieldHours.Value.ToString()) ||
                string.IsNullOrEmpty(fieldMinutes.Value.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Ticket ticket = new Ticket();
            ticket.TicketPassengerId = ((int)fieldTicketPassengerId.SelectedValue);
            ticket.TicketFlightId = ((int)fieldTicketFlightId.SelectedValue);
            ticket.PriceOf = (int)fieldPriceOf.Value;
            ticket.DateOf = fieldDateOf.Value;
            String seat = fieldSeatLetter.Text + fieldSeatNumber.Value.ToString();
            ticket.Seat = seat;
            ticket.Status = fieldStatus.Text;
            int hours = (int)fieldHours.Value;
            int minutes = (int)fieldMinutes.Value;

            TimeSpan time = new TimeSpan(hours, minutes, 0);
            string timeString = time.ToString(@"hh\:mm\:ss");
            ticket.TimeOf = time;
            Logic.AddEntity(ticket);
            this.Close();
        }
    }
}
