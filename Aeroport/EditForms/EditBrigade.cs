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
    public partial class EditBrigade : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> brigadeBossDict = new Dictionary<int, string>();
        private int ID;
        public EditBrigade(Aeroport mainform, int selectedRowID)
        {
            InitializeComponent();
            ID = selectedRowID;
            this.mainForm = mainform;
            using (var context = new AeroportContext())
            {
                var bosses = context.Bosses.ToList();
                var airplanes = context.Airplanes.ToList();
                foreach (var brigadeBoss in bosses)
                {
                    brigadeBossDict.Add(brigadeBoss.BossId, brigadeBoss.Lastname);
                }
                fieldBrigadeBoss.DataSource = bosses;
                fieldBrigadeBoss.DisplayMember = "Lastname";
                fieldBrigadeBoss.ValueMember = "BossID";

                fieldBrigadeAirplane.DataSource = airplanes;
                fieldBrigadeAirplane.DisplayMember = "ID";
                fieldBrigadeAirplane.ValueMember = "AirplaneID";

                var brigade = context.Brigades.Find(selectedRowID);

                fieldBrigadeBoss.SelectedValue = brigade.BrigadeBossId;
                fieldBrigadeAirplane.SelectedValue = brigade.BrigadeAirplaneId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (var context = new AeroportContext())
            {
                var brigade = context.Brigades.Find(ID);

                brigade.BrigadeBossId = (int)fieldBrigadeBoss.SelectedValue;
                brigade.BrigadeAirplaneId = (int)fieldBrigadeAirplane.SelectedValue;

                context.SaveChanges();
            }
            this.Close();
            mainForm.RefreshData();
        }
    }
}
