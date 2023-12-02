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

    public partial class AddAirplane_fixed : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> airplaneTypesDict = new Dictionary<int, string>();

        public AddAirplane_fixed(Aeroport mainForm)
        {
            InitializeComponent();
            using (var context = new AeroportContext())
            {
                var airplaneTypes = context.AirplaneTypes.ToList();
                foreach (var airplaneType in airplaneTypes)
                {
                    airplaneTypesDict.Add(airplaneType.AirplaneTypeId, airplaneType.AirplaneTypeName);
                }
                fieldToAirplaneType.DataSource = airplaneTypes;
                fieldToAirplaneType.DisplayMember = "AirplaneTypeName";
                fieldToAirplaneType.ValueMember = "AirplaneTypeId";
            }

            this.mainForm = mainForm;
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldToAirplaneType.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldLastRepair.Value.ToString()) ||
                string.IsNullOrEmpty(fieldCountOfRepairs.Value.ToString()) ||
                string.IsNullOrEmpty(fieldTechnicalInspectation.Value.ToString()) ||
                string.IsNullOrEmpty(fieldAge.Value.ToString()) ||
                string.IsNullOrEmpty(fieldReceiptDate.Value.ToString()) ||
                string.IsNullOrEmpty(fieldCountOfFlights.Value.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Airplane airplane = new Airplane();
            airplane.ToAirplaneTypeId = (int)fieldToAirplaneType.SelectedValue;
            airplane.LastRepair = fieldLastRepair.Value;
            airplane.CountOfRepairs = (int)fieldCountOfRepairs.Value;
            airplane.TechnicalInspection = fieldTechnicalInspectation.Value;
            airplane.Age = (int)fieldAge.Value;
            airplane.ReceiptDate = fieldReceiptDate.Value;
            airplane.CountOfFlights = (int)fieldCountOfFlights.Value;
            Logic.AddEntity(airplane);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
