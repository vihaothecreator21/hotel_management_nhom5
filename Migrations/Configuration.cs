namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration
    : DbMigrationsConfiguration<hotel_management_nhom5.Data.AppDbContext>
    {
        public Configuration()
        {
            // Cho phép tự động tạo migration
            AutomaticMigrationsEnabled = true;

            // Cho phép áp migration ngay cả khi có khả năng mất dữ liệu
            AutomaticMigrationDataLossAllowed = true;
        
        }

        protected override void Seed(hotel_management_nhom5.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
