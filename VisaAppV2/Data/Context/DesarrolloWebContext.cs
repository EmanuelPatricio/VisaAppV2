using Microsoft.EntityFrameworkCore;
using VisaAppV2.Data.Models;

namespace VisaAppV2.Data.Context;

public partial class DesarrolloWebContext : DbContext
{
    public DesarrolloWebContext()
    {
    }

    public DesarrolloWebContext(DbContextOptions<DesarrolloWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solicitu__3214EC07647046B8");

            entity.ToTable("Solicitud");

            entity.Property(e => e.Id)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.BornDate).HasColumnType("date");
            entity.Property(e => e.DocumentImage).IsUnicode(false);
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
