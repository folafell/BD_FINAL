using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Passenger
{
    public int PassengerId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
