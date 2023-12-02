using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Airplane
{
    public int AirplaneId { get; set; }

    public int ToAirplaneTypeId { get; set; }

    public DateTime LastRepair { get; set; }

    public int CountOfRepairs { get; set; }

    public DateTime TechnicalInspection { get; set; }

    public int Age { get; set; }

    public DateTime ReceiptDate { get; set; }

    public int CountOfFlights { get; set; }

    public virtual ICollection<Brigade> Brigades { get; set; } = new List<Brigade>();

    public virtual AirplaneType ToAirplaneType { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
