﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Details_Task.Data;

#nullable disable

namespace Student_Details_Task.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Student_Details_Task.Model.Domain.Studentdetail", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<long>("PhoneNo")
                        .HasColumnType("bigint");

                    b.HasKey("StudentId");

                    b.ToTable("Studentdetails");
                });
#pragma warning restore 612, 618
        }
    }
}