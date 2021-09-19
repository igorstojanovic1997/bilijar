namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTableType : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT TableTypes ON");

            Sql("INSERT INTO TableTypes(Id, TableFee) VALUES (1, 20)");
            Sql("INSERT INTO TableTypes(Id, TableFee) VALUES (2, 30)");
            Sql("INSERT INTO TableTypes(Id, TableFee) VALUES (3, 40)");

            Sql("SET IDENTITY_INSERT TableTypes OFF");

        }

        public override void Down()
        {
        }
    }
}
