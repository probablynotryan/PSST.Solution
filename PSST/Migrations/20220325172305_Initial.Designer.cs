﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Treats.Models;

namespace PSST.Migrations
{
    [DbContext(typeof(TreatsContext))]
    [Migration("20220325172305_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Treats.Models.Flavor", b =>
                {
                    b.Property<int>("FlavorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FlavorName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("FlavorId");

                    b.ToTable("Flavors");
                });

            modelBuilder.Entity("Treats.Models.FlavorSweet", b =>
                {
                    b.Property<int>("FlavorSweetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FlavorId")
                        .HasColumnType("int");

                    b.Property<int>("SweetId")
                        .HasColumnType("int");

                    b.HasKey("FlavorSweetId");

                    b.HasIndex("FlavorId");

                    b.HasIndex("SweetId");

                    b.ToTable("FlavorSweet");
                });

            modelBuilder.Entity("Treats.Models.Sweet", b =>
                {
                    b.Property<int>("SweetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SweetName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SweetId");

                    b.ToTable("Sweets");
                });

            modelBuilder.Entity("Treats.Models.FlavorSweet", b =>
                {
                    b.HasOne("Treats.Models.Flavor", "Flavor")
                        .WithMany("JoinEntities")
                        .HasForeignKey("FlavorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Treats.Models.Sweet", "Sweet")
                        .WithMany("JoinEntities")
                        .HasForeignKey("SweetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flavor");

                    b.Navigation("Sweet");
                });

            modelBuilder.Entity("Treats.Models.Flavor", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Treats.Models.Sweet", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
