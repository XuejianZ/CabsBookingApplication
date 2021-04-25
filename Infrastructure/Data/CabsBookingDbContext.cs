using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;

namespace Infrastructure.Data
{
    public class CabsBookingDbContext:DbContext
    {
        public CabsBookingDbContext(DbContextOptions<CabsBookingDbContext> options) : base(options)
        {
                
        }

        public DbSet<Bookings> Bookings { get; set; }

        public DbSet<BookingsHistory> BookingsHistory { get; set; }

        public DbSet<CabTypes> CabTypes { get; set; }

        public DbSet<Places> Places { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabTypes>(ConfigureCabTypes);
            modelBuilder.Entity<Places>(ConfigurePlaces);
            modelBuilder.Entity<Bookings>(ConfigureBookings);
            modelBuilder.Entity<BookingsHistory>(ConfigureBookingsHistory);


            //modelBuilder.Entity<CabTypes>()
            //    .HasOne<Bookings>(c => c.Bookings)
            //    .WithOne(c => c.CabTypes)
            //        .HasForeignKey<Bookings>(c => c.CabTypeId);



            //modelBuilder.Entity<Bookings>().HasIndex(b => b.CabTypeId).IsUnique(false);
            //modelBuilder.Entity<BookingsHistory>().HasIndex(b => b.CabTypeId).IsUnique(false);

            //modelBuilder.Entity<CabTypes>()
            //    .HasOne<BookingsHistory>(c => c.BookingsHistory)
            //    .WithOne(c => c.CabTypes)
            //    .HasForeignKey<BookingsHistory>(c => c.CabTypeId);



            //modelBuilder.Entity<BookingsHistory>()
            //    .HasOne<Places>(b => b.Places2)
            //    .WithMany(p => p.BookingsHistory)
            //    .HasForeignKey(b => b.FromPlace);


            //modelBuilder.Entity<BookingsHistory>()
            //    .HasOne<Places>(b => b.ToPlaces)
            //    .WithMany(p => p.BookingsHistory)
            //    .HasForeignKey(b => b.ToPlace);

            //modelBuilder.Entity<BookingsHistory>()
            //    .HasOne<Places>(b => b.FromPlaces)
            //    .WithMany(p => p.BookingsHistory)
            //    .HasForeignKey(b => b.FromPlaces);



            //modelBuilder.Entity<Bookings>()
            //    .HasOne<Places>(b => b.ToPlaces)
            //    .WithMany(p => p.Bookings)
            //    .HasForeignKey(b => b.ToPlace);


            //modelBuilder.Entity<Bookings>()
            //    .HasOne<Places>(b => b.FromPlaces)
            //    .WithMany(p => p.Bookings)
            //    .HasForeignKey(b => b.FromPlace);



        }


        private void ConfigureCabTypes(EntityTypeBuilder<CabTypes> builder)
        {
            builder.ToTable("CabTypes");
            builder.HasKey(c => c.CabTypeId);
            builder.Property(c => c.CabTypeName).HasMaxLength(30).HasColumnType("varchar");
            builder.HasIndex((u => u.CabTypeName)).IsUnique(); ;

        }

        private void ConfigurePlaces(EntityTypeBuilder<Places> builder)
        {
            builder.ToTable("Places");

            builder.HasKey(c => c.PlaceId);
            builder.Property(c => c.PlaceName).HasMaxLength(30).HasColumnType("varchar");
            builder.HasIndex((u => u.PlaceName)).IsUnique(); ;

        }


        private void ConfigureBookings(EntityTypeBuilder<Bookings> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Email).HasMaxLength(50).HasColumnType("varchar");

            builder.Property(c => c.BookingDate);

            builder.Property(c => c.BookingTime).HasMaxLength(5).HasColumnType("varchar");

            builder.Property(c => c.FromPlace);

            builder.Property(c => c.ToPlace);

            builder.Property(c => c.PickupAddress).HasMaxLength(200).HasColumnType("varchar");

            builder.Property(c => c.Landmark).HasMaxLength(30).HasColumnType("varchar");

            builder.Property(c => c.PickupDate);

            builder.Property(c => c.PickupTime).HasMaxLength(5).HasColumnType("varchar");

            builder.Property(c => c.CabTypeId);

            builder.Property(c => c.ContactNo).HasMaxLength(25).HasColumnType("varchar");

            builder.Property(c => c.Status).HasMaxLength(30).HasColumnType("varchar");

            builder.HasOne(I => I.CabType).WithMany(I => I.Bookings).HasForeignKey(I => I.CabTypeId);

            builder.HasOne(I => I.FromPlaces).WithMany(I => I.Bookings).HasForeignKey(I => I.FromPlace);

            //builder.HasOne(I => I.ToPlaces).WithMany(I => I.Bookings).HasForeignKey(I => I.ToPlace).OnDelete(DeleteBehavior.NoAction);

        }

        private void ConfigureBookingsHistory(EntityTypeBuilder<BookingsHistory> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Email).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(c => c.CabTypeId);
            builder.Property(c => c.BookingDate);
            builder.Property(c => c.BookingTime).HasMaxLength(5).HasColumnType("varchar");

            builder.Property(c => c.FromPlace);
            builder.Property(c => c.ToPlace);

            builder.Property(c => c.PickupAddress).HasMaxLength(200).HasColumnType("varchar");
            builder.Property(c => c.Landmark).HasMaxLength(30).HasColumnType("varchar");

            builder.Property(c => c.PickupDate);

            builder.Property(c => c.PickupTime).HasMaxLength(5).HasColumnType("varchar");

            builder.Property(c => c.ContactNo).HasMaxLength(25).HasColumnType("varchar");
            builder.Property(c => c.Status).HasMaxLength(30).HasColumnType("varchar");
            builder.Property(c => c.comp_time).HasMaxLength(5).HasColumnType("varchar");
            builder.Property(c => c.charge);

            builder.Property(c => c.Feedback).HasMaxLength(1000).HasColumnType("varchar");

            builder.HasOne(I => I.CabType).WithMany(I => I.BookingsHistory).HasForeignKey(I => I.CabTypeId);

            builder.HasOne(I => I.FromPlaces).WithMany(I => I.BookingsHistory).HasForeignKey(I => I.FromPlace);

        }

    }
}
