using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int TicketPassengerId { get; set; }

    public int TicketFlightId { get; set; }

    public decimal PriceOf { get; set; }

    public DateTime DateOf { get; set; }

    public string Seat { get; set; } = null!;

    public string Status { get; set; } = null!;

    public TimeSpan TimeOf { get; set; }

    public virtual Flight TicketFlight { get; set; } = null!;

    public virtual Passenger TicketPassenger { get; set; } = null!;
}
