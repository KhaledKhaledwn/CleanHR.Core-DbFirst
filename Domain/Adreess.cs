using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Adreess
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; } = null!;
}
