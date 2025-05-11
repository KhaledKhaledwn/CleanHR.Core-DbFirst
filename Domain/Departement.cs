using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Departement
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    public List<Project> Projects { get; set; } = new List<Project>();
}
