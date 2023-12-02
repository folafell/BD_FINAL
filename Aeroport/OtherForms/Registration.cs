using Aeroport.Tables;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"\d"))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]"))
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну заглавную букву.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"[\W_]"))
            {
                MessageBox.Show("Пароль должен содержать хотя бы один специальный символ.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Length < 8)
            {
                MessageBox.Show("Логин должен содержать не менее 8 символов.");
                return;
            }
            using (var context = new AeroportContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserLogin == textBoxLogin.Text);
                if (user != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован.");
                    return;
                }
            }
            if (IsValidPassword(textBoxPassword.Text))
            {
                using (var context = new AeroportContext())
                {
                    var newUser = new User { UserLogin = textBoxLogin.Text, UserPassword = textBoxPassword.Text };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }
                MessageBox.Show($"Привет, {textBoxLogin.Text}! Вы успешно зарегистрированы.");

                loadAuthorization();
                return;
            }
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void loadAuthorization()
        {
            var authorizationForm = new Authorization();
            authorizationForm.FormClosed += AuthorizationForm_FormClosed;
            this.Hide();
            authorizationForm.Show();
        }

        private void linkLabelAlready_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadAuthorization();
        }
    }
}
