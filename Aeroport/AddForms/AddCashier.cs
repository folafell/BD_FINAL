using Microsoft.EntityFrameworkCore;
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
    public partial class AddCashier : Form
    {
        private Aeroport mainForm;
        public AddCashier(Aeroport mainForm)
        {
            InitializeComponent();
            var employeesNotCashiers = Logic.GetEmployeesNotInRole();
            fieldCashierEmployeeId.DataSource = employeesNotCashiers;
            fieldCashierEmployeeId.DisplayMember = "EmployeeID";
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldCashierEmployeeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldAccountantEducation.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Cashier cashier = new Cashier();
            cashier.CashierEmployeeId = ((Employee)fieldCashierEmployeeId.SelectedValue).EmployeeId;
            cashier.AccountantEducation = fieldAccountantEducation.Text;
            Logic.AddEntity(cashier);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
