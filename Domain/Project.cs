using System;
using System.Collections.Generic;

namespace DataAccessLayer;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DepartementId { get; set; }
    public Departement Departement { get; set; }
}
