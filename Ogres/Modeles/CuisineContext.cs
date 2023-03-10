using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OgresKoffiEmmanuel.Modeles;

public partial class CuisineContext : DbContext
{
    public CuisineContext()
    {
    }

    public CuisineContext(DbContextOptions<CuisineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Plat> Plats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Cuisine;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Plat>(entity =>
        {
            entity.Property(e => e.PlatId).HasColumnName("platId");
            entity.Property(e => e.DateCreation).HasColumnName("dateCreation");
            entity.Property(e => e.NomPlat).HasColumnName("nomPlat");
            entity.Property(e => e.NombreBouchees).HasColumnName("nombreBouchees");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
