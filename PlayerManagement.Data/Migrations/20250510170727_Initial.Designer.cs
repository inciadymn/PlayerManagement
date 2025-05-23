﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayerManagement.Data.Context;

#nullable disable

namespace PlayerManagement.Data.Migrations
{
    [DbContext(typeof(PlayerManagementDbContext))]
    [Migration("20250510170727_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlayerManagement.Model.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1998, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Kylian Mbappe",
                            Height = 178,
                            Position = "CentreForward",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1985, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Luka Modric",
                            Height = 172,
                            Position = "Midfielder",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1992, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Daniel Carvajal",
                            Height = 173,
                            Position = "RightBack",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1991, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Lucas Vazquez",
                            Height = 173,
                            Position = "RightBack",
                            TeamId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2002, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Troy Parrott",
                            Height = 185,
                            Position = "CentreForward",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1998, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Mees de Wit",
                            Height = 181,
                            Position = "LeftBack",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2003, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Mexx Meerdink",
                            Height = 182,
                            Position = "CentreForward",
                            TeamId = 2
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(2002, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Zico Buurmeester",
                            Height = 184,
                            Position = "Midfielder",
                            TeamId = 2
                        });
                });

            modelBuilder.Entity("PlayerManagement.Model.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Spain",
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Real Madrid"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Netherlands",
                            CreatedDate = new DateTime(2025, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "AZ Alkmaar"
                        });
                });

            modelBuilder.Entity("PlayerManagement.Model.Entities.Player", b =>
                {
                    b.HasOne("PlayerManagement.Model.Entities.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PlayerManagement.Model.Entities.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
