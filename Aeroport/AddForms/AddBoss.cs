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
    public partial class AddBoss : Form
    {
        private Aeroport mainForm;
        public AddBoss(Aeroport mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldLastname.Text) ||
                string.IsNullOrEmpty(fieldFirstname.Text) ||
                string.IsNullOrEmpty(fieldPatronymic.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Boss boss = new Boss();
            boss.Lastname = fieldLastname.Text;
            boss.Firstname = fieldFirstname.Text;
            boss.Patronymic = fieldPatronymic.Text;
            boss.Salary = (int)fieldSalary.Value;
            Logic.AddEntity(boss);
            this.Close();
            mainForm.Show();
        }
    }
}
