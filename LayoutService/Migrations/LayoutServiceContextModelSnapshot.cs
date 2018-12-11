﻿// <auto-generated />
using LayoutService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LayoutService.Migrations
{
    [DbContext(typeof(LayoutServiceContext))]
    partial class LayoutServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LayoutService.Models.AppLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("IconName")
                        .IsRequired();

                    b.Property<int>("Priority");

                    b.Property<string>("Uri")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AppLink");
                });

            modelBuilder.Entity("LayoutService.Models.AppSubLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<int>("AppLinkId");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("IconName")
                        .IsRequired();

                    b.Property<int>("Priority");

                    b.Property<string>("Uri")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AppLinkId");

                    b.ToTable("AppSubLink");
                });

            modelBuilder.Entity("LayoutService.Models.AppSubLink", b =>
                {
                    b.HasOne("LayoutService.Models.AppLink")
                        .WithMany("SubLinks")
                        .HasForeignKey("AppLinkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
