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
    public partial class AddPassenger : Form
    {
        private Aeroport mainForm;
        public AddPassenger(Aeroport mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fieldFirstname.Text) ||
                string.IsNullOrEmpty(fieldLastname.Text) ||
                string.IsNullOrEmpty(fieldPatronymic.Text) ||
                string.IsNullOrEmpty(fieldGender.Text) ||
                string.IsNullOrEmpty(fieldAge.Value.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Passenger passenger = new Passenger();
            passenger.Firstname = fieldFirstname.Text;
            passenger.Lastname = fieldLastname.Text;
            passenger.Patronymic = fieldPatronymic.Text;
            passenger.Gender = fieldGender.Text;
            passenger.Age = (int)fieldAge.Value;
            Logic.AddEntity(passenger);
            this.Close();
            mainForm.RefreshData();
        }

        private void fieldGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void fieldAge_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void fieldPatronymic_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void fieldLastname_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void fieldFirstname_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
