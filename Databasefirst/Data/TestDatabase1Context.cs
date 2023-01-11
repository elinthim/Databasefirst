using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Codefirst.Models;

namespace Codefirst.Data
{
    public partial class TestDatabase1Context : DbContext
    {
        public TestDatabase1Context()
        {
        }

        public TestDatabase1Context(DbContextOptions<TestDatabase1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Emplo> Emplos { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=TestDatabase1;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emplo>(entity =>
            {
                entity.ToTable("Emplo");

                entity.Property(e => e.EmploId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmploID");

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Lname).HasMaxLength(50);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Gender");

                entity.Property(e => e.FkEmploId).HasColumnName("FK_EmploID");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkEmplo)
                    .WithMany()
                    .HasForeignKey(d => d.FkEmploId)
                    .HasConstraintName("FK_Gender_Emplo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
