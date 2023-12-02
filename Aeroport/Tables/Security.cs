using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Security
{
    public int SecurityId { get; set; }

    public int SecurityEmployeeId { get; set; }

    public string Education { get; set; } = null!;

    public virtual Employee SecurityEmployee { get; set; } = null!;
}
