using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Stewardess
{
    public int StewardessId { get; set; }

    public int StewardessEmployeeId { get; set; }

    public string ForeignLanguage { get; set; } = null!;

    public virtual Employee StewardessEmployee { get; set; } = null!;
}
