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
            if (string.IsNullOrEmpty(fieldBrigadeAirplane.SelectedItem?.ToString()) ||
                string.IsNullOrEmpty(fieldBrigadeBoss.SelectedItem?.ToString()))
            {
                MessageBox.Show("Необходимо заполнить все поля");
                return;
            }
            Brigade brigade = new Brigade();
            string selectedBrigadeBoss = fieldBrigadeBoss.SelectedItem.ToString();

            int BrigadeBossID = brigadeBossDict.FirstOrDefault(x => x.Value == selectedBrigadeBoss).Key;

            brigade.BrigadeBossId = BrigadeBossID + 1;

            brigade.BrigadeAirplaneId = (int)fieldBrigadeAirplane.SelectedValue;
            Logic.AddEntity(brigade);
            this.Close();
            mainForm.RefreshData();
        }
    }
}
