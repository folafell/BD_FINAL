using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Flight
{
    public int FlightId { get; set; }

    public string PlaceFrom { get; set; } = null!;

    public string PlaceTo { get; set; } = null!;

    public string Category { get; set; } = null!;

    public TimeSpan Duration { get; set; }

    public int FlightAirplaneTypeId { get; set; }

    public int FlightBrigadeId { get; set; }

    public virtual ICollection<CanceledFlight> CanceledFlights { get; set; } = new List<CanceledFlight>();

    public virtual AirplaneType FlightAirplaneType { get; set; } = null!;

    public virtual Brigade FlightBrigade { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
