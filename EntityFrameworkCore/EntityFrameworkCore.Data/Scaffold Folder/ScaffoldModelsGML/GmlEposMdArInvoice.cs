using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class GmlEposMdArInvoice
{
    public int Trxkey { get; set; }

    public long Trxlineid { get; set; }

    public long? Businessunitid { get; set; }

    public string? Businessunitname { get; set; }

    public string Invoicesource { get; set; } = null!;

    public string? Betonsales { get; set; }

    public string? Salestype { get; set; }

    public string? Transactionbatchsource { get; set; }

    public string? Transactiontypename { get; set; }

    public long? Transactiontypeid { get; set; }

    public string? Transactionnumber { get; set; }

    public string? Ordernumber { get; set; }

    public DateTime? Transactiondate { get; set; }

    public long? Salespersonid { get; set; }

    public string? Salespersonname { get; set; }

    public string? Customername { get; set; }

    public string? Customeraccountnumber { get; set; }

    public long? Customerid { get; set; }

    public string? Billtoaddress { get; set; }

    public string? Shiptoaddress { get; set; }

    public int? Billtositenumber { get; set; }

    public int? Shiptositenumber { get; set; }

    public string? Invoicecurrency { get; set; }

    public string? Paymentterms { get; set; }

    public string? Outletcode { get; set; }

    public int? Outletid { get; set; }

    public int? Epostrxid { get; set; }

    public bool? Createreceipt { get; set; }

    public string? Receiptnumber { get; set; }

    public DateTime? Receiptdate { get; set; }

    public string? Remittancebank { get; set; }

    public string? Itemcode { get; set; }

    public string? Itemdescription { get; set; }

    public string? Uom { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Unitsellingprice { get; set; }

    public decimal? Amount { get; set; }

    public string? Vatcode { get; set; }

    public long? Arsequencenumber { get; set; }

    public int? Counttrxlines { get; set; }

    public string? Interfacestatus { get; set; }

    public string? Transactionstatus { get; set; }

    public string? Receiptstatus { get; set; }

    public string? Errordescription { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public string? Createdby { get; set; }

    public string? Modifiedby { get; set; }

    public string? Deletedby { get; set; }

    public string? Receiptmethod { get; set; }

    public long? Receiptmethodid { get; set; }

    public string? Chequenumber { get; set; }

    public string? Receiptref { get; set; }

    public string? Applyreceiptstatus { get; set; }

    public decimal? Vatamount { get; set; }

    public string? Customerporef { get; set; }

    public string? Comments { get; set; }
}
