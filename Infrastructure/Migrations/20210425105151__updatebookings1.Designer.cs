// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CabsBookingDbContext))]
    [Migration("20210425105151__updatebookings1")]
    partial class _updatebookings1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.Bookings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingTime")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("CabTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("FromPlace")
                        .HasColumnType("int");

                    b.Property<string>("Landmark")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PickupAddress")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PickupTime")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Status")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("ToPlace")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CabTypeId");

                    b.HasIndex("FromPlace");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("ApplicationCore.Entities.BookingsHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CabTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FromPlace")
                        .HasColumnType("int");

                    b.Property<string>("Landmark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickupAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PickupTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToPlace")
                        .HasColumnType("int");

                    b.Property<decimal>("charge")
                        .HasColumnType("money");

                    b.Property<string>("comp_time")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingsHistory");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CabTypes", b =>
                {
                    b.Property<int>("CabTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CabTypeName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("CabTypeId");

                    b.HasIndex("CabTypeName")
                        .IsUnique()
                        .HasFilter("[CabTypeName] IS NOT NULL");

                    b.ToTable("CabTypes");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Places", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlaceName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("PlaceId");

                    b.HasIndex("PlaceName")
                        .IsUnique()
                        .HasFilter("[PlaceName] IS NOT NULL");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Bookings", b =>
                {
                    b.HasOne("ApplicationCore.Entities.CabTypes", "CabType")
                        .WithMany("Bookings")
                        .HasForeignKey("CabTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entities.Places", "FromPlaces")
                        .WithMany("Bookings")
                        .HasForeignKey("FromPlace")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CabType");

                    b.Navigation("FromPlaces");
                });

            modelBuilder.Entity("ApplicationCore.Entities.CabTypes", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Places", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
