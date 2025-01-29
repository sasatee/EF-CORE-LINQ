﻿// <auto-generated />
using System;
using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    [DbContext(typeof(FootballLeagueDbContext))]
    [Migration("20250129095109_SeedTeams")]
    partial class SeedTeams
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("EntityFrameworkCore.Domain.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("EntityFrameworkCore.Domain.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            CreatedDate = new DateTime(2025, 1, 29, 9, 51, 9, 706, DateTimeKind.Unspecified).AddTicks(6240),
                            Name = "Manchester United"
                        },
                        new
                        {
                            TeamId = 2,
                            CreatedDate = new DateTime(2025, 1, 29, 9, 51, 9, 706, DateTimeKind.Unspecified).AddTicks(6537),
                            Name = "Liverpool"
                        },
                        new
                        {
                            TeamId = 3,
                            CreatedDate = new DateTime(2025, 1, 29, 9, 51, 9, 706, DateTimeKind.Unspecified).AddTicks(6540),
                            Name = "Spur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
