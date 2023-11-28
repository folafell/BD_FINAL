using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class Brigade
{
    public int BrigadeId { get; set; }

    public int BrigadeAirplaneId { get; set; }

    public int BrigadeBossId { get; set; }

    public virtual Airplane BrigadeAirplane { get; set; } = null!;

    public virtual Boss BrigadeBoss { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
