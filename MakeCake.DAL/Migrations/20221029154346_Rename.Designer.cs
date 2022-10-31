﻿// <auto-generated />
using MakeCake.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakeCake.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221029154346_Rename")]
    partial class Rename
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MakeCake.DAL.Models.BiscuitDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Biscuits");
                });

            modelBuilder.Entity("MakeCake.DAL.Models.CreamDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Creams");
                });

            modelBuilder.Entity("MakeCake.DAL.Models.FillingDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fillings");
                });

            modelBuilder.Entity("MakeCake.DAL.Models.TierDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BiscuitId")
                        .HasColumnType("int");

                    b.Property<int>("CreamId")
                        .HasColumnType("int");

                    b.Property<int>("Diametr")
                        .HasColumnType("int");

                    b.Property<int>("FillingId")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BiscuitId");

                    b.HasIndex("CreamId");

                    b.HasIndex("FillingId");

                    b.ToTable("Tiers");
                });

            modelBuilder.Entity("MakeCake.DAL.Models.TierDto", b =>
                {
                    b.HasOne("MakeCake.DAL.Models.BiscuitDto", "Biscuit")
                        .WithMany()
                        .HasForeignKey("BiscuitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakeCake.DAL.Models.CreamDto", "Cream")
                        .WithMany()
                        .HasForeignKey("CreamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakeCake.DAL.Models.FillingDto", "Filling")
                        .WithMany()
                        .HasForeignKey("FillingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biscuit");

                    b.Navigation("Cream");

                    b.Navigation("Filling");
                });
#pragma warning restore 612, 618
        }
    }
}
