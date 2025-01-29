using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.ScaffoldModelsGML;

public partial class Appuser
{
    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? Roleid { get; set; }

    public string? Rolename { get; set; }

    public int Id { get; set; }

    public string? Contactphone { get; set; }

    public bool? Locked { get; set; }

    public bool? Passwordexpired { get; set; }

    public int? Badpasswordcount { get; set; }

    public string Customerid { get; set; } = null!;

    public DateTime? Passwordresetexpired { get; set; }

    public string? Passwordresettoken { get; set; }

    public string? Siteid { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Updatedate { get; set; }
}
