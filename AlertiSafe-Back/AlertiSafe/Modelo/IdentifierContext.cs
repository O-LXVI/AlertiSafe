﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AlertiSafe.Modelo;

public partial class IdentifierContext : DbContext
{
    public IdentifierContext()
    {
    }

    public IdentifierContext(DbContextOptions<IdentifierContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\manub\\Desktop\\db\\identifier.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("usuario");

            entity.HasIndex(e => e.Email, "IX_usuario_email").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellido).HasColumnName("apellido");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
