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
    public partial class AddPilot : Form
    {
        private Aeroport mainForm;
        public AddPilot(Aeroport mainForm)
        {
            InitializeComponent();
            var employeesNotPilots = Logic.GetEmployeesNotInRole();
            fieldPilotEmployeeId.DataSource = employeesNotPilots;
            fieldPilotEmployeeId.DisplayMember = "EmployeeID";
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldPilotEmployeeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(physical.Value.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Pilot pilot = new Pilot();
            pilot.PilotEmployeeId = ((Employee)fieldPilotEmployeeId.SelectedValue).EmployeeId;
            pilot.Physical = (int)physical.Value;
            Logic.AddEntity(pilot);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
