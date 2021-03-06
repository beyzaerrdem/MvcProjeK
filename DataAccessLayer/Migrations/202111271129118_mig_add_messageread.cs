namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_messageread : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsReading", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsReading");
        }
    }
}
