using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Pilot
{
    public int PilotId { get; set; }

    public int PilotEmployeeId { get; set; }

    public int Physical { get; set; }

    public virtual Employee PilotEmployee { get; set; } = null!;
}
