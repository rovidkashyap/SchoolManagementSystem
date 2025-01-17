﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.Infrastructure.Context;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240405114354_initial_Setup")]
    partial class initial_Setup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SMS.Core.Entity.Academics.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ClassId");

                    b.ToTable("Class", (string)null);

                    b.HasData(
                        new
                        {
                            ClassId = 1001,
                            ClassName = "Class 1",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            ClassId = 1002,
                            ClassName = "Class 2",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            ClassId = 1003,
                            ClassName = "Class 3",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            ClassId = 1004,
                            ClassName = "Class 4",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            UpdatedBy = "Rovid Kashyap"
                        });
                });

            modelBuilder.Entity("SMS.Core.Entity.Academics.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionId"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SectionId");

                    b.ToTable("Section", (string)null);

                    b.HasData(
                        new
                        {
                            SectionId = 1111,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            SectionName = "A",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            SectionId = 1112,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            SectionName = "B",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            SectionId = 1113,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            SectionName = "C",
                            UpdatedBy = "Rovid Kashyap"
                        },
                        new
                        {
                            SectionId = 1114,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            SectionName = "D",
                            UpdatedBy = "Rovid Kashyap"
                        });
                });

            modelBuilder.Entity("SMS.Core.Entity.StudentModel.StudentPersonal", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GuardianName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("MotherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("StudentPersonal", (string)null);

                    b.HasData(
                        new
                        {
                            StudentId = 10001,
                            ClassId = 1001,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            Email = "ashish.singh@gmail.com",
                            FatherName = "Ravi Singh",
                            FirstName = "Ashish",
                            GuardianName = "Shiv Dubey",
                            LastName = "Singh",
                            Mobile = "9045102010",
                            MotherName = "Urmi Singh",
                            SectionId = 1111,
                            UpdatedBy = "Rovid Kashyap",
                            gender = "Male"
                        },
                        new
                        {
                            StudentId = 10002,
                            ClassId = 1002,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            Email = "arjun.singh@gmail.com",
                            FatherName = "Rohan Singh",
                            FirstName = "Arjun",
                            GuardianName = "Rishab Yadav",
                            LastName = "Singh",
                            Mobile = "9760332211",
                            MotherName = "Laxmi Singh",
                            SectionId = 1112,
                            UpdatedBy = "Rovid Kashyap",
                            gender = "Male"
                        },
                        new
                        {
                            StudentId = 10003,
                            ClassId = 1003,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            Email = "pooja.tomar@gmail.com",
                            FatherName = "Ravi Tomar",
                            FirstName = "Pooja",
                            GuardianName = "Ashish Chanchal",
                            LastName = "Tomar",
                            Mobile = "7854122321",
                            MotherName = "Shweta Tomar",
                            SectionId = 1111,
                            UpdatedBy = "Rovid Kashyap",
                            gender = "Female"
                        },
                        new
                        {
                            StudentId = 10004,
                            ClassId = 1004,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "Rovid Kashyap",
                            Email = "rashi.verma@gmail.com",
                            FatherName = "Pankaj Verma",
                            FirstName = "Rashi",
                            GuardianName = "Ashok Nagar",
                            LastName = "Verma",
                            Mobile = "9897202010",
                            MotherName = "Rashmi Verma",
                            SectionId = 1113,
                            UpdatedBy = "Rovid Kashyap",
                            gender = "Female"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
