namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToReservation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "Name", c => c.String());
        }
    }
}
