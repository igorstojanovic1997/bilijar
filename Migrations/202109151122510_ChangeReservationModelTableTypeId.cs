namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeReservationModelTableTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reservations", "TableType_Id", "dbo.TableTypes");
            DropIndex("dbo.Reservations", new[] { "TableType_Id" });
            DropColumn("dbo.Reservations", "TableTypeId");
            RenameColumn(table: "dbo.Reservations", name: "TableType_Id", newName: "TableTypeId");
            AlterColumn("dbo.Reservations", "TableTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Reservations", "TableTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "TableTypeId");
            AddForeignKey("dbo.Reservations", "TableTypeId", "dbo.TableTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "TableTypeId", "dbo.TableTypes");
            DropIndex("dbo.Reservations", new[] { "TableTypeId" });
            AlterColumn("dbo.Reservations", "TableTypeId", c => c.Int());
            AlterColumn("dbo.Reservations", "TableTypeId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Reservations", name: "TableTypeId", newName: "TableType_Id");
            AddColumn("dbo.Reservations", "TableTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Reservations", "TableType_Id");
            AddForeignKey("dbo.Reservations", "TableType_Id", "dbo.TableTypes", "Id");
        }
    }
}
