using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class AirplaneType
{
    public int AirplaneTypeId { get; set; }

    public string AirplaneTypeName { get; set; } = null!;

    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
