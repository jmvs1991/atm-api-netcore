﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using atm_api_net_core;

namespace atm_api_net_core.Migrations
{
    [DbContext(typeof(AtmContext))]
    [Migration("20210212012339_CambiosEnLaTabla")]
    partial class CambiosEnLaTabla
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("atm_api_net_core.Tarjeta.Entities.TarjetaEntity", b =>
                {
                    b.Property<int>("IdTarjeta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTarjeta")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Numero");

                    b.Property<string>("Pin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Pin");

                    b.HasKey("IdTarjeta");

                    b.ToTable("Tarjeta");
                });
#pragma warning restore 612, 618
        }
    }
}
