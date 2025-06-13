namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        Check_in = c.DateTime(nullable: false),
                        Check_out = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Total_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Booking_Date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.CustomerId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Full_Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Identity_Card = c.String(),
                        Created_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        BookingId = c.Int(nullable: false),
                        Rating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comment = c.String(),
                        Created_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Bookings", t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.CustomerId)
                .Index(t => t.RoomId)
                .Index(t => t.BookingId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Room_number = c.String(),
                        Type = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Staff_name = c.String(),
                        Position = c.String(),
                        Phone_number = c.String(),
                        Email = c.String(),
                        Worked_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reviews", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Reviews", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Reviews", new[] { "BookingId" });
            DropIndex("dbo.Reviews", new[] { "RoomId" });
            DropIndex("dbo.Reviews", new[] { "CustomerId" });
            DropIndex("dbo.Bookings", new[] { "RoomId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropTable("dbo.Staffs");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reviews");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
