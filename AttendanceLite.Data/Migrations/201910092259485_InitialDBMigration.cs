namespace AttendanceLite.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Byte(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeLogs");
        }
    }
}
