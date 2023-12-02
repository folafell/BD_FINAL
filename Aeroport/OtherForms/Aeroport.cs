using Aeroport.AddForms;
using Aeroport.EditForms;
using Aeroport.OtherForms;
using Aeroport.Tables;
using Microsoft.EntityFrameworkCore;

namespace Aeroport
{
    public partial class Aeroport : Form
    {
        private string currentTable = "Airplanes";
        public event Action DataUpdated;
        public Aeroport()
        {
            InitializeComponent();

            using (var context = new AeroportContext())
            {
                var data = context.Airplanes.ToList();
                dataGridView1.DataSource = data;
                labelTableName.Text = "Airplanes";
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
            currentTable = linkLabel.Text;
            labelTableName.Text = currentTable;

            using (var context = new AeroportContext())
            {
                if (tableMap.TryGetValue(currentTable, out var getTableData))
                {
                    var table = getTableData(context);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Таблица " + currentTable + " не найдена.");
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

            switch (currentTable)
            {
                case "Administrators":
                    new AddAdministrator(this).ShowDialog();
                    break;
                case "Airplanes":
                    new AddAirplane_fixed(this).ShowDialog();
                    break;
                case "AirplaneTypes":
                    new AddAirplaneType(this).ShowDialog();
                    break;
                case "Bosses":
                    new AddBoss(this).ShowDialog();
                    break;
                case "Brigades":
                    new AddBrigade(this).ShowDialog();
                    break;
                case "CancelledFlights":
                    new AddCancelledFlight(this).ShowDialog();
                    break;
                case "Cashiers":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddCashier(this).ShowDialog();
                    break;
                case "Dispatchers":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddDispatcher(this).ShowDialog();
                    break;
                case "Employees":
                    new AddEmployee(this).ShowDialog();
                    break;
                case "Flights":
                    new AddFlight(this).ShowDialog();
                    break;
                case "Passengers":
                    new AddPassenger(this).ShowDialog();
                    break;
                case "Pilots":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddPilot(this).ShowDialog();
                    break;
                case "Securities":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddSecurity(this).ShowDialog();
                    break;
                case "Stewardesses":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddStewardess(this).ShowDialog();
                    break;
                case "Technicians":
                    if (Logic.isEmployeesNotInRoleEmpty())
                    {
                        MessageBox.Show("Все сотрудники уже назначены на роли. Сначала добавьте нового сотрудника.");
                    }
                    else new AddTechnician(this).ShowDialog();
                    break;
                case "Tickets":
                    new AddTicket(this).ShowDialog();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());

                using (var context = new AeroportContext())
                {
                    switch (currentTable)
                    {
                        case "Administrators":
                            Logic.DeleteEntity<Administrator>(rowID);
                            break;
                        case "Airplanes":
                            Logic.DeleteEntity<Airplane>(rowID);
                            break;
                        case "AirplaneTypes":
                            Logic.DeleteEntity<AirplaneType>(rowID);
                            break;
                        case "Bosses":
                            Logic.DeleteEntity<Boss>(rowID);
                            break;
                        case "Brigades":
                            Logic.DeleteEntity<Brigade>(rowID);
                            break;
                        case "CancelledFlights":
                            Logic.DeleteEntity<CanceledFlight>(rowID);
                            break;
                        case "Cashiers":
                            Logic.DeleteEntity<Cashier>(rowID);
                            break;
                        case "Dispatchers":
                            Logic.DeleteEntity<Dispatcher>(rowID);
                            break;
                        case "Employees":
                            Logic.DeleteEntity<Employee>(rowID);
                            break;
                        case "Flights":
                            Logic.DeleteEntity<Flight>(rowID);
                            break;
                        case "Passengers":
                            Logic.DeleteEntity<Passenger>(rowID);
                            break;
                        case "Pilots":
                            Logic.DeleteEntity<Pilot>(rowID);
                            break;
                        case "Securities":
                            Logic.DeleteEntity<Security>(rowID);
                            break;
                        case "Stewardesses":
                            Logic.DeleteEntity<Stewardess>(rowID);
                            break;
                        case "Technicians":
                            Logic.DeleteEntity<Technician>(rowID);
                            break;
                        case "Tickets":
                            Logic.DeleteEntity<Ticket>(rowID);
                            break;
                        default:
                            MessageBox.Show("Таблица " + currentTable + " не найдена.");
                            break;
                    }
                }
                using (var context = new AeroportContext())
                {
                    if (tableMap.TryGetValue(currentTable, out var getTableData))
                    {
                        var table = getTableData(context);
                        dataGridView1.DataSource = table;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        public void RefreshData()
        {
            using (var context = new AeroportContext())
            {
                if (tableMap.TryGetValue(currentTable, out var getTableData))
                {
                    var table = getTableData(context);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Таблица " + currentTable + " не найдена.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = fieldSearch.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchWord))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    }
                }
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());

                switch (currentTable)
                {
                    case "Administrators":
                        new EditAdministrator(this, rowID).ShowDialog();
                        break;
                    case "Airplanes":
                        new EditAirplane(this, rowID).ShowDialog();
                        break;
                    case "AirplaneTypes":
                        new EditAirplaneType(this, rowID).ShowDialog();
                        break;
                    case "Bosses":
                        new EditBoss(this, rowID).ShowDialog();
                        break;
                    case "Brigades":
                        new EditBrigade(this, rowID).ShowDialog();
                        break;
                    case "CancelledFlights":
                        new EditCancelledFlight(this, rowID).ShowDialog();
                        break;
                    case "Cashiers":
                        new EditCahier(this, rowID).ShowDialog();
                        break;
                    case "Dispatchers":
                        new EditDispatcher(this, rowID).ShowDialog();
                        break;
                    case "Employees":
                        new EditEmployee(this, rowID).ShowDialog();
                        break;
                    case "Flights":
                        new EditFlight(this, rowID).ShowDialog();
                        break;
                    case "Passengers":
                        new EditPassenger(this, rowID).ShowDialog();
                        break;
                    case "Pilots":
                        new EditPilot(this, rowID).ShowDialog();
                        break;
                    case "Securities":
                        new EditSecurity(this, rowID).ShowDialog();
                        break;
                    case "Stewardesses":
                        new EditStewardess(this, rowID).ShowDialog();
                        break;
                    case "Technicians":
                        new EditTechnician(this, rowID).ShowDialog();
                        break;
                    case "Tickets":
                        new EditTicket(this, rowID).ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Необходимо выбрать таблицу");
                        break;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }

        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            new Queries().ShowDialog();
        }
    }
}