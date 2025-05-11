using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer;

public partial class ManagemnetResourcesDbFirstContext : DbContext
{


    public virtual DbSet<Adreess> Adreesses { get; set; }

    public virtual DbSet<Departement> Departements { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Data Source =(localdb)\\ProjectModels;Initial Catalog=ManagemnetResourcesDbFirst");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>()
            .HasOne(a => a.Adreess)
            .WithOne(e => e.Employee)
            .HasForeignKey<Adreess>(e => e.EmployeeId);

        modelBuilder.Entity<Departement>()
            .HasMany(p => p.Projects)
            .WithOne(d => d.Departement)
            .HasForeignKey(pi => pi.DepartementId);


        modelBuilder.Entity<Departement>()
            .HasMany(e => e.Employees)
            .WithOne(d => d.Departemnet)
            .HasForeignKey(e => e.DepId);

        modelBuilder.Entity<Employee>()
           .HasMany(s => s.Skills)
           .WithMany(e => e.Emps);
    }
}