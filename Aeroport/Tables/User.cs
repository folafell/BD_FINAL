﻿using System;
using System.Collections.Generic;

namespace Aeroport.Tables;

public partial class User
{
    public int UserId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string UserPassword { get; set; } = null!;
}
