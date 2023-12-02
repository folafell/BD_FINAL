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
    public partial class AddAdministrator : Form
    {
        private Aeroport mainForm;
        public AddAdministrator(Aeroport mainform)
        {
            InitializeComponent();
            this.mainForm = mainform;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text) ||
                string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Administrator administrator = new Administrator();
            administrator.Login = textBoxLogin.Text;
            administrator.Password = textBoxPassword.Text;
            Logic.AddEntity(administrator);
            this.Close();
            mainForm.RefreshData();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
        }
    }
}
