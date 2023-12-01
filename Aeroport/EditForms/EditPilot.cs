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
    public partial class EditPilot : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditPilot(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var pilot = context.Pilots.Find(selectedRowID);
                var employeesNotPilots = Logic.GetEmployeesNotInRole();

                var pilotEmployee = context.Employees.Find(pilot.PilotEmployeeId);

                employeesNotPilots.Add(pilotEmployee);

                fieldPilotEmployeeId.DataSource = employeesNotPilots;
                fieldPilotEmployeeId.DisplayMember = "EmployeeID";
                fieldPilotEmployeeId.ValueMember = "EmployeeID";
                fieldPilotEmployeeId.SelectedValue = pilot.PilotEmployeeId;
                physical.Value = pilot.Physical;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var pilot = context.Pilots.Find(ID);

                pilot.PilotEmployeeId = (int)fieldPilotEmployeeId.SelectedValue;
                pilot.Physical = (int)physical.Value;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
