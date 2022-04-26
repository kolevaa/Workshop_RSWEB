﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workshop_RSWEB.Data;

#nullable disable

namespace Workshop_RSWEB.Migrations
{
    [DbContext(typeof(Workshop_RSWEBContext))]
    [Migration("20220424185823_PredmetStudentProfesor")]
    partial class PredmetStudentProfesor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Workshop_RSWEB.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Semestar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Smer")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AkademskiRang")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StepenObrazovanie")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Profesor");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.ProfesorPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PredmetId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("ProfesorPredmet");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Index")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.StudentPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PredmetId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PredmetId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentPredmet");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Predmet", b =>
                {
                    b.HasOne("Workshop_RSWEB.Models.Profesor", null)
                        .WithMany("Predmets")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.ProfesorPredmet", b =>
                {
                    b.HasOne("Workshop_RSWEB.Models.Predmet", "Predmet")
                        .WithMany("Profesors")
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workshop_RSWEB.Models.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.StudentPredmet", b =>
                {
                    b.HasOne("Workshop_RSWEB.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workshop_RSWEB.Models.Student", "Student")
                        .WithMany("Predmets")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predmet");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Predmet", b =>
                {
                    b.Navigation("Profesors");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Profesor", b =>
                {
                    b.Navigation("Predmets");
                });

            modelBuilder.Entity("Workshop_RSWEB.Models.Student", b =>
                {
                    b.Navigation("Predmets");
                });
#pragma warning restore 612, 618
        }
    }
}
