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
    public partial class EditSecurity : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditSecurity(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var security = context.Securities.Find(selectedRowID);
                var employeesNotSecurities = Logic.GetEmployeesNotInRole();

                var securityEmployee = context.Employees.Find(security.SecurityEmployeeId);

                employeesNotSecurities.Add(securityEmployee);

                fieldSecurityEmployeeId.DataSource = employeesNotSecurities;
                fieldSecurityEmployeeId.DisplayMember = "EmployeeID";
                fieldSecurityEmployeeId.ValueMember = "EmployeeID";

                fieldSecurityEmployeeId.SelectedValue = security.SecurityEmployeeId;
                fieldEducation.Text = security.Education;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var security = context.Securities.Find(ID);

                security.SecurityEmployeeId = (int)fieldSecurityEmployeeId.SelectedValue;
                security.Education = fieldEducation.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
