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
    public partial class EditAirplaneType : Form
    {
        private Aeroport mainForm;
        private int ID;
        public EditAirplaneType(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var airplaneType = context.AirplaneTypes.Find(selectedRowID);

                fieldAirplaneTypeName.Text = airplaneType.AirplaneTypeName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var airplaneType = context.AirplaneTypes.Find(ID);

                airplaneType.AirplaneTypeName = fieldAirplaneTypeName.Text;
                context.SaveChanges();
            }

            this.Close();
            mainForm.RefreshData();
        }
    }
}
