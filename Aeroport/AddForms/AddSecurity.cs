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
    public partial class AddSecurity : Form
    {
        private Aeroport mainForm;
        public AddSecurity(Aeroport mainForm)
        {
            InitializeComponent();
            var employeesNotSecurities = Logic.GetEmployeesNotInRole();
            fieldSecurityEmployeeId.DataSource = employeesNotSecurities;
            fieldSecurityEmployeeId.DisplayMember = "EmployeeID";
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldSecurityEmployeeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldEducation.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Security security = new Security();
            security.SecurityEmployeeId = ((Employee)fieldSecurityEmployeeId.SelectedValue).EmployeeId;
            security.Education = fieldEducation.Text;
            Logic.AddEntity(security);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
