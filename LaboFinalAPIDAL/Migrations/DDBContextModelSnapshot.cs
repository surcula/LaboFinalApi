﻿// <auto-generated />
using System;
using LaboFinalAPIDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaboFinalAPIDAL.Migrations
{
    [DbContext(typeof(DDBContext))]
    partial class DDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LaboFinalAPIDomain.Models.Items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Ca")
                        .HasColumnType("int");

                    b.Property<int>("Ca_Bonus")
                        .HasColumnType("int");

                    b.Property<int?>("DiceNumber")
                        .HasColumnType("int");

                    b.Property<int?>("DiceType")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int?>("TypesItemsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypesItemsId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("LaboFinalAPIDomain.Models.Sources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("LaboFinalAPIDomain.Models.Spells", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CastingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Components")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HigherLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int>("sourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("sourceId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("LaboFinalAPIDomain.Models.TypesItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeItem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypesItems");
                });

            modelBuilder.Entity("LaboFinalAPIDomain.Models.Items", b =>
                {
                    b.HasOne("LaboFinalAPIDomain.Models.TypesItems", "TypesItems")
                        .WithMany()
                        .HasForeignKey("TypesItemsId");

                    b.Navigation("TypesItems");
                });

            modelBuilder.Entity("LaboFinalAPIDomain.Models.Spells", b =>
                {
                    b.HasOne("LaboFinalAPIDomain.Models.Sources", "Source")
                        .WithMany()
                        .HasForeignKey("sourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Source");
                });
#pragma warning restore 612, 618
        }
    }
}
