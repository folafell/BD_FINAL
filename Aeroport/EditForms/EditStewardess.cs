using Microsoft.EntityFrameworkCore;
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
    public partial class EditStewardess : Form
    {
        private Aeroport mainForm;
        private int ID;

        public EditStewardess(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var stewardess = context.Stewardesses.Find(selectedRowID);
                var employeesNotStewardesses = Logic.GetEmployeesNotInRole();

                var stewardessEmployee = context.Employees.Find(stewardess.StewardessEmployeeId);

                employeesNotStewardesses.Add(stewardessEmployee);

                fieldStewardessEmployeeId.DataSource = employeesNotStewardesses;
                fieldStewardessEmployeeId.DisplayMember = "EmployeeID";
                fieldStewardessEmployeeId.ValueMember = "EmployeeID";

                fieldStewardessEmployeeId.SelectedValue = stewardess.StewardessEmployeeId;
                var languages = stewardess.ForeignLanguage.Split(", ");

                var checkBoxes = new System.Windows.Forms.CheckBox[] { checkBoxEnglish,
                                                       checkBoxGerman,
                                                       checkBoxSpanish,
                                                       checkBoxFrench,
                                                       checkBoxJapanese,
                                                       checkBoxChinese
                                                     };

                foreach (var checkBox in checkBoxes)
                {
                    if (languages.Contains(checkBox.Text))
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var checkBoxes = new System.Windows.Forms.CheckBox[] { checkBoxEnglish,
                                                               checkBoxGerman,
                                                               checkBoxSpanish,
                                                               checkBoxFrench,
                                                               checkBoxJapanese,
                                                               checkBoxChinese
                                                             };

                bool atLeastOneChecked = checkBoxes.Any(cb => cb.Checked);

                if (!atLeastOneChecked)
                {
                    MessageBox.Show("Пожалуйста, выберите хотя бы один язык.");
                    return;
                }

                var selectedLanguages = checkBoxes
                        .Where(cb => cb.Checked)
                        .Select(cb => cb.Text);

                string languagesString = string.Join(", ", selectedLanguages);

                var stewardess = context.Stewardesses.Find(ID);

                stewardess.StewardessEmployeeId = (int)fieldStewardessEmployeeId.SelectedValue;
                stewardess.ForeignLanguage = languagesString;

                context.Entry(stewardess).State = EntityState.Modified;
                context.SaveChanges();
            }

            this.Close();
            mainForm.RefreshData();
        }

    }
}
