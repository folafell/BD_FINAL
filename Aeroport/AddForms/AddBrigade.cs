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
    public partial class AddBrigade : Form
    {
        private Aeroport mainForm;
        Dictionary<int, string> brigadeBossDict = new Dictionary<int, string>();
        public AddBrigade(Aeroport mainForm)
        {
            InitializeComponent();
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
            }

            this.mainForm = mainForm;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brigade newBrigade = new Brigade();

            newBrigade.BrigadeBossId = (int)fieldBrigadeBoss.SelectedValue;
            newBrigade.BrigadeAirplaneId = (int)fieldBrigadeAirplane.SelectedValue;

            using (var context = new AeroportContext())
            {
                context.Brigades.Add(newBrigade);
                context.SaveChanges();
            }
            mainForm.RefreshData();
            this.Close();
        }

    }
}
