﻿// <auto-generated />
using System;
using BibliotecaOnRenan.Controller.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotecaOnRenan.Migrations
{
    [DbContext(typeof(LivrariaContext))]
    partial class LivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BibliotecaOnRenan.Model.Livro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Genero")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("NomeAutor")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("NomeLivro")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Sinopse")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.HasKey("ID");

                    b.ToTable("livros");
                });

            modelBuilder.Entity("BibliotecaOnRenan.Model.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("NomeUsuario")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(12) CHARACTER SET utf8mb4")
                        .HasMaxLength(12);

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.HasKey("IdUsuario");

                    b.ToTable("login");
                });
#pragma warning restore 612, 618
        }
    }
}
