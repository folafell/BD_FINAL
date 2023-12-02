using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Cashier
{
    public int CashierId { get; set; }

    public int CashierEmployeeId { get; set; }

    public string AccountantEducation { get; set; } = null!;

    public virtual Employee CashierEmployee { get; set; } = null!;
}
