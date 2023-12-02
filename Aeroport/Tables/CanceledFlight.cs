using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class CanceledFlight
{
    public int CanceledFlightId { get; set; }

    public int FlightId { get; set; }

    public string Reason { get; set; } = null!;

    public virtual Flight Flight { get; set; } = null!;
}
