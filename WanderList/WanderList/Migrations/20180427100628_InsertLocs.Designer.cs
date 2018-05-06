﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WanderList.Models;

namespace WanderList.Migrations
{
    [DbContext(typeof(WanderListContext))]
    [Migration("20180427100628_InsertLocs")]
    partial class InsertLocs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WanderList.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("ImageLink");

                    b.Property<string>("Name");

                    b.Property<double>("Rating");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("WanderList.Models.SavedLocation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("UserId");

                    b.HasKey("id");

                    b.ToTable("SavedLocation");
                });

            modelBuilder.Entity("WanderList.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.Property<int>("SavedLocs");

                    b.Property<string>("UserName");

                    b.Property<int>("ViewedLocs");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WanderList.Models.ViewedLocation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("UserId");

                    b.HasKey("id");

                    b.ToTable("ViewedLocation");
                });
#pragma warning restore 612, 618
        }
    }
}