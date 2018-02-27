﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Proyecto_Web_ll.Models;
using System;

namespace Proyecto_Web_ll.Migrations
{
    [DbContext(typeof(MvcToyotaContext))]
    [Migration("20180224053101_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Proyecto_Web_ll.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CedulaJuridica")
                        .IsRequired();

                    b.Property<string>("DireccionFisica")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PaginaWeb");

                    b.Property<int>("SectorID");

                    b.Property<int?>("telefono");

                    b.HasKey("ID");

                    b.HasIndex("SectorID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Contacto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido_Uno")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("ClienteID");

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Puesto")
                        .IsRequired();

                    b.Property<int>("Telefono")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Contacto");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Estado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Reunion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UsuarioID");

                    b.Property<bool>("Virtual");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Reunion");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Sector", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Ticket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.Property<string>("Detalle");

                    b.Property<int>("EstadoID");

                    b.Property<string>("PersonaReporte");

                    b.Property<string>("Titulo");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("EstadoID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido_Uno");

                    b.Property<string>("Contrasenna")
                        .IsRequired();

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Permisos");

                    b.Property<string>("Puesto");

                    b.Property<int?>("Telefono");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Cliente", b =>
                {
                    b.HasOne("Proyecto_Web_ll.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Contacto", b =>
                {
                    b.HasOne("Proyecto_Web_ll.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Reunion", b =>
                {
                    b.HasOne("Proyecto_Web_ll.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proyecto_Web_ll.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proyecto_Web_ll.Models.Ticket", b =>
                {
                    b.HasOne("Proyecto_Web_ll.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proyecto_Web_ll.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}