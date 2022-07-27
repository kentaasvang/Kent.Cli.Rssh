﻿// <auto-generated />
using System;
using kentaasvang.Rssh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace kentaasvang.Rssh.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220410160451_DisplayNameColumnForConnectionDetails")]
    partial class DisplayNameColumnForConnectionDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("kentaasvang.Rssh.Models.ConnectionDetail", b =>
                {
                    b.Property<Guid>("ConnectionDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConnectionName")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ip")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("ConnectionDetailId");

                    b.HasIndex("GroupId");

                    b.ToTable("ConnectionDetails");
                });

            modelBuilder.Entity("kentaasvang.Rssh.Models.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("kentaasvang.Rssh.Models.ConnectionDetail", b =>
                {
                    b.HasOne("kentaasvang.Rssh.Models.Group", null)
                        .WithMany("ConnectionDetails")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("kentaasvang.Rssh.Models.Group", b =>
                {
                    b.Navigation("ConnectionDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
