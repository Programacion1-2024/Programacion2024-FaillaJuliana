using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;

namespace CDatos.Contexts
{
    public partial class LibreriaContext : DbContext
    {
        public LibreriaContext()
        {
        }

        public LibreriaContext(DbContextOptions<LibreriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Imagen> Imagen { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CopiaLibro> CopiaLibro { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<FormaDePago> FormaDePago { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<AutorLibro> AutorLibro { get; set; }
        public virtual DbSet<GeneroLibro> GeneroLibro { get; set; }
        public object? IdAutorLibro { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {   
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-MFV6MCLC\\SQLEXPRESS;Initial Catalog=LibreriaProgramacion1;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK_ID_AUTOR");

                entity.HasMany(e => e.Libros)
                    .WithMany(e => e.Autores)
                    .UsingEntity<AutorLibro>(
                        l => l
                            .HasOne<Libro>()
                            .WithMany()
                            .HasForeignKey(e => e.IdLibro)
                            .OnDelete(DeleteBehavior.Restrict), 
                        a => a
                            .HasOne<Autor>()
                            .WithMany()
                            .HasForeignKey(e => e.IdAutor)
                            .OnDelete(DeleteBehavior.Restrict) 
                    );
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_ID_CLIENTE");
                entity.HasMany(e => e.Prestamos)
                      .WithOne(e => e.Cliente)
                      .HasForeignKey("IdCliente")
                      .IsRequired();
                entity.HasMany(e => e.Ventas)
                     .WithOne(e => e.Cliente)
                     .HasForeignKey("IdCliente")
                     .IsRequired();
            });
            modelBuilder.Entity<Imagen>(entity =>
            {
                entity.HasKey(e => e.IdImagen)
                    .HasName("PK_ID_IMAGEN");
            });
            modelBuilder.Entity<CopiaLibro>(entity =>
            {
                entity.HasKey(e => e.IdCopiaLibro)
                    .HasName("PK_ID_COPIALIBRO");
                entity.HasMany(e => e.Prestamos)
                    .WithOne(e => e.CopiaLibro)
                    .HasForeignKey("IdCopia")
                    .IsRequired();
            }); 
            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.IdEditorial)
                    .HasName("PK_ID_EDITORIAL");
                entity.HasMany(e => e.Libros)
                      .WithOne(e => e.Editorial)
                      .HasForeignKey("IdEditorial")
                      .IsRequired();
            }); 
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK_ID_EMPLEADO");
                 entity.HasMany(e => e.Ventas)
                      .WithOne(e => e.Empleado)
                      .HasForeignKey("IdEmpleado")
                      .IsRequired();
                entity.HasMany(e => e.Prestamos)
                      .WithOne(e => e.Empleado)
                      .HasForeignKey("IdEmpleado")
                      .IsRequired();
            }); 
            modelBuilder.Entity<FormaDePago>(entity =>
            {
                entity.HasKey(e => e.IdFormaDePago)
                    .HasName("PK_ID_FORMADEPAGO");
                entity.HasMany(e => e.Prestamo)
                      .WithOne(e => e.FormaDePago)
                      .HasForeignKey("IdFormaDePago")
                      .IsRequired();
                entity.HasMany(e => e.Venta)
                      .WithOne(e => e.FormaDePago)
                      .HasForeignKey("IdFormaDePago")
                      .IsRequired();
            });
            modelBuilder.Entity<GeneroLibro>(entity =>
            {
                entity.HasKey(e => e.IdGeneroLibro)
                    .HasName("PK_ID_GENEROLIBRO");
            });
            modelBuilder.Entity<AutorLibro>(entity =>
            {
                entity.HasKey(e => e.IdAutorLibro)
                    .HasName("PK_ID_AUTORLIBRO");
            });
            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK_ID_GENERO");
                entity.HasMany(e => e.Libros)
                      .WithMany(e => e.Generos)
                      .UsingEntity<GeneroLibro>(
                       l => l.HasOne<Libro>().WithMany().HasForeignKey(e => e.IdLibro),
                       g => g.HasOne<Genero>().WithMany().HasForeignKey(e => e.IdGenero)
                    );
            }); 
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibro)
                    .HasName("PK_ID_LIBRO");
                entity.HasMany(e => e.CopiasLibro)
                   .WithOne(e => e.Libro)
                   .HasForeignKey("IdLibro")
                   .OnDelete(DeleteBehavior.NoAction)
                   .IsRequired();
                entity.HasMany(e => e.Venta)
                    .WithOne(e => e.Libro)
                    .HasForeignKey("IdLibro")
                    .IsRequired();
            }); 
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK_ID_PERSONA");
                entity.HasOne(e => e.Autor)
                      .WithOne(e => e.Persona)
                      .HasForeignKey<Autor>("IdPersona")
                      .IsRequired(false);
                entity.HasOne(e => e.Cliente)
                     .WithOne(e => e.Persona)
                     .HasForeignKey<Cliente>("IdPersona")
                     .IsRequired(false);
                entity.HasOne(e => e.Empleado)
                     .WithOne(e => e.Persona)
                     .HasForeignKey<Empleado>("IdPersona")
                     .IsRequired(false);
            }); 
            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo)
                    .HasName("PK_ID_PRESTAMO");
                
            });
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK_ID_VENTA");
    

            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
