using System.Collections.Generic;
using System.Data.Entity;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection") { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Staff> Staffs { get; set; }
<<<<<<< Updated upstream
=======
        public DbSet<RoomType> RoomTypes { get; set; }

>>>>>>> Stashed changes

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Cấu hình relationship cho Review-Customer
            modelBuilder.Entity<Review>()
                .HasRequired(r => r.Customer)
                .WithMany()
                .HasForeignKey(r => r.CustomerId)
                .WillCascadeOnDelete(false);

            // Cấu hình relationship cho Review-Room
            modelBuilder.Entity<Review>()
                .HasRequired(r => r.Room)
                .WithMany(rm => rm.Reviews)
                .HasForeignKey(r => r.RoomId)
                .WillCascadeOnDelete(false);

            // Cấu hình relationship cho Review-Booking
            modelBuilder.Entity<Review>()
                .HasRequired(r => r.Booking)
                .WithMany(b => b.Reviews)
                .HasForeignKey(r => r.BookingId)
                .WillCascadeOnDelete(false);

            // Cấu hình relationship cho Booking-Customer
            modelBuilder.Entity<Booking>()
                .HasRequired(b => b.Customer)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.CustomerId)
                .WillCascadeOnDelete(false);

            // Cấu hình relationship cho Booking-Room
            modelBuilder.Entity<Booking>()
                .HasRequired(b => b.Room)
                .WithMany()
                .HasForeignKey(b => b.RoomId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}