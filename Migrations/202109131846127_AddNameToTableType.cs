namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToTableType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TableTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TableTypes", "Name");
        }
    }
}
