﻿// <auto-generated />
using System;
using CDatos.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CDatos.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    [Migration("20240702210625_Tablas")]
    partial class Tablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("en_US.UTF-8")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CEntidades.Entidades.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutor"));

                    b.Property<string>("BiografiaAutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantidadLibrosEscritosAutor")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimientoAutor")
                        .HasColumnType("datetime2");

                    b.Property<string>("NacionalidadAutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaAutorIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdAutor")
                        .HasName("PK_ID_AUTOR");

                    b.HasIndex("PersonaAutorIdPersona");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("CEntidades.Entidades.AutorLibro", b =>
                {
                    b.Property<int>("IdAutorLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutorLibro"));

                    b.Property<int>("AutorAutorLibroIdAutor")
                        .HasColumnType("int");

                    b.Property<int>("LibroAutorLibroIdLibro")
                        .HasColumnType("int");

                    b.HasKey("IdAutorLibro")
                        .HasName("PK_ID_AUTORLIBRO");

                    b.HasIndex("AutorAutorLibroIdAutor");

                    b.HasIndex("LibroAutorLibroIdLibro");

                    b.ToTable("AutorLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<bool>("EsSocio")
                        .HasColumnType("bit");

                    b.Property<bool>("PagaIVA")
                        .HasColumnType("bit");

                    b.Property<int>("PersonaClienteIdPersona")
                        .HasColumnType("int");

                    b.HasKey("IdCliente")
                        .HasName("PK_ID_CLIENTE");

                    b.HasIndex("PersonaClienteIdPersona");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CEntidades.Entidades.Copia", b =>
                {
                    b.Property<int>("IdCopia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCopia"));

                    b.Property<double>("PrecioPrestamo")
                        .HasColumnType("float");

                    b.HasKey("IdCopia")
                        .HasName("PK_ID_COPIA");

                    b.ToTable("Copia");
                });

            modelBuilder.Entity("CEntidades.Entidades.Editorial", b =>
                {
                    b.Property<int>("IdEditorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEditorial"));

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEditorial")
                        .HasName("PK_ID_EDITORIAL");

                    b.ToTable("Editorial");
                });

            modelBuilder.Entity("CEntidades.Entidades.Empleado", b =>
                {
                    b.Property<int>("IdEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmpleado"));

                    b.Property<DateTime>("Antiguedad")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaEmpleadoIdPersona")
                        .HasColumnType("int");

                    b.Property<double>("Sueldo")
                        .HasColumnType("float");

                    b.HasKey("IdEmpleado")
                        .HasName("PK_ID_EMPLEADO");

                    b.HasIndex("PersonaEmpleadoIdPersona");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("CEntidades.Entidades.FormaPago", b =>
                {
                    b.Property<int>("IdFormaPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFormaPago"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFormaPago")
                        .HasName("PK_ID_FORMAPAGO");

                    b.ToTable("FormaPago");
                });

            modelBuilder.Entity("CEntidades.Entidades.Genero", b =>
                {
                    b.Property<int>("IdGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGenero"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGenero")
                        .HasName("PK_ID_GENERO");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("CEntidades.Entidades.GeneroLibro", b =>
                {
                    b.Property<int>("IdGeneroLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGeneroLibro"));

                    b.Property<int>("GeneroGeneroLibroIdGenero")
                        .HasColumnType("int");

                    b.Property<int>("LibroGeneroLibroIdLibro")
                        .HasColumnType("int");

                    b.HasKey("IdGeneroLibro")
                        .HasName("PK_ID_GENEROLIBRO");

                    b.HasIndex("GeneroGeneroLibroIdGenero");

                    b.HasIndex("LibroGeneroLibroIdLibro");

                    b.ToTable("GeneroLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Libro", b =>
                {
                    b.Property<int>("IdLibro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLibro"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EditorialLibroIdEditorial")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrecioVenta")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLibro")
                        .HasName("PK_ID_LIBRO");

                    b.HasIndex("EditorialLibroIdEditorial");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPersona")
                        .HasName("PK_ID_PERSONA");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("CEntidades.Entidades.Prestamo", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrestamo"));

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaLimite")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPrestamo")
                        .HasName("PK_ID_PRESTAMO");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("CEntidades.Entidades.Venta", b =>
                {
                    b.Property<int>("IdVenta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVenta"));

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("datetime2");

                    b.HasKey("IdVenta")
                        .HasName("PK_ID_VENTA");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("CEntidades.Entidades.Autor", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "PersonaAutor")
                        .WithMany()
                        .HasForeignKey("PersonaAutorIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonaAutor");
                });

            modelBuilder.Entity("CEntidades.Entidades.AutorLibro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Autor", "AutorAutorLibro")
                        .WithMany()
                        .HasForeignKey("AutorAutorLibroIdAutor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Libro", "LibroAutorLibro")
                        .WithMany()
                        .HasForeignKey("LibroAutorLibroIdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutorAutorLibro");

                    b.Navigation("LibroAutorLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Cliente", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "PersonaCliente")
                        .WithMany()
                        .HasForeignKey("PersonaClienteIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonaCliente");
                });

            modelBuilder.Entity("CEntidades.Entidades.Empleado", b =>
                {
                    b.HasOne("CEntidades.Entidades.Persona", "PersonaEmpleado")
                        .WithMany()
                        .HasForeignKey("PersonaEmpleadoIdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonaEmpleado");
                });

            modelBuilder.Entity("CEntidades.Entidades.GeneroLibro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Genero", "GeneroGeneroLibro")
                        .WithMany()
                        .HasForeignKey("GeneroGeneroLibroIdGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEntidades.Entidades.Libro", "LibroGeneroLibro")
                        .WithMany()
                        .HasForeignKey("LibroGeneroLibroIdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneroGeneroLibro");

                    b.Navigation("LibroGeneroLibro");
                });

            modelBuilder.Entity("CEntidades.Entidades.Libro", b =>
                {
                    b.HasOne("CEntidades.Entidades.Editorial", "EditorialLibro")
                        .WithMany()
                        .HasForeignKey("EditorialLibroIdEditorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EditorialLibro");
                });
#pragma warning restore 612, 618
        }
    }
}
