﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SPVTMaster.Models;
using System;

namespace SPVTMaster.Migrations
{
    [DbContext(typeof(AutomobileContext))]
    [Migration("20171104101435_testingtextbox")]
    partial class testingtextbox
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SPVTMaster.Models.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("DateTimeStamp");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<string>("TextBox");

                    b.Property<string>("licensePlate")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("SPVTMaster.Models.VehicleViolationList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("VehicleViolation")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("VehicleViolationList");
                });
#pragma warning restore 612, 618
        }
    }
}
