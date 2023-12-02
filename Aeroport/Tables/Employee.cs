using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int EmployeeBrigadeId { get; set; }

    public string Lastname { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public string Experience { get; set; } = null!;

    public int Children { get; set; }

    public decimal Salary { get; set; }

    public virtual ICollection<Cashier> Cashiers { get; set; } = new List<Cashier>();

    public virtual ICollection<Dispatcher> Dispatchers { get; set; } = new List<Dispatcher>();

    public virtual Brigade EmployeeBrigade { get; set; } = null!;

    public virtual ICollection<Pilot> Pilots { get; set; } = new List<Pilot>();

    public virtual ICollection<Security> Securities { get; set; } = new List<Security>();

    public virtual ICollection<Stewardess> Stewardesses { get; set; } = new List<Stewardess>();

    public virtual ICollection<Technician> Technicians { get; set; } = new List<Technician>();
}
