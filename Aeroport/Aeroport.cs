using Aeroport.AddForms;

namespace Aeroport
{
    public partial class Aeroport : Form
    {
        public Aeroport()
        {
            InitializeComponent();

            using (var context = new AeroportContext())
            {
                var data = context.Airplanes.ToList();
                dataGridView1.DataSource = data;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, Func<AeroportContext, object>> tableMap
            = new Dictionary<string, Func<AeroportContext, object>>
        {
            { "Airplanes", context => context.Airplanes.ToList() },
            { "Flights", context => context.Flights.ToList() },
            { "Administrators", context => context.Administrators.ToList() },
            { "AirplaneTypes", context => context.AirplaneTypes.ToList() },
            { "Bosses", context => context.Bosses.ToList() },
            { "Brigades", context => context.Brigades.ToList() },
            { "CancelledFlights", context => context.CanceledFlights.ToList() },
            { "Cashiers", context => context.Cashiers.ToList() },
            { "Dispatchers", context => context.Dispatchers.ToList() },
            { "Employees", context => context.Employees.ToList() },
            { "Passengers", context => context.Passengers.ToList() },
            { "Pilots", context => context.Pilots.ToList() },
            { "Schedules", context => context.Schedules.ToList() },
            { "Securities", context => context.Securities.ToList() },
            { "Stewardesses", context => context.Stewardesses.ToList() },
            { "Technicians", context => context.Technicians.ToList() },
            { "Tickets", context => context.Tickets.ToList() },
        };

        private void link_Click(object sender, EventArgs e)
        {
            var linkLabel = (LinkLabel)sender;
            var tableName = linkLabel.Text;

            using (var context = new AeroportContext())
            {
                if (tableMap.TryGetValue(tableName, out var getTableData))
                {
                    var table = getTableData(context);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Таблица " + tableName + " не найдена.");
                }
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<string> columnsToHide = new List<string>
                {
                "Brigades", "Airplanes", "ToAirplaneType", "Schedules",
                "BrigadeAirplane", "BrigadeBoss", "Employees", "Flights",  "Flight", "CashierEmployee",
                "DispatcherEmployee", "Cashiers", "Dispatchers", "EmployeeBrigade", "Pilots", "Securities",
                "Stewardesses", "Technicians", "CanceledFlights", "FlightAirplaneType", "FlightBrigade",
                "Schedules", "Tickets", "PilotEmployee", "SecurityEmployee", "StewardessEmployee",
                "TechnicianEmployee", "TicketFlight", "TicketPassenger"
                };

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (columnsToHide.Contains(column.Name))
                {
                    column.Visible = false;
                }
            }
        }

        private void comboBoxPlaceholder(ComboBox comboBox)
        {
            comboBox.SelectedIndex = 0;

            comboBox.DropDown += (s, e) =>
            {
                if (comboBox.SelectedIndex == 0)
                {
                    comboBox.Items.RemoveAt(0);
                }
            };

            comboBox.DropDownClosed += (s, e) =>
            {
                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.Items.Insert(0, "Choose a table");
                    comboBox.SelectedIndex = 0;
                }
            };
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox.SelectedItem.ToString();

            switch (selectedTable)
            {
                case "Administrators":
                    new AddAdministrator().ShowDialog();
                    break;
                case "Airplanes":
                    new AddAirplane().ShowDialog();
                    break;
                case "AirplaneTypes":
                    new AddAirplaneType().ShowDialog();
                    break;
                case "Bosses":
                    new AddBoss().ShowDialog();
                    break;
                case "Brigades":
                    new AddBrigade().ShowDialog();
                    break;
                case "CancelledFlights":
                    new AddCancelledFlight().ShowDialog();
                    break;
                case "Cashiers":
                    new AddCashier().ShowDialog();
                    break;
                case "Dispatchers":
                    new AddDispatcher().ShowDialog();
                    break;
                case "Employees":
                    new AddEmployee().ShowDialog();
                    break;
                case "Flights":
                    new AddFlight().ShowDialog();
                    break;
                case "Passengers":
                    new AddPassenger().ShowDialog();
                    break;
                case "Pilots":
                    new AddPilot().ShowDialog();
                    break;
                case "Securities":
                    new AddSecurity().ShowDialog();
                    break;
                case "Stewardesses":
                    new AddStewardess().ShowDialog();
                    break;
                case "Technicians":
                    new AddTechnician().ShowDialog();
                    break;
                case "Tickets":
                    new AddTicket().ShowDialog();
                    break;
                default:
                    MessageBox.Show("Необходимо выбрать таблицу");
                    break;
            }

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1.Rows[e.RowIndex].Selected)
            {
                e.Cancel = true;
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}