using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int ScheduleFlightId { get; set; }

    public virtual Flight ScheduleFlight { get; set; } = null!;

    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
}
