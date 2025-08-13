using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System.Threading.Tasks;
using EF_Core_01.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_01.Data
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Instructor> Instructors { get; set; }     
        public DbSet<Student> Students { get; set; } 
       
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .; database = ITI; trusted_connection = true; TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Instructor>(builder =>
            {
                builder.HasKey(x => new { x.Ins_Id, x.Cor_Id });

                builder.Property(x => x.State)
                       .IsRequired(true)
                       .HasMaxLength(100);        
            });
        }
    }
}
