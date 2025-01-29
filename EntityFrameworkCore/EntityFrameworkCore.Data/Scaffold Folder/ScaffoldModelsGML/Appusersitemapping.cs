using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Appusersitemapping
{
    public int Id { get; set; }

    public int? Appuserid { get; set; }

    public string? Customerid { get; set; }

    public string? Siteid { get; set; }
}
