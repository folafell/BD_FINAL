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
    public partial class EditAdministrator : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditAdministrator(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var administrator = context.Administrators.Find(selectedRowID);

                textBoxLogin.Text = administrator.Login;
                textBoxPassword.Text = administrator.Password;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var administrator = context.Administrators.Find(ID);

                administrator.Login = textBoxLogin.Text;
                administrator.Password = textBoxPassword.Text;
                context.SaveChanges();
            }

            this.Close();
            mainForm.RefreshData();
        }
    }
}
