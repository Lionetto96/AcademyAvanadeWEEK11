﻿// <auto-generated />
using System;
using GestioneOrdini_EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestioneOrdini_EF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220211150428_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestioneOrdini_CORE.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodiceCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("GestioneOrdini_CORE.Models.Ordine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("CodiceOrdine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodiceProdotto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataOrdine")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("int");

                    b.Property<decimal>("Importo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ordini");
                });

            modelBuilder.Entity("GestioneOrdini_CORE.Models.Ordine", b =>
                {
                    b.HasOne("GestioneOrdini_CORE.Models.Cliente", null)
                        .WithMany("Ordini")
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}