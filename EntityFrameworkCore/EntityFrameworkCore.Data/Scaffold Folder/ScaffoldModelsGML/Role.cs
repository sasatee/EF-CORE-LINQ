﻿using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
