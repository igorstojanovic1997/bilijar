namespace bilijar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOdTableType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE TableTypes SET Name = 'Table for 2 persons' WHERE Id = 1");
            Sql("UPDATE TableTypes SET Name = 'Table for 3 persons' WHERE Id = 2");
            Sql("UPDATE TableTypes SET Name = 'Table for 4 persons' WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
