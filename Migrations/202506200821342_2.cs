namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Rooms", name: "Type", newName: "Room_number");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Rooms", name: "Room_number", newName: "Type");
        }
    }
}
