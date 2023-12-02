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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var context = new AeroportContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserLogin == textBoxLogin.Text && u.UserPassword == textBoxPassword.Text);
                if (user != null)
                {
                    var aeroportForm = new Aeroport();
                    aeroportForm.FormClosed += RegistrationForm_FormClosed;
                    this.Hide();
                    aeroportForm.Show();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registrationForm = new Registration();
            registrationForm.FormClosed += RegistrationForm_FormClosed;
            this.Hide();
            registrationForm.Show();
        }
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
