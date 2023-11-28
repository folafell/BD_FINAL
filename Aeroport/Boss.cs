using System;
using System.Collections.Generic;

namespace Aeroport;

public partial class Boss
{
    public int BossId { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public decimal Salary { get; set; }

    public virtual ICollection<Brigade> Brigades { get; set; } = new List<Brigade>();
}
