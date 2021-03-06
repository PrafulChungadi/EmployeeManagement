﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Dal;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(EmployeeDal))]
    [Migration("20200712171453_ver7122020")]
    partial class ver7122020
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired();

                    b.Property<int?>("employeeid");

                    b.HasKey("id");

                    b.HasIndex("employeeid");

                    b.ToTable("tblAddress");
                });

            modelBuilder.Entity("WebApplication2.Models.EmployeeModel", b =>
                {
                    b.Property<int>("id");

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("tblEmployee");
                });

            modelBuilder.Entity("WebApplication2.Models.Address", b =>
                {
                    b.HasOne("WebApplication2.Models.EmployeeModel", "employee")
                        .WithMany("addresses")
                        .HasForeignKey("employeeid");
                });
#pragma warning restore 612, 618
        }
    }
}
