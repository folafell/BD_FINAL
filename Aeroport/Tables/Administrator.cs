﻿using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class Administrator
{
    public int AdministratorId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
