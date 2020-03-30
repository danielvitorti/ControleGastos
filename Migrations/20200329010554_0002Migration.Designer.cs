﻿// <auto-generated />
using System;
using ControleGastos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleGastos.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200329010554_0002Migration")]
    partial class _0002Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ControleGastos.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Contas");
                });

            modelBuilder.Entity("ControleGastos.Models.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("ControleGastos.Models.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Competencia")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdConta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFormaPagamento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<int?>("contaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("formaPagamentoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("contaId");

                    b.HasIndex("formaPagamentoId");

                    b.ToTable("Lancamentos");
                });

            modelBuilder.Entity("ControleGastos.Models.Lancamento", b =>
                {
                    b.HasOne("ControleGastos.Models.Conta", "conta")
                        .WithMany()
                        .HasForeignKey("contaId");

                    b.HasOne("ControleGastos.Models.FormaPagamento", "formaPagamento")
                        .WithMany()
                        .HasForeignKey("formaPagamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
