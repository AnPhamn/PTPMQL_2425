﻿// <auto-generated />
using DEMOMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DEMOMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002085847_Create_table_Employee")]
    partial class Create_table_Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DEMOMVC.Models.Person", b =>
                {
                    b.Property<string>("CCCDID")
                        .HasColumnType("TEXT");

                    b.Property<string>("hoVaten")
                        .HasColumnType("TEXT");

                    b.Property<string>("queQuan")
                        .HasColumnType("TEXT");

                    b.HasKey("CCCDID");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DEMOMVC.Models.Employee", b =>
                {
                    b.HasBaseType("DEMOMVC.Models.Person");

                    b.Property<string>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeID")
                        .HasColumnType("TEXT");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DEMOMVC.Models.Employee", b =>
                {
                    b.HasOne("DEMOMVC.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DEMOMVC.Models.Employee", "CCCDID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
