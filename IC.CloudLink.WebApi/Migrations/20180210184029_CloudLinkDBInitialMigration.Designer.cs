﻿// <auto-generated />
using IC.Core.Entity;
using IC.Core.Entity.CloudLink.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace IC.CloudLink.WebApi.Migrations
{
    [DbContext(typeof(CloudLinkDBContext))]
    [Migration("20180210184029_CloudLinkDBInitialMigration")]
    partial class CloudLinkDBInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("IC.Core.Entity.CloudLink.DB.FlowCard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DelTime");

                    b.Property<string>("ICCId");

                    b.Property<bool>("IsDel");

                    b.Property<decimal>("TotalFlow");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<decimal>("UsagedFlow");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("FlowCards");
                });

            modelBuilder.Entity("IC.Core.Entity.CloudLink.DB.FlowPackage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DelTime");

                    b.Property<string>("Desc");

                    b.Property<decimal>("Flow");

                    b.Property<bool>("IsDel");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("FlowPackages");
                });

            modelBuilder.Entity("IC.Core.Entity.CloudLink.DB.FlowPackageRecord", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DelTime");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<bool>("IsDel");

                    b.Property<string>("PackageId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("FlowPackageRecords");
                });

            modelBuilder.Entity("IC.Core.Entity.CloudLink.DB.ReChargeRecord", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DelTime");

                    b.Property<bool>("IsDel");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("ReChargeRecords");
                });

            modelBuilder.Entity("IC.Core.Entity.CloudLink.DB.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DelTime");

                    b.Property<bool>("IsDel");

                    b.Property<string>("Phone");

                    b.Property<string>("WxOpenId");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
