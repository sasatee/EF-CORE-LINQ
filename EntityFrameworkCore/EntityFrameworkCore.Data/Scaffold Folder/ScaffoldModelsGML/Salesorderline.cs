using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Salesorderline
{
    public int Id { get; set; }

    public string Inventoryitemid { get; set; } = null!;

    public int Quantity { get; set; }

    public int? Unitprice { get; set; }

    public int? Totalamount { get; set; }

    public string? Description { get; set; }

    public bool? Istransportcalculated { get; set; }

    public string? Orderno { get; set; }

    public string? Lineno { get; set; }

    public string? Itemcode { get; set; }

    public string? Itemdescription { get; set; }
}
