using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Salesorderheader
{
    public int Id { get; set; }

    public string? Businessunit { get; set; }

    public string Orderno { get; set; } = null!;

    public DateTime? Orderdate { get; set; }

    public string? Customername { get; set; }

    public string? Brnnic { get; set; }

    public string? Paymentterm { get; set; }

    public string? Workorderno { get; set; }

    public string? Quoteno { get; set; }

    public string? Billtoaddress { get; set; }

    public string? Shiptoaddress { get; set; }

    public string? Shiptodescription { get; set; }

    public string? Shiptofulladdress { get; set; }

    public string? Purchaseorderno { get; set; }

    public string? Ordertype { get; set; }

    public string? Pricelist { get; set; }

    public string? Betonsales { get; set; }

    public string? Transportrequired { get; set; }

    public string? Sitevisitedby { get; set; }

    public string? Shippinginstruction { get; set; }

    public decimal? TransportCharges { get; set; }

    public decimal? TransportPayables { get; set; }

    public decimal? Distance { get; set; }

    public decimal? OrderAmt { get; set; }

    public decimal? TotalQty { get; set; }

    public string? Status { get; set; }

    public string? Errordescription { get; set; }

    public string? Oracleorderno { get; set; }

    public bool? Isoffline { get; set; }

    public string? Cancellationreason { get; set; }

    public bool? Pushtofusion { get; set; }

    public DateTime? Pushtofusiondate { get; set; }

    public int? Failedpushcount { get; set; }

    public DateTime? Creatednotifon { get; set; }

    public string? Customerstatus { get; set; }

    public string? Approvername { get; set; }

    public long? Customerid { get; set; }
}
