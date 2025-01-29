using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class GmlFsStatementOfAcct
{
    public int Id { get; set; }

    public long Customertrxid { get; set; }

    public long? Customerid { get; set; }

    public string? Customername { get; set; }

    public string? Customerno { get; set; }

    public string? Orderno { get; set; }

    public string? Customerpono { get; set; }

    public int? Daysoverdue { get; set; }

    public decimal? Due { get; set; }

    public DateTime? Duedate { get; set; }

    public string? Invno { get; set; }

    public DateTime? Lastupdatedate { get; set; }

    public string? Location { get; set; }

    public string? Month { get; set; }

    public long? Salesrepid { get; set; }

    public string? Salesrepname { get; set; }

    public string? Terms { get; set; }

    public decimal? Trxamt { get; set; }

    public DateTime? Trxdate { get; set; }

    public string? Trxsource { get; set; }

    public string? Trxtype { get; set; }

    public string? Typename { get; set; }

    public int? Years { get; set; }

    public long? Lineid { get; set; }

    public string? Itemcode { get; set; }

    public string? Shiptositename { get; set; }

    public decimal? Qtyinvoiced { get; set; }

    public long? Shiptositeid { get; set; }

    public decimal? Unitsellingprice { get; set; }

    public string? Shiptositecontactemail { get; set; }

    public string? Uom { get; set; }

    public string? Itemdescription { get; set; }

    public string? Currency { get; set; }

    public string? Itemcategory { get; set; }

    public decimal? Vatamt { get; set; }

    public decimal? Extendedamt { get; set; }

    public decimal? Deliveredpercentage { get; set; }

    public decimal? Qtyorder { get; set; }
}
  