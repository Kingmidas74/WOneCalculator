﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    [DbContext(typeof(APIContext))]
    [Migration("20200529115655_CreateOperationHistory")]
    partial class CreateOperationHistory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.EntityStatus", b =>
                {
                    b.Property<int>("EntityStatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("EntityStatusId");

                    b.ToTable("EntityStatus");

                    b.HasData(
                        new
                        {
                            EntityStatusId = 1,
                            Value = "Active"
                        },
                        new
                        {
                            EntityStatusId = 2,
                            Value = "Inactive"
                        });
                });

            modelBuilder.Entity("Domain.Operation", b =>
                {
                    b.Property<int>("OperationId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("OperationId");

                    b.ToTable("Operation");

                    b.HasData(
                        new
                        {
                            OperationId = 1,
                            Value = "Addition"
                        },
                        new
                        {
                            OperationId = 2,
                            Value = "Subtraction"
                        },
                        new
                        {
                            OperationId = 3,
                            Value = "Multiplication"
                        },
                        new
                        {
                            OperationId = 4,
                            Value = "Division"
                        });
                });

            modelBuilder.Entity("Domain.OperationHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("FirstOperand")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Operation")
                        .HasColumnType("integer");

                    b.Property<double>("SecondOperand")
                        .HasColumnType("double precision");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OperationHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
