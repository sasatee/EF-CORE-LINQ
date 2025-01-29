using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Ytdallsitespermonth
{
    public int? Year { get; set; }

    public int Id { get; set; }

    public string? Month { get; set; }

    public string? Category { get; set; }

    public string? Volume { get; set; }

    public string? Uom { get; set; }

    public string? Amount { get; set; }

    public string? Currencysymbol { get; set; }

    public string? Siteno { get; set; }

    public string? Siteid { get; set; }

    public string? Customerid { get; set; }

    public string? Sites { get; set; }
}
