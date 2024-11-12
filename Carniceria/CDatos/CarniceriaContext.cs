using CEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public partial class CarniceriaContext : DbContext
    {
        public CarniceriaContext()
        {
        }

        public CarniceriaContext(DbContextOptions<CarniceriaContext> options)
            : base(options)
        {
        }

        // Creación de DbSets
        public virtual DbSet<Corte> Corte { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-MFV6MCLC\\SQLEXPRESS;Initial Catalog=CarniceriaBD;Integrated Security=False;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Corte>().HasKey(c => c.Id);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
