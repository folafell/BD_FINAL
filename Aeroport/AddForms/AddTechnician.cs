using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeroport
{
    public partial class AddTechnician : Form
    {
        public AddTechnician()
        {
            InitializeComponent();
            var employeesNotTechnicians = Logic.GetEmployeesNotInRole();
            fieldTechnicianEmployeeId.DataSource = employeesNotTechnicians;
            fieldTechnicianEmployeeId.DisplayMember = "EmployeeID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldTechnicianEmployeeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldEducation.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Technician technician = new Technician();
            technician.TechnicianEmployeeId = ((Employee)fieldTechnicianEmployeeId.SelectedValue).EmployeeId;
            technician.Education = fieldEducation.Text;
            Logic.AddEntity(technician);
            this.Close();
        }
    }
}
