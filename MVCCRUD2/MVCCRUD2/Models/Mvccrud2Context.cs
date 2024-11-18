using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCCRUD2.Models;

public partial class Mvccrud2Context : DbContext
{
    public Mvccrud2Context()
    {
    }

    public Mvccrud2Context(DbContextOptions<Mvccrud2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //=> optionsBuilder.UseSqlServer("server=Nahomi\\SQLEXPRESS; database=MVCCRUD2; integrated security=true; TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(p => p.IdPersona); // Define la clave primaria
        });

        // Configurar herencia mediante discriminador
        modelBuilder.Entity<Persona>()
            .HasDiscriminator<string>("Discriminator")
            .HasValue<Administrador>("Administrador")
            .HasValue<Usuario>("Usuario");

        // Relación uno a uno entre Persona y Administrador
        modelBuilder.Entity<Administrador>()
            .HasOne(a => a.IdPersonaNavigation)
            .WithOne(p => p.Administrador)
            .HasForeignKey<Administrador>(a => a.IdPersona)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación uno a uno entre Persona y Usuario
        modelBuilder.Entity<Usuario>()
            .HasOne(u => u.IdPersonaNavigation)
            .WithOne(p => p.Usuario)
            .HasForeignKey<Usuario>(u => u.IdPersona)
            .OnDelete(DeleteBehavior.Restrict);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
