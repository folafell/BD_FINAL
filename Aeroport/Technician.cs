using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class Technician
{
    public int TechnicianId { get; set; }

    public int TechnicianEmployeeId { get; set; }

    public string Education { get; set; } = null!;

    public virtual Employee TechnicianEmployee { get; set; } = null!;
}
