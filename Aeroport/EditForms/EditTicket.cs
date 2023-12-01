using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroport.EditForms
{
    public partial class EditTicket : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditTicket(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var ticket = context.Tickets.Find(selectedRowID);

                var passenger = context.Passengers.ToList();
                fieldTicketPassengerId.DataSource = passenger;
                fieldTicketPassengerId.DisplayMember = "Passenger";
                fieldTicketPassengerId.ValueMember = "PassengerId";
                fieldTicketPassengerId.SelectedValue = ticket.TicketPassengerId;

                var flight = context.Flights.ToList();
                fieldTicketFlightId.DataSource = flight;
                fieldTicketFlightId.DisplayMember = "Flight";
                fieldTicketFlightId.ValueMember = "FlightId";
                fieldTicketFlightId.SelectedValue = ticket.TicketFlightId;

                fieldPriceOf.Value = ticket.PriceOf;
                fieldDateOf.Value = ticket.DateOf;
                string Seat = ticket.Seat;
                string SeatLeter = Seat.Substring(0, 1);
                string SeatNumber = Seat.Substring(1);
                fieldSeatLetter.Text = SeatLeter;
                fieldSeatNumber.Text = SeatNumber;

                fieldStatus.Text = ticket.Status;

                string time = ticket.TimeOf.ToString();
                TimeSpan ts = TimeSpan.Parse(time);
                int hours = ts.Hours;
                int minutes = ts.Minutes;
                fieldHours.Value = hours;
                fieldMinutes.Value = minutes;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var ticket = context.Tickets.Find(ID);

                ticket.TicketPassengerId = (int)fieldTicketPassengerId.SelectedValue;
                ticket.TicketFlightId = (int)fieldTicketFlightId.SelectedValue;
                ticket.PriceOf = fieldPriceOf.Value;
                ticket.DateOf = fieldDateOf.Value;
                ticket.Seat = fieldSeatLetter.Text + fieldSeatNumber.Text;
                ticket.Status = fieldStatus.Text;

                TimeSpan timeOf = new TimeSpan((int)fieldHours.Value, (int)fieldMinutes.Value, 0);
                ticket.TimeOf = timeOf;
                context.Entry(ticket).State = EntityState.Modified;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
