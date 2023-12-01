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
    public partial class EditTechnician : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditTechnician(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var technician = context.Technicians.Find(selectedRowID);
                var employeesNotTechnicians = Logic.GetEmployeesNotInRole();

                var technicianEmployee = context.Employees.Find(technician.TechnicianEmployeeId);

                employeesNotTechnicians.Add(technicianEmployee);

                fieldTechnicianEmployeeId.DataSource = employeesNotTechnicians;
                fieldTechnicianEmployeeId.DisplayMember = "EmployeeID";
                fieldTechnicianEmployeeId.ValueMember = "EmployeeID";

                fieldTechnicianEmployeeId.SelectedValue = technician.TechnicianEmployeeId;
                fieldEducation.Text = technician.Education;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var technician = context.Securities.Find(ID);

                technician.SecurityEmployeeId = (int)fieldTechnicianEmployeeId.SelectedValue;
                technician.Education = fieldEducation.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
