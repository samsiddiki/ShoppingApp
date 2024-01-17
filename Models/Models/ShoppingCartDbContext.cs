using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataModels.Models;

public partial class ShoppingCartDbContext : DbContext
{
    public ShoppingCartDbContext()
    {
    }

    public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminInfo> AdminInfos { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //optionsBuilder.UseSqlServer("Server=DESKTOP-M9QE7L0;Database=ShoppingCartDB;Trusted_Connection=true; TrustServerCertificate=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AdminInf__3214EC0792BEDA05");

            entity.ToTable("AdminInfo");

            entity.Property(e => e.CreatedOn).HasMaxLength(25);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.LastLogin).HasMaxLength(25);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(15);
            entity.Property(e => e.UpdatedOn).HasMaxLength(25);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Category__3214EC072F0005BE");

            entity.ToTable("Category");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07AEE65EF0");

            entity.ToTable("Product");

            entity.Property(e => e.ImageUrl).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
