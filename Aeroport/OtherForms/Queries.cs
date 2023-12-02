using Aeroport.Tables;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Aeroport.OtherForms
{
    public partial class Queries : Form
    {
        private SqlConnection connection;
        private Dictionary<string, QueryInfo> queries;

        public Queries()
        {
            InitializeComponent();

            connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=Aeroport;Trusted_Connection=True;TrustServerCertificate=True;");

            // Инициализация словаря запросов
            queries = new Dictionary<string, QueryInfo>
            {
                {
                    "Запрос №1",
                    new QueryInfo
                    {
                        Description = "1. Вывести всех сотрудников женского пола.",
                        SqlQuery = "SELECT Employee.Lastname AS \"Фамилия\", Employee.Age AS 'Возраст', " +
                                   "Employee.Gender AS 'Пол', Employee.Children AS 'Дети', Employee.Salary " +
                                   "AS 'Зарплата'\r\n" +
                                   "FROM Employee\r\n" +
                                   "WHERE Experience >= 24 AND Gender = 'Ж' AND Children > 0 AND Salary > 500"
                    }
                },


                {
                    "Запрос №2",
                    new QueryInfo
                    {
                        Description = "2. Вывести всех сотрудниц стюардесс.",
                        SqlQuery = "SELECT Employee.Lastname AS 'Фамилия', Employee.Gender AS 'Пол', Employee.Age AS 'Возраст'," +
                                   "Experience AS 'Стаж', Employee.Children AS 'Дети', Stewardess.ForeignLanguage AS 'Языки' \r\n" +
                                   "FROM Employee\r\n" +
                                   "JOIN Stewardess ON Stewardess.StewardessEmployeeID = Employee.EmployeeId\r\n"
                    }
                },

                {
                    "Запрос №3",
                    new QueryInfo
                    {
                        Description = "3. Вывести всех сотрудников мужского пола, с опытом от 24 месяцев, " +
                        "имеющих хотя бы одного ребенка и зарплату выше 1000.",
                        SqlQuery = "SELECT * FROM Employee\r\nWHERE Experience >= 24 " +
                                   "AND Gender = 'М' AND Children > 0 AND Salary > 1000\r\n" +
                                   "ORDER BY Employee.Age DESC"
                    }
                },

                {
                    "Запрос №4",
                    new QueryInfo
                    {
                        Description = "4. Вывести всех начальников отделов с зарплатой выше 1300",
                        SqlQuery = "SELECT * FROM Boss WHERE Salary > 1300"
                    }
                },

                {
                    "Запрос №5",
                    new QueryInfo
                    {
                        Description = "5. Вывести всех сотрудников бригады, обслуживающей рейс 'Лондон' - 'Москва'. ",
                        SqlQuery = "SELECT Brigade.BrigadeId AS 'Номер бригады', Flight.PlaceFrom AS 'Откуда', Flight.PlaceTo " +
                                   "AS 'Куда', Boss.Lastname AS 'Начальник', Employee.Lastname AS 'Фамилия сотрудника', Employee.Age " +
                                   "AS 'Возраст', Employee.Salary AS 'Зарплата'\r\nFROM Brigade\r\nJOIN Boss ON Boss.BossId = Brigade.BrigadeBossID\r\n" +
                                   "JOIN Employee ON EmployeeBrigadeID = Brigade.BrigadeId\r\nJOIN Flight ON Flight.FlightBrigadeID = BrigadeID\r\n" +
                                   "WHERE Flight.PlaceFrom = 'Лондон' AND Flight.PlaceTo = 'Минск'\r\nORDER BY Employee.Salary DESC"
                    }
                },

                {
                    "Запрос №6",
                    new QueryInfo
                    {
                        Description = "6. Вывести всех сотрудников бригады, обслуживающей рейс 'Лондон' - 'Москва' по убыванию заработной платы.",
                        SqlQuery = "SELECT Brigade.BrigadeId AS 'Номер бригады', Flight.PlaceFrom AS 'Откуда', Flight.PlaceTo " +
                                   "AS 'Куда', Boss.Lastname AS 'Начальник', Employee.Lastname AS 'Фамилия сотрудника', Employee.Age " +
                                   "AS 'Возраст', Employee.Salary AS 'Зарплата'\r\nFROM Brigade\r\nJOIN Boss ON Boss.BossId = Brigade.BrigadeBossID\r\n" +
                                   "JOIN Employee ON EmployeeBrigadeID = Brigade.BrigadeId\r\nJOIN Flight ON Flight.FlightBrigadeID = BrigadeID\r\n" +
                                   "WHERE Flight.PlaceFrom = 'Лондон' AND Flight.PlaceTo = 'Минск'\r\nORDER BY Employee.Salary DESC"
                    }
                },

                {
                    "Запрос №7",
                    new QueryInfo
                    {
                        Description = "7. Вывести пилотов, прошедших медосмотр в 2023 году по убыванию заработной платы.",
                        SqlQuery = "SELECT Pilot.Physical AS 'Год прохождения медосмотра', Employee.Salary AS 'Зарплата', Employee.Gender " +
                                   "AS 'Пол', Employee.Age AS 'Возраст', Employee.Lastname AS 'Фамилия'\r\n" +
                                   "FROM Pilot\r\n" +
                                   "JOIN Employee ON Employee.EmployeeId = Pilot.PilotEmployeeID\r\n" +
                                   "WHERE Physical = 2023\r\nORDER BY Employee.Salary DESC"
                    }
                },

                {
                    "Запрос №8",
                    new QueryInfo
                    {
                        Description = "8. Вывести самолеты, поступившие в аэропорт после 1 января 2015 года и совершившие больше 30 полетов.",
                        SqlQuery = "SELECT * FROM Airplane\r\n" +
                                   "WHERE CountOfFlights > 30 AND Receiptdate > '2015-01-01'"
                    }
                },

                {
                    "Запрос №9",
                    new QueryInfo
                    {
                        Description = "9. Вывести самолеты, которые прошли техосмотр в 2022 году.",
                        SqlQuery = "SELECT * FROM Airplane\r\n" +
                                   "WHERE TechnicalInspection >= '2022-01-01' AND TechnicalInspection <= '2022-12-30'"
                    }
                },

                {
                    "Запрос №10",
                    new QueryInfo
                    {
                        Description = "10. Вывести самолеты, возраст которых больше 7 лет, которые ремонтировались последний раз позже 10.10.2022, .",
                        SqlQuery = "SELECT * FROM Airplane\r\n" +
                                   "WHERE LastRepair >= '2022-10-10' AND CountOfRepairs > 1 AND Age > 7"
                    }
                },

                {
                    "Запрос №11",
                    new QueryInfo
                    {
                        Description = "11. Вывести рейсы из Минска.",
                        SqlQuery = "SELECT Flight.PlaceFrom AS 'Откуда', Flight.PlaceTo AS 'Куда', Flight.Duration " +
                                   "AS 'Длительность перелета', Ticket.PriceOf AS 'Стоимость'\r\n" +
                                   "FROM Flight\r\nJOIN Ticket ON Flight.FlightID = Ticket.TicketFlightID\r\n" +
                                   "WHERE PlaceFrom = 'Минск'"
                    }
                },

                {
                    "Запрос №12",
                    new QueryInfo
                    {
                        Description = "12. Вывести отмененные по причине погодных условий рейсы из Лондона в Афины.",
                        SqlQuery = "SELECT CanceledFlights.*, Flight.Category, Flight.PlaceFrom, Flight.PlaceTo\r\n" +
                                   "FROM CanceledFlights\r\n" +
                                   "JOIN Flight ON CanceledFlights.FlightID = Flight.FlightID\r\n" +
                                   "WHERE CanceledFlights.Reason = 'Погодные условия' AND Flight.PlaceFrom = 'Лондон' AND Flight.PlaceTo = 'Афины'"
                    }
                },

                {
                    "Запрос №13",
                    new QueryInfo
                    {
                        Description = "13. Вывести рейсы по которым летают пассажирские самолеты из Минска, среднюю цену билета.",
                        SqlQuery = "SELECT Flight.PlaceFrom AS 'Откуда', Flight.PlaceTo AS 'Куда', Flight.Category " +
                                   "AS 'Вид', Flight.Duration AS 'Длительность перелета',\r\nAirplaneType.AirplaneTypeName " +
                                   "AS 'Вид самолета', Ticket.Status AS 'Статус билета', Ticket.Seat AS 'Место',\r\n" +
                                   "Ticket.PriceOf AS 'Стоимость билета', AVG(Ticket.PriceOf) OVER() AS 'Средняя цена'\r\n" +
                                   "FROM Flight\r\nJOIN AirplaneType ON Flight.FlightAirplaneTypeID = AirplaneType.AirplaneTypeID\r\n" +
                                   "JOIN Ticket ON Flight.FlightID = Ticket.TicketFlightID\r\n" +
                                   "WHERE AirplaneType.AirplaneTypeName = 'Пассажирский' AND Ticket.Status = 'Продан' " +
                                   "AND Flight.PlaceFrom = 'Минск'\r\nORDER BY Ticket.PriceOf DESC"
                    }
                },

                {
                    "Запрос №14",
                    new QueryInfo
                    {
                        Description = "14. Вывести чартерные рейсы в Лондон.",
                        SqlQuery = "SELECT * FROM Flight\r\n" +
                                   "WHERE Category = 'Чартерный' AND PlaceTo = 'Лондон'"
                    }
                },

                {
                    "Запрос №15",
                    new QueryInfo
                    {
                        Description = "15. Вывести рейсы, тип самолета которых - грузовой.",
                        SqlQuery = "SELECT * FROM Flight\r\n" +
                                   "JOIN AirplaneType ON Flight.FlightAirplaneTypeID = AirplaneType.AirplaneTypeId\r\n" +
                                   "WHERE AirplaneType.AirplaneTypeName = 'Грузовой'"
                    }
                },


                {
                    "Запрос №16",
                    new QueryInfo
                    {
                        Description = "16. Вывести пассажиров на международные рейсы, с датой 2023-05-01.",
                        SqlQuery = "SELECT Passenger.Lastname AS 'Фамилия', Passenger.Firstname AS 'Имя', Passenger.Patronymic " +
                                   "AS 'Отчество', Passenger.Age AS 'Возраст', Passenger.Gender AS 'Пол', Ticket.DateOf AS 'Дата'\r\nFROM Passenger\r\n" +
                                   "JOIN Ticket ON Ticket.TicketPassengerID = Passenger.PassengerID\r\nJOIN Flight ON Flight.FlightID = TicketFlightID\r\n" +
                                   "WHERE Flight.Category = 'Международный' AND Ticket.DateOf = '2023-05-01'"
                    }
                },

                {
                    "Запрос №17",
                    new QueryInfo
                    {
                        Description = "17. Вывести рейсы из Минска или в Минск.",
                        SqlQuery = "SELECT Flight.PlaceFrom AS 'Откуда', Flight.PlaceTo " +
                                   "AS 'Куда', Flight.Category AS 'Вид', Ticket.Status AS 'Статус'\r\n" +
                                   "FROM Flight\r\nJOIN Ticket ON Ticket.TicketFlightID = Flight.FlightID\r\n" +
                                   "WHERE Flight.PlaceFrom = 'Минск' OR PlaceTo = 'Минск'"
                    }
                },

                {
                    "Запрос №18",
                    new QueryInfo
                    {
                        Description = "18. Вывести билеты на отмененные рейсы в Москву с датой 2023-05-01.",
                        SqlQuery = "SELECT Ticket.Status AS 'Статус', Passenger.Firstname AS 'Пассажир', Flight.PlaceFrom " +
                                   "AS 'Откуда', Flight.PlaceTo AS 'Куда', Ticket.DateOf AS 'Дата', CanceledFlights.Reason " +
                                   "AS 'Причина отмены'\r\nFROM Ticket\r\nJOIN Flight ON Ticket.TicketFlightID = Flight.FlightID\r\n" +
                                   "JOIN Passenger ON Passenger.PassengerID = Ticket.TicketPassengerID\r\n" +
                                   "JOIN CanceledFlights ON CanceledFlights.CanceledFlightID = Flight.FlightID\r\n" +
                                   "WHERE Ticket.Status = 'Отменен' AND Ticket.DateOf = '2023-05-01' " +
                                   "AND Flight.PlaceTo = 'Москва'"
                    }
                },
            };



            foreach (var query in queries.Keys)
            {
                comboBoxQueries.Items.Add(query);
            }
            comboBoxQueries.SelectedIndex = 0;
        }

        private void ComboBoxQueries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryName = comboBoxQueries.SelectedItem.ToString();

            if (queries.TryGetValue(queryName, out QueryInfo queryInfo))
            {
                txtQueryDescription.Text = queryInfo.Description;
            }
            else
            {
                MessageBox.Show("Запрос " + queryName + " не найден.");
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string queryName = comboBoxQueries.SelectedItem.ToString();

            if (queries.TryGetValue(queryName, out QueryInfo queryInfo))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryInfo.SqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Запрос " + queryName + " не найден.");
            }
        }
    }

    internal class QueryInfo
    {
        public string Description { get; set; }
        public string SqlQuery { get; set; }
    }
}
