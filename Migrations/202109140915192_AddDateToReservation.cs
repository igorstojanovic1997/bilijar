namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateToReservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "ReservationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "ReservationDate");
        }
    }
}
