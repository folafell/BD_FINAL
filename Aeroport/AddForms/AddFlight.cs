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

namespace Aeroport.AddForms
{
    public partial class AddFlight : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> airplaneTypesDict = new Dictionary<int, string>();
        public AddFlight(Aeroport mainForm)
        {
            InitializeComponent();
            using (var context = new AeroportContext())
            {
                var airplaneTypes = context.AirplaneTypes.ToList();
                foreach (var airplaneType in airplaneTypes)
                {
                    airplaneTypesDict.Add(airplaneType.AirplaneTypeId, airplaneType.AirplaneTypeName);
                }
                fieldAirplaneTypeId.DataSource = airplaneTypes;
                fieldAirplaneTypeId.DisplayMember = "AirplaneTypeName";
                fieldAirplaneTypeId.ValueMember = "AirplaneTypeId";

                var brigades = context.Brigades.ToList();

                fieldBrigadeId.DataSource = brigades;
                fieldBrigadeId.DisplayMember = "Brigade";
                fieldBrigadeId.ValueMember = "BrigadeId";


            }

            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldPlacefrom.Text) ||
                string.IsNullOrEmpty(fieldPlaceTo.Text) ||
                string.IsNullOrEmpty(fieldCategory.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldHours.Value.ToString()) ||
                string.IsNullOrEmpty(fieldMinutes.Value.ToString()) ||
                string.IsNullOrEmpty(fieldAirplaneTypeId.Text) ||
                string.IsNullOrEmpty(fieldBrigadeId.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Flight flight = new Flight();
            flight.PlaceFrom = fieldPlacefrom.Text;
            flight.PlaceTo = fieldPlaceTo.Text;
            flight.Category = fieldCategory.Text;
            
            int hours = (int)fieldHours.Value;
            int minutes = (int)fieldMinutes.Value;

            TimeSpan time = new TimeSpan(hours, minutes, 0);

            flight.Duration = time;
            flight.FlightAirplaneTypeId = (int)fieldAirplaneTypeId.SelectedValue;
            flight.FlightBrigadeId = (int)fieldBrigadeId.SelectedValue;
            Logic.AddEntity(flight);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
