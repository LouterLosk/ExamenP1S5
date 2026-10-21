namespace Alcatraz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventoes", "estado", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eventoes", "estado");
        }
    }
}
