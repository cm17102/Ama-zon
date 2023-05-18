using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Ama_zon.Models;

public partial class DbamazonContext : DbContext
{
    public DbamazonContext()
    {
    }

    public DbamazonContext(DbContextOptions<DbamazonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acuerdo> Acuerdos { get; set; }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<ContratosAcuerdo> ContratosAcuerdos { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Sede> Sedes { get; set; }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-RGSSVROO\\SQLEXPRESS; Database=dbamazon; Trusted_Connection=True; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acuerdo>(entity =>
        {
            entity.HasKey(e => e.Acuerdoid).HasName("PK__acuerdos__0FE72FFD578D98F3");

            entity.ToTable("acuerdos");

            entity.Property(e => e.Acuerdoid)
                .ValueGeneratedNever()
                .HasColumnName("acuerdoid");
            entity.Property(e => e.Contenido).HasColumnName("contenido");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Paisid).HasColumnName("paisid");
            entity.Property(e => e.Pivoteid).HasColumnName("pivoteid");
            entity.Property(e => e.Tipo).HasColumnName("tipo");

            entity.HasOne(d => d.Pais).WithMany(p => p.Acuerdos)
                .HasForeignKey(d => d.Paisid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__acuerdos__paisid__34C8D9D1");

            entity.HasOne(d => d.Pivote).WithMany(p => p.Acuerdos)
                .HasForeignKey(d => d.Pivoteid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__acuerdos__pivote__35BCFE0A");
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("configuracion");

            entity.Property(e => e.Llave).HasColumnName("llave");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.Contratoid).HasName("PK__contrato__F7EE8A4698EB82FE");

            entity.ToTable("contrato");

            entity.Property(e => e.Contratoid)
                .ValueGeneratedNever()
                .HasColumnName("contratoid");
            entity.Property(e => e.Empleadoid).HasColumnName("empleadoid");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.Pivoteid).HasColumnName("pivoteid");
            entity.Property(e => e.Tipo).HasColumnName("tipo");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.Empleadoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__contrato__emplea__3B75D760");

            entity.HasOne(d => d.Pivote).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.Pivoteid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__contrato__pivote__3C69FB99");
        });

        modelBuilder.Entity<ContratosAcuerdo>(entity =>
        {
            entity.HasKey(e => e.Pivoteid).HasName("PK__contrato__C52A791378B1C2F7");

            entity.ToTable("contratos_acuerdos");

            entity.Property(e => e.Pivoteid)
                .ValueGeneratedNever()
                .HasColumnName("pivoteid");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("direccion");

            entity.Property(e => e.Calle).HasColumnName("calle");
            entity.Property(e => e.Direccion1).HasColumnName("direccion");
            entity.Property(e => e.Direccionid).HasColumnName("direccionid");
            entity.Property(e => e.Empleadoid).HasColumnName("empleadoid");
            entity.Property(e => e.Sedeid).HasColumnName("sedeid");
            entity.Property(e => e.Zip).HasColumnName("zip");

            entity.HasOne(d => d.Empleado).WithMany()
                .HasForeignKey(d => d.Empleadoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__direccion__emple__38996AB5");

            entity.HasOne(d => d.Sede).WithMany()
                .HasForeignKey(d => d.Sedeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__direccion__sedei__37A5467C");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.Empleadoid).HasName("PK__empleado__CCDA5420C45515FF");

            entity.ToTable("empleados");

            entity.Property(e => e.Empleadoid)
                .ValueGeneratedNever()
                .HasColumnName("empleadoid");
            entity.Property(e => e.Cargo).HasColumnName("cargo");
            entity.Property(e => e.Correo).HasColumnName("correo");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.Paisid).HasName("PK__pais__456747A35A6A4FDA");

            entity.ToTable("pais");

            entity.Property(e => e.Paisid)
                .ValueGeneratedNever()
                .HasColumnName("paisid");
            entity.Property(e => e.Idioma).HasColumnName("idioma");
            entity.Property(e => e.Isoalfa2).HasColumnName("isoalfa2");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        modelBuilder.Entity<Sede>(entity =>
        {
            entity.HasKey(e => e.Sedeid).HasName("PK__sede__FFC4AC77CFF68425");

            entity.ToTable("sede");

            entity.Property(e => e.Sedeid)
                .ValueGeneratedNever()
                .HasColumnName("sedeid");
            entity.Property(e => e.Codigosede).HasColumnName("codigosede");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Paisid).HasColumnName("paisid");

            entity.HasOne(d => d.Pais).WithMany(p => p.Sedes)
                .HasForeignKey(d => d.Paisid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__sede__paisid__29572725");
        });

        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.HasKey(e => e.Telefonoid).HasName("PK__telefono__EC01EDD59FF6FFD2");

            entity.ToTable("telefono");

            entity.Property(e => e.Telefonoid)
                .ValueGeneratedNever()
                .HasColumnName("telefonoid");
            entity.Property(e => e.Empleadoid).HasColumnName("empleadoid");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Sedeid).HasColumnName("sedeid");

            entity.HasOne(d => d.Empleado).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.Empleadoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__telefono__emplea__2F10007B");

            entity.HasOne(d => d.Sede).WithMany(p => p.Telefonos)
                .HasForeignKey(d => d.Sedeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__telefono__sedeid__2E1BDC42");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
