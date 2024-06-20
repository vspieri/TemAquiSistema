﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tem_Aqui.Models;

#nullable disable

namespace Tem_Aqui.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240620131847_Criacao-TUDO")]
    partial class CriacaoTUDO
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TemAqui.Models.SerPres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SerPresId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEHR")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataEHr");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Preço");

                    b.Property<int>("PrestadordeservicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrestadordeservicoId");

                    b.ToTable("SerPres");
                });

            modelBuilder.Entity("Tem_Aqui.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CadastroId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CadastroNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CadastroNome");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cnpj");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descrição");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Foto");

                    b.Property<string>("Localidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Localidade");

                    b.Property<int>("Telefone")
                        .HasColumnType("int")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("Tem_Aqui.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LoginId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LoginNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LoginNome");

                    b.Property<string>("LoginSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LoginSenha");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Tem_Aqui.Models.Prestadordeservico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPrestador");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereco");

                    b.Property<string>("NomePrestador")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomePrestador");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("Numero");

                    b.Property<string>("TipoServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoServico");

                    b.HasKey("Id");

                    b.ToTable("Prestador");
                });

            modelBuilder.Entity("Tem_Aqui.Models.TabelClientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EmailId");

                    b.Property<string>("EndereçoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EndereçoId");

                    b.Property<string>("NumeroId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NumeroId");

                    b.HasKey("Id");

                    b.ToTable("TabelClientes");
                });

            modelBuilder.Entity("TemAqui.Models.SerPres", b =>
                {
                    b.HasOne("Tem_Aqui.Models.Prestadordeservico", "Prestadordeservico")
                        .WithMany()
                        .HasForeignKey("PrestadordeservicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prestadordeservico");
                });
#pragma warning restore 612, 618
        }
    }
}
