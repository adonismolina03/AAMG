using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AAMG.AppMVC.Models;

public partial class AamgdbContext : DbContext
{
    public AamgdbContext()
    {
    }

    public AamgdbContext(DbContextOptions<AamgdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-KAL6DMR;Database=AAMGDB;Trusted_Connection=True; Trust Server Certificate=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mascotas__3214EC07272D69A0");

            entity.ToTable("mascotas");

            entity.Property(e => e.Antecedentes)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Dueño)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Raza)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
