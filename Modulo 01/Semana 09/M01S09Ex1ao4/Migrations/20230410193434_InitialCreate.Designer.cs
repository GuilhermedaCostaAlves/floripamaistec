﻿// <auto-generated />
using System;
using M01S09Ex1ao4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace M01S09Ex1ao4.Migrations
{
    [DbContext(typeof(BercarioContext))]
    [Migration("20230410193434_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("M01S09Ex1ao4.Models.Bebe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaeId")
                        .HasColumnType("int")
                        .HasColumnName("Mae_Id");

                    b.Property<int>("PartoId")
                        .HasColumnType("int")
                        .HasColumnName("Parto_Id");

                    b.Property<decimal>("Peso_Nascimento")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MaeId");

                    b.HasIndex("PartoId");

                    b.ToTable("Bebe", (string)null);
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK__Mae");

                    b.ToTable("Mae", (string)null);
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id")
                        .HasName("PK__Medico");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Parto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horario_Parto")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int")
                        .HasColumnName("Medico_Id");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Parto", (string)null);
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Bebe", b =>
                {
                    b.HasOne("M01S09Ex1ao4.Models.Mae", "Mae")
                        .WithMany("Bebes")
                        .HasForeignKey("MaeId")
                        .IsRequired()
                        .HasConstraintName("FK__Mae_Bebe");

                    b.HasOne("M01S09Ex1ao4.Models.Parto", "Parto")
                        .WithMany("Bebes")
                        .HasForeignKey("PartoId")
                        .IsRequired()
                        .HasConstraintName("FK__Parto_Bebe");

                    b.Navigation("Mae");

                    b.Navigation("Parto");
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Parto", b =>
                {
                    b.HasOne("M01S09Ex1ao4.Models.Medico", "Medico")
                        .WithMany("Partos")
                        .HasForeignKey("MedicoId")
                        .IsRequired()
                        .HasConstraintName("FK__Medico_Parto");

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("M01S09Ex1ao4.Models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}