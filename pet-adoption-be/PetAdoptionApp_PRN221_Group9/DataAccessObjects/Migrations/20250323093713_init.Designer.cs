﻿// <auto-generated />
using System;
using DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessObjects.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20250323093713_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusinessObjects.Adoption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdoptionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdoptionStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ApprovalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Adoptions");
                });

            modelBuilder.Entity("BusinessObjects.Donation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Money")
                        .HasColumnType("real");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.HasIndex("UserId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("BusinessObjects.Enrollment", b =>
                {
                    b.Property<Guid?>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("EventId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("BusinessObjects.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventStatus")
                        .HasColumnType("int");

                    b.Property<int?>("EventType")
                        .HasColumnType("int");

                    b.Property<int?>("LimitedCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sponsors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BusinessObjects.EventImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("EventImages");
                });

            modelBuilder.Entity("BusinessObjects.Healths", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.Property<int?>("VaccineStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Healths");
                });

            modelBuilder.Entity("BusinessObjects.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RescuedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ShelterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("ShelterId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("BusinessObjects.PetImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("PetImages");
                });

            modelBuilder.Entity("BusinessObjects.Shelter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LimitedCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ShelterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Shelters");
                });

            modelBuilder.Entity("BusinessObjects.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConfirmationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<byte?>("Status")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BusinessObjects.Adoption", b =>
                {
                    b.HasOne("BusinessObjects.Pet", "Pet")
                        .WithMany("Adoptions")
                        .HasForeignKey("PetId");

                    b.HasOne("BusinessObjects.User", "User")
                        .WithMany("Adoptions")
                        .HasForeignKey("UserId");

                    b.Navigation("Pet");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Donation", b =>
                {
                    b.HasOne("BusinessObjects.Shelter", "Shelter")
                        .WithMany("Donations")
                        .HasForeignKey("ShelterId");

                    b.HasOne("BusinessObjects.User", "User")
                        .WithMany("Donations")
                        .HasForeignKey("UserId");

                    b.Navigation("Shelter");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.Enrollment", b =>
                {
                    b.HasOne("BusinessObjects.Event", "Event")
                        .WithMany("Enrollments")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusinessObjects.User", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BusinessObjects.EventImage", b =>
                {
                    b.HasOne("BusinessObjects.Event", "Event")
                        .WithMany("Images")
                        .HasForeignKey("EventId");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("BusinessObjects.Healths", b =>
                {
                    b.HasOne("BusinessObjects.Pet", "Pet")
                        .WithMany("Healths")
                        .HasForeignKey("PetId");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("BusinessObjects.Pet", b =>
                {
                    b.HasOne("BusinessObjects.Shelter", "Shelter")
                        .WithMany("Pets")
                        .HasForeignKey("ShelterId");

                    b.Navigation("Shelter");
                });

            modelBuilder.Entity("BusinessObjects.PetImage", b =>
                {
                    b.HasOne("BusinessObjects.Pet", "Pet")
                        .WithMany("PetImages")
                        .HasForeignKey("PetId");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("BusinessObjects.Event", b =>
                {
                    b.Navigation("Enrollments");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("BusinessObjects.Pet", b =>
                {
                    b.Navigation("Adoptions");

                    b.Navigation("Healths");

                    b.Navigation("PetImages");
                });

            modelBuilder.Entity("BusinessObjects.Shelter", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("BusinessObjects.User", b =>
                {
                    b.Navigation("Adoptions");

                    b.Navigation("Donations");

                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
