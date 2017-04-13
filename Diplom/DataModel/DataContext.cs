using Diplom.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace Diplom
{
    class DataContext : DbContext
    {
        
            public DataContext()
                : base("DbConnection")
            { }

            public DbSet<Student> Students { get; set; }
            public DbSet<Group> Groups { get; set; }
            public DbSet<StudentReceived> SdudentsRecevieds { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().
                Property(p => p.DateBirth)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired();
            modelBuilder.Entity<Student>().
                  Property(p => p.DateDocument)
                  .HasColumnType("datetime2")
                  .HasPrecision(0)
                  .IsRequired();
            modelBuilder.Entity<Student>().
                Property(p => p.EndSchool)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired();

            modelBuilder.Entity<StudentReceived>().
                Property(p => p.DateBirth)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired();
            modelBuilder.Entity<StudentReceived>().
                  Property(p => p.DateDocument)
                  .HasColumnType("datetime2")
                  .HasPrecision(0)
                  .IsRequired();
            modelBuilder.Entity<StudentReceived>().
                Property(p => p.EndSchool)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired();

        }

    }
}


