﻿// <auto-generated />
using System;
using MCard40.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MCard40.Data.Migrations
{
    [DbContext(typeof(MCard40DbContext))]
    partial class MCard40DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MCard40.Model.Entity.CardPage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Assessment")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateСreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("DiseaseInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(800)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Treatment")
                        .IsRequired()
                        .HasColumnType("nvarchar(800)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("CardPages", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Entity.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address_home")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Address_job")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Age")
                        .HasColumnType("date");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Experience")
                        .HasColumnType("date");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("ITN")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("ITN")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Doctors", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Entity.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Age")
                        .HasColumnType("date");

                    b.Property<int>("BloodGroup")
                        .HasColumnType("int");

                    b.Property<int?>("Disability")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("ITN")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("ITN")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Entity.Week", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DayWeeks")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Weeks", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Entity.WorkDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Employment_type")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("FinalWork")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartWork")
                        .HasColumnType("time");

                    b.Property<int>("WeekId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WeekId");

                    b.ToTable("WorkDays", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("MCard40.Model.Entity.CardPage", b =>
                {
                    b.HasOne("MCard40.Model.Entity.Doctor", "Doctor")
                        .WithMany("CardPages")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MCard40.Model.Entity.Patient", "Patient")
                        .WithMany("CardPages")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Doctor", b =>
                {
                    b.HasOne("MCard40.Model.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Patient", b =>
                {
                    b.HasOne("MCard40.Model.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Week", b =>
                {
                    b.HasOne("MCard40.Model.Entity.Doctor", "Doctor")
                        .WithMany("Weeks")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MCard40.Model.Entity.WorkDay", b =>
                {
                    b.HasOne("MCard40.Model.Entity.Week", "Week")
                        .WithMany("WorkDays")
                        .HasForeignKey("WeekId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Week");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Doctor", b =>
                {
                    b.Navigation("CardPages");

                    b.Navigation("Weeks");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Patient", b =>
                {
                    b.Navigation("CardPages");
                });

            modelBuilder.Entity("MCard40.Model.Entity.Week", b =>
                {
                    b.Navigation("WorkDays");
                });
#pragma warning restore 612, 618
        }
    }
}