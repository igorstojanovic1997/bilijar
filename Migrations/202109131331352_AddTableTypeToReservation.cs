namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableTypeToReservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TableTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableFee = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Reservations", "TableTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Reservations", "TableType_Id", c => c.Int());
            CreateIndex("dbo.Reservations", "TableType_Id");
            AddForeignKey("dbo.Reservations", "TableType_Id", "dbo.TableTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "TableType_Id", "dbo.TableTypes");
            DropIndex("dbo.Reservations", new[] { "TableType_Id" });
            DropColumn("dbo.Reservations", "TableType_Id");
            DropColumn("dbo.Reservations", "TableTypeId");
            DropTable("dbo.TableTypes");
        }
    }
}
