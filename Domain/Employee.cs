using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DepId { get; set; }

    public virtual Adreess? Adreess { get; set; }

    public virtual Departement Departemnet { get; set; } = null!;

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
