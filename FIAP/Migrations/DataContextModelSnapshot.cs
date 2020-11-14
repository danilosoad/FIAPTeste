﻿// <auto-generated />
using FIAP.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FIAP.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FIAP.Models.LoginModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("ADMIN")
                        .HasColumnType("bit");

                    b.Property<string>("PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SALT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USERNAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Login");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ADMIN = true,
                            PASSWORD = "scMR1rXjMMPCxLR35LfrTk0s9Xti8IsCk1/W0VuAyfY=",
                            SALT = "Lp/VYJDCuUrK8FZsYO2+4A==",
                            USERNAME = "admin"
                        });
                });

            modelBuilder.Entity("FIAP.Models.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
