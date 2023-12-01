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
    public partial class EditEmployee : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditEmployee(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var employee = context.Employees.Find(selectedRowID);
                var brigades = context.Brigades.ToList();

                fieldEmployeeBrigadeId.DataSource = brigades;
                fieldEmployeeBrigadeId.DisplayMember = "ID";
                fieldEmployeeBrigadeId.ValueMember = "BrigadeId";

                fieldEmployeeBrigadeId.SelectedValue = employee.EmployeeBrigadeId;
                fieldLastname.Text = employee.Lastname;
                fieldAge.Value = (int)employee.Age;
                fieldGender.Text = employee.Gender;
                fieldExperience.Text = employee.Experience;
                fieldChildren.Value = employee.Children;
                fieldSalary.Value = employee.Salary;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var employee = context.Employees.Find(ID);

                employee.EmployeeBrigadeId = (int)fieldEmployeeBrigadeId.SelectedValue;
                employee.Lastname = fieldLastname.Text;
                employee.Age = (int)fieldAge.Value;
                employee.Gender = fieldGender.Text;
                employee.Experience = fieldExperience.Value.ToString();
                employee.Children = (int)fieldChildren.Value;
                employee.Salary = (int)fieldSalary.Value;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
