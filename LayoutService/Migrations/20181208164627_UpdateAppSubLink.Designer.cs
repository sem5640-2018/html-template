﻿// <auto-generated />
using LayoutService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LayoutService.Migrations
{
    [DbContext(typeof(LayoutServiceContext))]
    [Migration("20181208164627_UpdateAppSubLink")]
    partial class UpdateAppSubLink
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AberFitnessLayout.Models.AppLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Uri");

                    b.HasKey("Id");

                    b.ToTable("AppLink");
                });

            modelBuilder.Entity("AberFitnessLayout.Models.AppSubLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<int>("AppLinkId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Uri")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AppLinkId");

                    b.ToTable("AppSubLink");
                });

            modelBuilder.Entity("AberFitnessLayout.Models.AppSubLink", b =>
                {
                    b.HasOne("AberFitnessLayout.Models.AppLink")
                        .WithMany("SubLinks")
                        .HasForeignKey("AppLinkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
