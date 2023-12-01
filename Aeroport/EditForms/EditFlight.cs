using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Aeroport.EditForms
{
    public partial class EditFlight : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> airplaneTypesDict = new Dictionary<int, string>();
        private int ID;
        public EditFlight(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var flight = context.Flights.Find(selectedRowID);
                fieldPlacefrom.Text = flight.PlaceFrom.ToString();
                fieldPlaceTo.Text = flight.PlaceTo.ToString();
                fieldCategory.SelectedValue = flight.Category.ToString();
                TimeSpan ts = TimeSpan.Parse(flight.Duration.ToString());
                int hours = ts.Hours;
                int minutes = ts.Minutes;
                fieldHours.Value = hours;
                fieldMinutes.Value = minutes;

                var airplaneTypes = context.AirplaneTypes.ToList();
                foreach (var airplaneType in airplaneTypes)
                {
                    airplaneTypesDict.Add(airplaneType.AirplaneTypeId, airplaneType.AirplaneTypeName);
                }
                fieldAirplaneTypeId.DataSource = airplaneTypes;
                fieldAirplaneTypeId.DisplayMember = "AirplaneTypeName";
                fieldAirplaneTypeId.ValueMember = "AirplaneTypeId";
                fieldAirplaneTypeId.SelectedValue = flight.FlightAirplaneTypeId;

                var brigades = context.Brigades.ToList();

                fieldBrigadeId.DataSource = brigades;
                fieldBrigadeId.DisplayMember = "Brigade";
                fieldBrigadeId.ValueMember = "BrigadeId";
                fieldBrigadeId.SelectedValue = flight.FlightBrigadeId;
                fieldCategory.Text= flight.Category;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var context = new AeroportContext())
            {
                var flight = context.Flights.Find(ID);

                flight.PlaceFrom = fieldPlacefrom.Text;
                flight.PlaceTo = fieldPlaceTo.Text;
                flight.Category = fieldCategory.Text;

                int hours = (int)fieldHours.Value;
                int minutes = (int)fieldMinutes.Value;

                TimeSpan time = new TimeSpan(hours, minutes, 0);

                flight.Duration = time;
                flight.FlightAirplaneTypeId = (int)fieldAirplaneTypeId.SelectedValue;
                flight.FlightBrigadeId = (int)fieldBrigadeId.SelectedValue;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
