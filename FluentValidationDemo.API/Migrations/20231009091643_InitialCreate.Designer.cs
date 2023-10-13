﻿// <auto-generated />
using FluentValidationDemo.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FluentValidationDemo.API.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20231009091643_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FluentValidationDemo.API.Model.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bigint")
                        .HasColumnName("employee_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeId"));

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasColumnName("employee_name");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mobile");

                    b.HasKey("EmployeeId");

                    b.ToTable("employee_fluentvalidemo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
