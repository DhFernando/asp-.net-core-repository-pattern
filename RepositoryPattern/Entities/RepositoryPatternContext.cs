using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RepositoryPattern.Models
{
    public partial class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext(DbContextOptions<RepositoryPatternContext> options) : base(options) { }

        public virtual DbSet<Dep> Dep { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dep>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_Table_1");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(36)
                    .IsFixedLength();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsFixedLength();

                entity.Property(e => e.DepartmentStart)
                    .HasMaxLength(70)
                    .IsFixedLength();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .IsFixedLength();

                entity.Property(e => e.UserBday)
                    .IsRequired()
                    .HasColumnName("UserBDay")
                    .HasMaxLength(70)
                    .IsFixedLength();

                entity.Property(e => e.UserDep)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsFixedLength();

                entity.Property(e => e.UserRole)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
