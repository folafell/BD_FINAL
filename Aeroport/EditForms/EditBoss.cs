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
    public partial class EditBoss : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditBoss(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var boss = context.Bosses.Find(selectedRowID);

                fieldLastname.Text = boss.Lastname;
                fieldFirstname.Text = boss.Firstname;
                fieldPatronymic.Text = boss.Patronymic;
                fieldSalary.Value = boss.Salary;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var boss = context.Bosses.Find(ID);

                boss.Lastname = fieldLastname.Text;
                boss.Firstname = fieldFirstname.Text;
                boss.Patronymic = fieldPatronymic.Text;
                boss.Salary = fieldSalary.Value;
                context.SaveChanges();
            }

            this.Close();
            mainForm.RefreshData();
        }
    }
}
