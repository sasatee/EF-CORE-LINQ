using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class GmlFsMdCustomer
{
    public long Customerid { get; set; }

    public string? Customername { get; set; }

    public int? Customernumber { get; set; }

    public string? Clientemail { get; set; }

    public string? Contactperson { get; set; }

    public string? Mobilen0 { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string Skipcreditcheck { get; set; } = null!;

    public DateTime? Lastupdatedate { get; set; }

    public string? Billtoaddressid { get; set; }

    public string? Billtosideid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Title { get; set; }

    public string? Origsystemreference { get; set; }

    public string? Paymenttermid { get; set; }

    public string? Status { get; set; }

    public bool? Isactive { get; set; }

    public string? Taxexempted { get; set; }

    public string? Taxreference { get; set; }

    public string? Billtositeid { get; set; }

    public string? Telephone { get; set; }

    public string? Credithold { get; set; }

    public string? Hidename { get; set; }

    public string? Bu20transportcharge { get; set; }

    public string? Bu30transportcharge { get; set; }

    public string? Customertype { get; set; }

    public string? Customerclasscode { get; set; }

    public int? Creditlimit { get; set; }

    public string? Businessregno { get; set; }

    public string? Personfirstname { get; set; }

    public string? Personlastname { get; set; }

    public string? Persontitle { get; set; }

    public string? Emailaddress { get; set; }

    public string? Contactnumber { get; set; }

    public string Allowover6mthsbal { get; set; } = null!;

    public string? Createdby { get; set; }

    public decimal? Gclcreditlimit { get; set; }

    public string? Lastupdatedby { get; set; }

    public string? Partyid { get; set; }

    public DateTime? Creationdate { get; set; }

    public string? Lastupdatedbyname { get; set; }

    public string? Createdbyname { get; set; }

    public int? Appuserid { get; set; }
}
