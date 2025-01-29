using System;
using System.Collections.Generic;
using EntityFrameworkCore.Data.ScaffoldModelsGML;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data.ScaffoldContextGML;

public partial class GmlPortalDbContext : DbContext
{
    public GmlPortalDbContext()
    {
    }

    public GmlPortalDbContext(DbContextOptions<GmlPortalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appuser> Appusers { get; set; }

    public virtual DbSet<Appusercustomersitemapping> Appusercustomersitemappings { get; set; }

    public virtual DbSet<Appusersitemapping> Appusersitemappings { get; set; }

    public virtual DbSet<GmlEposMdArInvoice> GmlEposMdArInvoices { get; set; }

    public virtual DbSet<GmlEposTrxTypeSiteMap> GmlEposTrxTypeSiteMaps { get; set; }

    public virtual DbSet<GmlFsMdCustomer> GmlFsMdCustomers { get; set; }

    public virtual DbSet<GmlFsMdCustomersSite> GmlFsMdCustomersSites { get; set; }

    public virtual DbSet<GmlFsStatementOfAcct> GmlFsStatementOfAccts { get; set; }

    public virtual DbSet<Opt> Opts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Salesorderheader> Salesorderheaders { get; set; }

    public virtual DbSet<Salesorderline> Salesorderlines { get; set; }

    public virtual DbSet<Ytdallsite> Ytdallsites { get; set; }

    public virtual DbSet<Ytdallsitespermonth> Ytdallsitespermonths { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("........................................");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appuser_pkey");

            entity.ToTable("appuser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Badpasswordcount)
                .HasDefaultValue(0)
                .HasColumnName("badpasswordcount");
            entity.Property(e => e.Contactphone).HasColumnName("contactphone");
            entity.Property(e => e.Createdate).HasColumnName("createdate");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Locked)
                .HasDefaultValue(false)
                .HasColumnName("locked");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Passwordexpired)
                .HasDefaultValue(false)
                .HasColumnName("passwordexpired");
            entity.Property(e => e.Passwordresetexpired).HasColumnName("passwordresetexpired");
            entity.Property(e => e.Passwordresettoken).HasColumnName("passwordresettoken");
            entity.Property(e => e.Roleid).HasColumnName("roleid");
            entity.Property(e => e.Rolename).HasColumnName("rolename");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Updatedate).HasColumnName("updatedate");
        });

        modelBuilder.Entity<Appusercustomersitemapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appusercustomersitemappings_pkey");

            entity.ToTable("appusercustomersitemappings");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appuserid).HasColumnName("appuserid");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
        });

        modelBuilder.Entity<Appusersitemapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("appusersitemapping_pkey");

            entity.ToTable("appusersitemapping");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Appuserid).HasColumnName("appuserid");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
        });

        modelBuilder.Entity<GmlEposMdArInvoice>(entity =>
        {
            entity.HasKey(e => e.Trxkey).HasName("GML_EPOS_MD_AR_INVOICE_pkey");

            entity.ToTable("GML_EPOS_MD_AR_INVOICE");

            entity.Property(e => e.Trxkey)
                .ValueGeneratedNever()
                .HasColumnName("trxkey");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Applyreceiptstatus).HasColumnName("applyreceiptstatus");
            entity.Property(e => e.Arsequencenumber).HasColumnName("arsequencenumber");
            entity.Property(e => e.Betonsales).HasColumnName("betonsales");
            entity.Property(e => e.Billtoaddress).HasColumnName("billtoaddress");
            entity.Property(e => e.Billtositenumber).HasColumnName("billtositenumber");
            entity.Property(e => e.Businessunitid).HasColumnName("businessunitid");
            entity.Property(e => e.Businessunitname).HasColumnName("businessunitname");
            entity.Property(e => e.Chequenumber).HasColumnName("chequenumber");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Counttrxlines).HasColumnName("counttrxlines");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'2020-09-10 16:51:01.177768+00'::timestamp with time zone")
                .HasColumnName("created");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createreceipt).HasColumnName("createreceipt");
            entity.Property(e => e.Customeraccountnumber).HasColumnName("customeraccountnumber");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Customername).HasColumnName("customername");
            entity.Property(e => e.Customerporef).HasColumnName("customerporef");
            entity.Property(e => e.Deletedby).HasColumnName("deletedby");
            entity.Property(e => e.Epostrxid).HasColumnName("epostrxid");
            entity.Property(e => e.Errordescription).HasColumnName("errordescription");
            entity.Property(e => e.Interfacestatus)
                .HasDefaultValueSql("'New'::text")
                .HasColumnName("interfacestatus");
            entity.Property(e => e.Invoicecurrency).HasColumnName("invoicecurrency");
            entity.Property(e => e.Invoicesource).HasColumnName("invoicesource");
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Itemdescription).HasColumnName("itemdescription");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'2020-09-10 16:51:01.177768+00'::timestamp with time zone")
                .HasColumnName("modified");
            entity.Property(e => e.Modifiedby).HasColumnName("modifiedby");
            entity.Property(e => e.Ordernumber).HasColumnName("ordernumber");
            entity.Property(e => e.Outletcode).HasColumnName("outletcode");
            entity.Property(e => e.Outletid).HasColumnName("outletid");
            entity.Property(e => e.Paymentterms).HasColumnName("paymentterms");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Receiptdate).HasColumnName("receiptdate");
            entity.Property(e => e.Receiptmethod).HasColumnName("receiptmethod");
            entity.Property(e => e.Receiptmethodid).HasColumnName("receiptmethodid");
            entity.Property(e => e.Receiptnumber).HasColumnName("receiptnumber");
            entity.Property(e => e.Receiptref).HasColumnName("receiptref");
            entity.Property(e => e.Receiptstatus).HasColumnName("receiptstatus");
            entity.Property(e => e.Remittancebank).HasColumnName("remittancebank");
            entity.Property(e => e.Salespersonid).HasColumnName("salespersonid");
            entity.Property(e => e.Salespersonname).HasColumnName("salespersonname");
            entity.Property(e => e.Salestype).HasColumnName("salestype");
            entity.Property(e => e.Shiptoaddress).HasColumnName("shiptoaddress");
            entity.Property(e => e.Shiptositenumber).HasColumnName("shiptositenumber");
            entity.Property(e => e.Transactionbatchsource).HasColumnName("transactionbatchsource");
            entity.Property(e => e.Transactiondate).HasColumnName("transactiondate");
            entity.Property(e => e.Transactionnumber).HasColumnName("transactionnumber");
            entity.Property(e => e.Transactionstatus).HasColumnName("transactionstatus");
            entity.Property(e => e.Transactiontypeid).HasColumnName("transactiontypeid");
            entity.Property(e => e.Transactiontypename).HasColumnName("transactiontypename");
            entity.Property(e => e.Trxlineid).HasColumnName("trxlineid");
            entity.Property(e => e.Unitsellingprice).HasColumnName("unitsellingprice");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.Vatamount).HasColumnName("vatamount");
            entity.Property(e => e.Vatcode).HasColumnName("vatcode");
        });

        modelBuilder.Entity<GmlEposTrxTypeSiteMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GML_EPOS_TRX_TYPE_SITE_MAP_pkey");

            entity.ToTable("GML_EPOS_TRX_TYPE_SITE_MAP");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creditnotetrxtype).HasColumnName("creditnotetrxtype");
            entity.Property(e => e.Creditnotetrxtypeid).HasColumnName("creditnotetrxtypeid");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Fusiontrxtypeid).HasColumnName("fusiontrxtypeid");
            entity.Property(e => e.Fusiontrxtypename).HasColumnName("fusiontrxtypename");
            entity.Property(e => e.Itembu).HasColumnName("itembu");
            entity.Property(e => e.Itemdescription).HasColumnName("itemdescription");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Ordertype).HasColumnName("ordertype");
            entity.Property(e => e.Outletid).HasColumnName("outletid");
            entity.Property(e => e.Salestype).HasColumnName("salestype");
            entity.Property(e => e.Shipfromsite).HasColumnName("shipfromsite");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Sitename).HasColumnName("sitename");
        });

        modelBuilder.Entity<GmlFsMdCustomer>(entity =>
        {
            entity.HasKey(e => e.Customerid).HasName("GML_FS_MD_CUSTOMERS_pkey");

            entity.ToTable("GML_FS_MD_CUSTOMERS");

            entity.Property(e => e.Customerid)
                .ValueGeneratedNever()
                .HasColumnName("customerid");
            entity.Property(e => e.Address1).HasColumnName("address1");
            entity.Property(e => e.Address2).HasColumnName("address2");
            entity.Property(e => e.Address3).HasColumnName("address3");
            entity.Property(e => e.Address4).HasColumnName("address4");
            entity.Property(e => e.Allowover6mthsbal)
                .HasDefaultValueSql("'N'::text")
                .HasColumnName("allowover6mthsbal");
            entity.Property(e => e.Appuserid).HasColumnName("appuserid");
            entity.Property(e => e.Billtoaddressid).HasColumnName("billtoaddressid");
            entity.Property(e => e.Billtosideid).HasColumnName("billtosideid");
            entity.Property(e => e.Billtositeid).HasColumnName("billtositeid");
            entity.Property(e => e.Bu20transportcharge).HasColumnName("bu20transportcharge");
            entity.Property(e => e.Bu30transportcharge).HasColumnName("bu30transportcharge");
            entity.Property(e => e.Businessregno).HasColumnName("businessregno");
            entity.Property(e => e.Clientemail).HasColumnName("clientemail");
            entity.Property(e => e.Contactnumber).HasColumnName("contactnumber");
            entity.Property(e => e.Contactperson).HasColumnName("contactperson");
            entity.Property(e => e.Createdby).HasColumnName("createdby");
            entity.Property(e => e.Createdbyname).HasColumnName("createdbyname");
            entity.Property(e => e.Creationdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("creationdate");
            entity.Property(e => e.Credithold).HasColumnName("credithold");
            entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");
            entity.Property(e => e.Customerclasscode).HasColumnName("customerclasscode");
            entity.Property(e => e.Customername).HasColumnName("customername");
            entity.Property(e => e.Customernumber).HasColumnName("customernumber");
            entity.Property(e => e.Customertype).HasColumnName("customertype");
            entity.Property(e => e.Emailaddress).HasColumnName("emailaddress");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Gclcreditlimit).HasColumnName("gclcreditlimit");
            entity.Property(e => e.Hidename).HasColumnName("hidename");
            entity.Property(e => e.Isactive)
                .HasDefaultValue(true)
                .HasColumnName("isactive");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Lastupdatedate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastupdatedate");
            entity.Property(e => e.Lastupdatedby).HasColumnName("lastupdatedby");
            entity.Property(e => e.Lastupdatedbyname).HasColumnName("lastupdatedbyname");
            entity.Property(e => e.Mobilen0).HasColumnName("mobilen0");
            entity.Property(e => e.Origsystemreference).HasColumnName("origsystemreference");
            entity.Property(e => e.Partyid).HasColumnName("partyid");
            entity.Property(e => e.Paymenttermid).HasColumnName("paymenttermid");
            entity.Property(e => e.Personfirstname).HasColumnName("personfirstname");
            entity.Property(e => e.Personlastname).HasColumnName("personlastname");
            entity.Property(e => e.Persontitle).HasColumnName("persontitle");
            entity.Property(e => e.Skipcreditcheck)
                .HasDefaultValueSql("'N'::text")
                .HasColumnName("skipcreditcheck");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Taxexempted).HasColumnName("taxexempted");
            entity.Property(e => e.Taxreference).HasColumnName("taxreference");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<GmlFsMdCustomersSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GML_FS_MD_CUSTOMERS_SITES_pkey");

            entity.ToTable("GML_FS_MD_CUSTOMERS_SITES");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accountcode).HasColumnName("accountcode");
            entity.Property(e => e.Address2).HasColumnName("address2");
            entity.Property(e => e.Address3).HasColumnName("address3");
            entity.Property(e => e.Address4).HasColumnName("address4");
            entity.Property(e => e.Addresscategory).HasColumnName("addresscategory");
            entity.Property(e => e.Appuserid).HasColumnName("appuserid");
            entity.Property(e => e.Badsiteid).HasColumnName("badsiteid");
            entity.Property(e => e.Bu20transportcharge).HasColumnName("bu20transportcharge");
            entity.Property(e => e.Bu30transportcharge).HasColumnName("bu30transportcharge");
            entity.Property(e => e.Bypassbolsuppliercheck).HasColumnName("bypassbolsuppliercheck");
            entity.Property(e => e.Code1).HasColumnName("code1");
            entity.Property(e => e.Code2).HasColumnName("code2");
            entity.Property(e => e.Code3).HasColumnName("code3");
            entity.Property(e => e.Code4).HasColumnName("code4");
            entity.Property(e => e.Code5).HasColumnName("code5");
            entity.Property(e => e.Code6).HasColumnName("code6");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Defaultsupplierid).HasColumnName("defaultsupplierid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Firstname).HasColumnName("firstname");
            entity.Property(e => e.Gammarevtogl).HasColumnName("gammarevtogl");
            entity.Property(e => e.Lastname).HasColumnName("lastname");
            entity.Property(e => e.Locationcode).HasColumnName("locationcode");
            entity.Property(e => e.Manualboulderstrips).HasColumnName("manualboulderstrips");
            entity.Property(e => e.Orgid).HasColumnName("orgid");
            entity.Property(e => e.Origsiteid).HasColumnName("origsiteid");
            entity.Property(e => e.Primaryflag).HasColumnName("primaryflag");
            entity.Property(e => e.Printpriceflag).HasColumnName("printpriceflag");
            entity.Property(e => e.Receivableaccount).HasColumnName("receivableaccount");
            entity.Property(e => e.Receivableccid).HasColumnName("receivableccid");
            entity.Property(e => e.Region).HasColumnName("region");
            entity.Property(e => e.Salebyvolume).HasColumnName("salebyvolume");
            entity.Property(e => e.Shiptositeemail).HasColumnName("shiptositeemail");
            entity.Property(e => e.Sitedate).HasColumnName("sitedate");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Siteno).HasColumnName("siteno");
            entity.Property(e => e.Sitenote).HasColumnName("sitenote");
            entity.Property(e => e.Sitesalesrepid).HasColumnName("sitesalesrepid");
            entity.Property(e => e.Sitetel).HasColumnName("sitetel");
            entity.Property(e => e.Siteusecode).HasColumnName("siteusecode");
            entity.Property(e => e.Specialcontract).HasColumnName("specialcontract");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Stockflag).HasColumnName("stockflag");
            entity.Property(e => e.Transportformularate).HasColumnName("transportformularate");
            entity.Property(e => e.Trxtypeid).HasColumnName("trxtypeid");
            entity.Property(e => e.Typeofsales).HasColumnName("typeofsales");
            entity.Property(e => e.Xcoordinate).HasColumnName("xcoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("ycoordinate");
        });

        modelBuilder.Entity<GmlFsStatementOfAcct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("GML_FS_STATEMENT_OF_ACCT_pkey");

            entity.ToTable("GML_FS_STATEMENT_OF_ACCT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Currency).HasColumnName("currency");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Customername).HasColumnName("customername");
            entity.Property(e => e.Customerno).HasColumnName("customerno");
            entity.Property(e => e.Customerpono).HasColumnName("customerpono");
            entity.Property(e => e.Customertrxid).HasColumnName("customertrxid");
            entity.Property(e => e.Daysoverdue).HasColumnName("daysoverdue");
            entity.Property(e => e.Deliveredpercentage).HasColumnName("deliveredpercentage");
            entity.Property(e => e.Due).HasColumnName("due");
            entity.Property(e => e.Duedate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("duedate");
            entity.Property(e => e.Extendedamt).HasColumnName("extendedamt");
            entity.Property(e => e.Invno).HasColumnName("invno");
            entity.Property(e => e.Itemcategory).HasColumnName("itemcategory");
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Itemdescription).HasColumnName("itemdescription");
            entity.Property(e => e.Lastupdatedate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lastupdatedate");
            entity.Property(e => e.Lineid).HasColumnName("lineid");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Orderno).HasColumnName("orderno");
            entity.Property(e => e.Qtyinvoiced).HasColumnName("qtyinvoiced");
            entity.Property(e => e.Qtyorder).HasColumnName("qtyorder");
            entity.Property(e => e.Salesrepid).HasColumnName("salesrepid");
            entity.Property(e => e.Salesrepname).HasColumnName("salesrepname");
            entity.Property(e => e.Shiptositecontactemail).HasColumnName("shiptositecontactemail");
            entity.Property(e => e.Shiptositeid).HasColumnName("shiptositeid");
            entity.Property(e => e.Shiptositename).HasColumnName("shiptositename");
            entity.Property(e => e.Terms).HasColumnName("terms");
            entity.Property(e => e.Trxamt).HasColumnName("trxamt");
            entity.Property(e => e.Trxdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("trxdate");
            entity.Property(e => e.Trxsource).HasColumnName("trxsource");
            entity.Property(e => e.Trxtype).HasColumnName("trxtype");
            entity.Property(e => e.Typename).HasColumnName("typename");
            entity.Property(e => e.Unitsellingprice).HasColumnName("unitsellingprice");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.Vatamt).HasColumnName("vatamt");
            entity.Property(e => e.Years).HasColumnName("years");
        });

        modelBuilder.Entity<Opt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("opt_pkey");

            entity.ToTable("opt");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Expirydate).HasColumnName("expirydate");
            entity.Property(e => e.Isverified)
                .HasDefaultValue(false)
                .HasColumnName("isverified");
            entity.Property(e => e.Optcodeverification).HasColumnName("optcodeverification");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_pkey");

            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Salesorderheader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("salesorderheader_pkey");

            entity.ToTable("salesorderheader");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approvername).HasColumnName("approvername");
            entity.Property(e => e.Betonsales).HasColumnName("betonsales");
            entity.Property(e => e.Billtoaddress).HasColumnName("billtoaddress");
            entity.Property(e => e.Brnnic).HasColumnName("brnnic");
            entity.Property(e => e.Businessunit).HasColumnName("businessunit");
            entity.Property(e => e.Cancellationreason).HasColumnName("cancellationreason");
            entity.Property(e => e.Creatednotifon).HasColumnName("creatednotifon");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Customername).HasColumnName("customername");
            entity.Property(e => e.Customerstatus).HasColumnName("customerstatus");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.Errordescription).HasColumnName("errordescription");
            entity.Property(e => e.Failedpushcount)
                .HasDefaultValue(0)
                .HasColumnName("failedpushcount");
            entity.Property(e => e.Isoffline)
                .HasDefaultValue(false)
                .HasColumnName("isoffline");
            entity.Property(e => e.Oracleorderno).HasColumnName("oracleorderno");
            entity.Property(e => e.OrderAmt).HasColumnName("orderAmt");
            entity.Property(e => e.Orderdate).HasColumnName("orderdate");
            entity.Property(e => e.Orderno).HasColumnName("orderno");
            entity.Property(e => e.Ordertype).HasColumnName("ordertype");
            entity.Property(e => e.Paymentterm).HasColumnName("paymentterm");
            entity.Property(e => e.Pricelist).HasColumnName("pricelist");
            entity.Property(e => e.Purchaseorderno).HasColumnName("purchaseorderno");
            entity.Property(e => e.Pushtofusion)
                .HasDefaultValue(false)
                .HasColumnName("pushtofusion");
            entity.Property(e => e.Pushtofusiondate).HasColumnName("pushtofusiondate");
            entity.Property(e => e.Quoteno).HasColumnName("quoteno");
            entity.Property(e => e.Shippinginstruction).HasColumnName("shippinginstruction");
            entity.Property(e => e.Shiptoaddress).HasColumnName("shiptoaddress");
            entity.Property(e => e.Shiptodescription).HasColumnName("shiptodescription");
            entity.Property(e => e.Shiptofulladdress).HasColumnName("shiptofulladdress");
            entity.Property(e => e.Sitevisitedby).HasColumnName("sitevisitedby");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalQty).HasColumnName("totalQty");
            entity.Property(e => e.TransportCharges).HasColumnName("transportCharges");
            entity.Property(e => e.TransportPayables).HasColumnName("transportPayables");
            entity.Property(e => e.Transportrequired).HasColumnName("transportrequired");
            entity.Property(e => e.Workorderno).HasColumnName("workorderno");
        });

        modelBuilder.Entity<Salesorderline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("salesorderline_pkey");

            entity.ToTable("salesorderline");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Inventoryitemid).HasColumnName("inventoryitemid");
            entity.Property(e => e.Istransportcalculated)
                .HasDefaultValue(false)
                .HasColumnName("istransportcalculated");
            entity.Property(e => e.Itemcode).HasColumnName("itemcode");
            entity.Property(e => e.Itemdescription).HasColumnName("itemdescription");
            entity.Property(e => e.Lineno).HasColumnName("lineno");
            entity.Property(e => e.Orderno).HasColumnName("orderno");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Totalamount).HasColumnName("totalamount");
            entity.Property(e => e.Unitprice).HasColumnName("unitprice");
        });

        modelBuilder.Entity<Ytdallsite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ytdallsites_pkey");

            entity.ToTable("ytdallsites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Currencysymbol).HasColumnName("currencysymbol");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.Volume).HasColumnName("volume");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Ytdallsitespermonth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ytdallsitespermonth_pkey");

            entity.ToTable("ytdallsitespermonth");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Currencysymbol).HasColumnName("currencysymbol");
            entity.Property(e => e.Customerid).HasColumnName("customerid");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Siteid).HasColumnName("siteid");
            entity.Property(e => e.Siteno).HasColumnName("siteno");
            entity.Property(e => e.Sites).HasColumnName("sites");
            entity.Property(e => e.Uom).HasColumnName("uom");
            entity.Property(e => e.Volume).HasColumnName("volume");
            entity.Property(e => e.Year).HasColumnName("year");
        });
        modelBuilder.HasSequence("customer_id_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
