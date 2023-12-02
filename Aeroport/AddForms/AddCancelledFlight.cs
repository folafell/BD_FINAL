using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeroport.Tables;

namespace Aeroport
{
    public partial class AddCancelledFlight : Form
    {
        private Aeroport mainForm;

        public AddCancelledFlight(Aeroport mainForm)
        {
            InitializeComponent();
            using (var context = new AeroportContext())
            {
                var flights = context.Flights.ToList();

                fieldFlightID.DataSource = flights;
                fieldFlightID.DisplayMember = "ID";
                fieldFlightID.ValueMember = "FlightID";
            }

            this.mainForm = mainForm;   
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldFlightID.Text) ||
               string.IsNullOrEmpty(fieldReason.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            CanceledFlight canceledFlight = new CanceledFlight();

            canceledFlight.FlightId = (int)fieldFlightID.SelectedValue;
            canceledFlight.Reason = fieldReason.Text;
            Logic.AddEntity(canceledFlight);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
