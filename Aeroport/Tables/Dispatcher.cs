using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Dispatcher
{
    public int DispatcherId { get; set; }

    public int DispatcherEmployeeId { get; set; }

    public string Education { get; set; } = null!;

    public virtual Employee DispatcherEmployee { get; set; } = null!;
}
