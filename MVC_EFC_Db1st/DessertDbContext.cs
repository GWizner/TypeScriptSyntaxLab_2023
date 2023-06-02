﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_EFC_Db1st;

public partial class DessertDbContext : DbContext
{
    public DessertDbContext()
    {
    }

    public DessertDbContext(DbContextOptions<DessertDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dessert> Desserts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=DessertDb; Integrated Security=SSPI; Trust Server Certificate=true; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dessert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Desserts__3214EC07EEC03717");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
