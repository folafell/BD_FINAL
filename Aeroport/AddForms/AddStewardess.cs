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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Aeroport
{
    public partial class AddStewardess : Form
    {
        private Aeroport mainForm;
        public AddStewardess(Aeroport mainForm)
        {
            InitializeComponent();
            var employeesNotStewardesses = Logic.GetEmployeesNotInRole();
            fieldStewardessEmployeeId.DataSource = employeesNotStewardesses;
            fieldStewardessEmployeeId.DisplayMember = "EmployeeID";
            this.mainForm = mainForm;
        }
        private void btnAdd_Click(object sender, EventArgs e)
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
            Stewardess stewardess = new Stewardess();
            var selectedLanguages = checkBoxes
                    .Where(cb => cb.Checked)
                    .Select(cb => cb.Text);

            string languagesString = string.Join(", ", selectedLanguages);
            stewardess.StewardessEmployeeId = ((Employee)fieldStewardessEmployeeId.SelectedValue).EmployeeId;
            stewardess.ForeignLanguage = languagesString;
            Logic.AddEntity(stewardess);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
