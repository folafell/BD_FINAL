using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aeroport.Tables;

namespace Aeroport
{
    public partial class AddDispatcher : Form
    {
        private Aeroport mainForm;
        public AddDispatcher(Aeroport mainForm)
        {
            InitializeComponent();
            var employeesNotDispatchers = Logic.GetEmployeesNotInRole();
            fieldDispatcherEmployeeId.DataSource = employeesNotDispatchers;
            fieldDispatcherEmployeeId.DisplayMember = "EmployeeID";
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(fieldDispatcherEmployeeId.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldEducation.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Dispatcher dispatcher = new Dispatcher();
            dispatcher.DispatcherEmployeeId = ((Employee)fieldDispatcherEmployeeId.SelectedValue).EmployeeId;
            dispatcher.Education = fieldEducation.Text;
            Logic.AddEntity(dispatcher);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
