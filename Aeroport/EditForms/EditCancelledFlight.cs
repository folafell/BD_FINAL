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
    public partial class EditCancelledFlight : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditCancelledFlight(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var cancelledFlight = context.CanceledFlights.Find(selectedRowID);

                var flights = context.Flights.ToList();

                fieldFlightID.DataSource = flights;
                fieldFlightID.DisplayMember = "ID";
                fieldFlightID.ValueMember = "FlightID";

                fieldFlightID.SelectedValue = cancelledFlight.FlightId;
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var context = new AeroportContext())
            {
                var cancelledFlight = context.CanceledFlights.Find(ID);

                cancelledFlight.FlightId = (int)fieldFlightID.SelectedValue;
                cancelledFlight.Reason = fieldReason.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
