﻿// <auto-generated />
using ExamWebApplication.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExamWebApplication.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2");

            modelBuilder.Entity("ExamWebApplication.Models.Player", b =>
                {
                    b.Property<int>("ShirtNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(99)
                        .HasColumnType("INTEGER");

                    b.Property<int>("GoalsThisSeason")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salary")
                        .HasColumnType("TEXT");

                    b.HasKey("ShirtNumber");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ExamWebApplication.Models.Team", b =>
                {
                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameOfCoach")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Ranking")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamName");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
