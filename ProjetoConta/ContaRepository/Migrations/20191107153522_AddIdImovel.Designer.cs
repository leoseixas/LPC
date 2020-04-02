﻿// <auto-generated />
using System;
using ContaRepository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContaRepository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191107153522_AddIdImovel")]
    partial class AddIdImovel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ContaDomain.Entities.ContaLuz", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataLeitura");

                    b.Property<DateTime>("DataPagamento");

                    b.Property<double>("KwGasto");

                    b.Property<double>("MediaConsumo");

                    b.Property<double>("NumLeitura");

                    b.Property<double>("ValorAPagar");

                    b.Property<int>("idImovel");

                    b.Property<int?>("imovelid");

                    b.HasKey("id");

                    b.HasIndex("imovelid");

                    b.ToTable("ContasLuz");
                });

            modelBuilder.Entity("ContaDomain.Entities.Imovel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Estado");

                    b.Property<string>("Identificacao");

                    b.Property<string>("Numero");

                    b.HasKey("id");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("ContaDomain.Entities.ContaLuz", b =>
                {
                    b.HasOne("ContaDomain.Entities.Imovel", "imovel")
                        .WithMany("contasLuz")
                        .HasForeignKey("imovelid");
                });
#pragma warning restore 612, 618
        }
    }
}
