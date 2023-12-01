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
    public partial class EditCahier : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditCahier(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;         
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var cashier = context.Cashiers.Find(selectedRowID);
                var employeesNotCashiers = Logic.GetEmployeesNotInRole();

                var cashierEmployee = context.Employees.Find(cashier.CashierEmployeeId);

                employeesNotCashiers.Add(cashierEmployee);

                fieldCashierEmployeeId.DataSource = employeesNotCashiers;
                fieldCashierEmployeeId.DisplayMember = "EmployeeID";
                fieldCashierEmployeeId.ValueMember = "EmployeeID";

                fieldCashierEmployeeId.SelectedValue = cashier.CashierEmployeeId;
                fieldAccountantEducation.Text = cashier.AccountantEducation;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var cashier = context.Cashiers.Find(ID);

                cashier.CashierEmployeeId = (int)fieldCashierEmployeeId.SelectedValue;
                cashier.AccountantEducation = fieldAccountantEducation.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
