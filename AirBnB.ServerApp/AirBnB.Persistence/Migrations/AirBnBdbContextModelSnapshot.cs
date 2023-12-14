﻿// <auto-generated />
using System;
using AirBnB.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AirBnB.Persistence.Migrations
{
    [DbContext(typeof(AirBnBdbContext))]
    partial class AirBnBdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AirBnB.Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("BuiltYear")
                        .HasColumnType("integer");

                    b.Property<float>("FeedBack")
                        .HasColumnType("real");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("PricePerNight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("AirBnB.Domain.Entities.LocationCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.ToTable("LocationCategories");
                });

            modelBuilder.Entity("AirBnB.Domain.Entities.LocationRelation", b =>
                {
                    b.Property<Guid>("LocationCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.HasKey("LocationCategoryId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LocationRelations");
                });

            modelBuilder.Entity("AirBnB.Domain.Entities.LocationRelation", b =>
                {
                    b.HasOne("AirBnB.Domain.Entities.LocationCategory", null)
                        .WithMany()
                        .HasForeignKey("LocationCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirBnB.Domain.Entities.Location", null)
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
