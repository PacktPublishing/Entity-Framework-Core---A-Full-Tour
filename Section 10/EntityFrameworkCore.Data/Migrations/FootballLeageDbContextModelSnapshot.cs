﻿// <auto-generated />
using System;
using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCore.Data.Migrations
{
    [DbContext(typeof(FootballLeagueDbContext))]
    partial class FootballLeageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("EntityFrameworkCore.Domain.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
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
                            CreatedDate = new DateTime(2023, 8, 31, 20, 42, 11, 206, DateTimeKind.Unspecified).AddTicks(9543),
                            Name = "Tivoli Gardens F.C."
                        },
                        new
                        {
                            TeamId = 2,
                            CreatedDate = new DateTime(2023, 8, 31, 20, 42, 11, 206, DateTimeKind.Unspecified).AddTicks(9556),
                            Name = "Waterhouse F.C."
                        },
                        new
                        {
                            TeamId = 3,
                            CreatedDate = new DateTime(2023, 8, 31, 20, 42, 11, 206, DateTimeKind.Unspecified).AddTicks(9557),
                            Name = "Humble Lions F.C."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
