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
    public partial class EditDispatcher : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditDispatcher(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var dispatcher = context.Dispatchers.Find(selectedRowID);
                var employeesNotDispatchers = Logic.GetEmployeesNotInRole();

                var dispatcherEmployee = context.Employees.Find(dispatcher.DispatcherEmployeeId);

                employeesNotDispatchers.Add(dispatcherEmployee);

                fieldDispatcherEmployeeId.DataSource = employeesNotDispatchers;
                fieldDispatcherEmployeeId.DisplayMember = "EmployeeID";
                fieldDispatcherEmployeeId.ValueMember = "EmployeeID";

                fieldDispatcherEmployeeId.SelectedValue = dispatcher.DispatcherEmployeeId;
                fieldEducation.Text = dispatcher.Education.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var cashier = context.Cashiers.Find(ID);

                cashier.CashierEmployeeId = (int)fieldDispatcherEmployeeId.SelectedValue;
                cashier.AccountantEducation = fieldDispatcherEmployeeId.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
