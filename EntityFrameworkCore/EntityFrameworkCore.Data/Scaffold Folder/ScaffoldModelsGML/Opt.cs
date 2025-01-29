using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Opt
{
    public int Id { get; set; }

    public string Optcodeverification { get; set; } = null!;

    public DateTime Expirydate { get; set; }

    public bool? Isverified { get; set; }

    public int? Userid { get; set; }
}
