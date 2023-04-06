﻿// <auto-generated />
using System;
using ExerSemana9.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExerSemana9.Migrations
{
    [DbContext(typeof(SemanaContext))]
    [Migration("20230406201625_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerSemana9.Model.SemanaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CODIGO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AplicadoConteudo")
                        .HasColumnType("bit")
                        .HasColumnName("APLICCONTEÚDO");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CONTEÚDO");

                    b.Property<DateTime>("DataSemana")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.HasKey("Id");

                    b.ToTable("Semana");
                });
#pragma warning restore 612, 618
        }
    }
}