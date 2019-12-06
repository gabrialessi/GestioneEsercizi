﻿// <auto-generated />
using System;
using GestioneEsercizi.DA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestioneEsercizi.DA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191203145150_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Anno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Annata")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Anni");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnnoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AnnoId");

                    b.ToTable("Classi");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Esercizio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ModuloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Testo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titolo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("Esercizi");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.EsercizioProva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EsercizioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProvaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EsercizioId");

                    b.HasIndex("ProvaId");

                    b.ToTable("EserciziProva");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Modulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClasseId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Moduli");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Prova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClasseId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titolo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Prove");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Tematica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ModuloId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ModuloId");

                    b.ToTable("Tematiche");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Classe", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Anno", "Anno")
                        .WithMany("Classi")
                        .HasForeignKey("AnnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Esercizio", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Modulo", "Modulo")
                        .WithMany("Esercizi")
                        .HasForeignKey("ModuloId");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.EsercizioProva", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Esercizio", "Esercizio")
                        .WithMany("EserciziProva")
                        .HasForeignKey("EsercizioId");

                    b.HasOne("GestioneEsercizi.DA.Models.Prova", "Prova")
                        .WithMany("EserciziProva")
                        .HasForeignKey("ProvaId");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Modulo", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Classe", "Classe")
                        .WithMany("Moduli")
                        .HasForeignKey("ClasseId");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Prova", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Classe", "Classe")
                        .WithMany("Prove")
                        .HasForeignKey("ClasseId");
                });

            modelBuilder.Entity("GestioneEsercizi.DA.Models.Tematica", b =>
                {
                    b.HasOne("GestioneEsercizi.DA.Models.Modulo", "Modulo")
                        .WithMany("Tematiche")
                        .HasForeignKey("ModuloId");
                });
#pragma warning restore 612, 618
        }
    }
}