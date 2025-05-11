using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Skill
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Emps { get; set; } = new List<Employee>();
}
