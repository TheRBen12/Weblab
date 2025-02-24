﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebLab.Data;

#nullable disable

namespace WebLab.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebLab.Models.Experiment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Position")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("WebLab.Models.ExperimentTest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DetailDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EstimatedExecutionTime")
                        .HasColumnType("integer");

                    b.Property<int>("ExperimentId")
                        .HasColumnType("integer");

                    b.Property<string>("HeadDetailDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Position")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ExperimentId");

                    b.ToTable("ExperimentTests");
                });

            modelBuilder.Entity("WebLab.Models.KeyPad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BatteryTime")
                        .HasColumnType("integer");

                    b.Property<string>("ConnectionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EnergyType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyPadLayout")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyPadType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("SignalTransmission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TouchType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.Property<int>("Width")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeId");

                    b.ToTable("KeyPads");
                });

            modelBuilder.Entity("WebLab.Models.Mixer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Colr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lenght")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OriginCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Power")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Volume")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeId");

                    b.ToTable("Mixers");
                });

            modelBuilder.Entity("WebLab.Models.Notebook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Arbeitsspeicher")
                        .HasColumnType("integer");

                    b.Property<int>("Festplatte")
                        .HasColumnType("integer");

                    b.Property<string>("GraphicCardModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyPadFormat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxBatteryTime")
                        .HasColumnType("integer");

                    b.Property<int>("NumberPerformanceCors")
                        .HasColumnType("integer");

                    b.Property<int>("NumberProcessorCores")
                        .HasColumnType("integer");

                    b.Property<int>("NumberUsbAdapters")
                        .HasColumnType("integer");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProcessorType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Notebooks");
                });

            modelBuilder.Entity("WebLab.Models.PersonalComputer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cache")
                        .HasColumnType("integer");

                    b.Property<float>("ClockFrequency")
                        .HasColumnType("real");

                    b.Property<string>("GraphicCardModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KeyPadFormat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberPerformanceCors")
                        .HasColumnType("integer");

                    b.Property<int>("NumberProcessorCores")
                        .HasColumnType("integer");

                    b.Property<int>("NumberUsbAdapters")
                        .HasColumnType("integer");

                    b.Property<string>("Os")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProcessorType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Ram")
                        .HasColumnType("integer");

                    b.Property<int>("StorageCapacity")
                        .HasColumnType("integer");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TypeId");

                    b.ToTable("PersonalComputers");
                });

            modelBuilder.Entity("WebLab.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Trademark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebLab.Models.ProductProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductProperties");
                });

            modelBuilder.Entity("WebLab.Models.ProductSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductPropertyId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductPropertyId");

                    b.ToTable("ProductSpecifications");
                });

            modelBuilder.Entity("WebLab.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentTypeId");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("WebLab.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentExperimentPosition")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prename")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebLab.Models.UserSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AutoStartNextExperiment")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("ProgressiveVisualizationExperiment")
                        .HasColumnType("boolean");

                    b.Property<bool>("ProgressiveVisualizationExperimentTest")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("WebLab.Models.ExperimentTest", b =>
                {
                    b.HasOne("WebLab.Models.Experiment", "Experiment")
                        .WithMany()
                        .HasForeignKey("ExperimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Experiment");
                });

            modelBuilder.Entity("WebLab.Models.KeyPad", b =>
                {
                    b.HasOne("WebLab.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLab.Models.ProductType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("WebLab.Models.Mixer", b =>
                {
                    b.HasOne("WebLab.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLab.Models.ProductType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("WebLab.Models.Notebook", b =>
                {
                    b.HasOne("WebLab.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebLab.Models.PersonalComputer", b =>
                {
                    b.HasOne("WebLab.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLab.Models.ProductType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("WebLab.Models.Product", b =>
                {
                    b.HasOne("WebLab.Models.ProductType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("WebLab.Models.ProductSpecification", b =>
                {
                    b.HasOne("WebLab.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebLab.Models.ProductProperty", "ProductProperty")
                        .WithMany()
                        .HasForeignKey("ProductPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductProperty");
                });

            modelBuilder.Entity("WebLab.Models.ProductType", b =>
                {
                    b.HasOne("WebLab.Models.ProductType", "ParentType")
                        .WithMany("SubTypes")
                        .HasForeignKey("ParentTypeId");

                    b.Navigation("ParentType");
                });

            modelBuilder.Entity("WebLab.Models.UserSetting", b =>
                {
                    b.HasOne("WebLab.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebLab.Models.ProductType", b =>
                {
                    b.Navigation("SubTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
