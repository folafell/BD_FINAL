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
        Dictionary<int, string> brigadeBossDict = new Dictionary<int, string>();
        public AddBrigade()
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
            // Получите выбранное значение из ComboBox
            string selectedBrigadeBoss = fieldBrigadeBoss.SelectedItem.ToString();

            // Получите ID типа самолета из словаря
            int BrigadeBossID = brigadeBossDict.FirstOrDefault(x => x.Value == selectedBrigadeBoss).Key;

            // Присвойте ID типа самолета полю ToAirplaneType
            brigade.BrigadeBossId = BrigadeBossID + 1;

            brigade.BrigadeAirplaneId = (int)fieldBrigadeAirplane.SelectedValue;
            Logic.AddEntity(brigade);
            this.Close();
        }
    }
}
