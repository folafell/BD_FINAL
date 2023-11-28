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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
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
        }
    }
}
