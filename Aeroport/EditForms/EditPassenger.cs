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
    public partial class EditPassenger : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditPassenger(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var passenger = context.Passengers.Find(selectedRowID);
                fieldFirstname.Text = passenger.Firstname;
                fieldLastname.Text = passenger.Lastname;
                fieldPatronymic.Text = passenger.Patronymic;
                fieldAge.Value = (int)passenger.Age;
                fieldGender.Text = passenger.Gender;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var passenger = context.Passengers.Find(ID);

                passenger.Firstname = fieldFirstname.Text;
                passenger.Lastname = fieldLastname.Text;
                passenger.Patronymic = fieldPatronymic.Text;
                passenger.Age = (int)fieldAge.Value;
                passenger.Gender = fieldGender.Text;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
