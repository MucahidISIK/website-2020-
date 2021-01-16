﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lolhub.Data;

namespace lolhub.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("lolhub.Models.Paylasim", b =>
                {
                    b.Property<int>("PaylasimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaylasimID");

                    b.ToTable("Paylasimlar");
                });
#pragma warning restore 612, 618
        }
    }
}
