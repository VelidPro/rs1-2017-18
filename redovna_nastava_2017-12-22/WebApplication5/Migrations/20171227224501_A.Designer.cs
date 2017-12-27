﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication5.EF;

namespace WebApplication5.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20171227224501_A")]
    partial class A
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication5.EntityModels.Opstina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("Opstine");
                });

            modelBuilder.Entity("WebApplication5.EntityModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<int?>("OpstinaId");

                    b.Property<string>("Prezime");

                    b.HasKey("Id");

                    b.HasIndex("OpstinaId");

                    b.ToTable("Studenti");
                });

            modelBuilder.Entity("WebApplication5.EntityModels.Student", b =>
                {
                    b.HasOne("WebApplication5.EntityModels.Opstina", "Opstina")
                        .WithMany()
                        .HasForeignKey("OpstinaId");
                });
#pragma warning restore 612, 618
        }
    }
}
