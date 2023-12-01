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
    public partial class EditAirplane : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> airplaneTypesDict = new Dictionary<int, string>();
        private int ID;
        public EditAirplane(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var airplane = context.Airplanes.Find(selectedRowID);

                var airplaneType = context.AirplaneTypes.ToList();
                fieldToAirplaneType.DataSource = airplaneType;
                fieldToAirplaneType.DisplayMember = "airplaneType";
                fieldToAirplaneType.ValueMember = "airplaneTypeId";
                fieldToAirplaneType.SelectedValue = airplane.ToAirplaneTypeId;

                fieldLastRepair.Value = airplane.LastRepair;
                fieldCountOfRepairs.Value = airplane.CountOfRepairs;
                fieldTechnicalInspectation.Value = airplane.TechnicalInspection;
                fieldAge.Value = airplane.Age;
                fieldReceiptDate.Value = airplane.ReceiptDate;
                fieldCountOfFlights.Value = airplane.CountOfFlights;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var airplane = context.Airplanes.Find(ID);

                airplane.ToAirplaneTypeId = (int)fieldToAirplaneType.SelectedValue;
                airplane.LastRepair = fieldLastRepair.Value;
                airplane.CountOfRepairs = (int)fieldCountOfRepairs.Value;
                airplane.TechnicalInspection = fieldTechnicalInspectation.Value;
                airplane.Age = (int)fieldAge.Value;
                airplane.ReceiptDate = fieldReceiptDate.Value;
                airplane.CountOfFlights = (int)fieldCountOfFlights.Value;
                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
