﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyApp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20200504074942_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MyApp.Models.Entities.Montain", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Height")
                        .HasColumnType("numeric");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("PrefectureId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PrefectureId");

                    b.ToTable("Montains");
                });

            modelBuilder.Entity("MyApp.Models.Entities.Prefecture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Prefectures");
                });

            modelBuilder.Entity("MyApp.Models.Entities.Montain", b =>
                {
                    b.HasOne("MyApp.Models.Entities.Prefecture", "Prefecture")
                        .WithMany()
                        .HasForeignKey("PrefectureId");
                });
#pragma warning restore 612, 618
        }
    }
}
