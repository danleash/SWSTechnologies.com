using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;

namespace SWSTechnologies1.Models
{
    public class SWSTechDBContext : DbContext
    {
        public SWSTechDBContext()
        {
        }

        public SWSTechDBContext(DbContextOptions<SWSTechDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ContactClientModel> ContactClientModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SWSTechDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ContactClientModel>(entity =>
            {
                entity.Property(e => e.EmailAddress).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
