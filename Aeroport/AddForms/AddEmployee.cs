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
    public partial class AddEmployee : Form
    {
        private Aeroport mainForm;
        public AddEmployee(Aeroport mainForm)
        {
            InitializeComponent();
            using (var context = new AeroportContext())
            {
                var brigades = context.Brigades.ToList();

                fieldEmployeeBrigadeId.DataSource = brigades;
                fieldEmployeeBrigadeId.DisplayMember = "ID";
                fieldEmployeeBrigadeId.ValueMember = "BrigadeID";
            }

            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldEmployeeBrigadeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldLastname.Text) ||
                string.IsNullOrEmpty(fieldAge.Value.ToString()) ||
                string.IsNullOrEmpty(fieldGender.Text) ||
                string.IsNullOrEmpty(fieldExperience.Value.ToString()) ||
                string.IsNullOrEmpty(fieldChildren.Value.ToString()) ||
                 string.IsNullOrEmpty(fieldSalary.Value.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Employee employee = new Employee();
            employee.EmployeeBrigadeId = (int)fieldEmployeeBrigadeId.SelectedValue;
            employee.Lastname = fieldLastname.Text;
            employee.Age = (int)fieldEmployeeBrigadeId.SelectedValue;
            employee.Gender = fieldGender.Text;
            employee.Experience = fieldExperience.Value.ToString();
            employee.Children = (int)fieldChildren.Value;
            employee.Salary = (int)fieldSalary.Value;
            Logic.AddEntity(employee);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
