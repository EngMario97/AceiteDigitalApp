﻿// <auto-generated />
using System;
using AceiteDigital.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AceiteDigital.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Assinatura", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Assinado")
                        .HasColumnType("bit")
                        .HasColumnName("Assinado");

                    b.Property<DateTime>("DataHoraRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("DataHorarioRegistro");

                    b.Property<long>("DocumentoSignatarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DocumentoSignatarioId")
                        .IsUnique();

                    b.ToTable("Assinatura", (string)null);
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Documento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime")
                        .HasColumnName("DataCriacao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Documento", (string)null);
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.DocumentoSignatario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long>("DocumentoId")
                        .HasColumnType("bigint");

                    b.Property<long>("SignatarioId")
                        .HasColumnType("bigint");

                    b.Property<int>("TipoSignatario")
                        .HasColumnType("int")
                        .HasColumnName("TipoSignatario");

                    b.HasKey("Id");

                    b.HasIndex("DocumentoId");

                    b.HasIndex("SignatarioId");

                    b.ToTable("DocumentoSignatario", (string)null);
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Evento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("DataHoraEvento")
                        .HasColumnType("datetime")
                        .HasColumnName("DataHoraEvento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("Descricao");

                    b.Property<long>("DocumentoId")
                        .HasColumnType("bigint");

                    b.Property<int>("TipoEvento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentoId");

                    b.ToTable("Evento", (string)null);
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Signatario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Cpf");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Signatario", (string)null);
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Assinatura", b =>
                {
                    b.HasOne("AceiteDigitalApp.Domain.Entities.DocumentoSignatario", "DocumentoSignatario")
                        .WithOne("Assinatura")
                        .HasForeignKey("AceiteDigitalApp.Domain.Entities.Assinatura", "DocumentoSignatarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DocumentoSignatario_Assinatura_DocumentoSignatarioId");

                    b.Navigation("DocumentoSignatario");
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.DocumentoSignatario", b =>
                {
                    b.HasOne("AceiteDigitalApp.Domain.Entities.Documento", "Documento")
                        .WithMany("DocumentosSignatarios")
                        .HasForeignKey("DocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Documento_DocumentoSignatario_DocumentoId");

                    b.HasOne("AceiteDigitalApp.Domain.Entities.Signatario", "Signatario")
                        .WithMany("DocumentosSignatarios")
                        .HasForeignKey("SignatarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Documento_DocumentoSignatario_SignatarioId");

                    b.Navigation("Documento");

                    b.Navigation("Signatario");
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Evento", b =>
                {
                    b.HasOne("AceiteDigitalApp.Domain.Entities.Documento", "Documento")
                        .WithMany("Eventos")
                        .HasForeignKey("DocumentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("Fk_Documento_Evento_DocumentoId");

                    b.Navigation("Documento");
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Documento", b =>
                {
                    b.Navigation("DocumentosSignatarios");

                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.DocumentoSignatario", b =>
                {
                    b.Navigation("Assinatura")
                        .IsRequired();
                });

            modelBuilder.Entity("AceiteDigitalApp.Domain.Entities.Signatario", b =>
                {
                    b.Navigation("DocumentosSignatarios");
                });
#pragma warning restore 612, 618
        }
    }
}
