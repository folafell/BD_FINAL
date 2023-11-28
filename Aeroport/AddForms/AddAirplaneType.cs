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
    public partial class AddAirplaneType : Form
    {
        public AddAirplaneType()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AirplaneType airplaneType = new AirplaneType();
            airplaneType.AirplaneTypeName = fieldAirplaneTypeName.Text;
            Logic.AddEntity(airplaneType);
            this.Close();
        }
    }
}
