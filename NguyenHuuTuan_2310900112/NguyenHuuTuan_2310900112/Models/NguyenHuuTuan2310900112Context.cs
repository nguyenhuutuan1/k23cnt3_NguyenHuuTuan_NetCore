using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NguyenHuuTuan_2310900112.Models;

public partial class NguyenHuuTuan2310900112Context : DbContext
{
    public NguyenHuuTuan2310900112Context()
    {
    }

    public NguyenHuuTuan2310900112Context(DbContextOptions<NguyenHuuTuan2310900112Context> options)
        : base(options)
    {
    }


    public virtual DbSet<NhtEmployee> NhtEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-A67EEHV;Database=NguyenHuuTuan_2310900112;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<NhtEmployee>(entity =>
        {
            entity.HasKey(e => e.NhtEmpId).HasName("PK__NhtEmplo__CA96F19C5EF8DC56");

            entity.ToTable("NhtEmployee");

            entity.Property(e => e.NhtEmpId)
                .ValueGeneratedNever()
                .HasColumnName("nhtEmpId");
            entity.Property(e => e.NhtEmpLevel)
                .HasMaxLength(50)
                .HasColumnName("nhtEmpLevel");
            entity.Property(e => e.NhtEmpName)
                .HasMaxLength(100)
                .HasColumnName("nhtEmpName");
            entity.Property(e => e.NhtEmpStartDate).HasColumnName("nhtEmpStartDate");
            entity.Property(e => e.NhtEmpStatus).HasColumnName("nhtEmpStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
